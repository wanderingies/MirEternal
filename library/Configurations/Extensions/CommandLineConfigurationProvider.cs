﻿using System;
using System.Collections.Generic;

namespace Configurations.Extensions
{
    internal class CommandLineConfigurationProvider
    {
        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="args">The command line args.</param>
        /// <param name="switchMappings">The switch mappings.</param>
        public CommandLineConfigurationProvider(IEnumerable<string> args, IDictionary<string, string>? switchMappings = null)
        {
            Args = args ?? throw new ArgumentNullException(nameof(args));

            if (switchMappings != null)
            {
                _switchMappings = GetValidatedSwitchMappingsCopy(switchMappings);
            }
        }

        /// <summary>
        /// The command line arguments.
        /// </summary>
        protected IEnumerable<string> Args { get; private set; }

        private readonly Dictionary<string, string>? _switchMappings;

        /// <summary>
        /// Loads the configuration data from the command line args.
        /// </summary>
        public Dictionary<string, string> Load()
        {
            var data = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            string key, value;

            using (var enumerator = Args.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var currentArg = enumerator.Current;
                    var keyStartIndex = 0;

                    if (currentArg.StartsWith("--", StringComparison.OrdinalIgnoreCase))
                    {
                        keyStartIndex = 2;
                    }
                    else if (currentArg.StartsWith("-", StringComparison.OrdinalIgnoreCase))
                    {
                        keyStartIndex = 1;
                    }
                    else if (currentArg.StartsWith("/", StringComparison.OrdinalIgnoreCase))
                    {
                        // "/SomeSwitch" is equivalent to "--SomeSwitch" when interpreting switch mappings
                        // So we do a conversion to simplify later processing
                        currentArg = $"--{currentArg.Substring(1)}";
                        keyStartIndex = 2;
                    }

                    var separator = currentArg.IndexOf('=');

                    if (separator < 0)
                    {
                        // If there is neither equal sign nor prefix in current arugment, it is an invalid format
                        if (keyStartIndex == 0)
                        {
                            // Ignore invalid formats
                            continue;
                        }

                        // If the switch is a key in given switch mappings, interpret it
                        if (_switchMappings != null && _switchMappings.TryGetValue(currentArg, out var mappedKey))
                        {
                            key = mappedKey;
                        }
                        // If the switch starts with a single "-" and it isn't in given mappings , it is an invalid usage so ignore it
                        else if (keyStartIndex == 1)
                        {
                            continue;
                        }
                        // Otherwise, use the switch name directly as a key
                        else
                        {
                            key = currentArg.Substring(keyStartIndex);
                        }

                        var previousKey = enumerator.Current;
                        if (!enumerator.MoveNext())
                        {
                            // ignore missing values
                            continue;
                        }

                        value = enumerator.Current;
                    }
                    else
                    {
                        var keySegment = currentArg.Substring(0, separator);

                        // If the switch is a key in given switch mappings, interpret it
                        if (_switchMappings != null && _switchMappings.TryGetValue(keySegment, out var mappedKeySegment))
                        {
                            key = mappedKeySegment;
                        }
                        // If the switch starts with a single "-" and it isn't in given mappings , it is an invalid usage
                        else if (keyStartIndex == 1)
                        {
                            throw new FormatException($"Short Switch {currentArg} Not Defined");
                        }
                        // Otherwise, use the switch name directly as a key
                        else
                        {
                            key = currentArg.Substring(keyStartIndex, separator - keyStartIndex);
                        }

                        value = currentArg.Substring(separator + 1);
                    }

                    // Override value when key is duplicated. So we always have the last argument win.
                    data[key] = value;
                }
            }

            //Data = data;
            return data;
        }

        private Dictionary<string, string> GetValidatedSwitchMappingsCopy(IDictionary<string, string> switchMappings)
        {
            // The dictionary passed in might be constructed with a case-sensitive comparer
            // However, the keys in configuration providers are all case-insensitive
            // So we check whether the given switch mappings contain duplicated keys with case-insensitive comparer
            var switchMappingsCopy =
                new Dictionary<string, string>(switchMappings.Count, StringComparer.OrdinalIgnoreCase);
            foreach (var mapping in switchMappings)
            {
                // Only keys start with "--" or "-" are acceptable
                if (!mapping.Key.StartsWith("-", StringComparison.Ordinal) && !mapping.Key.StartsWith("--", StringComparison.Ordinal))
                {
                    throw new ArgumentException($"The map key should start with `-` or `--`, but the current key is {mapping.Key}",
                        nameof(switchMappings));
                }

                if (switchMappingsCopy.ContainsKey(mapping.Key))
                {
                    throw new ArgumentException(
                        $"Duplicated Key In SwitchMappings, the duplicated key is {mapping.Key}",
                        nameof(switchMappings));
                }

                switchMappingsCopy.Add(mapping.Key, mapping.Value);
            }

            return switchMappingsCopy;
        }
    }
}
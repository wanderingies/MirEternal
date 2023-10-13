using System;
using System.Runtime.CompilerServices;
using Configurations;
using Configurations.Converters;

namespace GateServer
{
    internal sealed class Configura : Configuration
    {
        public bool? IsTested
        {
            get => GetBoolean();
            set => SetValue(value);
        }

        public decimal? Amount
        {
            get => GetDecimal();
            set => SetValue(value);
        }

        public double? OffsetX
        {
            get => GetDouble();
            set => SetValue(value);
        }

        public float? SizeX
        {
            get => GetSingle();
            set => SetValue(value);
        }

        public int? Count
        {
            get => GetInt32();
            set => SetValue(value);
        }

        public int Count2
        {
            get => GetInt32() ?? 0;
            set => SetValue(value);
        }

        public long? Length
        {
            get => GetInt64();
            set => SetValue(value);
        }

        public long Length2
        {
            get => GetInt64() ?? 0L;
            set => SetValue(value);
        }

        public string Message
        {
            get => GetString();
            set => SetValue(value);
        }

        public string Host
        {
            get => GetString() ?? "https://localhost:17134";
            set => SetValue(value);
        }

        public MethodImplOptions MethodImpl
        {
            get => this.GetValue<MethodImplOptions>() ?? MethodImplOptions.AggressiveInlining;
            set => this.SetValue(value);
        }

        public MethodImplOptions? MethodImpl2
        {
            get => this.GetValue<MethodImplOptions>();
            set => this.SetValue(value);
        }

        public DateTime DateTime
        {
            get => this.GetValue<DateTime>() ?? default;
            set => this.SetValue(value);
        }

        public DateTimeOffset? DateTimeOffset
        {
            get => this.GetValue<DateTime>();
            set => this.SetValue(value);
        }
    }
}

﻿// Copyright 2009-2022 Josh Close
// This file is a part of CsvHelper and is dual licensed under MS-PL and Apache 2.0.
// See LICENSE.txt for details or visit http://www.opensource.org/licenses/ms-pl.html for MS-PL and http://opensource.org/licenses/Apache-2.0 for Apache 2.0.
// https://github.com/JoshClose/CsvHelper
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReader
{
	/// <summary>
	/// Function that is called when a reading exception occurs.
	/// The default function will re-throw the given exception. If you want to ignore
	/// reading exceptions, you can supply your own function to do other things like
	/// logging the issue.
	/// </summary>
	public delegate bool ReadingExceptionOccurred(ReadingExceptionOccurredArgs args);

	/// <summary>
	/// ReadingExceptionOccurred args.
	/// </summary>
	public readonly struct ReadingExceptionOccurredArgs
	{
		/// <summary>
		/// The exception.
		/// </summary>
		public readonly CsvHelperException Exception;

		/// <summary>
		/// Creates a new instance of ReadingExceptionOccurredArgs.
		/// </summary>
		/// <param name="exception">The exception.</param>
		public ReadingExceptionOccurredArgs(CsvHelperException exception)
		{
			Exception = exception;
		}
	}
}

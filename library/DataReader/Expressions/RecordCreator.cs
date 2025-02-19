﻿// Copyright 2009-2022 Josh Close
// This file is a part of CsvHelper and is dual licensed under MS-PL and Apache 2.0.
// See LICENSE.txt for details or visit http://www.opensource.org/licenses/ms-pl.html for MS-PL and http://opensource.org/licenses/Apache-2.0 for Apache 2.0.
// https://github.com/JoshClose/CsvHelper
using System;
using System.Collections.Generic;
using System.Reflection;

namespace DataReader.Expressions
{
	/// <summary>
	/// Base implementation for classes that create records.
	/// </summary>
	public abstract class RecordCreator
	{
		private readonly Dictionary<Type, Delegate> createRecordFuncs = new Dictionary<Type, Delegate>();

		/// <summary>
		/// The reader.
		/// </summary>
		protected CsvReader Reader { get; private set; }

		/// <summary>
		/// The expression manager.
		/// </summary>
		protected ExpressionManager ExpressionManager { get; private set; }

		/// <summary>
		/// Initializes a new instance using the given reader.
		/// </summary>
		/// <param name="reader">The reader.</param>
		public RecordCreator(CsvReader reader)
		{
			Reader = reader;
			ExpressionManager = new ExpressionManager(reader);
		}

		/// <summary>
		/// Create a record of the given type using the current row.
		/// </summary>
		/// <typeparam name="T">The record type.</typeparam>
		public T Create<T>()
		{
			try
			{
				return ((Func<T>)GetCreateRecordDelegate(typeof(T))).Invoke();
			}
			catch (TargetInvocationException ex)
			{
				if (ex.InnerException != null)
				{
					throw ex.InnerException;
				}
				else
				{
					throw;
				}
			}
		}

		/// <summary>
		/// Create a record of the given type using the current row.
		/// </summary>
		/// <param name="recordType">The record type.</param>
		public object? Create(Type recordType)
		{
			try
			{
				return GetCreateRecordDelegate(recordType).DynamicInvoke();
			}
			catch (TargetInvocationException ex)
			{
				if (ex.InnerException != null)
				{
					throw ex.InnerException;
				}
				else
				{
					throw;
				}
			}
		}

		/// <summary>
		/// Gets the delegate to create a record for the given record type. 
		/// If the delegate doesn't exist, one will be created and cached.
		/// </summary>
		/// <param name="recordType">The record type.</param>
		protected virtual Delegate GetCreateRecordDelegate(Type recordType)
		{
			if (!createRecordFuncs.TryGetValue(recordType, out Delegate func))
			{
				createRecordFuncs[recordType] = func = CreateCreateRecordDelegate(recordType);
			}

			return func;
		}

		/// <summary>
		/// Creates a <see cref="Delegate"/> of type <see cref="Func{T}"/>
		/// that will create a record of the given type using the current
		/// reader row.
		/// </summary>
		/// <param name="recordType">The record type.</param>
		protected abstract Delegate CreateCreateRecordDelegate(Type recordType);
	}
}

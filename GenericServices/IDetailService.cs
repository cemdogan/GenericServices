﻿using System;
using System.Linq.Expressions;
using GenericServices.Core;
using GenericServices.Services;

namespace GenericServices
{
    public interface IDetailService
    {
        /// <summary>
        /// This works out what sort of service is needed from the type provided
        /// and returns a single entry using the primary keys to find it.
        /// </summary>
        /// <typeparam name="T">The type of the data to output. 
        /// Type must be a type either an EF data class or one of the EfGenericDto's</typeparam>
        /// <param name="keys">The keys must be given in the same order as entity framework has them</param>
        /// <returns>Data class as read from database (not tracked)</returns>
        T GetDetail<T>(params object[] keys) where T : class, new();
    }

}
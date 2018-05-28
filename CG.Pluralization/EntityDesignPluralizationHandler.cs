//---------------------------------------------------------------------
// <copyright file="EntityDesignPluralizationHandler.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//
// @owner       Microsoft
// @backupOwner Microsoft
//---------------------------------------------------------------------
using System;

#if !NET40

namespace System.Data.Entity.Design.PluralizationServices
{
    internal class EntityDesignPluralizationHandler
    {
        /// <summary>
        /// user might set the service to null, so we have to check the null when using this property
        /// </summary>
        internal PluralizationService Service
        {
            get;
            set;
        }

        /// <summary>
        /// Handler for pluralization service in Entity Design
        /// </summary>
        /// <param name="doPluralization">overall switch for the service, the service only start working when the value is true</param>
        /// <param name="userDictionaryPath"></param>
        /// <param name="errors"></param>
        internal EntityDesignPluralizationHandler(PluralizationService service)
        {
            this.Service = service;
        }

        internal string GetEntityTypeName(string storeTableName)
        {
            return this.Service != null ? this.Service.Singularize(storeTableName) : storeTableName;
        }

        internal string GetEntitySetName(string storeTableName)
        {
            return this.Service != null ? this.Service.Pluralize(storeTableName) : storeTableName;
        }
    }
}

#endif

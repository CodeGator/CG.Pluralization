//---------------------------------------------------------------------
// <copyright file="ICustomPluralizationMapping.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//
// @owner       leil
// @backupOwner jeffreed
//---------------------------------------------------------------------
using System;

#if NET40

[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Data.Entity.Design.PluralizationServices.ICustomPluralizationMapping))]

#else

namespace System.Data.Entity.Design.PluralizationServices
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pluralization")]
    public interface ICustomPluralizationMapping
    {
        void AddWord(string singular, string plural);
    }
}

#endif

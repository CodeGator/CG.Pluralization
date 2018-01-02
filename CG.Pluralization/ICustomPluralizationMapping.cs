//---------------------------------------------------------------------
// <copyright file="ICustomPluralizationMapping.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//
// @owner       leil
// @backupOwner jeffreed
//---------------------------------------------------------------------
using System;

namespace CG.Pluralization
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Pluralization")]
    public interface ICustomPluralizationMapping
    {
        void AddWord(string singular, string plural);
    }
}
//---------------------------------------------------------------------
// <copyright file="PolyfillUtilities.cs" company="Andrew Arnott">
//      Copyright (c) Andrew Arnott.  All rights reserved.
// </copyright>
//
// @owner       Andrew Arnott
//---------------------------------------------------------------------

using System;
using System.Globalization;

namespace System.Data.Entity.Design.PluralizationServices
{
    internal static class PolyfillUtilities
    {
#if NETSTANDARD1_0
        internal static string ToLower(this string value, CultureInfo cultureInfo)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (cultureInfo == null)
            {
                throw new ArgumentNullException(nameof(cultureInfo));
            }

            return cultureInfo.TextInfo.ToLower(value);
        }

        internal static bool EndsWith(this string value, string suffix, bool ignoreCase, CultureInfo culture)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            culture = culture ?? CultureInfo.CurrentCulture;

            return culture.CompareInfo.IsSuffix(value, suffix, ignoreCase ? CompareOptions.IgnoreCase : CompareOptions.None);
        }
#endif
    }
}

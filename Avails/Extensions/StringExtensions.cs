using System;
using System.Collections.Generic;

namespace CP.Shared.Primitives.Avails.Extensions
{
    public static class StringExtensions
    {
        public static bool IsEmptyNullOrWhiteSpace (this string value)
        {
            return string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace (value);
        }

        public static bool HasValue (this string? value)
        {
            return value is { } 
                && value.IsEmptyNullOrWhiteSpace().Not();
        }

        public static bool HasNoValue(this string value)
        {
            return value.HasValue().Not();
        }

        public static bool DoesNotContain (this List<string> value
                                         , string            substring)
        {
            return value.Contains (substring).Not();
        }

        public static bool IsNotEqualTo (this string      source
                                       , string           other
                                       , StringComparison comparisonType)
        {
            return string.Equals(source
                               , other
                               , comparisonType).Not();
        }
        
        /// <summary>
        /// Uses the current culture to compare the two strings, ignoring case (opposite of <see cref="IsEqualTo(string,string)"/>).
        /// </summary>
        /// <param name="source"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static bool IsNotEqualTo (this string      source
                                       , string           other)
        {
            return string.Equals(source
                               , other).Not();
        }
        public static bool IsEqualTo (this string      source
                                    , string           other
                                    , StringComparison comparisonType)
        {
            return string.Equals(source
                               , other
                               , comparisonType);
        }
        
        /// <summary>
        /// Uses the current culture to compare the two strings, ignoring case.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static bool IsEqualTo (this string      source
                                    , string           other)
        {
            return string.Equals(source
                               , other
                               , StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool IsInt (this string value)
        {
            return int.TryParse(value, out _);
        }

        public static bool IsNotInt (this string value)
        {
            return IsInt (value).Not();
        }

        public static Guid ToGuid (this string value)
        {
            return Guid.ParseExact(value, "N");
        }
    }
}

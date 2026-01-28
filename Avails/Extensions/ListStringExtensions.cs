using System;
using System.Collections.Generic;
using System.Linq;

namespace CP.Shared.Primitives.Avails.Extensions
{
    public static class ListStringExtensions
    {
        public static bool ContainsCaseInsensitive (this List<string> value
                                                  , string            searchTerm)
        {
            return value.Contains(searchTerm
                                , StringComparer.OrdinalIgnoreCase);
        }

        public static bool DoesNotContainCaseInsensitive (this List<string> value
                                                        , string            searchTerm)
        {
            return value.ContainsCaseInsensitive(searchTerm).Not();
        }

        public static bool HasEntries (this List<string> value)
        {
            return value.Count > 0;
        }
    }
}
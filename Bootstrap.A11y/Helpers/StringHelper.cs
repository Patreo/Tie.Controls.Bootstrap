// StringHelper.cs

// Copyright (C) 2018 Kinsey Roberts (@kinzdesign), Weatherhead School of Management (@wsomweb)

// This program is free software; you can redistribute it and/or modify it under the terms of the GNU 
// General Public License as published by the Free Software Foundation; either version 2 of the 
// License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See 
// the GNU General Public License for more details. You should have received a copy of the GNU 
// General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 
// Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Bootstrap.A11y.Helpers
{
    /// <summary>
    /// Helper functions for dealing with strings.
    /// </summary>
    public static class StringHelper
    {
        #region ToLower

        /// <summary>
        /// Returns the lower-case, English equivalent of <paramref name="val"/>.
        /// </summary>
        /// <param name="val">The value to convert.</param>
        /// <returns>"true" or "false" as appropriate.</returns>
        public static string ToLower(bool val)
        {
            return val ? "true" : "false";
        }

        /// <summary>
        /// Returns the lower-case text equivalent of <paramref name="val"/>.
        /// </summary>
        /// <param name="val">The enumeration to convert.</param>
        /// <returns>The lower-case text equivalent of <paramref name="val"/>.</returns>
        public static string ToLower(Enum val)
        {
            return val.ToString().ToLower(CultureInfo.InvariantCulture);
        }

        #endregion

        #region AppendWithSpaceIfNotEmpty

        /// <summary>
        /// Appends <paramref name="toAdd"/> (with a separating space) to <paramref name="contents"/>, if <paramref name="toAdd"/> is not empty.
        /// </summary>
        /// <param name="contents">The base text to be returned no matter what.</param>
        /// <param name="toAdd">The additional string to append if not empty.</param>
        /// <returns>If <paramref name="toAdd"/> has contents, a space and <paramref name="toAdd"/> are appended to <paramref name="contents"/>.
        /// Otherwise (<paramref name="toAdd"/> is null or empty), <paramref name="contents"/> is returned unchanged.</returns>
        public static string AppendWithSpaceIfNotEmpty(string contents, string toAdd)
        {
            if (String.IsNullOrEmpty(toAdd))
            {
                return contents;
            }
            return String.Concat(contents, " ", toAdd);
        }

        /// <summary>
        /// Appends <paramref name="toAdd"/> (with a separating space) to <paramref name="stringBuilder"/>, if <paramref name="toAdd"/> is not empty.
        /// </summary>
        /// <param name="stringBuilder">The buffer to append to.</param>
        /// <param name="toAdd">The string to append if not empty.</param>
        /// <returns>Whether <paramref name="toAdd"/> had contents.</returns>
        public static bool AppendWithSpaceIfNotEmpty(StringBuilder stringBuilder, string toAdd)
        {
            if (String.IsNullOrEmpty(toAdd))
            {
                return false;
            }
            stringBuilder.Append(" ");
            stringBuilder.Append(toAdd);
            return true;
        }

        #endregion

        #region AppendIf

        /// <summary>
        /// Appends <paramref name="toAdd"/> to <paramref name="contents"/>, if <paramref name="condition"/> is true.
        /// </summary>
        /// <param name="contents">The base text to be returned no matter what.</param>
        /// <param name="condition">The condition to check.</param>
        /// <param name="toAdd">The additional string to append if not empty.</param>
        /// <returns>If <paramref name="condition"/> is true, <paramref name="toAdd"/> is appended to <paramref name="contents"/>.
        /// Otherwise (<paramref name="condition"/> is false), <paramref name="contents"/> is returned unchanged.</returns>
        public static string AppendIf(string contents, bool condition, string toAdd)
        {
            if (condition)
            {
                return contents + toAdd;
            }
            return contents;
        }

        /// <summary>
        /// Appends <paramref name="toAdd"/> to <paramref name="stringBuilder"/>, if <paramref name="condition"/> is true.
        /// </summary>
        /// <param name="stringBuilder">The buffer to append to.</param>
        /// <param name="condition">The condition to check.</param>
        /// <param name="toAdd">The string to append if not empty.</param>
        /// <returns>Whether <paramref name="toAdd"/> was appended.</returns>
        public static bool AppendIf(StringBuilder stringBuilder, bool condition, string toAdd)
        {
            if (condition)
            {
                stringBuilder.Append(toAdd);
            }
            return condition;
        }

        #endregion

        #region EnsureClassPresent

        /// <summary>
        /// Ensures that <paramref name="classes"/> contains <paramref name="toAdd"/>.
        /// </summary>
        /// <param name="classes">The existing list of CSS classes.</param>
        /// <param name="toAdd">The CSS class to add.</param>
        /// <returns>
        /// If <paramref name="classes"/> contains <paramref name="toAdd"/>, <paramref name="classes"/> is returned as-is. 
        /// Otherwise, <paramref name="classes"/> and <paramref name="toAdd"/> are concatenated with a space in between and returned.
        /// </returns>
        public static string EnsureClassPresent(string classes, string toAdd)
        {
            // if no existing classes, return toAdd
            if(IsNullEmptyOrWhitespace(classes))
            {
                return toAdd;
            }
            // if nothing to add, return current
            if (IsNullEmptyOrWhitespace(toAdd))
            {
                return classes;
            }
            // one at a time, please!
            string trimmed = toAdd.Trim();
            if(trimmed.Contains(" "))
            {
                throw new ArgumentException("Only one class can be added at once (toAdd should not contain spaces).", "toAdd");
            }
            // check whether classes contains toAdd, if so, return classes
            string regex = String.Format(@"(^|\s){0}(\s|$)", trimmed);
            if(Regex.IsMatch(classes, regex, RegexOptions.CultureInvariant | RegexOptions.IgnoreCase))
            {
                return classes;
            }
            // concatenate and return
            return String.Concat(classes.Trim(), ' ', toAdd);
        }

        #endregion

        #region IsWhitespace, IsNullEmptyOrWhitespace

        private static Regex WhitespaceRegex = new Regex(@"^\s+$", RegexOptions.Compiled);

        /// <summary>
        /// Returns a boolean representing whether <paramref name="s"/> contains only whitespace.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True if the string is non-null, has contents, and contains only whitespace.</returns>
        public static bool IsWhitespace(string s)
        {
            return WhitespaceRegex.IsMatch(s);
        }

        /// <summary>
        /// Returns a boolean representing whether <paramref name="s"/> is null, empty, or contains only whitespace.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True if the string is null, empty, or contains only whitespace.</returns>
        public static bool IsNullEmptyOrWhitespace(string s)
        {
            if(String.IsNullOrEmpty(s))
            {
                return true;
            }
            return IsWhitespace(s);
        }

        #endregion

        #region IsPositiveInteger

        /// <summary>
        /// Matches positive integer strings (@"^[0-9]+$").
        /// </summary>
        private static readonly Regex PositiveIntegerRegex = new Regex(@"^[0-9]+$", RegexOptions.Compiled);

        /// <summary>
        /// Checks whether a string represents a positive integer.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>Whether the string represents a positive integer.</returns>
        public static bool IsPositiveInteger(string s)
        {
            return PositiveIntegerRegex.IsMatch(s);
        }

        #endregion
    }
}

// InputSizes.cs

// Copyright (C) 2013 Pedro Fernandes
// Accessibility and other updates (C) 2018 Kinsey Roberts (@kinzdesign), Weatherhead School of Management (@wsomweb)

// This program is free software; you can redistribute it and/or modify it under the terms of the GNU 
// General Public License as published by the Free Software Foundation; either version 2 of the 
// License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See 
// the GNU General Public License for more details. You should have received a copy of the GNU 
// General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 
// Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System;
using System.Web.UI.WebControls;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// The three sizes a control may have.
    /// </summary>
    public enum InputSizes : byte
    {
        /// <summary>The default size.</summary>
        Default = 0,
        /// <summary>A larger size.</summary>
        Large = 1,
        /// <summary>A smaller size.</summary>
        Small = 2
    }

    /// <summary>
    /// Helper methods for dealing with <see cref="InputSizes"/>.
    /// </summary>
    public static class InputSizesHelper
    {
        /// <summary>
        /// Adds the size suffix ("lg" or "sm") associated with <paramref name="inputSize"/> to <paramref name="prefix"/>.
        /// If <paramref name="inputSize"/> is <see cref="InputSizes.Default"/>, an empty string is returned.
        /// </summary>
        /// <param name="inputSize">The <see cref="InputSizes"/>.</param>
        /// <param name="prefix">A prefix to come before the suffix.</param>
        /// <returns>Concatenation of <paramref name="prefix"/> and the appropriate suffix if <paramref name="inputSize"/> is not <see cref="InputSizes.Default"/>. Otherwise, an empty string.</returns>
        public static string AddSizeSuffix(InputSizes inputSize, string prefix)
        {
            if (inputSize == InputSizes.Large)
            {
                return prefix + "lg";
            }
            else if (inputSize == InputSizes.Small)
            {
                return prefix + "sm";
            }
            else
            {
                return String.Empty;
            }
        }

        /// <summary>
        /// Adds a class containing <paramref name="prefix"/> and the size suffix ("lg" or "sm") associated with <paramref name="inputSize"/>.
        /// If <paramref name="inputSize"/> is <see cref="InputSizes.Default"/>, no class is added.
        /// </summary>
        /// <param name="control">The <see cref="WebControl"/> to add the CssClass to.</param>
        /// <param name="inputSize">The <see cref="InputSizes"/>.</param>
        /// <param name="prefix">A prefix to come before the suffix.</param>
        public static void EnsureSizeClassPresent(WebControl control, InputSizes inputSize, string prefix)
        {
            if (inputSize != InputSizes.Default)
            {
                ControlHelper.EnsureCssClassPresent(control, AddSizeSuffix(inputSize, prefix));
            }
        }
    }
}

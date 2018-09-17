// ButtonSizes.cs

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

namespace Bootstrap.A11y
{
    /// <summary>
    /// The four sizes a button may have.
    /// </summary>
    public enum ButtonSizes : byte
    {
        /// <summary>The default size.</summary>
        Default = 0,
        /// <summary>A larger size.</summary>
        Large = 1,
        /// <summary>A smaller size.</summary>
        Small = 2,
        /// <summary>An extra-small size.</summary>
        Mini = 3
    }

    /// <summary>
    /// Helper methods for dealing with <see cref="ButtonSizes"/>.
    /// </summary>
    public static class ButtonSizesHelper
    {
        /// <summary>
        /// Gets the class name associated with <paramref name="size"/>.
        /// </summary>
        /// <param name="size">The <see cref="InputSizes"/>.</param>
        /// <returns>The associated CSS class name.</returns>
        public static string GetClassName(ButtonSizes size)
        {
            switch (size)
            {
                case ButtonSizes.Large:
                    return " btn-lg";
                case ButtonSizes.Small:
                    return " btn-sm";
                case ButtonSizes.Mini:
                    return " btn-xs";
                case ButtonSizes.Default:
                default:
                    return String.Empty;
            }
        }
    }
}

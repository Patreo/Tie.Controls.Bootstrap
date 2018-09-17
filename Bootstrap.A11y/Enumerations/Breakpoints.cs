// Breakpoints.cs

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

namespace Bootstrap.A11y
{
    /// <summary>
    /// Bootstrap media breakpoints.
    /// </summary>
    public enum Breakpoints : byte
    {
        /// <summary>Extra small (phones)</summary>
        ExtraSmall = 1,
        /// <summary>Small (tablets)</summary>
        Small = 2,
        /// <summary>Medium (desktops)</summary>
        Medium = 3,
        /// <summary>Large (larger desktops)</summary>
        Large = 4
    }

    /// <summary>
    /// Helper methods for dealing with <see cref="Breakpoints"/>.
    /// </summary>
    public static class BreakpointsHelper
    {
        /// <summary>
        /// Get the breakpoint abbreviation as used in class names.
        /// </summary>
        /// <param name="breakpoint">The <see cref="Breakpoints"/>.</param>
        /// <returns>The abbreviation associated with <paramref name="breakpoint"/>.</returns>
        public static string GetAbbreviation(Breakpoints breakpoint)
        {
            switch (breakpoint)
            {
                case Breakpoints.ExtraSmall:
                    return "xs";
                case Breakpoints.Small:
                    return "sm";
                case Breakpoints.Medium:
                    return "md";
                case Breakpoints.Large:
                    return "lg";
                default:
                    return String.Empty;
            }
        }
    }
}

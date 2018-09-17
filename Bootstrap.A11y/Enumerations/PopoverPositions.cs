// PopoverPositions.cs

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
using System.Text;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Valid positions for a <see cref="Popover"/>.
    /// </summary>
    [Flags]
    public enum PopoverPositions : byte
    {
        /// <summary>No position specified.</summary>
        None    = 0,
        /// <summary>Dynamically reorient the popover.</summary>
        Auto    = 1,
        /// <summary>Position popover above.</summary>
        Top     = 2,
        /// <summary>Position popover to the right.</summary>
        Right   = 4,
        /// <summary>Position popover below.</summary>
        Bottom  = 8,
        /// <summary>Position popover to the right.</summary>
        Left    = 16
    }

    /// <summary>
    /// Helper methods for dealing with <see cref="PopoverPositions"/>.
    /// </summary>
    public static class PopoverPositionsHelper
    {
        /// <summary>
        /// Gets a lower-case, space-delimited string of the flags set in <paramref name="positions"/>.
        /// </summary>
        /// <param name="positions">One or more positions.</param>
        /// <returns>A lower-case, space-delimited string of the flags set in <paramref name="positions"/>.</returns>
        public static string ToString(PopoverPositions positions)
        {
            if (positions == PopoverPositions.None)
            {
                return String.Empty;
            }
            // at this point we have at least 1, but might have more
            StringBuilder builder = new StringBuilder();
            if ((positions & PopoverPositions.Auto) > 0)
            {
                builder.Append("auto ");
            }
            if ((positions & PopoverPositions.Top) > 0)
            {
                builder.Append("top ");
            }
            if ((positions & PopoverPositions.Right) > 0)
            {
                builder.Append("right ");
            }
            if ((positions & PopoverPositions.Bottom) > 0)
            {
                builder.Append("bottom ");
            }
            if ((positions & PopoverPositions.Left) > 0)
            {
                builder.Append("left ");
            }
            return builder.ToString().Trim();
        }
    }
}

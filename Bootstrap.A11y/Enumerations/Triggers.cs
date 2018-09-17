// Triggers.cs

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
    /// Defines which actions cause an event to occur.
    /// </summary>
    [Flags]
    public enum Triggers : byte
    {
        /// <summary>No trigger defined.</summary>
        None = 0,
        /// <summary>Action occurs when the element is clicked.</summary>
        Click = 1,
        /// <summary>Action occurs when the element is hovered.</summary>
        Hover = 2,
        /// <summary>Action occurs when the element gains focus.</summary>
        Focus = 4,
        /// <summary>Action must be triggered from JavaScript. Cannot be combined with any other trigger.</summary>
        Manual = 8
    }

    /// <summary>
    /// Helper methods for dealing with <see cref="Triggers"/>.
    /// </summary>
    public static class TriggersHelper
    {
        /// <summary>
        /// Gets a lower-case, space-delimited string of the flags set in <paramref name="triggers"/>.
        /// </summary>
        /// <param name="triggers">One or more triggers.</param>
        /// <returns>A lower-case, space-delimited string of the flags set in <paramref name="triggers"/>.</returns>
        public static string ToString(Triggers triggers)
        {
            if (triggers == Triggers.None)
            {
                return String.Empty;
            }
            // if manual is specified, it must be on its own
            if ((triggers & Triggers.Manual) > 0)
            {
                if (triggers != Triggers.Manual)
                {
                    throw new InvalidOperationException("Trigger 'manual' cannot be combined with any other triggers.");
                }
                return "manual";
            }
            // at this point we have at least 1, but might have more
            StringBuilder builder = new StringBuilder();
            if ((triggers & Triggers.Click) > 0)
            {
                builder.Append("click ");
            }
            if ((triggers & Triggers.Hover) > 0)
            {
                builder.Append("hover ");
            }
            if ((triggers & Triggers.Focus) > 0)
            {
                builder.Append("focus ");
            }
            return builder.ToString().Trim();
        }
    }
}

// AspectRatios.cs

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
    /// Valid aspect ratios for a <see cref="ResponsiveEmbed"/>.
    /// </summary>
    public enum AspectRatios : byte
    {
        /// <summary>16:9</summary>
        SixteenByNine = 1,
        /// <summary>4:3</summary>
        FourByThree = 2
    }

    /// <summary>
    /// Helper methods for dealing with <see cref="AspectRatios"/>.
    /// </summary>
    public static class AspectRatiosHelper
    {
        /// <summary>
        /// Gets the string representation of <paramref name="aspectRatio"/>.
        /// </summary>
        /// <param name="aspectRatio">The <see cref="AspectRatios"/>.</param>
        /// <returns>The string representation of <paramref name="aspectRatio"/>.</returns>
        public static string ToString(AspectRatios aspectRatio)
        {
            if (aspectRatio == AspectRatios.SixteenByNine)
            {
                return "16by9";
            }
            else if (aspectRatio == AspectRatios.FourByThree)
            {
                return "4by3";
            }
            else
            {
                throw new InvalidOperationException("Invalid AspectRatios");
            }
        }
    }
}

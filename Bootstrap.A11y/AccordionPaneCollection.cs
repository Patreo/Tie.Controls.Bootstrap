// AccordionPaneCollection.cs

// Copyright (C) 2013 Francois Viljoen
// Accessibility and other updates (C) 2018 Kinsey Roberts (@kinzdesign), Weatherhead School of Management (@wsomweb)

// This program is free software; you can redistribute it and/or modify it under the terms of the GNU 
// General Public License as published by the Free Software Foundation; either version 2 of the 
// License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See 
// the GNU General Public License for more details. You should have received a copy of the GNU 
// General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 
// Temple Place, Suite 330, Boston, MA 02111-1307 USA


using System.Web.UI;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a collection of Bootstrap <see cref="AccordionPane"/>s.
    /// </summary>
    public class AccordionPaneCollection : CollectionBase<AccordionPane>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccordionPaneCollection" /> class.
        /// </summary>
        /// <param name="parent">The parent control.</param>
        public AccordionPaneCollection(Control parent) : base(parent)
        {
        }
    }
}
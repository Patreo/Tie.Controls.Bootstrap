// TabCollection.cs

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

using System.Collections;
using System.Web.UI;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a collection of Bootstrap <see cref="TabPage"/>s.
    /// </summary>
    public class TabCollection : CollectionBase
    {
        /// <summary>
        /// The parent control.
        /// </summary>
        protected Control Parent;

        /// <summary>
        /// Initializes a new instance of the <see cref="TabCollection" /> class.
        /// </summary>
        /// <param name="parent">The parent control.</param>
        public TabCollection(Control parent)
        {
            Parent = parent;
        }

        /// <summary>
        /// Indexer property for the collection that returns and sets an item
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public TabPage this[int index]
        {
            get { return (TabPage)List[index]; }
            set { List[index] = value; }
        }

        /// <summary>
        /// Adds the specified tab.
        /// </summary>
        /// <param name="Tab">The tab.</param>
        public void Add(TabPage Tab)
        {
            List.Add(Tab);
            Parent.Controls.Add(Tab);
        }

        /// <summary>
        /// Inserts the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="item">The item.</param>
        public void Insert(int index, TabPage item)
        {
            List.Insert(index, item);
        }

        /// <summary>
        /// Removes the specified tab.
        /// </summary>
        /// <param name="Tab">The tab.</param>
        public void Remove(TabPage Tab)
        {
            List.Remove(Tab);
        }

        /// <summary>
        /// Determines whether the collection contains the specified tab.
        /// </summary>
        /// <param name="tab">The tab.</param>
        /// <returns>
        ///   <c>true</c> if contains the specified tab; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(TabPage tab)
        {
            return List.Contains(tab);
        }

        /// <summary>
        /// Gets the index of a given tab. Returns -1 if the item isn't in the list.
        /// </summary>
        /// <param name="tab">The tab.</param>
        /// <returns>The index of the tab in the list, or -1 if the item isn't in the list.</returns>
        public int IndexOf(TabPage tab)
        {
            return List.IndexOf(tab);
        }

        /// <summary>
        /// Copies to.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="index">The index.</param>
        public void CopyTo(TabPage[] array, int index)
        {
            List.CopyTo(array, index);
        }
    }
}

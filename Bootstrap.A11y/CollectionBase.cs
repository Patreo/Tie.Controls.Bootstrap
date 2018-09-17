// CollectionBase.cs

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
using System.Collections;
using System.Web.UI;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a strongly-typed collection of <typeparamref name="T"/>s.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="Control"/>s in the collection.</typeparam>
    public class CollectionBase<T> : CollectionBase where T : Control
    {
        /// <summary>
        /// The parent control.
        /// </summary>
        protected Control Parent;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionBase{T}" /> class.
        /// </summary>
        /// <param name="parent">The parent control.</param>
        public CollectionBase(Control parent)
        {
            this.Parent = parent;
        }

        /// <summary>
        /// Gets or sets the element at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the element to get or set.</param>
        /// <returns>The element at the specified index.</returns>
        public T this[int index]
        {
            get { return (T)List[index]; }
            set { List[index] = value; }
        }

        /// <summary>
        /// Adds an object to the end of the list.
        /// </summary>
        /// <param name="item">The object to be added to the end of the list.</param>
        public void Add(T item)
        {
            List.Add(item);
            this.Parent.Controls.Add(item);
        }

        /// <summary>
        /// Inserts an element into the list at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which item should be inserted.</param>
        /// <param name="item">The object to insert.</param>
        public void Insert(int index, T item)
        {
            List.Insert(index, item);
        }

        /// <summary>
        /// Removes the first occurrence of a specific object from the list.
        /// </summary>
        /// <param name="item">The object to remove from the list.</param>
        public void Remove(T item)
        {
            List.Remove(item);
        }

        /// <summary>
        /// Determines whether an element is in the list.
        /// </summary>
        /// <param name="item">The object to locate in the list.</param>
        /// <returns>
        /// <c>true</c> if <paramref name="item"/> is found in the list; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains(T item)
        {
            return List.Contains(item);
        }

        /// <summary>
        /// Searches for the specified object and returns the zero-based index of the first occurrence within the entire list.
        /// </summary>
        /// <param name="item">The object to locate in the list.</param>
        /// <returns>The zero-based index of the first occurrence of <paramref name="item"/> within the entire list, if found; otherwise, –1.</returns>
        public int IndexOf(T item)
        {
            return List.IndexOf(item);
        }

        /// <summary>
        /// Copies the entire list to a compatible one-dimensional array, starting at the specified index of the target array.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> that is the destination of the elements copied from list. The <see cref="Array"/> must have zero-based indexing.</param>
        /// <param name="index">The zero-based index in <paramref name="array"/> at which copying begins.</param>
        public void CopyTo(T[] array, int index)
        {
            List.CopyTo(array, index);
        }
    }
}
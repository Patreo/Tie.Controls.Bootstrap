// GridViewAdapter.cs

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
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Adapters;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y.Adapters
{
    /// <summary>
    /// Adapter to apply Bootstrap classes to a base ASP.NET <see cref="System.Web.UI.WebControls.GridView"/>.
    /// </summary>
    public class GridViewAdapter : WebControlAdapter
    {
        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.PreRender" /> event. This notifies the control to perform any steps necessary for its creation on a page request.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnPreRender(EventArgs e)
        {
            GridView gridView = this.Control as GridView;
            if (gridView != null)
            {
                gridView.GridLines = GridLines.None;
                gridView.UseAccessibleHeader = true;
                gridView.HeaderRow.TableSection = TableRowSection.TableHeader;
                gridView.FooterRow.TableSection = TableRowSection.TableFooter;
                gridView.TopPagerRow.TableSection = TableRowSection.TableHeader;
                gridView.BottomPagerRow.TableSection = TableRowSection.TableFooter;
            }

            base.OnPreRender(e);
        }

        /// <summary>
        /// Renders the HTML end tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderBeginTag(HtmlTextWriter writer)
        {
            base.RenderBeginTag(writer);
            string tableClass = StringHelper.AppendWithSpaceIfNotEmpty("table", this.Control.CssClass);
            writer.AddAttribute(HtmlTextWriterAttribute.Class, tableClass);
        }
    }
}
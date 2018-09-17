// ButtonAdapter.cs

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
using System.Web.UI.WebControls.Adapters;

namespace Bootstrap.A11y.Adapters
{
    /// <summary>
    /// Adapter to apply Bootstrap classes to a base ASP.NET <see cref="System.Web.UI.WebControls.Button"/>.
    /// </summary>
    public class ButtonAdapter : WebControlAdapter
    {
        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Class, "btn btn-default" + (!String.IsNullOrEmpty(this.Control.CssClass) ? " " + this.Control.CssClass : ""));
            base.Render(writer);
        }
    }
}

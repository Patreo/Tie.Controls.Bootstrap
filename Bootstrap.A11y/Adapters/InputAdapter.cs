// InputAdapter.cs

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
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Adapters;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y.Adapters
{
    /// <summary>
    /// Adapter to apply Bootstrap classes to a base ASP.NET input (e.g. <see cref="System.Web.UI.WebControls.TextBox"/>, 
    /// <see cref="System.Web.UI.WebControls.DropDownList"/>, or <see cref="System.Web.UI.WebControls.ListBox"/>).
    /// </summary>
    public class InputAdapter : WebControlAdapter
    {
        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.PreRender" /> event. This notifies the control to perform any steps necessary for its creation on a page request.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnPreRender(EventArgs e)
        {
            ControlHelper.EnsureCssClassPresent(this.Control, "form-control");
            base.OnPreRender(e);
        }

        /// <summary>
        /// Generates the target-specific inner markup for the Web control to which the control adapter is attached.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> containing methods to render the target-specific output.</param>
        protected override void RenderContents(System.Web.UI.HtmlTextWriter writer)
        {
            TextBox txt = this.Control as TextBox;
            if (txt != null && txt.TextMode == TextBoxMode.MultiLine)
            {
                writer.Write(txt.Text);
            }

            base.RenderContents(writer);            
        }
    }
}

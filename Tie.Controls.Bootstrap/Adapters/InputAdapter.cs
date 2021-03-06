﻿// InputAdapter.cs

// Copyright (C) 2013 Pedro Fernandes

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

namespace Tie.Controls.Bootstrap.Adapters
{
    public class InputAdapter : WebControlAdapter
    {
        /// <summary>
        /// Generates the target-specific markup for the control to which the control adapter is attached.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> containing methods to render the target-specific output.</param>
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            writer.AddAttribute(System.Web.UI.HtmlTextWriterAttribute.Class, "form-control" + (!String.IsNullOrEmpty(this.Control.CssClass) ? " " + this.Control.CssClass : ""));
            base.Render(writer);
        }

        /// <summary>
        /// Generates the target-specific inner markup for the Web control to which the control adapter is attached.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> containing methods to render the target-specific output.</param>
        protected override void RenderContents(System.Web.UI.HtmlTextWriter writer)
        {
            if (this.Control is TextBox)
            {
                TextBox txt = ((TextBox)this.Control);

                if (txt.TextMode == TextBoxMode.MultiLine)
                {
                    writer.Write(txt.Text);
                }
            }

            base.RenderContents(writer);            
        }
    }
}

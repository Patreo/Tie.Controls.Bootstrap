// Heading.cs

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
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Bootstrap heading.
    /// </summary>
    [ToolboxData("<{0}:Heading runat=server />")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Label))]
    [DefaultProperty("Text")]
    [ControlValueProperty("Text")]
    [ParseChildren(false)]
    public class Heading : TextWebControl
    {
        /// <summary>
        /// Gets or sets the H.
        /// </summary>
        /// <value>
        /// The H.
        /// </value>
        [Category("Appearance")]
        [DefaultValue("")]
        public int H
        {
            get { return (int)this.ViewState["H"]; }
            set
            {
                if (value < 1 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("H", "Invalid header value, H must be 1-6");
                }
                this.ViewState["H"] = value;
            }
        }

        /// <summary>
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            switch (H)
            {
                case 1:
                    writer.RenderBeginTag(HtmlTextWriterTag.H1);
                    break;

                case 2:
                    writer.RenderBeginTag(HtmlTextWriterTag.H2);
                    break;

                case 3:
                    writer.RenderBeginTag(HtmlTextWriterTag.H3);
                    break;

                case 4:
                    writer.RenderBeginTag(HtmlTextWriterTag.H4);
                    break;

                case 5:
                    writer.RenderBeginTag(HtmlTextWriterTag.H5);
                    break;

                case 6:
                    writer.RenderBeginTag(HtmlTextWriterTag.H6);
                    break;

                default:
                    throw new ArgumentOutOfRangeException("H", "Invalid header value, H must be 1-6");
            }
        }
    }
}
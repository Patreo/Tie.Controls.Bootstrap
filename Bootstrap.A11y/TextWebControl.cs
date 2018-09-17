// TextWebControl.cs

// Copyright (C) 2018 Kinsey Roberts (@kinzdesign), Weatherhead School of Management (@wsomweb)

// This program is free software; you can redistribute it and/or modify it under the terms of the GNU 
// General Public License as published by the Free Software Foundation; either version 2 of the 
// License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See 
// the GNU General Public License for more details. You should have received a copy of the GNU 
// General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 
// Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Base class for controls with a simple Text field.
    /// </summary>
    [ParseChildren(true, "Text")]
    [PersistChildren(false)]
    public class TextWebControl : WebControl
    {
        /// <summary>
        /// The contents of the control.
        /// </summary>
        public string Text
        {
            get { return (string)this.ViewState["Text"]; }
            set { this.ViewState["Text"] = value; }
        }

        /// <summary>
        /// Renders the HTML contents of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.Write(this.Text);
            base.RenderContents(writer);
        }

        /// <summary>
        /// Gets the <see cref="HtmlTextWriterTag"/> value that corresponds to this Web server control.
        /// </summary>
        /// <value>
        /// One of the <see cref="HtmlTextWriterTag"/> enumeration values.
        /// </value>
        protected override HtmlTextWriterTag TagKey
        {
            get { return HtmlTextWriterTag.Div; }
        }
    }
}

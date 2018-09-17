﻿// RadioButton.cs

// Copyright (C) 2018 Kinsey Roberts (@kinzdesign), Weatherhead School of Management (@wsomweb)

// This program is free software; you can redistribute it and/or modify it under the terms of the GNU 
// General Public License as published by the Free Software Foundation; either version 2 of the 
// License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See 
// the GNU General Public License for more details. You should have received a copy of the GNU 
// General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 
// Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Bootstrap RadioButton.
    /// </summary>
    [ToolboxData("<{0}:RadioButton runat=server></{0}:RadioButton>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.RadioButton))]
    public class RadioButton : System.Web.UI.WebControls.RadioButton
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadioButton" /> class.
        /// </summary>
        public RadioButton()
        {
            this.Inline = false;
        }

        /// <summary>
        /// Gets or sets whether to render the <see cref="RadioButton"/> inline.
        /// </summary>
        [DefaultValue(false)]
        public bool Inline
        {
            get { return (bool)this.ViewState["Inline"]; }
            set { this.ViewState["Inline"] = value; }
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            // store text to render, clear base Text (so CheckBox doesn't output its own label)
            string text = this.Text;
            this.Text = null;
            // open wrapper div
            writer.AddAttribute(HtmlTextWriterAttribute.Class, BuildDivClass());
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            // open label
            writer.RenderBeginTag(HtmlTextWriterTag.Label);
            // if TextAlign is Left, output text before button
            if (this.TextAlign == TextAlign.Left)
            {
                writer.Write(text);
            }

            // render radio button
            base.Render(writer);

            // if TextAlign is Right, output text after button
            if (this.TextAlign == TextAlign.Right)
            {
                writer.Write(text);
            }
            // close div
            writer.RenderEndTag();
            // close label
            writer.RenderEndTag();
            // fix Text property
            this.Text = text;
        }

        private string BuildDivClass()
        {
            StringBuilder classes = new StringBuilder("radio");
            if (this.Inline)
            {
                classes.Append("-inline");
            }
            if (!this.Enabled)
            {
                classes.Append(" disabled");
            }
            return classes.ToString();
        }
    }
}

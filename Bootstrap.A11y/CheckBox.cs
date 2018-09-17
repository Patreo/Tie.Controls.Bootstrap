// CheckBox.cs

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
    /// Represents a Bootstrap check box.
    /// </summary>
    [ToolboxData("<{0}:CheckBox runat=server></{0}:CheckBox>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.CheckBox))]
    public class CheckBox : System.Web.UI.WebControls.CheckBox
    {
        /// <summary>
        /// Gets or sets whether to render the <see cref="CheckBox"/> inline.
        /// </summary>
        [DefaultValue(false)]
        public bool Inline
        {
            get { return (bool)this.ViewState["Inline"]; }
            set { this.ViewState["Inline"] = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBox" /> class.
        /// </summary>
        public CheckBox()
        {
            this.Inline = false;
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
            writer.AddAttribute(HtmlTextWriterAttribute.Class, BuildWrapperClass());
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            // open label
            writer.RenderBeginTag(HtmlTextWriterTag.Label);
            // if TextAlign is Left, output text before box
            if (this.TextAlign == TextAlign.Left)
            {
                writer.Write(text);
            }
            
            // render checkbox
            base.Render(writer);

            // if TextAlign is Right, output text after box
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

        /// <summary>
        /// Builds the class for the wrapper div.
        /// </summary>
        /// <returns>The CSS class(es) to be applied to the wrapper div.</returns>
        protected string BuildWrapperClass()
        {
            StringBuilder classes = new StringBuilder("checkbox");
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
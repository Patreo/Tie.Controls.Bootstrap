// DropDownList.cs

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
using System.ComponentModel;
using System.Web.UI;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Bootstrap drop-down list.
    /// </summary>
    public class DropDownList : System.Web.UI.WebControls.DropDownList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DropDownList" /> class.
        /// </summary>
        public DropDownList()
        {
            this.PlaceholderText = String.Empty;
            this.InputSize = InputSizes.Default;
        }

        /// <summary>
        /// Gets or sets the placeholder text to display when the control is empty.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string PlaceholderText
        {
            get { return (string)this.ViewState["PlaceholderText"]; }
            set { this.ViewState["PlaceholderText"] = value; }
        }

        /// <summary>
        /// Gets or sets the size of the input
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [Category("Behavior")]
        [DefaultValue(InputSizes.Default)]
        public InputSizes InputSize
        {
            get { return (InputSizes)this.ViewState["InputSize"]; }
            set { this.ViewState["InputSize"] = value; }
        }

        /// <summary>
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            ControlHelper.EnsureCssClassPresent(this, "form-control");
            InputSizesHelper.EnsureSizeClassPresent(this, this.InputSize, "input-");
            if (!String.IsNullOrEmpty(this.PlaceholderText))
            {
                writer.AddAttribute("placeholder", PlaceholderText);
            }
            base.RenderBeginTag(writer);
        }
    }
}

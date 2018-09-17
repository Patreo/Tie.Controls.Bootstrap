// Label.cs

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

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Contextual styles used on Bootstrap Labels.
    /// </summary>
    public enum LabelTypes
    {
        /// <summary>Default style (usually gray)</summary>
        Default = 0,
        /// <summary>Indicates a successful or positive action (usually green)</summary>
        Success = 1,
        /// <summary>Indicates caution should be taken with this action (usually yellow-orange)</summary>
        Warning = 2,
        /// <summary>Primary brand color</summary>
        Primary = 3,
        /// <summary>Indicates informational messages (usually light-blue)</summary>
        Info = 4,
        /// <summary>Indicates a dangerous or potentially negative action (usually red)</summary>
        Danger = 5
    }

    /// <summary>
    /// Represents a Bootstrap label.
    /// </summary>
    [ToolboxData("<{0}:Label runat=server />")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Label))]
    [DefaultProperty("Text")]
    public class Label : TextWebControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        public Label()
        {
            this.LabelType = LabelTypes.Default;
            this.Text = "Label";
        }

        /// <summary>
        /// Gets or sets the type of the label.
        /// </summary>
        /// <value>
        /// The type of the label.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(LabelTypes.Default)]
        public LabelTypes LabelType
        {
            get { return (LabelTypes)this.ViewState["LabelType"]; }
            set { this.ViewState["LabelType"] = value; }
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            ControlHelper.EnsureCssClassPresent(this, "label");
            ControlHelper.EnsureCssClassPresent(this, "label-" + StringHelper.ToLower(LabelType));
            base.Render(writer);
        }
    }
}
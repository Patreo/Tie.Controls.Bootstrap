// Well.cs

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
    /// The three sizes a well may have.
    /// </summary>
    public enum Size
    {
        /// <summary>The default size.</summary>
        Default = 0,
        /// <summary>A larger size.</summary>
        Large = 1,
        /// <summary>A smaller size.</summary>
        Small = 2
    }

    /// <summary>
    /// Represents a simple Bootstrap control with an inset effect.
    /// </summary>
    [ToolboxData("<{0}:Well runat=server></{0}:Well>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Label))]
    public class Well : TextWebControl, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Well"/> class.
        /// </summary>
        public Well()
        {
            this.Size = Size.Default;
        }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(Size.Default)]
        public Size Size
        {
            get { return (Size)this.ViewState["Size"]; }
            set { this.ViewState["Size"] = value; }
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            ControlHelper.EnsureCssClassPresent(this, "well");
            if(this.Size != Size.Default)
            {
                ControlHelper.EnsureCssClassPresent(this, "well-" + StringHelper.ToLower(Size));
            }
            base.Render(writer);
        }
    }
}

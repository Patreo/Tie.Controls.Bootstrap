// Hamburguer.cs

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
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Bootstrap hamburger control and brand information for a <see cref="NavBar"/>.
    /// </summary>
    [ToolboxData("<{0}:Hamburger runat=server />")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Button))]
    [DefaultProperty("Text")]
    public class Hamburger : System.Web.UI.WebControls.Button, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hamburger" /> class.
        /// </summary>
        public Hamburger()
        {
            this.Text = "Brand";
            this.NavigateUrl = "#";
        }

        /// <summary>
        /// Gets or sets the type of the label.
        /// </summary>
        /// <value>
        /// The type of the label.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("#")]
        public string NavigateUrl
        {
            get { return (string)this.ViewState["NavigateUrl"]; }
            set { this.ViewState["NavigateUrl"] = value; }
        }

        /// <summary>
        /// Gets or sets the URL to the brand image.
        /// </summary>
        /// <value>
        /// The URL to the brand image.
        /// </value>
        [Category("Appearance")]
        public string ImageUrl
        {
            get { return (string)this.ViewState["ImageUrl"]; }
            set { this.ViewState["ImageUrl"] = value; }
        }

        /// <summary>
        /// Gets or sets the alternative text for the brand image.
        /// </summary>
        /// <value>
        /// The alternative text for the brand image.
        /// </value>
        [Category("Appearance")]
        public string AlternativeText
        {
            get { return (string)this.ViewState["AlternativeText"]; }
            set { this.ViewState["AlternativeText"] = value; }
        }

        /// <summary>
        /// Gets or sets the height for the brand image.
        /// </summary>
        /// <value>
        /// The height for the brand image.
        /// </value>
        [Category("Appearance")]
        public int? ImageHeight
        {
            get { return (int?)this.ViewState["ImageHeight"]; }
            set { this.ViewState["ImageHeight"] = value; }
        }

        /// <summary>
        /// Gets or sets the width for the brand image.
        /// </summary>
        /// <value>
        /// The width for the brand image.
        /// </value>
        [Category("Appearance")]
        public int? ImageWidth
        {
            get { return (int?)this.ViewState["ImageWidth"]; }
            set { this.ViewState["ImageWidth"] = value; }
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            base.Render(writer);
        }

        /// <summary>
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "navbar-header");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            writer.AddAttribute(HtmlTextWriterAttribute.Type, "button");
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());
            writer.AddAttribute("aria-expanded", "false");
            writer.AddAttribute("data-toggle", "collapse");

            if (this.NamingContainer is NavBar)
            {
                writer.AddAttribute("data-target", "#" + this.NamingContainer.ClientID + "_bs-navbar-collapse");
            }

            writer.RenderBeginTag(HtmlTextWriterTag.Button);
        }

        /// <summary>
        /// Renders the HTML end tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
            writer.RenderEndTag();

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "navbar-brand");
            writer.AddAttribute(HtmlTextWriterAttribute.Href, ResolveUrl(this.NavigateUrl));            
            writer.RenderBeginTag(HtmlTextWriterTag.A);
            if (!String.IsNullOrEmpty(ImageUrl))
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Alt, AlternativeText);
                writer.AddAttribute(HtmlTextWriterAttribute.Src, ImageUrl);
                if (ImageHeight.HasValue)
                {
                    writer.AddAttribute(HtmlTextWriterAttribute.Height, ImageHeight.ToString());
                }
                if (ImageWidth.HasValue)
                {
                    writer.AddAttribute(HtmlTextWriterAttribute.Width, ImageWidth.ToString());
                }
                writer.RenderBeginTag(HtmlTextWriterTag.Img);
                writer.RenderEndTag();
            }
            writer.Write(this.Text);
            writer.RenderEndTag();

            writer.RenderEndTag();
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "sr-only");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.Write("Toggle navigation");
            writer.RenderEndTag();

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "icon-bar");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.RenderEndTag();

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "icon-bar");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.RenderEndTag();

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "icon-bar");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.RenderEndTag();

            base.RenderContents(writer);
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            return StringHelper.AppendWithSpaceIfNotEmpty("navbar-toggle collapsed", this.CssClass);
        }
    }
}

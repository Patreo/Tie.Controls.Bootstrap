// BreadcrumbsItem.cs

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
using System.Web.UI;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents an entry in a Bootstrap breadcrumb trail.
    /// </summary>
    [ToolboxData("<{0}:BreadcrumbsItem runat=server></{0}:BreadcrumbsItem>")]
    [ToolboxItem(false)]
    public class BreadcrumbsItem:Control, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BreadcrumbsItem"/> class.
        /// </summary>
        public BreadcrumbsItem()
        {
            this.Text = "";
            this.NavigateUrl = "#";
        }

         /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [Localizable(true)]
        [DefaultValue("")]
        public string Text
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the navigate URL.
        /// </summary>
        /// <value>
        /// The navigate URL.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [DefaultValue("#")]
        [UrlProperty]
        public string NavigateUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            Breadcrumbs parent = Parent as Breadcrumbs;
            bool addSchemaMarkeup = parent != null && parent.AddSchemaMarkup;
            if (!String.IsNullOrEmpty(this.NavigateUrl))
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Href, ResolveClientUrl(this.NavigateUrl));
                if (addSchemaMarkeup)
                {
                    writer.AddAttribute("itemscope", String.Empty);
                    writer.AddAttribute("itemtype", "http://schema.org/Thing");
                    writer.AddAttribute("itemprop", "item");
                }
                writer.RenderBeginTag(HtmlTextWriterTag.A);
            }
            if (addSchemaMarkeup)
            {
                writer.AddAttribute("itemprop", "name");
                writer.RenderBeginTag(HtmlTextWriterTag.Span);
            }

            writer.Write(this.Text);

            if (addSchemaMarkeup)
            {
                writer.RenderEndTag();
            }
            if (!String.IsNullOrEmpty(this.NavigateUrl))
            {
                writer.RenderEndTag();
            }
        }
    }
}

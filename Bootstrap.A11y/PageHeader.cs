// PageHeader.cs

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
using System.Web.UI.WebControls;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Bootstrap page header.
    /// </summary>
    [ToolboxData("<{0}:PageHeader runat=server />")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Label))]
    public class PageHeader : WebControl, INamingContainer
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Category("Appearance")]
        [DefaultValue("")]
        public string Title
        {
            get { return (string)this.ViewState["Title"]; }
            set { this.ViewState["Title"] = value; }
        }

        /// <summary>
        /// Gets or sets the sub title.
        /// </summary>
        /// <value>
        /// The sub title.
        /// </value>
        [Category("Appearance")]
        [DefaultValue("")]
        public string SubText
        {
            get { return (string)this.ViewState["SubText"]; }
            set { this.ViewState["SubText"] = value; }
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Id, this.ClientID);
            writer.AddAttribute(HtmlTextWriterAttribute.Name, this.UniqueID);
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());

            base.Render(writer);
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.RenderBeginTag(HtmlTextWriterTag.H1);
            writer.Write(this.Title);
          
            if (!String.IsNullOrEmpty(this.SubText))
            {
                writer.RenderBeginTag(HtmlTextWriterTag.Small);
                writer.Write(this.SubText);
                writer.RenderEndTag();
            }

            writer.RenderEndTag();
            this.RenderChildren(writer);
        }

        private string BuildCss()
        {
            return StringHelper.AppendWithSpaceIfNotEmpty("page-header", this.CssClass);
        }
    }
}

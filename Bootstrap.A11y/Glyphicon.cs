// Glyphicon.cs

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
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Glyphicon icon.
    /// </summary>
    public class Glyphicon : WebControl, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Glyphicon" /> class.
        /// </summary>
        public Glyphicon()
        {
            this.Icon = "";
            this.AlternateText = "";
        }

        /// <summary>
        /// Gets or sets the icon key (e.g. "search").
        /// </summary>
        /// <value>
        /// The icon key.
        /// </value>
        [DefaultValue("")]
        public string Icon
        {
            get { return (string)this.ViewState["Icon"]; }
            set { this.ViewState["Icon"] = value; }
        }

        /// <summary>
        /// Gets or sets the alternative text. This text is presented to screen readers,
        /// but is invisible to sighted users.
        /// </summary>
        /// <value>
        /// The alternative text.
        /// </value>
        [DefaultValue("")]
        public string AlternateText
        {
            get { return (string)this.ViewState["AlternateText"]; }
            set { this.ViewState["AlternateText"] = value; }
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            RenderIconSpan(writer);
            RenderScreenReaderSpan(writer);
        }

        /// <summary>
        /// Renders the icon span.
        /// </summary>
        /// <param name="writer">The <see cref="HtmlTextWriter"/> to render to.</param>
        protected void RenderIconSpan(HtmlTextWriter writer)
        {
            // only render icon if defined
            string iconClass = this.Icon;
            if (String.IsNullOrEmpty(iconClass))
            {
                return;
            }
            // clean up iconClass
            iconClass = iconClass.Trim().ToLower(CultureInfo.InvariantCulture).Replace("glyphicon-", "");
            // set CSS classes
            string classes = "glyphicon glyphicon-" + iconClass;
            writer.AddAttribute(HtmlTextWriterAttribute.Class, classes);
            // hide icon from screen readers
            writer.AddAttribute("aria-hidden", "true");
            // output empty span
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.RenderEndTag();
        }

        /// <summary>
        /// Renders the .sr-only span.
        /// </summary>
        /// <param name="writer">The <see cref="HtmlTextWriter"/> to render to.</param>
        protected void RenderScreenReaderSpan(HtmlTextWriter writer)
        {
            // only render icon if defined
            string altText = this.AlternateText;
            if (String.IsNullOrEmpty(altText))
            {
                return;
            }
            // hide icon from sighted readers
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "sr-only");
            // output span
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.Write(altText);
            writer.RenderEndTag();
        }
    }
}

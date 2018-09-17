// ListHeader.cs

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
    /// Represents a header in a Bootstrap list.
    /// </summary>
    [ToolboxData("<{0}:ListHeader runat=server></{0}:ListHeader>")]
    [ToolboxItem(false)]
    [ParseChildren(true, "Text")]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ListHeader : Control, INamingContainer, IParserAccessor, IListItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListHeader"/> class.
        /// </summary>
        public ListHeader()
        {
            this.Text = "";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListHeader"/> class.
        /// </summary>
        /// <param name="Text">The text.</param>
        public ListHeader(string Text)
            : this()
        {
            this.Text = Text;
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
        string IListItem.NavigateUrl
        {
            get { return null; }
            set { throw new InvalidOperationException("ListHeaders do not use the NavigateUrl property."); }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="IListItem" /> is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if enabled; otherwise, <c>false</c>.
        /// </value>
        bool IListItem.Enabled
        {
            get { return true; }
            set { throw new InvalidOperationException("ListHeaders do not use the Enabled property."); }
        }

        /// <summary>
        /// Outputs server control content to a provided <see cref="T:System.Web.UI.HtmlTextWriter" /> object and stores tracing information about the control if tracing is enabled.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        public override void RenderControl(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "dropdown-header");
            writer.RenderBeginTag(HtmlTextWriterTag.Li);
            writer.Write(this.Text);
            writer.RenderEndTag();

            base.RenderControl(writer);
        }
    }
}

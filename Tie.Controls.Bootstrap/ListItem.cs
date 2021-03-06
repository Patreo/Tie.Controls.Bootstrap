﻿// ListItem.cs

// Copyright (C) 2013 Pedro Fernandes

// This program is free software; you can redistribute it and/or modify it under the terms of the GNU 
// General Public License as published by the Free Software Foundation; either version 2 of the 
// License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See 
// the GNU General Public License for more details. You should have received a copy of the GNU 
// General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 
// Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tie.Controls.Bootstrap
{
    [ToolboxData("<{0}:ListItem runat=server></{0}:ListItem>")]
    [ToolboxItem(false)]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [ParseChildren(true, "Items")]
    [PersistChildren(false)]
    public class ListItem : Control, INamingContainer, IParserAccessor, IListItem
    {
        private ListItemCollection _items;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItem"/> class.
        /// </summary>
        public ListItem()
            : base()
        {
            this._items = new ListItemCollection();
            this.Enabled = true;
            this.Icon = "";
            this.Text = "";
            this.NavigateUrl = "#";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItem"/> class.
        /// </summary>
        /// <param name="Text">The text.</param>
        /// <param name="Value">The value.</param>
        /// <param name="Enabled">if set to <c>true</c> [enabled].</param>
        public ListItem(string Text, string Value, bool Enabled)
            : this()
        {
            this.Text = Text;
            this.NavigateUrl = Value;
            this.Enabled = Enabled;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ListItem"/> is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if enabled; otherwise, <c>false</c>.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool Enabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        /// <value>
        /// The icon.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [DefaultValue("")]
        public string Icon
        {
            get;
            set;
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
        /// Gets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public ListItemCollection Items
        {
            get { return _items; }
        }     

        /// <summary>
        /// Notifies the server control that an element, either XML or HTML, was parsed, and adds the element to the server control's <see cref="T:System.Web.UI.ControlCollection" /> object.
        /// </summary>
        /// <param name="obj">An <see cref="T:System.Object" /> that represents the parsed element.</param>
        protected override void AddParsedSubObject(object obj)
        {
            if (obj is ListItem || obj is ListHeader | obj is ListSeparator)
            {
                Items.Add((IListItem)obj);
                return;
            }
        }

        /// <summary>
        /// Gets a <see cref="T:System.Web.UI.ControlCollection" /> object that represents the child controls for a specified server control in the UI hierarchy.
        /// </summary>
        public override ControlCollection Controls
        {
            get
            {
                this.EnsureChildControls();
                return base.Controls;
            }
        }

        /// <summary>
        /// Outputs server control content to a provided <see cref="T:System.Web.UI.HtmlTextWriter" /> object and stores tracing information about the control if tracing is enabled.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        public override void RenderControl(HtmlTextWriter writer)
        {
            string strCssClass = this.BuildCssItem();

            if (!String.IsNullOrEmpty(strCssClass)) writer.AddAttribute(HtmlTextWriterAttribute.Class, strCssClass);
            writer.RenderBeginTag(HtmlTextWriterTag.Li);
            Render(writer);
            writer.RenderEndTag();
        }   

        /// <summary>
        /// Sends server control content to a provided <see cref="T:System.Web.UI.HtmlTextWriter" /> object, which writes the content to be rendered on the client.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the server control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            if (!String.IsNullOrEmpty(this.Icon))
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "icon-" + this.Icon);
                writer.RenderBeginTag(HtmlTextWriterTag.I);
                writer.RenderEndTag();
            }

            if (this.Items.Count != 0)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Href, "#");
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "dropdown-toggle");
                writer.AddAttribute("data-toggle", "dropdown");
                writer.AddAttribute("role", "button");
                writer.AddAttribute("aria-haspopup", "true");
                writer.AddAttribute("aria-expanded", "false");
            }
            else
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Href, ResolveClientUrl(this.NavigateUrl));
            }

            writer.RenderBeginTag(HtmlTextWriterTag.A);
            writer.Write(this.Text);

            if (this.Items.Count != 0)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "caret");
                writer.RenderBeginTag(HtmlTextWriterTag.Span);
                writer.RenderEndTag();
            }

            writer.RenderEndTag();

            if (this.Items.Count != 0)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "dropdown-menu");
                writer.RenderBeginTag(HtmlTextWriterTag.Ul);

                foreach (Control item in this.Items)
                {
                    if (item.GetType() == typeof(ListItem) || item.GetType() == typeof(ListSeparator))
                    {
                        item.RenderControl(writer);
                    }
                }

                writer.RenderEndTag();
            }
        }

        /// <summary>
        /// Builds the CSS item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        private string BuildCssItem()
        {
            string str = "";

            if (this.Items.Count != 0)
            {
                str += " dropdown";
            }

            if (this.Enabled == false)
            {
                str += " disabled";
            }

            return str.Trim();
        }
    }
}

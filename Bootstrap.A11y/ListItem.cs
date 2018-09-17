// ListItem.cs

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
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents an item in a Bootstrap list.
    /// </summary>
    [ToolboxData("<{0}:ListItem runat=server></{0}:ListItem>")]
    [ToolboxItem(false)]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [ParseChildren(true, "Items")]
    [PersistChildren(false)]
    public class ListItem : WebControl, INamingContainer, IParserAccessor, IListItem
    {
        readonly ListItemCollection _items;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItem"/> class.
        /// </summary>
        public ListItem() : base(HtmlTextWriterTag.Li)
        {
            this._items = new ListItemCollection();
            this.Enabled = true;
            this.Active = false;
            this.Icon = "";
            this.Text = "";
            this.NavigateUrl = "#";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItem"/> class.
        /// </summary>
        /// <param name="Text">The text.</param>
        /// <param name="Value">The value.</param>
        /// <param name="Enabled">Whether the item is enabled.</param>
        /// <param name="Active">Whether the item is active.</param>
        public ListItem(string Text, string Value, bool Enabled, bool Active)
            : this()
        {
            this.Text = Text;
            this.NavigateUrl = Value;
            this.Enabled = Enabled;
            this.Active = Active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItem"/> class.
        /// </summary>
        /// <param name="Text">The text.</param>
        /// <param name="Value">The value.</param>
        /// <param name="Enabled">if set to <c>true</c> [enabled].</param>
        public ListItem(string Text, string Value, bool Enabled)
            : this(Text, Value, Enabled, false)
        { }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ListItem"/> is the active item.
        /// </summary>
        /// <value>
        ///   <c>true</c> if active; otherwise, <c>false</c>.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [DefaultValue(false)]
        public bool Active
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
            IListItem listItem = obj as IListItem;
            if (listItem != null)
            {
                this.Items.Add(listItem);
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
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            this.CssClass = StringHelper.AppendWithSpaceIfNotEmpty(this.CssClass, BuildCss());
            base.RenderBeginTag(writer);
        }

        /// <summary>
        /// Renders the HTML contents of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
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
        /// <returns>The CSS classes.</returns>
        private string BuildCss()
        {
            StringBuilder classes = new StringBuilder();
            StringHelper.AppendIf(classes, this.Items.Count > 0, " dropdown");
            StringHelper.AppendIf(classes, !this.Enabled, " disabled");
            StringHelper.AppendIf(classes, this.Active, " active");
            return classes.ToString();
        }
    }
}

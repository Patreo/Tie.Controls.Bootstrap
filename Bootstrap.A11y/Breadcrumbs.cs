// Breadcrumbs.cs

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
    /// Represents a Bootstrap breadcrumbs list.
    /// </summary>
    [ToolboxData("<{0}:Breadcrumbs runat=server></{0}:Breadcrumbs>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.BulletedList))]
    [ParseChildren(true, "Items")]
    [PersistChildren(false)]
    public class Breadcrumbs : WebControl, INamingContainer
    {
        readonly BreadcrumbsCollection _items;

        /// <summary>
        /// Initializes a new instance of the <see cref="Breadcrumbs"/> class.
        /// </summary>
        public Breadcrumbs()
        {
            this._items = new BreadcrumbsCollection(this);
            this.AddSchemaMarkup = true;
        }

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public BreadcrumbsCollection Items
        {
            get { return _items; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to include Schema.org markup.
        /// </summary>
        /// <value>
        ///   <c>true</c> if schema should be included; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool AddSchemaMarkup
        {
            get { return (bool)this.ViewState["AddSchemaMarkup"]; }
            set { this.ViewState["AddSchemaMarkup"] = value; }
        }

        /// <summary>
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());
            writer.AddAttribute("aria-label", "Breadcrumb");
            if(AddSchemaMarkup)
            {
                writer.AddAttribute("itemscope", String.Empty);
                writer.AddAttribute("itemtype", "http://schema.org/BreadcrumbList");
            }
            writer.RenderBeginTag(HtmlTextWriterTag.Ol);
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Id, this.ClientID);
            writer.AddAttribute(HtmlTextWriterAttribute.Name, this.UniqueID);

            base.Render(writer);
        }

        /// <summary>
        /// Notifies the server control that an element, either XML or HTML, was parsed, and adds the element to the server control's <see cref="T:System.Web.UI.ControlCollection" /> object.
        /// </summary>
        /// <param name="obj">An <see cref="T:System.Object" /> that represents the parsed element.</param>
        protected override void AddParsedSubObject(object obj)
        {
            BreadcrumbsItem crumb = obj as BreadcrumbsItem;
            if (crumb != null)
            {
                Items.Add(crumb);
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
        /// Renders the HTML contents of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                BreadcrumbsItem item = this.Items[i];

                if (i == (this.Items.Count - 1))
                {
                    item.NavigateUrl = "";
                    writer.AddAttribute(HtmlTextWriterAttribute.Class, "active");
                    writer.AddAttribute("aria-current", "page");
                }

                if(AddSchemaMarkup)
                {
                    writer.AddAttribute("itemscope", String.Empty);
                    writer.AddAttribute("itemtype", "http://schema.org/ListItem");
                    writer.AddAttribute("itemprop", "itemListElement");
                }
                writer.RenderBeginTag(HtmlTextWriterTag.Li);
                item.RenderControl(writer);

                if (AddSchemaMarkup)
                {
                    writer.AddAttribute("content", (i + 1).ToString());
                    writer.AddAttribute("itemprop", "position");
                    writer.RenderBeginTag(HtmlTextWriterTag.Meta);
                    writer.RenderEndTag();
                }
                writer.RenderEndTag();
            }
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            return StringHelper.AppendWithSpaceIfNotEmpty("breadcrumb", this.CssClass);
        }
    }
}

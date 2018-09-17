// ListGroup.cs

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
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Bootstrap list group.
    /// </summary>
    [ToolboxData("<{0}:ListGroup runat=server></{0}:ListGroup>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.ListBox))]
    [ParseChildren(true, "Items")]
    [PersistChildren(false)]
    public class ListGroup : WebControl, INamingContainer
    {
        readonly ListGroupItemCollection _items;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGroup"/> class.
        /// </summary>
        public ListGroup()
        {
            this._items = new ListGroupItemCollection(this);
            this.RenderAsList = false;
        }

        /// <summary>
        /// Gets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public ListGroupItemCollection Items
        {
            get { return _items; }
        }

        /// <summary>
        /// Gets or sets the type of the alert.
        /// </summary>
        /// <value>
        /// The type of the alert.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool RenderAsList
        {
            get { return (bool)this.ViewState["RenderAsList"]; }
            set { this.ViewState["RenderAsList"] = value; }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.PreRender" /> event. This notifies the control to perform any steps necessary for its creation on a page request.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnPreRender(EventArgs e)
        {
            if (this.Items == null || this.Items.Count == 0)
            {
                this.Visible = false;
            }
        }

        /// <summary>
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            ControlHelper.EnsureCssClassPresent(this, "list-group");
            AddAttributesToRender(writer);
            writer.RenderBeginTag(this.RenderAsList ? HtmlTextWriterTag.Ul : HtmlTextWriterTag.Div);
        }

        /// <summary>
        /// Notifies the server control that an element, either XML or HTML, was parsed, and adds the element to the server control's <see cref="T:System.Web.UI.ControlCollection" /> object.
        /// </summary>
        /// <param name="obj">An <see cref="T:System.Object" /> that represents the parsed element.</param>
        protected override void AddParsedSubObject(object obj)
        {
            ListGroupItem crumb = obj as ListGroupItem;
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
    }
}

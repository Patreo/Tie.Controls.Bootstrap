// ListGroupItem.cs

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
using System.Web.UI;
using System.Web.UI.WebControls;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Contextual styles used in Bootstrap.
    /// </summary>
    public enum ListGroupStyles : byte
    {
        /// <summary>No style defined</summary>
        None = 0,
        /// <summary>Indicates informational messages (usually light-blue)</summary>
        Info = 1,
        /// <summary>Indicates a successful or positive action (usually green)</summary>
        Success = 2,
        /// <summary>Indicates caution should be taken with this action (usually yellow-orange)</summary>
        Warning = 3,
        /// <summary>Indicates a dangerous or potentially negative action (usually red)</summary>
        Danger = 4
    }

    /// <summary>
    /// Represents an item in a Bootstrap <see cref="ListGroup"/>.
    /// </summary>
    [ToolboxData("<{0}:ListGroupItem runat=server></{0}:ListGroupItem>")]
    [ToolboxItem(false)]
    [ParseChildren(true, "Content")]
    [PersistChildren(false)]
    public class ListGroupItem : WebControl, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListGroupItem"/> class.
        /// </summary>
        public ListGroupItem()
        {
            this.Text = "";
            this.BadgeValue = null;
            this.NavigateUrl = "";
            this.Selected = false;
            this.Enabled = true;
            this.RenderAsButton = false;
            this.ContextStyle = ListGroupStyles.None;
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
            get { return (string)this.ViewState["Text"]; }
            set { this.ViewState["Text"] = value; }
        }

        /// <summary>
        /// Gets or sets the contents.
        /// </summary>
        /// <value>
        /// The contents.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(Panel))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Content
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the number to show in the badge.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [Localizable(true)]
        [DefaultValue(null)]
        public int? BadgeValue
        {
            get { return (int?)this.ViewState["BadgeValue"]; }
            set { this.ViewState["BadgeValue"] = value; }
        }

        /// <summary>
        /// Gets or sets the navigate URL.
        /// </summary>
        /// <value>
        /// The navigate URL.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [UrlProperty]
        [DefaultValue("")]
        public string NavigateUrl
        {
            get { return (string)this.ViewState["NavigateUrl"]; }
            set { this.ViewState["NavigateUrl"] = value; }
        }

        /// <summary>
        /// Gets or sets whether the item is selected.
        /// </summary>
        /// <value>
        /// Whether the item is selected.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [DefaultValue(false)]
        public bool Selected
        {
            get { return (bool)this.ViewState["Selected"]; }
            set { this.ViewState["Selected"] = value; }
        }

        /// <summary>
        /// Gets or sets whether the item should be rendered as a button.
        /// </summary>
        /// <value>
        /// Whether the item should be rendered as a button.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [DefaultValue(false)]
        public bool RenderAsButton
        {
            get { return (bool)this.ViewState["RenderAsButton"]; }
            set { this.ViewState["RenderAsButton"] = value; }
        }

        /// <summary>
        /// Gets or sets the contextual style for the item.
        /// </summary>
        /// <value>
        /// The contextual style.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [DefaultValue(ListGroupStyles.None)]
        public ListGroupStyles ContextStyle
        {
            get { return (ListGroupStyles)this.ViewState["ContextStyle"]; }
            set { this.ViewState["ContextStyle"] = value; }
        }

        ListGroup _parent;
        private ListGroup ParentListGroup
        {
            get
            {
                if (_parent == null)
                {
                    _parent = Parent as ListGroup;
                }
                return _parent;
            }
        }

        private bool RenderAsListItem
        {
            get { return ParentListGroup.RenderAsList; }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.PreRender" /> event. This notifies the control to perform any steps necessary for its creation on a page request.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnPreRender(EventArgs e)
        {
            if(this.ParentListGroup == null)
            {
                throw new InvalidOperationException("ListGroupItems must be direct children of a ListGroup.");
            }
            base.OnPreRender(e);
        }

        /// <summary>
        /// Sends server control content to a provided <see cref="T:System.Web.UI.HtmlTextWriter" /> object, which writes the content to be rendered on the client.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the server control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            this.EnsureClassesPresent();
            base.Render(writer);
        }

        /// <summary>
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            if(this.RenderAsListItem)
            {
                writer.RenderBeginTag(HtmlTextWriterTag.Li);
            }
            else if (this.RenderAsButton)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Type, "button");
                writer.RenderBeginTag(HtmlTextWriterTag.Button);
            }
            else if (!String.IsNullOrEmpty(this.NavigateUrl))
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Href, NavigateUrl);
                writer.RenderBeginTag(HtmlTextWriterTag.A);
            }
            else
            {
                writer.RenderBeginTag(HtmlTextWriterTag.Div);
            }
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            // render badge span if present
            if(this.BadgeValue.HasValue && this.BadgeValue != 0)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "badge");
                writer.RenderBeginTag(HtmlTextWriterTag.Span);
                writer.Write(this.BadgeValue.Value);
                writer.RenderEndTag();
            }
            string text = this.Text;
            bool hasText = !String.IsNullOrEmpty(text);
            if (hasText)
            {
                writer.Write(this.Text);
            }
            else if (this.Content != null)
            {
                var container = new Control();
                container.ID = "container";
                this.Content.InstantiateIn(container);
                container.RenderControl(writer);
            }
        }

        /// <summary>
        /// Ensures that necessary classes are present on the control before rendering.
        /// </summary>
        protected virtual void EnsureClassesPresent()
        {
            ControlHelper.EnsureCssClassPresent(this, "list-group-item");
            ListGroupStyles style = this.ContextStyle;
            if (style != ListGroupStyles.None)
            {
                ControlHelper.EnsureCssClassPresent(this, "list-group-item-" + StringHelper.ToLower(style));
            }
            if(this.Selected)
            {
                ControlHelper.EnsureCssClassPresent(this, "active");
            }
            if (!this.Enabled)
            {
                ControlHelper.EnsureCssClassPresent(this, "disabled");
            }
        }
    }
}

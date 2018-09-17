// Dropdown.cs

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

using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Web.UI;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Bootstrap drop-down.
    /// </summary>
    [ToolboxData("<{0}:Dropdown runat=server></{0}:Dropdown>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.DropDownList))]
    [ParseChildren(true, "Items")]
    [PersistChildren(false)]
    public class Dropdown : AccessibleWebControl, INamingContainer
    {
        readonly ListItemCollection _items;

        /// <summary>
        /// Initializes a new instance of the <see cref="Dropdown" /> class.
        /// </summary>
        public Dropdown()
        {
            this._items = new ListItemCollection();
            this.RightToLeft = false;
            this.Expanded = false;
            this.DropUp = false;
            this.Text = "";
        }

        /// <summary>
        /// Gets or sets the type of the alert.
        /// </summary>
        /// <value>
        /// The type of the alert.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool RightToLeft
        {
            get { return (bool)this.ViewState["RightToLeft"]; }
            set { this.ViewState["RightToLeft"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [drop up].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [drop up]; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool DropUp
        {
            get { return (bool)this.ViewState["DropUp"]; }
            set { this.ViewState["DropUp"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [expanded].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [drop up]; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Expanded
        {
            get { return (bool)this.ViewState["Expanded"]; }
            set { this.ViewState["Expanded"] = value; }
        }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string Text
        {
            get { return (string)this.ViewState["Text"]; }
            set { this.ViewState["Text"] = value; }
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
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Id, this.ClientID);
            writer.AddAttribute(HtmlTextWriterAttribute.Name, this.UniqueID);
            if (ShouldRenderOuterDiv())
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());
                writer.RenderBeginTag(HtmlTextWriterTag.Div);
            }

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "btn btn-default dropdown-toggle");
            string buttonId = ClientID + "_btn";
            writer.AddAttribute("id", buttonId);
            writer.AddAttribute("type", "button");
            writer.AddAttribute("data-toggle", "dropdown");
            writer.AddAttribute("aria-haspopup", "true");
            writer.AddAttribute("aria-expanded", StringHelper.ToLower(Expanded));
            writer.RenderBeginTag(HtmlTextWriterTag.Button);
            writer.Write(this.Text);

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "caret");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.RenderEndTag(); // Span

            writer.RenderEndTag(); // Button

            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCssInternal());
            writer.AddAttribute("aria-labelledby", buttonId);
            writer.RenderBeginTag(HtmlTextWriterTag.Ul);
        }

        /// <summary>
        /// Decides whether or not the outer div (classed dropdown/dropup) should be rendered.
        /// If this is a descendant of a ButtonGroup, that div should not be rendered.
        /// </summary>
        /// <returns>True if the div should be rendered</returns>
        private bool ShouldRenderOuterDiv()
        {
            Control p = this.Parent;
            while (p != null)
            {
                if (p is ButtonGroup)
                {
                    return false;
                }
                p = p.Parent;
            }
            return true;
        }

        /// <summary>
        /// Renders the HTML end tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
            writer.RenderEndTag();
            if (ShouldRenderOuterDiv())
            {
                writer.RenderEndTag();
            }
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
        /// Renders the HTML contents of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            foreach (Control item in this.Items)
            {
                item.RenderControl(writer);              
            }            
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            StringBuilder classes = new StringBuilder(this.DropUp ? "dropup" : "dropdown");
            StringHelper.AppendIf(classes, this.Expanded, " open");
            StringHelper.AppendWithSpaceIfNotEmpty(classes, this.CssClass);
            return classes.ToString();
        }

        /// <summary>
        /// Builds the CSS internal.
        /// </summary>
        /// <returns></returns>
        private string BuildCssInternal()
        {
            return StringHelper.AppendIf("dropdown-menu", this.RightToLeft, " dropdown-menu-right");
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

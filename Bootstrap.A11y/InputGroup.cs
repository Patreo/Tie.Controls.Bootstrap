// InputGroup.cs

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
    /// Represents a Bootstrap input group.
    /// </summary>
    [ToolboxData("<{0}:InputGroup runat=server></{0}:InputGroup>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Panel))]
    [DefaultProperty("CssClass")]
    [ParseChildren(true, "Input")]
    [PersistChildren(false)]
    public class InputGroup : WebControl, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputGroup"/> class.
        /// </summary>
        public InputGroup()
        {
            this.Size = Size.Default;
            this.Prefix = "";
            this.Suffix = "";
        }

        /// <summary>
        /// Gets or sets the rows.
        /// </summary>
        /// <value>
        /// The rows.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(Row))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Input
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(Size.Default)]
        public Size Size
        {
            get { return (Size)this.ViewState["Size"]; }
            set { this.ViewState["Size"] = value; }
        }

        /// <summary>
        /// Gets or sets the prefix.
        /// </summary>
        /// <value>
        /// The prefix.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string Prefix
        {
            get { return (string)this.ViewState["Prefix"]; }
            set { this.ViewState["Prefix"] = value; }
        }

        /// <summary>
        /// Gets or sets the suffix.
        /// </summary>
        /// <value>
        /// The suffix.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string Suffix
        {
            get { return (string)this.ViewState["Suffix"]; }
            set { this.ViewState["Suffix"] = value; }
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            this.EnsureClassesPresent();
            base.Render(writer);
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            if (!String.IsNullOrEmpty(this.Prefix))
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "input-group-addon");
                writer.AddAttribute("aria-hidden", "true");
                writer.RenderBeginTag(HtmlTextWriterTag.Span);
                writer.Write(this.Prefix);
                writer.RenderEndTag();
            }

            this.RenderChildren(writer);

            if (!String.IsNullOrEmpty(this.Suffix))
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "input-group-addon");
                writer.AddAttribute("aria-hidden", "true");
                writer.RenderBeginTag(HtmlTextWriterTag.Span);
                writer.Write(this.Suffix);
                writer.RenderEndTag();
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event. This notifies the control to perform any steps necessary for its creation on a page request.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit(System.EventArgs e)
        {
            base.OnInit(e);
            this.CreateChildControls();
            this.ChildControlsCreated = true;
        }

        /// <summary>
        /// Called by the ASP.NET page framework to notify server controls that use composition-based implementation to create any child controls they contain in preparation for posting back or rendering.
        /// </summary>
        protected override void CreateChildControls()
        {
            var container = new Control();
            this.Input.InstantiateIn(container);

            this.Controls.Clear();
            this.Controls.Add(container);
        }

        /// <summary>
        /// Ensures that necessary classes are present on the control before rendering.
        /// </summary>
        private void EnsureClassesPresent()
        {
            ControlHelper.EnsureCssClassPresent(this, "input-group");
            if (this.Size != Size.Default)
            {
                ControlHelper.EnsureCssClassPresent(this, "input-group-" + StringHelper.ToLower(Size));
            }
        }
    }
}

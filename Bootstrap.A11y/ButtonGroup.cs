// ButtonGroup.cs

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
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a group of Bootstrap buttons.
    /// </summary>
    [ToolboxData("<{0}:ButtonGroup runat=server></{0}:ButtonGroup>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Button))]
    [ParseChildren(true, "Buttons")]
    [PersistChildren(false)]
    public class ButtonGroup : WebControl, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonGroup"/> class.
        /// </summary>
        public ButtonGroup()
        {
            this.Orientation = System.Web.UI.WebControls.Orientation.Horizontal;
            this.ButtonSize = ButtonSizes.Default;
            this.Justified = false;
            this.Toolbar = false;
            this.Label = String.Empty;
        }

        /// <summary>
        /// Gets or sets the orientation.
        /// </summary>
        /// <value>
        /// The orientation.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(Orientation.Horizontal)]
        public Orientation Orientation
        {
            get { return (Orientation)this.ViewState["Orientation"]; }
            set { this.ViewState["Orientation"] = value; }
        }

        /// <summary>
        /// Gets or sets the size of the button.
        /// </summary>
        /// <value>
        /// The size of the button.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(ButtonSizes.Default)]
        public ButtonSizes ButtonSize
        {
            get { return (ButtonSizes)this.ViewState["ButtonSize"]; }
            set { this.ViewState["ButtonSize"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ButtonGroup"/> is justified.
        /// </summary>
        /// <value>
        ///   <c>true</c> if justified; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Justified
        {
            get { return (bool)this.ViewState["Justified"]; }
            set { this.ViewState["Justified"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ButtonGroup"/> is toolbar.
        /// </summary>
        /// <value>
        ///   <c>true</c> if toolbar; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Toolbar
        {
            get { return (bool)this.ViewState["Toolbar"]; }
            set { this.ViewState["Toolbar"] = value; }
        }

        /// <summary>
        /// Gets or sets a label to describe the button group to screen readers.
        /// </summary>
        /// <value>
        /// The label text.
        /// </value>
        [Category("Accessibility")]
        [DefaultValue("")]
        public string Label
        {
            get { return (string)this.ViewState["Label"]; }
            set { this.ViewState["Label"] = value; }
        }

        /// <summary>
        /// Gets or sets the buttons.
        /// </summary>
        /// <value>
        /// The buttons.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(ButtonGroup))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Buttons
        {
            get;
            set;
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

            if (this.Toolbar)
            {
                writer.AddAttribute("role", "toolbar");
            }
            else
            {
                writer.AddAttribute("role", "group");
            }

            if (!String.IsNullOrEmpty(Label))
            {
                writer.AddAttribute("aria-label", Label);
            }

            base.Render(writer);
        }

        /// <summary>
        /// Renders the HTML contents of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            this.RenderChildren(writer);
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
            this.Buttons.InstantiateIn(container);

            this.Controls.Clear();
            this.Controls.Add(container);
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            StringBuilder classes = new StringBuilder();
            if(this.Toolbar)
            {
                classes.Append("btn-toolbar");
            }
            else
            {
                classes.Append("btn-group");
                StringHelper.AppendIf(classes, this.Orientation == Orientation.Vertical, "-vertical");
            }
            classes.Append(this.GetCssButtonSize());
            StringHelper.AppendIf(classes, this.Justified, " btn-group-justified");
            StringHelper.AppendWithSpaceIfNotEmpty(classes, this.CssClass);
            return classes.ToString();
        }

        /// <summary>
        /// Gets the size of the CSS button.
        /// </summary>
        /// <returns></returns>
        private string GetCssButtonSize()
        {
            switch (this.ButtonSize)
            {
                case ButtonSizes.Large:
                    return " btn-group-lg";

                case ButtonSizes.Small:
                    return " btn-group-sm";

                case ButtonSizes.Mini:
                    return " btn-group-xs";

                default:
                    // no class needed
                    return String.Empty;
            }
        }
    }
}
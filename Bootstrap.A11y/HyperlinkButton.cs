// HyperLinkButton.cs

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
using System.Text;
using System.Web.UI;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Bootstrap hyperlink button.
    /// </summary>
    [ToolboxData("<{0}:HyperLinkButton runat=server />")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.LinkButton))]
    [DefaultProperty("Text")]
    [ParseChildren(true, "Content")]
    [PersistChildren(false)]
    public class HyperLinkButton : System.Web.UI.WebControls.HyperLink, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperLinkButton" /> class.
        /// </summary>
        public HyperLinkButton()
        {
            this.ButtonType = ButtonTypes.Default;
            this.ButtonSize = ButtonSizes.Default;
            this.Block = false;
            this.Pressed = false;
            this.ModalID = "";
        }

        /// <summary>
        /// Gets or sets the popover.
        /// </summary>
        /// <value>
        /// The popover.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual Popover Popover
        {
            get;
            set;
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
        /// Gets or sets the button identifier.
        /// </summary>
        /// <value>
        /// The button identifier.
        /// </value>
        [Category("Modal")]
        [DefaultValue("")]
        public string ModalID
        {
            get { return (string)this.ViewState["ModalID"]; }
            set { this.ViewState["ModalID"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="HyperLinkButton" /> is block.
        /// </summary>
        /// <value>
        ///   <c>true</c> if block; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Block
        {
            get { return (bool)this.ViewState["Block"]; }
            set { this.ViewState["Block"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="HyperLinkButton"/> is pressed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if pressed; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Pressed
        {
            get { return (bool)this.ViewState["Pressed"]; }
            set { this.ViewState["Pressed"] = value; }
        }

        /// <summary>
        /// Gets or sets the type of the button.
        /// </summary>
        /// <value>
        /// The type of the button.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(ButtonTypes.Default)]
        public ButtonTypes ButtonType
        {
            get { return (ButtonTypes)this.ViewState["ButtonType"]; }
            set { this.ViewState["ButtonType"] = value; }
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
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            base.Render(writer);
        }

        /// <summary>
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            if (!String.IsNullOrEmpty(this.ModalID))
            {
                Modal modal = (Modal)Modal.FindControlRecursive(this.Page, this.ModalID);

                if (modal != null)
                {
                    writer.AddAttribute("data-toggle", "modal");
                    writer.AddAttribute("data-target", "#" + modal.ClientID);
                }
            }

            if (this.Popover != null)
            {
                writer.AddAttribute("data-toggle", "popover");
                writer.AddAttribute("data-container", "body");
                writer.AddAttribute("data-content", this.Popover.Text);
                if (this.Popover.Position != PopoverPositions.Right)
                {
                    writer.AddAttribute("data-placement", PopoverPositionsHelper.ToString(this.Popover.Position));
                }
                if (this.Popover.Trigger != Popover.DEFAULT_TRIGGER)
                {
                    writer.AddAttribute("data-trigger", TriggersHelper.ToString(this.Popover.Trigger));
                }

                if (this.Popover.DismissOnNextClick)
                {
                    writer.AddAttribute("tabindex", "0");
                    writer.AddAttribute("data-trigger", "focus");
                }
                if (!String.IsNullOrEmpty(this.Popover.Title))
                {
                    writer.AddAttribute("title", this.Popover.Title);
                }
            }

            this.CssClass = this.BuildCss();
            this.Attributes.Add("role", "button");
            this.AddAttributesToRender(writer);
            writer.RenderBeginTag(HtmlTextWriterTag.A);
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
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
            else
            {
                this.Visible = false;
            }
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            StringBuilder classes = new StringBuilder("btn");
            ButtonTypes type = this.ButtonType;
            if (type != ButtonTypes.Danger)
            {
                classes.Append(" btn-" + this.ButtonType);
            }
            classes.Append(ButtonSizesHelper.GetClassName(ButtonSize));

            if (Block)
            {
                classes.Append(" btn-block");
            }
            if (!Enabled)
            {
                classes.Append(" disabled");
            }
            if (Pressed)
            {
                classes.Append(" active");
            }
            if (!String.IsNullOrEmpty(CssClass))
            {
                classes.Append(' ');
                classes.Append(CssClass);
            }

            return classes.ToString().Trim();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event. This notifies the control to perform any steps necessary for its creation on a page request.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (Popover != null)
            {
                Popover.RegisterJsInit(Page);
            }
        }
    }
}
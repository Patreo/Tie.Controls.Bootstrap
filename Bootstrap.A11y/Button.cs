// Button.cs

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
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Contextual styles used on Bootstrap Buttons.
    /// </summary>
    public enum ButtonTypes
    {
        /// <summary>Default style (usually gray)</summary>
        Default = 0,
        /// <summary>Primary brand color</summary>
        Primary = 1,
        /// <summary>Indicates informational messages (usually light-blue)</summary>
        Info = 2,
        /// <summary>Indicates a successful or positive action (usually green)</summary>
        Success = 3,
        /// <summary>Indicates caution should be taken with this action (usually yellow-orange)</summary>
        Warning = 4,
        /// <summary>Indicates a dangerous or potentially negative action (usually red)</summary>
        Danger = 5,
        /// <summary>Inverted color scheme</summary>
        Inverse = 6,
        /// <summary>Deemphasize a button by making it look like a link while maintaining button behavior (buttons only)</summary>
        Link = 7
    }

    /// <summary>
    /// Represents a Bootstrap button.
    /// </summary>
    [ToolboxData("<{0}:Button runat=server />")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Button))]
    [DefaultProperty("Text")]
    [ParseChildren(true, "Content")]
    [PersistChildren(false)]
    public class Button : System.Web.UI.WebControls.Button, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Button" /> class.
        /// </summary>
        public Button()
        {
            this.ButtonType = ButtonTypes.Default;
            this.ButtonSize = ButtonSizes.Default;
            this.Block = false;
            this.Pressed = false;
            this.UseSubmitBehavior = true;
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
        /// Gets or sets a value indicating whether this <see cref="Button" /> is block.
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
        /// Gets or sets a value indicating whether this <see cref="Button"/> is pressed.
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
            // don't use submit behavior if popover is defined
            if (Popover != null)
            {
                UseSubmitBehavior = false;
            }
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
                    this.UseSubmitBehavior = false;
                    writer.AddAttribute("data-toggle", "modal");
                    writer.AddAttribute("data-target", "#" + modal.ClientID);
                }
            }

            if (this.Popover != null)
            {
                if (this.Popover.DismissOnNextClick)
                {
                    throw new InvalidOperationException("Popovers with DismissOnNextClick=\"true\" must be used on HyperLinkButton controls, not Button controls.");
                }
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
                if (!String.IsNullOrEmpty(this.Popover.Title))
                {
                    writer.AddAttribute("title", this.Popover.Title);
                }
            }

            if (!this.UseSubmitBehavior)
            {
                this.OnClientClick = String.Format("return {0};", StringHelper.ToLower(this.Popover != null));
            }

            this.CssClass = this.BuildCss();            
            this.Attributes.Add("type", "button");
            this.AddAttributesToRender(writer);
            writer.RenderBeginTag(HtmlTextWriterTag.Button);
        }

        /// <summary>
        /// Renders the HTML contents of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            string text = this.Text;
            bool hasText = !String.IsNullOrEmpty(text);
            if (hasText)
            {
                writer.Write(this.Text);
            }
            else if(this.Content != null)
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
            base.RenderContents(writer);
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            StringBuilder classes = new StringBuilder("btn");
            classes.Append(" btn-" + StringHelper.ToLower(this.ButtonType));
            classes.Append(ButtonSizesHelper.GetClassName(ButtonSize));
            StringHelper.AppendIf(classes, this.Block, " btn-block");
            StringHelper.AppendIf(classes, !this.Enabled, " disabled");
            StringHelper.AppendIf(classes, this.Pressed, " active");
            StringHelper.AppendWithSpaceIfNotEmpty(classes, this.CssClass);
            return classes.ToString();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event. This notifies the control to perform any steps necessary for its creation on a page request.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if(Popover != null)
            {
                Popover.RegisterJsInit(Page);
            }
        }
    }
}
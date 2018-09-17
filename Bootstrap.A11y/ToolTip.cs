// ToolTip.cs

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
    /// Represents a Bootstrap tooltip.
    /// </summary>
    [ToolboxData("<{0}:ToolTip runat=server />")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Label))]
    [DefaultProperty("Title")]
    [ParseChildren(true, "Content")]
    public class ToolTip : WebControl, INamingContainer
    {
        #region constructor 

        private const Triggers DEFAULT_TRIGGER = Triggers.Hover | Triggers.Focus;
        private const string DEFAULT_VIEWPORT = "body";

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTip" /> class.
        /// </summary>
        public ToolTip()
        {
            this.Placement = PopoverPositions.Right;
            this.Title = "";
            this.Animate = true;
            this.ContainerSelector = "";
            this.Delay = 0;
            this.IsHtml = false;
            this.Placement = PopoverPositions.Top;
            this.Trigger = DEFAULT_TRIGGER;
            this.ViewportSelector = DEFAULT_VIEWPORT;
            this.ViewportPadding = 0;
        }

        #endregion

        #region instance properties

        /// <summary>
        /// Gets or sets the title of the <see cref="ToolTip"/>.
        /// </summary>
        [Category("Behavior")]
        [DefaultValue("")]
        public string Title
        {
            get { return (string)this.ViewState["Title"]; }
            set { this.ViewState["Title"] = value; }
        }

        /// <summary>
        /// Gets or sets whether to apply a CSS fade transition to the tooltip.
        /// </summary>
        [Category("Behavior")]
        [DefaultValue(true)]
        public bool Animate
        {
            get { return (bool)this.ViewState["Animate"]; }
            set { this.ViewState["Animate"] = value; }
        }

        /// <summary>
        /// Gets or sets the delay in showing and hiding the tooltip (ms) - does not apply to manual <see cref="Trigger"/> type
        /// </summary>
        [Category("Behavior")]
        [DefaultValue(0)]
        public int Delay
        {
            get { return (int)this.ViewState["Delay"]; }
            set { this.ViewState["Delay"] = value; }
        }

        /// <summary>
        /// Gets or sets the selector for the element to append the tooltip to.
        /// </summary>
        /// <remarks>
        /// This option is particularly useful in that it allows you to position the tooltip in the flow of the document near the triggering element - which will prevent the tooltip from floating away from the triggering element during a window resize.
        /// </remarks>
        [Category("Behavior")]
        [DefaultValue("")]
        public string ContainerSelector
        {
            get { return (string)this.ViewState["ContainerSelector"]; }
            set { this.ViewState["ContainerSelector"] = value; }
        }

        /// <summary>
        /// Gets or sets how to position the tooltip.
        /// </summary>
        /// <remarks>
        /// When <c>Auto</c> is specified, it will dynamically reorient the tooltip. 
        /// For example, if placement is <c>Auto,Left</c>, the tooltip will display to the left when possible, otherwise it will display right.
        /// </remarks>
        [Category("Appearance")]
        [DefaultValue(PopoverPositions.Top)]
        public PopoverPositions Placement
        {
            get { return (PopoverPositions)this.ViewState["Placement"]; }
            set { this.ViewState["Placement"] = value; }
        }

        /// <summary>
        /// Gets or sets whether the <see cref="Content"/> contains HTML.
        /// </summary>
        /// <remarks>
        /// If <c>false</c>, jQuery's text method will be used to insert content into the DOM. 
        /// Use <c>false</c> if you're worried about XSS attacks.
        /// </remarks>
        [Category("Behavior")]
        [DefaultValue(false)]
        public bool IsHtml
        {
            get { return (bool)this.ViewState["IsHtml"]; }
            set { this.ViewState["IsHtml"] = value; }
        }

        /// <summary>
        /// Gets or sets how the tooltip is triggered.
        /// </summary>
        /// <remarks>
        /// You may pass multiple triggers; separate them with a comma. <c>Manual</c> cannot be combined with any other trigger.
        /// </remarks>
        [Category("Behavior")]
        [DefaultValue(DEFAULT_TRIGGER)]
        public Triggers Trigger
        {
            get { return (Triggers)this.ViewState["Trigger"]; }
            set { this.ViewState["Trigger"] = value; }
        }

        /// <summary>
        /// Gets or sets the selector for the element to keep the tooltip within.
        /// </summary>
        [Category("Behavior")]
        [DefaultValue(DEFAULT_VIEWPORT)]
        public string ViewportSelector
        {
            get { return (string)this.ViewState["ViewportSelector"]; }
            set { this.ViewState["ViewportSelector"] = value; }
        }

        /// <summary>
        /// Gets or sets the padding between the tooltip and the viewport.
        /// </summary>
        [Category("Behavior")]
        [DefaultValue(0)]
        public int ViewportPadding
        {
            get { return (int)this.ViewState["ViewportPadding"]; }
            set { this.ViewState["ViewportPadding"] = value; }
        }

        /// <summary>
        /// Gets or sets the contents of the tooltip.
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

        #endregion

        #region ClientScript 

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event. This notifies the control to perform any steps necessary for its creation on a page request.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (this.Visible)
            {
                RegisterJsInit(this.Page);
            }
        }

        internal static void RegisterJsInit(Page page)
        {
            // inject initialization javascript
            string js = "$(function () { $('[data-toggle=\"tooltip\"]').tooltip(); });";
            page.ClientScript.RegisterClientScriptBlock(typeof(ToolTip), "tooltip-init", js, true);
        }

        #endregion

        #region Render

        /// <summary>
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            writer.AddAttribute("data-toggle", "tooltip");
            writer.AddAttribute(HtmlTextWriterAttribute.Title, this.Title);
            if(!this.Animate)
            {
                writer.AddAttribute("data-animation", StringHelper.ToLower(this.Animate));
            }
            if(this.Delay > 0)
            { 
                writer.AddAttribute("data-delay", this.Delay.ToString());
            }
            if(this.IsHtml)
            {
                writer.AddAttribute("data-html", StringHelper.ToLower(this.IsHtml));
            }
            if(this.Placement != PopoverPositions.Top)
            {
                writer.AddAttribute("data-placement", PopoverPositionsHelper.ToString(this.Placement));
            }
            if(!String.IsNullOrEmpty(this.ContainerSelector))
            {
                writer.AddAttribute("data-container", this.ContainerSelector);
            }
            if (this.Trigger != DEFAULT_TRIGGER)
            {
                writer.AddAttribute("data-trigger", TriggersHelper.ToString(this.Trigger));
            }
            if (this.ViewportSelector != DEFAULT_VIEWPORT || this.ViewportPadding != 0)
            {
                writer.AddAttribute("data-viewport", String.Format("{{ selector: '{0}', padding: {1} }}", 
                    this.ViewportSelector, this.ViewportPadding));
            }
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            if (this.Content != null)
            {
                var contentsContainer = new Control();
                contentsContainer.ID = "contentsContainer";
                this.Content.InstantiateIn(contentsContainer);
                contentsContainer.RenderControl(writer);
            }
        }

        #endregion
    }

}
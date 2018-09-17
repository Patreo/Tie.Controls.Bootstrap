// Panel.cs

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
using System.Web.UI.HtmlControls;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Contextual styles used on Bootstrap panels and accordions.
    /// </summary>
    public enum PanelTypes
    {
        /// <summary>Default style (usually gray)</summary>
        Default = 0,
        /// <summary>Primary brand color</summary>
        Primary = 1,
        /// <summary>Indicates a successful or positive action (usually green)</summary>
        Success = 2,
        /// <summary>Indicates informational messages (usually light-blue)</summary>
        Info = 3,
        /// <summary>Indicates caution should be taken with this action (usually yellow-orange)</summary>
        Warning = 4,
        /// <summary>Indicates a dangerous or potentially negative action (usually red)</summary>
        Danger = 5
    }

    /// <summary>
    /// Represents a Bootstrap panel.
    /// </summary>
    [ToolboxData("<{0}:Panel runat=server></{0}:Panel>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Panel))]
    [ParseChildren(true, "Content")]
    [PersistChildren(false)]
    public class Panel : System.Web.UI.WebControls.Panel, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Panel"/> class.
        /// </summary>
        public Panel()
        {
            this.Title = "";
            this.TitleTag = HtmlTextWriterTag.Unknown;
            this.PanelType = PanelTypes.Default;
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string Title
        {
            get { return (string)this.ViewState["Title"]; }
            set { this.ViewState["Title"] = value; }
        }

        /// <summary>
        /// Gets or sets the tag type (typically a header like h3) to wrap around the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Category("Behavior")]
        [DefaultValue(HtmlTextWriterTag.Unknown)]
        public HtmlTextWriterTag TitleTag
        {
            get { return (HtmlTextWriterTag)this.ViewState["TitleTag"]; }
            set { this.ViewState["TitleTag"] = value; }
        }

        /// <summary>
        /// Gets or sets the type of the panel.
        /// </summary>
        /// <value>
        /// The type of the panel.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(PanelTypes.Default)]
        public PanelTypes PanelType
        {
            get { return (PanelTypes)this.ViewState["PanelType"]; }
            set { this.ViewState["PanelType"] = value; }
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
        /// Gets or sets contents that go within the "panel" div, but outside the "panel-body" div.
        /// </summary>
        /// <value>
        /// The contents.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(Panel))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate PostContent
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the footer contents.
        /// </summary>
        /// <value>
        /// The contents.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(Panel))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Footer
        {
            get;
            set;
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());
            base.Render(writer);
        }

        /// <summary>
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {          
            base.RenderBeginTag(writer);

            if (!String.IsNullOrEmpty(this.Title))
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "panel-heading");
                writer.RenderBeginTag(HtmlTextWriterTag.Div);
                HtmlTextWriterTag titleTag = this.TitleTag;
                if (titleTag == HtmlTextWriterTag.Unknown)
                {
                    writer.Write(this.Title);
                }
                else
                {
                    writer.AddAttribute(HtmlTextWriterAttribute.Class, "panel-title");
                    writer.RenderBeginTag(titleTag);
                    writer.Write(this.Title);
                    writer.RenderEndTag();
                }
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
            this.Controls.Clear();

            if (this.Content != null)
            {
                var contentsDiv = new HtmlGenericControl("div");
                contentsDiv.Attributes.Add("class", "panel-body");
                var contentsContainer = new Control();
                contentsContainer.ID = "contentsContainer";
                this.Content.InstantiateIn(contentsContainer);
                contentsDiv.Controls.Add(contentsContainer);
                this.Controls.Add(contentsDiv);
            }

            if (this.PostContent != null)
            {
                var postContainer = new Control();
                postContainer.ID = "postContainer";
                this.PostContent.InstantiateIn(postContainer);
                this.Controls.Add(postContainer);
            }

            if (this.Footer != null)
            {
                var footerDiv = new HtmlGenericControl("div");
                footerDiv.Attributes.Add("class", "panel-footer");
                var footerContainer = new Control();
                footerContainer.ID = "footerContainer";
                this.Footer.InstantiateIn(footerContainer);
                footerDiv.Controls.Add(footerContainer);
                this.Controls.Add(footerDiv);
            }
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            StringBuilder classes = new StringBuilder("panel");
            classes.Append(this.GetCssPanelType());
            StringHelper.AppendWithSpaceIfNotEmpty(classes, this.CssClass);
            return classes.ToString();
        }

        /// <summary>
        /// Gets the type of the CSS button.
        /// </summary>
        /// <returns></returns>
        private string GetCssPanelType()
        {
            switch (this.PanelType)
            {
                case PanelTypes.Primary:
                    return " panel-primary";

                case PanelTypes.Info:
                    return " panel-info";

                case PanelTypes.Success:
                    return " panel-success";

                case PanelTypes.Warning:
                    return " panel-warning";

                case PanelTypes.Danger:
                    return " panel-danger";

                default:
                    return " panel-default";
            }
        }
    }
}

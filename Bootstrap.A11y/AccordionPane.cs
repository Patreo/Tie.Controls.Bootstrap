// AccordionPane.cs

// Copyright (C) 2013 Francois Viljoen
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
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a pane within a Bootstrap accordion.
    /// </summary>
    [ToolboxData("<{0}:AccordionPane runat=server></{0}:AccordionPane>")]
    [ParseChildren(true, "Content")]
    [ToolboxItem(false)]
    public class AccordionPane : WebControl, INamingContainer
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AccordionPane"/> class.
        /// </summary>
        public AccordionPane() : base(HtmlTextWriterTag.Div)
        {
            this.Expanded = false;
            this.PanelType = null;
        }

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>
        /// The header.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(AccordionContentHeaderPanel))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Header
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(AccordionContentPanel))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Content
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets whether the pane is expanded.
        /// </summary>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Expanded
        {
            get { return (bool)this.ViewState["Expanded"]; }
            set { this.ViewState["Expanded"] = value; }
        }
        
        /// <summary>
        /// Gets or sets the type of the accordion panel.
        /// </summary>
        /// <value>
        /// The type of the panel.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(null)]
        public PanelTypes? PanelType
        {
            get { return (PanelTypes?)this.ViewState["PanelType"]; }
            set { this.ViewState["PanelType"] = value; }
        }

        /// <summary>
        /// Gets the ClientID for the <see cref="AccordionContentHeaderPanel"/>
        /// </summary>
        internal string HeadClientID
        {
            get { return this.ClientID + "-head"; }
        }

        /// <summary>
        /// Gets the ClientID for the <see cref="AccordionContentPanel"/>
        /// </summary>
        internal string BodyClientID
        {
            get { return this.ClientID + "-body"; }
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());
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
            var header = new AccordionContentHeaderPanel();
#if _4_0 || _4_5
            header.ClientIDMode = ClientIDMode.Static;
#endif
            header.ID = this.HeadClientID;
            this.Header.InstantiateIn(header);
            this.Controls.Clear();
            this.Controls.Add(header);
         
            var container = new AccordionContentPanel();
#if _4_0 || _4_5
            container.ClientIDMode = ClientIDMode.Static;
#endif
            container.ID = this.BodyClientID;
            this.Content.InstantiateIn(container);
            this.Controls.Add(container);
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            StringBuilder classes = new StringBuilder("panel");

            PanelTypes panelType = GetPanelType();
            if (panelType != PanelTypes.Default)
            {
                classes.Append(" panel-");
                classes.Append(StringHelper.ToLower(panelType));
            }

            StringHelper.AppendWithSpaceIfNotEmpty(classes, this.CssClass);
            return classes.ToString();
        }

        /// <summary>
        /// Gets the effective PanelType, coalescing this.PanelType, the parent AccordionControl's DefaultPanelType,
        /// and ContextStyles.Default.
        /// </summary>
        /// <returns>The first non-null PanelType.</returns>
        private PanelTypes GetPanelType()
        {
            if(this.PanelType.HasValue)
            {
                return this.PanelType.Value;
            }
            AccordionControl accordionControl = this.Parent as AccordionControl;
            if(accordionControl != null && accordionControl.DefaultPanelType.HasValue)
            {
                return accordionControl.DefaultPanelType.Value;
            }
            return PanelTypes.Default;
        }
    }
}
// AccordionControl.cs

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
using System.Web.UI;
using System.Web.UI.WebControls;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Bootstrap accordion.
    /// </summary>
    [ToolboxData("<{0}:AccordionControl runat=server></{0}:AccordionControl>")]
    [ParseChildren(true, "Panes")]
    public class AccordionControl : WebControl, INamingContainer
    {
        readonly AccordionPaneCollection _Panes;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccordionControl" /> class.
        /// </summary>
        public AccordionControl() : base(HtmlTextWriterTag.Div)
        {
            _Panes = new AccordionPaneCollection(this);
            this.ListGroup = false;
            this.MultiSelectable = false;
            this.HeaderTagType = "h4";
            this.DefaultPanelType = null;
        }

        /// <summary>
        /// Gets the tab pages.
        /// </summary>
        /// <value>
        /// The tab pages.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public AccordionPaneCollection Panes
        {
            get { return _Panes; }
        }

        /// <summary>
        /// Gets or sets whether or not the accordion should allow multiple tabs to be open at once.
        /// </summary>
        /// <value>
        /// The value that will be set as the aria-multiselectable attribute.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool MultiSelectable
        {
            get { return (bool)this.ViewState["MultiSelectable"]; }
            set { this.ViewState["MultiSelectable"] = value; }
        }

        /// <summary>
        /// Gets or set whether the panes should be rendered as a ListGroup.
        /// </summary>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool ListGroup
        {
            get { return (bool)this.ViewState["ListGroup"]; }
            set { this.ViewState["ListGroup"] = value; }
        }

        /// <summary>
        /// Gets or sets the tag type to use for the panel headers.
        /// </summary>
        /// <value>
        /// The tag name.
        /// </value>
        [Category("Appearance")]
        [DefaultValue("h4")]
        public string HeaderTagType
        {
            get { return (string)this.ViewState["HeaderTagType"]; }
            set { this.ViewState["HeaderTagType"] = value; }
        }

        /// <summary>
        /// Gets or sets the type of the accordion panel.
        /// </summary>
        /// <value>
        /// The type of the panel.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(null)]
        public PanelTypes? DefaultPanelType
        {
            get { return (PanelTypes?)this.ViewState["DefaultPanelType"]; }
            set { this.ViewState["DefaultPanelType"] = value; }
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
            // add ARIA markup
            writer.AddAttribute("role", "tablist");
            writer.AddAttribute("aria-multiselectable", StringHelper.ToLower(MultiSelectable));

            base.Render(writer);
        }

        /// <summary>
        /// Gets a <see cref="T:System.Web.UI.ControlCollection" /> object that represents the child controls for a specified server control in the UI hierarchy.
        /// </summary>
        /// <returns>
        /// The collection of child controls for the specified server control.
        ///   </returns>
        public override ControlCollection Controls
        {
            get
            {
                this.EnsureChildControls();
                return base.Controls;
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
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            return StringHelper.AppendWithSpaceIfNotEmpty("panel-group accordion", this.CssClass);
        }

    }
}
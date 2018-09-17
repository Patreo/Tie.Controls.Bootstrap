// TabPage.cs

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
using System.Web.UI;
using System.Web.UI.WebControls;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents an individual Bootstrap TabPage and holds the intermediary Tab page values.
    /// </summary>
    [ToolboxData("<{0}:TabPage runat=server></{0}:TabPage>")]
    [ToolboxItem(false)]
    [ParseChildren(true, "Content")]
    [PersistChildren(false)]
    public class TabPage : Control, INamingContainer
    {
        private PlaceHolder container;

        /// <summary>
        /// Initializes a new instance of the <see cref="TabPage" /> class.
        /// </summary>
        public TabPage()
        {
            this.Enabled = true;
            this.Title = this.ID;
            this.Index = 0;
        }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateInstance(TemplateInstance.Single)]
        [TemplateContainer(typeof(TabPage))]      
        public virtual ITemplate Content
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the container.
        /// </summary>
        /// <value>
        /// The container.
        /// </value>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PlaceHolder Container
        {
            get
            {
                this.EnsureChildControls();
                return this.container;
            }
            set
            {
                this.container = value;
            }
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

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [Localizable(true)]
        [DefaultValue("")]
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [Localizable(true)]
        [DefaultValue("")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TabPage" /> is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if enabled; otherwise, <c>false</c>.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [DefaultValue(true)]
        public bool Enabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        internal int Index
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
            TabControl tabControl = (TabControl)this.Parent;
            
            if (tabControl.AutoPostBack)
            {
                string postBackScript = this.Page.ClientScript.GetPostBackClientHyperlink(tabControl, this.Index.ToString());
                writer.AddAttribute(HtmlTextWriterAttribute.Onclick, postBackScript);
            }
            bool isActive = tabControl.ActiveTabPage == this.Index;

            writer.AddAttribute(HtmlTextWriterAttribute.Href, "#" + this.GetTabName());
            writer.AddAttribute(HtmlTextWriterAttribute.Id, this.GetTabName() + "-label");
            writer.AddAttribute("aria-controls", this.GetTabName());
            writer.AddAttribute("aria-expanded", StringHelper.ToLower(isActive));
            writer.AddAttribute("role", "tab");
            writer.AddAttribute("data-toggle", "tab");
            writer.RenderBeginTag(HtmlTextWriterTag.A);
            writer.Write(this.Title);
            writer.RenderEndTag();
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
                this.container = new PlaceHolder();
                this.Content.InstantiateIn(this.container);
                this.Controls.Add(this.container);
            }
        }

        /// <summary>
        /// Gets the name of the tab.
        /// </summary>
        /// <returns></returns>
        internal string GetTabName()
        {
            return (String.IsNullOrEmpty(Name) ? this.ClientID : Name);
        }
    }
}
// NavBar.cs

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
    /// Positions where a NavBar may occur.
    /// </summary>
    public enum Position
    {
        /// <summary>No position defined.</summary>
        None = 0,
        /// <summary>Top of page.</summary>
        Top = 1,
        /// <summary>Bottom of page.</summary>
        Bottom = 2
    }

    /// <summary>
    /// Represents a Bootstrap navigation bar.
    /// </summary>
    [ToolboxData("<{0}:NavBar runat=server></{0}:NavBar>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Menu))]
    [ParseChildren(true)]
    [PersistChildren(false)]
    public class NavBar : WebControl, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NavBar" /> class.
        /// </summary>
        public NavBar() : base("nav")
        {
            this.Position = Position.None;
            this.Inverted = true;
            this.Fixed = false;
            this.Collapsed = true;
            this.Fluid = true;
        }

        /// <summary>
        /// Gets or sets the brand.
        /// </summary>
        /// <value>
        /// The brand.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(NavBar))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Brand
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the content of the left.
        /// </summary>
        /// <value>
        /// The content of the left.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(NavBar))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate LeftContent
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the content of the right.
        /// </summary>
        /// <value>
        /// The content of the right.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(NavBar))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate RightContent
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(Position.None)]
        public Position Position
        {
            get { return (Position)this.ViewState["Position"]; }
            set { this.ViewState["Position"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="NavBar" /> is inverted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if inverted; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool Inverted
        {
            get { return (bool)this.ViewState["Inverted"]; }
            set { this.ViewState["Inverted"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="NavBar" /> is fixed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if fixed; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Fixed
        {
            get { return (bool)this.ViewState["Fixed"]; }
            set { this.ViewState["Fixed"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="NavBar" /> is collapsed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if collapsed; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool Collapsed
        {
            get { return (bool)this.ViewState["Collapsed"]; }
            set { this.ViewState["Collapsed"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="NavBar" />'s container is fluid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if fluid; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool Fluid
        {
            get { return (bool)this.ViewState["Fluid"]; }
            set { this.ViewState["Fluid"] = value; }
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Id, this.ClientID);
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());

            base.Render(writer);
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            string containerClass = Fluid ? "container-fluid" : "container";
            writer.AddAttribute(HtmlTextWriterAttribute.Class, containerClass);
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
           
            this.RenderChildren(writer);

            writer.RenderEndTag(); // Close Div   
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

            if (this.Brand != null)
            {
                var brandItem = new Control();
                this.Brand.InstantiateIn(brandItem);
                this.Controls.Add(brandItem);
            }

            System.Web.UI.WebControls.Panel panel = new System.Web.UI.WebControls.Panel();
            panel.CssClass = "navbar-collapse";
            if (Collapsed)
            {
                panel.CssClass += " collapse";
            }
            panel.ID = "bs-navbar-collapse";

            if (this.LeftContent != null)
            {
                var leftItem = new Control();
                leftItem.ID = "navbar-left";
                this.LeftContent.InstantiateIn(leftItem);
                panel.Controls.Add(leftItem);
            }

            if (this.RightContent != null)
            {
                var rightItem = new Control();
                rightItem.ID = "navbar-right";
                this.RightContent.InstantiateIn(rightItem);
                panel.Controls.Add(rightItem);
            }

            this.Controls.Add(panel);
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            StringBuilder classes = new StringBuilder("navbar");
            classes.Append(this.Inverted ? " navbar-inverse" : " navbar-default");
            classes.Append(GetPositionClass());
            StringHelper.AppendWithSpaceIfNotEmpty(classes, this.CssClass);
            return classes.ToString();
        }

        private string GetPositionClass()
        {
            switch (this.Position)
            {
                case Position.Top:
                case Position.Bottom:
                    string fixedStatic = this.Fixed ? "fixed" : "static";
                    return String.Format(" navbar-{0}-{1}", fixedStatic, StringHelper.ToLower(this.Position));
                case Position.None:
                default:
                    // no class needed
                    return String.Empty;
            }
        }
    }
}

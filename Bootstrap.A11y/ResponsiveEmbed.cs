// ResponsiveEmbed.cs

// Copyright (C) 2018 Kinsey Roberts (@kinzdesign), Weatherhead School of Management (@wsomweb)

// This program is free software; you can redistribute it and/or modify it under the terms of the GNU 
// General Public License as published by the Free Software Foundation; either version 2 of the 
// License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See 
// the GNU General Public License for more details. You should have received a copy of the GNU 
// General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 
// Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Bootstrap responsive embed.
    /// </summary>
    [ToolboxData("<{0}:ResponsiveEmbed runat=server></{0}:ResponsiveEmbed>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Image))]
    [ParseChildren(true, "Content")]
    [PersistChildren(false)]
    public class ResponsiveEmbed : WebControl, INamingContainer
    {
        const AspectRatios DEFAULT_ASPECT = AspectRatios.SixteenByNine;

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
        /// Gets or sets the aspect ratio.
        /// </summary>
        /// <value>
        /// The aspect ratio.
        /// </value>
        [Category("Layout")]
        [DefaultValue(DEFAULT_ASPECT)]
        public AspectRatios AspectRatio
        {
            get { return (AspectRatios)this.ViewState["AspectRatio"]; }
            set { this.ViewState["AspectRatio"] = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsiveEmbed" /> class.
        /// </summary>
        public ResponsiveEmbed() : base(HtmlTextWriterTag.Div)
        {
            this.AspectRatio = DEFAULT_ASPECT;
        }

        /// <summary>
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            ControlHelper.EnsureCssClassPresent(this, "embed-responsive");
            ControlHelper.EnsureCssClassPresent(this, "embed-responsive-" + AspectRatiosHelper.ToString(this.AspectRatio));
            base.RenderBeginTag(writer);
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
                var contentsContainer = new Control();
                contentsContainer.ID = "contentsContainer";
                this.Content.InstantiateIn(contentsContainer);
                this.Controls.Add(contentsContainer);
            }
        }
    }
}

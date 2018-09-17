// MediaObject.cs

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
    /// Image alignment direction
    /// </summary>
    public enum ImageAlign : byte
    {
        /// <summary>Image goes on the left</summary>
        Left = 0,
        /// <summary>Image goes on the right</summary>
        Right = 1
    }

    /// <summary>
    /// Represents a Bootstrap media object.
    /// </summary>
    [ToolboxData("<{0}:MediaObject runat=server></{0}:MediaObject>")]
    [DefaultProperty("Title")]
    [ParseChildren(true, "Content")]
    [PersistChildren(false)]
    public class MediaObject : WebControl, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaObject" /> class.
        /// </summary>
        public MediaObject()
        {
            this.Title = "";
            this.TitleTag = HtmlTextWriterTag.H4;
            this.ImageAlign = ImageAlign.Left;
            VerticalAlign = VerticalAlign.NotSet;
            this.NavigationUrl = "#";
        }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(MediaObject))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Content
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the image align.
        /// </summary>
        /// <value>
        /// The image align.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(ImageAlign.Left)]
        public ImageAlign ImageAlign
        {
            get { return (ImageAlign)this.ViewState["ImageAlign"]; }
            set { this.ViewState["ImageAlign"] = value; }
        }

        /// <summary>
        /// Gets or sets the vertical alignment.
        /// </summary>
        /// <value>
        /// The vertical alignment.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(VerticalAlign.NotSet)]
        public VerticalAlign VerticalAlign
        {
            get { return (VerticalAlign)this.ViewState["VerticalAlign"]; }
            set { this.ViewState["VerticalAlign"] = value; }
        }

        /// <summary>
        /// Gets or sets the navigation URL.
        /// </summary>
        /// <value>
        /// The navigation URL.
        /// </value>
        [Category("Link")]
        [DefaultValue("#")]
        public string NavigationUrl
        {
            get { return (string)this.ViewState["NavigationUrl"]; }
            set { this.ViewState["NavigationUrl"] = value; }
        }


        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Category("Appearance")]
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
        [DefaultValue(HtmlTextWriterTag.H4)]
        public HtmlTextWriterTag TitleTag
        {
            get { return (HtmlTextWriterTag)this.ViewState["TitleTag"]; }
            set { this.ViewState["TitleTag"] = value; }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Category("Appearance")]
        [DefaultValue("")]
        public string Description
        {
            get { return (string)this.ViewState["Description"]; }
            set { this.ViewState["Description"] = value; }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Category("Appearance")]
        [DefaultValue("")]
        [UrlProperty]
        public string ImageUrl
        {
            get { return (string)this.ViewState["ImageUrl"]; }
            set { this.ViewState["ImageUrl"] = value; }
        }

        /// <summary>
        /// Gets or sets the image's alt text.
        /// </summary>
        /// <value>
        /// The alt text.
        /// </value>
        [Category("Appearance")]
        [DefaultValue("")]
        public string AlternativeText
        {
            get { return (string)this.ViewState["AlternativeText"]; }
            set { this.ViewState["AlternativeText"] = value; }
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

            base.Render(writer);
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            if (ImageAlign == Bootstrap.A11y.ImageAlign.Left)
            {
                this.RenderImage(writer);
            }
            
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "media-body");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            this.RenderTitle(writer);
            this.RenderDescription(writer);

            writer.RenderBeginTag(HtmlTextWriterTag.Div);
            this.RenderChildren(writer);
            writer.RenderEndTag();

            writer.RenderEndTag(); // Div   

            if (ImageAlign == Bootstrap.A11y.ImageAlign.Right)
            {
                this.RenderImage(writer);
            }
        }

        /// <summary>
        /// Renders the image.
        /// </summary>
        /// <param name="output">The output.</param>
        private void RenderImage(HtmlTextWriter output)
        {
            output.AddAttribute(HtmlTextWriterAttribute.Class, BuildMediaCss());
            output.RenderBeginTag(HtmlTextWriterTag.Div);
            
            output.AddAttribute(HtmlTextWriterAttribute.Href, ResolveUrl(this.NavigationUrl));
            output.RenderBeginTag(HtmlTextWriterTag.A);            

            output.AddAttribute(HtmlTextWriterAttribute.Class, "media-object");
            output.AddAttribute("data-src", this.ImageUrl);
            output.AddAttribute("src", this.ImageUrl);
            output.AddAttribute("alt", AlternativeText);
            output.RenderBeginTag(HtmlTextWriterTag.Img);
            output.RenderEndTag(); // Img
            output.RenderEndTag(); // A
            output.RenderEndTag(); // Div
        }

        private string BuildMediaCss()
        {
            string horizontal = StringHelper.ToLower(ImageAlign);
            string vertical = GetVerticalSubclass();
            return String.Format("media-{0} media-{1}", horizontal, vertical);
        }

        private string GetVerticalSubclass()
        {
            if (VerticalAlign == VerticalAlign.Middle)
            {
                return "middle";
            }
            else if (VerticalAlign == VerticalAlign.Bottom)
            {
                return "bottom";
            }
            else
            {
                return "top";
            }

        }

        /// <summary>
        /// Renders the title.
        /// </summary>
        /// <param name="output">The output.</param>
        private void RenderTitle(HtmlTextWriter output)
        {
            output.AddAttribute(HtmlTextWriterAttribute.Class, "media-heading");
            output.RenderBeginTag(this.TitleTag);
            output.Write(this.Title);
            output.RenderEndTag();
        }

        /// <summary>
        /// Renders the description.
        /// </summary>
        /// <param name="output">The output.</param>
        private void RenderDescription(HtmlTextWriter output)
        {
            output.RenderBeginTag(HtmlTextWriterTag.P);
            output.Write(this.Description);
            output.RenderEndTag();
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
            this.Content.InstantiateIn(container);

            this.Controls.Clear();
            this.Controls.Add(container);
        }

        private string BuildCss()
        {
            return StringHelper.AppendWithSpaceIfNotEmpty("media", this.CssClass);
        }
    }
}

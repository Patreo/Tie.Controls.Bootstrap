// CarouselItem.cs

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

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents an item in a Bootstrap <see cref="Carousel"/>.
    /// </summary>
    [ToolboxData("<{0}:CarouselItem runat=server></{0}:CarouselItem>")]
    [ToolboxItem(false)]
    [ParseChildren(true)]
    [PersistChildren(false)]
    public class CarouselItem : Control, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarouselItem" /> class.
        /// </summary>
        public CarouselItem()
        {
            this.Text = "";
            this.AltText = "";
            this.Title = "";
            this.ImageUrl = "";
            this.NavigateUrl = String.Empty;
            this.TitleTag = HtmlTextWriterTag.H3;
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
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [Localizable(true)]
        [DefaultValue("")]
        public string Text
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the alternative image text.
        /// </summary>
        /// <value>
        /// The alternative image text.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [Localizable(true)]
        [DefaultValue("")]
        public string AltText
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [DefaultValue("")]
        public string ImageUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the URL to navigate to.
        /// </summary>
        /// <value>
        /// The URL to navigate to.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [DefaultValue("")]
        public string NavigateUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the title tag type.
        /// </summary>
        /// <value>
        /// The title tag type.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [Localizable(true)]
        [DefaultValue("h3")]
        public HtmlTextWriterTag TitleTag
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
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            if(String.IsNullOrEmpty(NavigateUrl))
            {
                writer.RenderBeginTag(HtmlTextWriterTag.Div);
            }
            else
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Href, ResolveUrl(this.NavigateUrl));
                writer.RenderBeginTag(HtmlTextWriterTag.A);
            }

            if (!String.IsNullOrEmpty(this.ImageUrl))
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Src, ResolveUrl(this.ImageUrl));
                writer.AddAttribute(HtmlTextWriterAttribute.Alt, String.IsNullOrEmpty(this.AltText) ? this.Title : this.AltText);
                writer.RenderBeginTag(HtmlTextWriterTag.Img);
                writer.RenderEndTag();
            }

            bool hasTitle = !String.IsNullOrEmpty(this.Title);
            bool hasText = !String.IsNullOrEmpty(this.Text);
            bool hasContent = this.Content != null;

            if (hasTitle || hasText)
            {
                if (hasContent)
                {
                    throw new InvalidOperationException("If Content is defined, Title and Text must not be defined");
                }

                writer.AddAttribute(HtmlTextWriterAttribute.Class, "carousel-caption");
                writer.RenderBeginTag(HtmlTextWriterTag.Div);

                if (hasTitle)
                {
                    writer.RenderBeginTag(TitleTag);
                    writer.Write(this.Title);
                    writer.RenderEndTag(); // TitleTag
                }

                if (hasText)
                {
                    writer.RenderBeginTag(HtmlTextWriterTag.P);
                    writer.Write(this.Text);
                    writer.RenderEndTag(); // P
                }

                writer.RenderEndTag(); // Div            
            }
            else if (hasContent)
            {
                var contentsContainer = new PlaceHolder();
                this.Content.InstantiateIn(contentsContainer);
                contentsContainer.RenderControl(writer);
            }
            else
            {
                throw new InvalidOperationException("At least one of Content, Title, or Text must be defined");
            }

            writer.RenderEndTag(); // A or Div            

            base.Render(writer);
        }
    }
}

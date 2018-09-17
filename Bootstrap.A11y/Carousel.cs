// Carousel.cs

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

using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Bootstrap carousel.
    /// </summary>
    /// <remarks>
    /// A slideshow component for cycling through elements, like a carousel.
    /// </remarks>
    [ToolboxData("<{0}:Carousel runat=server></{0}:Carousel>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Image))]
    [ParseChildren(true, "Items")]
    [PersistChildren(false)]
    public class Carousel : AccessibleWebControl, INamingContainer
    {
        readonly CarouselCollection _Items;

        /// <summary>
        /// Initializes a new instance of the <see cref="Carousel" /> class.
        /// </summary>
        public Carousel()
        {
            _Items = new CarouselCollection(this);
            this.ActiveCarouselItem = 0;
            this.TitleTag = HtmlTextWriterTag.H2;
            this.RightArrowClass = "glyphicon glyphicon-chevron-right";
            this.LeftArrowClass = "glyphicon glyphicon-chevron-left";
            this.Interval = 0;
            this.Wrap = true;
            this.KeyboardEvents = true;
            this.PauseType = PauseTypes.Hover;
            this.ShowIndicators = true;
            this.ShowArrows = true;
        }

        /// <summary>
        /// The zero-based index of the currently active item.
        /// </summary>
        [Category("Appearance")]
        [DefaultValue(true)]
        public int ActiveCarouselItem
        {
            get { return (int)this.ViewState["ActiveCarouselItem"]; }
            set { this.ViewState["ActiveCarouselItem"] = value; }
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
        [DefaultValue("H2")]
        public HtmlTextWriterTag TitleTag
        {
            get { return (HtmlTextWriterTag)this.ViewState["TitleTag"]; }
            set { this.ViewState["TitleTag"] = value; }
        }

        /// <summary>
        /// Gets or sets the class assigned to the right indicator arrow.
        /// </summary>
        /// <value>
        /// The CSS class to set on the right arrow.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [Localizable(true)]
        [DefaultValue("glyphicon glyphicon-chevron-right")]
        public string RightArrowClass
        {
            get { return (string)this.ViewState["RightArrowClass"]; }
            set { this.ViewState["RightArrowClass"] = value; }
        }

        /// <summary>
        /// Gets or sets the class assigned to the left indicator arrow.
        /// </summary>
        /// <value>
        /// The CSS class to set on the left arrow.
        /// </value>
        [NotifyParentProperty(true)]
        [Browsable(true)]
        [Localizable(true)]
        [DefaultValue("glyphicon glyphicon-chevron-left")]
        public string LeftArrowClass
        {
            get { return (string)this.ViewState["LeftArrowClass"]; }
            set { this.ViewState["LeftArrowClass"] = value; }
        }

        /// <summary>
        /// Gets or sets the amount of time to delay between automatically cycling an item (in milliseconds). 
        /// Zero or negative values will disable automatic cycling.
        /// </summary>
        /// <value>
        /// The amount of time to delay between automatically cycling an item.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(0)]
        public int Interval
        {
            get { return (int)this.ViewState["Interval"]; }
            set { this.ViewState["Interval"] = value; }
        }

        /// <summary>
        /// Specifies when to pause a <see cref="Carousel"/>'s cycling.
        /// </summary>
        public enum PauseTypes : byte
        {
            /// <summary>Hovering over the carousel won't pause it</summary>
            Null = 0,
            /// <summary>Pauses the cycling of the carousel on MouseEnter and resumes the cycling of the carousel on MouseLeave.</summary>
            Hover = 1,
            /// <summary>Pauses the cycling of the carousel when the mouse enters the control.</summary>
            MouseEnter = 2,
            /// <summary>Pauses the cycling of the carousel when the mouse leaves the control.</summary>
            MouseLeave = 3
        }

        /// <summary>
        /// Gets or sets the amount of time to delay between automatically cycling an item (in milliseconds). 
        /// Zero or negative values will disable automatic cycling.
        /// </summary>
        /// <value>
        /// The amount of time to delay between automatically cycling an item.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(PauseTypes.Hover)]
        public PauseTypes PauseType
        {
            get { return (PauseTypes)this.ViewState["PauseType"]; }
            set { this.ViewState["PauseType"] = value; }
        }

        /// <summary>
        /// Whether the carousel should cycle continuously or have hard stops.
        /// </summary>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool Wrap
        {
            get { return (bool)this.ViewState["Wrap"]; }
            set { this.ViewState["Wrap"] = value; }
        }

        /// <summary>
        /// Whether the carousel should react to keyboard events.
        /// </summary>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool KeyboardEvents
        {
            get { return (bool)this.ViewState["KeyboardEvents"]; }
            set { this.ViewState["KeyboardEvents"] = value; }
        }

        /// <summary>
        /// Whether the carousel indicators should be shown.
        /// </summary>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool ShowIndicators
        {
            get { return (bool)this.ViewState["ShowIndicators"]; }
            set { this.ViewState["ShowIndicators"] = value; }
        }

        /// <summary>
        /// Whether the carousel arrows should be shown.
        /// </summary>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool ShowArrows
        {
            get { return (bool)this.ViewState["ShowArrows"]; }
            set { this.ViewState["ShowArrows"] = value; }
        }

        /// <summary>
        /// Gets the tab pages.
        /// </summary>
        /// <value>
        /// The tab pages.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        public CarouselCollection Items
        {
            get { return _Items; }
        }
     
        /// <summary>
        /// Renders the HTML end tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
            this.RenderArrows(writer);
            writer.RenderEndTag();
        }

        /// <summary>
        /// Renders the control's arrows into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected virtual void RenderArrows(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, AddSrOnlyIf("left carousel-control", !this.ShowArrows));
            writer.AddAttribute(HtmlTextWriterAttribute.Href, "#" + this.ClientID);
            writer.AddAttribute("role", "button");
            writer.AddAttribute("data-slide", "prev");
            writer.RenderBeginTag(HtmlTextWriterTag.A);

            writer.AddAttribute(HtmlTextWriterAttribute.Class, LeftArrowClass);
            writer.AddAttribute("aria-hidden", "true");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.RenderEndTag(); // Span

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "sr-only");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.Write("Previous");
            writer.RenderEndTag(); // Span
            writer.RenderEndTag(); // A

            writer.AddAttribute(HtmlTextWriterAttribute.Class, AddSrOnlyIf("right carousel-control", !this.ShowArrows));
            writer.AddAttribute(HtmlTextWriterAttribute.Href, "#" + this.ClientID);
            writer.AddAttribute("role", "button");
            writer.AddAttribute("data-slide", "next");
            writer.RenderBeginTag(HtmlTextWriterTag.A);

            writer.AddAttribute(HtmlTextWriterAttribute.Class, RightArrowClass);
            writer.AddAttribute("aria-hidden", "true");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.RenderEndTag(); // Span

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "sr-only");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.Write("Next");
            writer.RenderEndTag(); // Span
            writer.RenderEndTag(); // A
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
            writer.AddAttribute("data-ride", "carousel");
            writer.AddAttribute("data-interval", Interval > 0 ? Interval.ToString() : "false");
            writer.AddAttribute("data-pause", StringHelper.ToLower(this.PauseType));
            writer.AddAttribute("data-wrap", StringHelper.ToLower(this.Wrap));
            writer.AddAttribute("data-keyboard", StringHelper.ToLower(this.KeyboardEvents));

            base.Render(writer);
        }

        /// <summary>
        /// Renders the HTML contents of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            this.RenderIndicators(writer);
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "carousel-inner");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            for (int i = 0; i < this.Items.Count; i++)
            {
                CarouselItem item = this.Items[i];

                bool isActive = this.ActiveCarouselItem == i;

                string cssClass = StringHelper.AppendIf("item", isActive, " active");
                writer.AddAttribute(HtmlTextWriterAttribute.Class, cssClass);
                writer.RenderBeginTag(HtmlTextWriterTag.Div);               
                item.RenderControl(writer);
                writer.RenderEndTag(); // Div
            }
            
            writer.RenderEndTag(); // Div
        }

        /// <summary>
        /// Renders the control's indicators into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected virtual void RenderIndicators(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, AddSrOnlyIf("carousel-indicators", !this.ShowIndicators));
            writer.RenderBeginTag(HtmlTextWriterTag.Ol);

            for (int i = 0; i < this.Items.Count; i++)
            {
                bool isActive = this.ActiveCarouselItem == i;

                if (isActive)
                {
                    writer.AddAttribute(HtmlTextWriterAttribute.Class, "active");
                }
                writer.AddAttribute("data-target", "#" + this.ClientID);
                writer.AddAttribute("data-slide-to", i.ToString());
                writer.RenderBeginTag(HtmlTextWriterTag.Li);
                writer.RenderEndTag(); // Li
            }

            writer.RenderEndTag(); // Ol
        }

        private static string AddSrOnlyIf(string baseClass, bool condition)
        {
            return StringHelper.AppendIf(baseClass, condition, " sr-only");
        }

        /// <summary>
        /// Notifies the server control that an element, either XML or HTML, was parsed, and adds the element to the server control's <see cref="T:System.Web.UI.ControlCollection" /> object.
        /// </summary>
        /// <param name="obj">An <see cref="T:System.Object" /> that represents the parsed element.</param>
        protected override void AddParsedSubObject(object obj)
        {
            CarouselItem item = obj as CarouselItem;
            if (item != null)
            {
                this.Items.Add(item);
            }
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
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            return StringHelper.AppendWithSpaceIfNotEmpty("carousel slide", this.CssClass);
        }
    }
}
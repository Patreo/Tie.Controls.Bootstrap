// AccordionContentHeaderPanel.cs

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
    /// Represents the header contents of an <see cref="AccordionPane"/>.
    /// </summary>
    [ToolboxItem(false)]
    public class AccordionContentHeaderPanel : WebControl, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccordionContentHeaderPanel" /> class.
        /// </summary>
        public AccordionContentHeaderPanel() : base(HtmlTextWriterTag.Div)
        {
            // nothing to do here
        }

        /// <summary>
        /// Renders the HTML end tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            ControlHelper.EnsureCssClassPresent(this, "panel-heading");
            this.Attributes["role"] = "tab";
            base.RenderBeginTag(writer);
        }

        /// <summary>
        /// Renders the HTML contents of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            AccordionPane pane = this.Parent as AccordionPane;
            if (pane == null)
            {
                throw new System.InvalidCastException("AccordionContentHeaderPanel must be the child of an AccordionPane");
            }
            AccordionControl accordion = this.Parent.Parent as AccordionControl;
            if (accordion == null)
            {
                throw new System.InvalidCastException("AccordionContentHeaderPanel must be the grandchild of an AccordionControl");
            }

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "panel-title");
            writer.RenderBeginTag(accordion.HeaderTagType);

            writer.AddAttribute(HtmlTextWriterAttribute.Href, "#" + pane.BodyClientID);
            writer.AddAttribute("role", "button");
            writer.AddAttribute("data-toggle", "collapse");
            // leave off data-parent if MultiSelectable is true on the AccordionControl
            if (!accordion.MultiSelectable)
            {
                writer.AddAttribute("data-parent", "#" + accordion.ClientID);
            }
            // add ARIA markup
            writer.AddAttribute("aria-expanded", StringHelper.ToLower(pane.Expanded));
            writer.AddAttribute("aria-controls", pane.BodyClientID);

            writer.RenderBeginTag(HtmlTextWriterTag.A);

            base.RenderContents(writer);

            writer.RenderEndTag();
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
    }
}
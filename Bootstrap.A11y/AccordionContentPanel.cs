// AccordionContentPanel.cs

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
    /// Represents the body contents of an <see cref="AccordionPane"/>.
    /// </summary>
    [ToolboxItem(false)]
    public class AccordionContentPanel : WebControl, INamingContainer
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="AccordionContentPanel" /> class.
        /// </summary>
        public AccordionContentPanel() : base(HtmlTextWriterTag.Div)
        {
            // nothing to do here
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            this.CssClass = this.BuildCss();
            // add ARIA markup
            writer.AddAttribute("role", "tabpanel");
            // grab AccordionContentHeaderPanel's ClientID
            foreach (Control ctrl in Parent.Controls)
            {
                if (ctrl is AccordionContentHeaderPanel)
                {
                    writer.AddAttribute("aria-labelledby", ctrl.ClientID);
                    break;
                }
            }

            base.Render(writer);
        }

        /// <summary>
        /// Renders the HTML contents of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            if (((AccordionControl)this.Parent.Parent).ListGroup)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "list-group");
            }
            else
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "panel-body");
            }
            
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            this.RenderChildren(writer);
            
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
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            StringBuilder classes = new StringBuilder("panel-collapse collapse");
            StringHelper.AppendIf(classes, ((AccordionPane)this.Parent).Expanded, " in");
            StringHelper.AppendWithSpaceIfNotEmpty(classes, this.CssClass);
            return classes.ToString();
        }

    }
}
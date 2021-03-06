﻿// Column.cs

// Copyright (C) 2013 Pedro Fernandes

// This program is free software; you can redistribute it and/or modify it under the terms of the GNU 
// General Public License as published by the Free Software Foundation; either version 2 of the 
// License, or (at your option) any later version.

// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See 
// the GNU General Public License for more details. You should have received a copy of the GNU 
// General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 
// Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tie.Controls.Bootstrap
{
    [ToolboxData("<{0}:Column runat=server></{0}:Column>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Panel))]
    [DefaultProperty("CssClass")]
    [ParseChildren(true, "Content")]
    [PersistChildren(false)]
    public class Column : WebControl, INamingContainer
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Container"/> class.
        /// </summary>
        public Column()
            : base()
        {
            this.ExtraSmall = 12;
            this.Small = 12;
            this.Medium = 12;
            this.Large = 12;
        }

        /// <summary>
        /// Gets or sets the extra small.
        /// </summary>
        /// <value>
        /// The extra small.
        /// </value>
        [Category("Size")]
        [DefaultValue(12)]
        public int ExtraSmall
        {
            get { return (int)ViewState["ExtraSmall"]; }
            set { ViewState["ExtraSmall"] = value; }
        }

        /// <summary>
        /// Gets or sets the small.
        /// </summary>
        /// <value>
        /// The small.
        /// </value>
        [Category("Size")]
        [DefaultValue(12)]
        public int Small
        {
            get { return (int)ViewState["Small"]; }
            set { ViewState["Small"] = value; }
        }

        /// <summary>
        /// Gets or sets the medium.
        /// </summary>
        /// <value>
        /// The medium.
        /// </value>
        [Category("Size")]
        [DefaultValue(12)]
        public int Medium
        {
            get { return (int)ViewState["Medium"]; }
            set { ViewState["Medium"] = value; }
        }

        /// <summary>
        /// Gets or sets the large.
        /// </summary>
        /// <value>
        /// The large.
        /// </value>
        [Category("Size")]
        [DefaultValue(12)]
        public int Large
        {
            get { return (int)ViewState["Large"]; }
            set { ViewState["Large"] = value; }
        }

        /// <summary>
        /// Gets or sets the rows.
        /// </summary>
        /// <value>
        /// The rows.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(Column))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Content
        {
            get;
            set;
        }

        /// <summary>
        /// Renders the HTML opening tag of the control to the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
        }

        /// <summary>
        /// Renders the HTML closing tag of the control into the specified writer. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
            writer.RenderEndTag();
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Id, this.ClientID);
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());

            if (DesignMode)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Style, "width:100%;height:20px;border:solid 1px #000;");
            }

            base.Render(writer);
        }

        /// <summary>
        /// Renders the contents.
        /// </summary>
        /// <param name="output">The output.</param>
        protected override void RenderContents(HtmlTextWriter output)
        {
            this.RenderChildren(output);
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event.
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

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            string str = "";

            str += " col-xs-" + this.ExtraSmall;
            str += " col-sm-" + this.Small;
            str += " col-md-" + this.Medium;
            str += " col-lg-" + this.Large;

            if (!String.IsNullOrEmpty(this.CssClass))
            {
                str += " " + this.CssClass;
            }

            return str.Trim();
        }
    }
}

// GridView.cs

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
using System.Text;
using System.Web.UI;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Bootstrap grid view.
    /// </summary>
    public class GridView : System.Web.UI.WebControls.GridView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GridView"/> class.
        /// </summary>
        public GridView()
        {
            this.GridLines = System.Web.UI.WebControls.GridLines.None;
            this.Condensed = false;
            this.HoverRow = false;
            this.Striped = false;
            this.Responsive = true;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="GridView"/> is condensed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if condensed; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Condensed
        {
            get { return (bool)this.ViewState["Condensed"]; }
            set { this.ViewState["Condensed"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [hover row].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [hover row]; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool HoverRow
        {
            get { return (bool)this.ViewState["HoverRow"]; }
            set { this.ViewState["HoverRow"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="GridView"/> is striped.
        /// </summary>
        /// <value>
        ///   <c>true</c> if striped; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Striped
        {
            get { return (bool)this.ViewState["Striped"]; }
            set { this.ViewState["Striped"] = value; }
        }

        /// <summary>
        /// Obsolete field indicating whether this <see cref="GridView"/> is striped.
        /// </summary>
        [Obsolete("Use Striped")]
        public bool Stripped
        {
            get { return Striped; }
            set { Striped = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="GridView"/> is responsive.
        /// </summary>
        /// <value>
        ///   <c>true</c> if responsive; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool Responsive
        {
            get { return (bool)this.ViewState["Responsive"]; }
            set { this.ViewState["Responsive"] = value; }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.PreRender" /> event. This notifies the control to perform any steps necessary for its creation on a page request.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnPreRender(EventArgs e)
        {
            this.UseAccessibleHeader = true;

            if (this.HeaderRow != null)
            {
                this.HeaderRow.TableSection = System.Web.UI.WebControls.TableRowSection.TableHeader;
            }
            
            base.OnPreRender(e);
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            if (this.Responsive)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "table-responsive");
                writer.RenderBeginTag(HtmlTextWriterTag.Div);
            }

            this.CssClass = BuildCss();
            base.Render(writer);

            if (this.Responsive)
            {
                writer.RenderEndTag();
            }
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            StringBuilder classes = new StringBuilder("table");
            StringHelper.AppendIf(classes, this.Condensed, " table-condensed");
            StringHelper.AppendIf(classes, this.HoverRow, " table-hover");
            StringHelper.AppendIf(classes, this.Striped, " table-striped");
            if (this.GridLines != System.Web.UI.WebControls.GridLines.None)
            {
                this.GridLines = System.Web.UI.WebControls.GridLines.None;
                classes.Append(" table-bordered");
            }
            StringHelper.AppendWithSpaceIfNotEmpty(classes, this.CssClass);
            return classes.ToString();
        }
    }
}

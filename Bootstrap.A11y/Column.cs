// Column.cs

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
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a column in the Bootstrap grid system.
    /// </summary>
    [ToolboxData("<{0}:Column runat=server></{0}:Column>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Panel))]
    [DefaultProperty("CssClass")]
    [ParseChildren(true, "Content")]
    [PersistChildren(false)]
    public class Column : WebControl, INamingContainer
    {
        /// <summary>
        /// Gets or sets the extra small.
        /// </summary>
        /// <value>
        /// The extra small.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? ExtraSmall
        {
            get { return (int?)this.ViewState["ExtraSmall"]; }
            set { this.ViewState["ExtraSmall"] = value; }
        }

        /// <summary>
        /// Gets or sets the small.
        /// </summary>
        /// <value>
        /// The small.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? Small
        {
            get { return (int?)this.ViewState["Small"]; }
            set { this.ViewState["Small"] = value; }
        }

        /// <summary>
        /// Gets or sets the medium.
        /// </summary>
        /// <value>
        /// The medium.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? Medium
        {
            get { return (int?)this.ViewState["Medium"]; }
            set { this.ViewState["Medium"] = value; }
        }

        /// <summary>
        /// Gets or sets the large.
        /// </summary>
        /// <value>
        /// The large.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? Large
        {
            get { return (int?)this.ViewState["Large"]; }
            set { this.ViewState["Large"] = value; }
        }

        /// <summary>
        /// Gets or sets the extra small offset.
        /// </summary>
        /// <value>
        /// The extra small offset.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? ExtraSmallOffset
        {
            get { return (int?)this.ViewState["ExtraSmallOffset"]; }
            set { this.ViewState["ExtraSmallOffset"] = value; }
        }

        /// <summary>
        /// Gets or sets the small offset.
        /// </summary>
        /// <value>
        /// The small offset.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? SmallOffset
        {
            get { return (int?)this.ViewState["SmallOffset"]; }
            set { this.ViewState["SmallOffset"] = value; }
        }

        /// <summary>
        /// Gets or sets the medium offset.
        /// </summary>
        /// <value>
        /// The medium offset.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? MediumOffset
        {
            get { return (int?)this.ViewState["MediumOffset"]; }
            set { this.ViewState["MediumOffset"] = value; }
        }

        /// <summary>
        /// Gets or sets the large offset.
        /// </summary>
        /// <value>
        /// The large offset.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? LargeOffset
        {
            get { return (int?)this.ViewState["LargeOffset"]; }
            set { this.ViewState["LargeOffset"] = value; }
        }

        /// <summary>
        /// Gets or sets the extra small push.
        /// </summary>
        /// <value>
        /// The extra small push.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? ExtraSmallPush
        {
            get { return (int?)this.ViewState["ExtraSmallPush"]; }
            set { this.ViewState["ExtraSmallPush"] = value; }
        }

        /// <summary>
        /// Gets or sets the small push.
        /// </summary>
        /// <value>
        /// The small push.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? SmallPush
        {
            get { return (int?)this.ViewState["SmallPush"]; }
            set { this.ViewState["SmallPush"] = value; }
        }

        /// <summary>
        /// Gets or sets the medium push.
        /// </summary>
        /// <value>
        /// The medium push.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? MediumPush
        {
            get { return (int?)this.ViewState["MediumPush"]; }
            set { this.ViewState["MediumPush"] = value; }
        }

        /// <summary>
        /// Gets or sets the large push.
        /// </summary>
        /// <value>
        /// The large push.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? LargePush
        {
            get { return (int?)this.ViewState["LargePush"]; }
            set { this.ViewState["LargePush"] = value; }
        }

        /// <summary>
        /// Gets or sets the extra small pull.
        /// </summary>
        /// <value>
        /// The extra small pull.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? ExtraSmallPull
        {
            get { return (int?)this.ViewState["ExtraSmallPull"]; }
            set { this.ViewState["ExtraSmallPull"] = value; }
        }

        /// <summary>
        /// Gets or sets the small pull.
        /// </summary>
        /// <value>
        /// The small pull.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? SmallPull
        {
            get { return (int?)this.ViewState["SmallPull"]; }
            set { this.ViewState["SmallPull"] = value; }
        }

        /// <summary>
        /// Gets or sets the medium pull.
        /// </summary>
        /// <value>
        /// The medium pull.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? MediumPull
        {
            get { return (int?)this.ViewState["MediumPull"]; }
            set { this.ViewState["MediumPull"] = value; }
        }

        /// <summary>
        /// Gets or sets the large pull.
        /// </summary>
        /// <value>
        /// The large pull.
        /// </value>
        [Category("Size")]
        [DefaultValue(null)]
        public int? LargePull
        {
            get { return (int?)this.ViewState["LargePull"]; }
            set { this.ViewState["LargePull"] = value; }
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
        /// Renders the HTML contents of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            this.RenderChildren(writer);
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

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            StringBuilder classes = new StringBuilder(this.CssClass);

            AppendClassIfHasValue(classes, " col-xs-{0}", this.ExtraSmall);
            AppendClassIfHasValue(classes, " col-sm-{0}", this.Small);
            AppendClassIfHasValue(classes, " col-md-{0}", this.Medium);
            AppendClassIfHasValue(classes, " col-lg-{0}", this.Large);

            AppendClassIfHasValue(classes, " col-xs-offset-{0}", this.ExtraSmallOffset);
            AppendClassIfHasValue(classes, " col-sm-offset-{0}", this.SmallOffset);
            AppendClassIfHasValue(classes, " col-md-offset-{0}", this.MediumOffset);
            AppendClassIfHasValue(classes, " col-lg-offset-{0}", this.LargeOffset);

            AppendClassIfHasValue(classes, " col-xs-push-{0}", this.ExtraSmallPush);
            AppendClassIfHasValue(classes, " col-sm-push-{0}", this.SmallPush);
            AppendClassIfHasValue(classes, " col-md-push-{0}", this.MediumPush);
            AppendClassIfHasValue(classes, " col-lg-push-{0}", this.LargePush);

            AppendClassIfHasValue(classes, " col-xs-pull-{0}", this.ExtraSmallPull);
            AppendClassIfHasValue(classes, " col-sm-pull-{0}", this.SmallPull);
            AppendClassIfHasValue(classes, " col-md-pull-{0}", this.MediumPull);
            AppendClassIfHasValue(classes, " col-lg-pull-{0}", this.LargePull);

            return classes.ToString().Trim();
        }

        private static void AppendClassIfHasValue(StringBuilder classes, string classFormat, int? val)
        {
            if (val.HasValue)
            {
                classes.AppendFormat(classFormat, val.Value);
            }
        }
    }
}

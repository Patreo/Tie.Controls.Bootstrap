// Alert.cs

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
    /// Contextual styles used on Bootstrap Alerts.
    /// </summary>
    public enum AlertTypes
    {
        /// <summary>Indicates caution should be taken with this action (usually yellow-orange)</summary>
        Warning = 0,
        /// <summary>Indicates a dangerous or potentially negative action (usually red)</summary>
        Danger = 1,
        /// <summary>Indicates a successful or positive action (usually green)</summary>
        Success = 2,
        /// <summary>Indicates informational messages (usually light-blue)</summary>
        Info = 3
    }

    /// <summary>
    /// Represents a Bootstrap alert.
    /// </summary>
    [ToolboxData("<{0}:Alert runat=server></{0}:Alert>")]
    [DefaultProperty("CssClass")]
    [ParseChildren(true, "Content")]
    [PersistChildren(true)]
    public class Alert : AccessibleWebControl, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Alert" /> class.
        /// </summary>
        public Alert()
        {
            this.AlertType = AlertTypes.Danger;
            this.Dismissible = false;
        }

        /// <summary>
        /// Gets or sets the type of the alert.
        /// </summary>
        /// <value>
        /// The type of the alert.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(AlertTypes.Warning)]
        public AlertTypes AlertType
        {
            get { return (AlertTypes)this.ViewState["AlertType"]; }
            set { this.ViewState["AlertType"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Alert"/> is dismissible.
        /// </summary>
        /// <value>
        ///   <c>true</c> if dismissible; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Dismissible
        {
            get { return (bool)this.ViewState["Dismissible"]; }
            set { this.ViewState["Dismissible"] = value; }
        }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(Alert))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Content
        {
            get;
            set;
        }

        /// <summary>
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            writer.AddAttribute("role", "alert");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);            
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
        /// Renders the HTML contents of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            if (this.Dismissible)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "close");
                writer.AddAttribute("type", "button");
                writer.AddAttribute("data-dismiss", "alert");
                writer.AddAttribute("aria-label", "Close");
                writer.RenderBeginTag(HtmlTextWriterTag.Button);

                writer.AddAttribute("aria-hidden", "true");
                writer.RenderBeginTag(HtmlTextWriterTag.Span);
                writer.Write("&times;");

                writer.RenderEndTag(); // Span
                writer.RenderEndTag(); // Button
            }

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
            StringBuilder classes = new StringBuilder("alert");
            classes.Append(this.GetAlertType());
            StringHelper.AppendIf(classes, this.Dismissible, " alert-dismissible");
            StringHelper.AppendWithSpaceIfNotEmpty(classes, this.CssClass);
            return classes.ToString();
        }


        /// <summary>
        /// Gets the type of the alert.
        /// </summary>
        /// <returns></returns>
        private string GetAlertType()
        {
            switch (this.AlertType)
            {
                case AlertTypes.Success:
                    return " alert-success";

                case AlertTypes.Warning:
                    return " alert-warning";

                case AlertTypes.Danger:
                    return " alert-danger";

                case AlertTypes.Info:
                    return " alert-info";

                default:
                    return String.Empty;
            }
        }
    }
}
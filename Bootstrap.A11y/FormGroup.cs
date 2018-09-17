// FormGroup.cs

// Copyright (C) 2018 Kinsey Roberts (@kinzdesign), Weatherhead School of Management (@wsomweb)

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
using System.Drawing;
using System.Web.UI;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Bootstrap form group.
    /// </summary>
    [ToolboxData("<{0}:Panel runat=server></{0}:Panel>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Panel))]
    [ParseChildren(true, "Control")]
    [PersistChildren(false)]
    public class FormGroup : System.Web.UI.WebControls.Panel, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormGroup"/> class.
        /// </summary>
        public FormGroup()
        {
            this.LabelText = "";
            this.LabelClass = "";
            this.LabelVisible = true;
            this.PlaceholderText = "";
            this.InputSize = InputSizes.Default;
        }

        /// <summary>
        /// Gets or sets the label text.
        /// </summary>
        /// <value>
        /// The label text.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string LabelText
        {
            get { return (string)this.ViewState["LabelText"]; }
            set { this.ViewState["LabelText"] = value; }
        }

        /// <summary>
        /// Gets or sets the label's CSS class (used in horizontal forms).
        /// </summary>
        /// <value>
        /// The label CSS class.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string LabelClass
        {
            get { return (string)this.ViewState["LabelClass"]; }
            set { this.ViewState["LabelClass"] = value; }
        }

        /// <summary>
        /// Gets or sets whether the label is visible. If false, will still be rendered to screen readers.
        /// </summary>
        /// <value>
        /// Whether the label is visible.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool LabelVisible
        {
            get { return (bool)this.ViewState["LabelVisible"]; }
            set { this.ViewState["LabelVisible"] = value; }
        }

        /// <summary>
        /// Gets or sets the control's CSS class (used in horizontal forms).
        /// </summary>
        /// <value>
        /// The control CSS class.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string ControlClass
        {
            get { return (string)this.ViewState["ControlClass"]; }
            set { this.ViewState["ControlClass"] = value; }
        }

        /// <summary>
        /// Gets or sets the control's ID.
        /// </summary>
        /// <value>
        /// The control ID.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string ControlID
        {
            get { return (string)this.ViewState["ControlID"]; }
            set { this.ViewState["ControlID"] = value; }
        }

        /// <summary>
        /// Gets or sets the placeholder text.
        /// </summary>
        /// <value>
        /// The placeholder text.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string PlaceholderText
        {
            get { return (string)this.ViewState["PlaceholderText"]; }
            set { this.ViewState["PlaceholderText"] = value; }
        }

        /// <summary>
        /// Gets or sets the size of the input
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [Category("Behavior")]
        [DefaultValue(InputSizes.Default)]
        public InputSizes InputSize
        {
            get { return (InputSizes)this.ViewState["InputSize"]; }
            set { this.ViewState["InputSize"] = value; }
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
        public virtual ITemplate Control
        {
            get;
            set;
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(System.Web.UI.HtmlTextWriter writer)
        {
            ControlHelper.EnsureCssClassPresent(this, "form-group");
            InputSizesHelper.EnsureSizeClassPresent(this, this.InputSize, "form-group-");
            base.Render(writer);
        }


        /// <summary>
        /// Renders the HTML contents of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            var contentsContainer = new Control();
            contentsContainer.ID = "contentsContainer";
            this.Control.InstantiateIn(contentsContainer);
            this.Controls.Add(contentsContainer);

            string clientID = GetControlClientID(ControlID, contentsContainer);
            if (String.IsNullOrEmpty(clientID))
            {
                throw new InvalidOperationException("FormGroup must either define ControlID property or have exactly one non-Literal Control in its Control template");
            }

            if (!String.IsNullOrEmpty(this.LabelText))
            {
                writer.AddAttribute(HtmlTextWriterAttribute.For, clientID);
                if (!LabelVisible)
                {
                    this.LabelClass = StringHelper.EnsureClassPresent(this.LabelClass, "sr-only");
                }
                if (!String.IsNullOrEmpty(this.LabelClass))
                {
                    writer.AddAttribute(HtmlTextWriterAttribute.Class, this.LabelClass);
                }
                writer.RenderBeginTag(HtmlTextWriterTag.Label);
                writer.Write(this.LabelText);
                writer.RenderEndTag();
            }
            if (String.IsNullOrEmpty(ControlClass))
            {
                contentsContainer.RenderControl(writer);
            }
            else
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, ControlClass);
                writer.RenderBeginTag(HtmlTextWriterTag.Div);
                contentsContainer.RenderControl(writer);
                writer.RenderEndTag();
            }
        }

        private static string GetControlClientID(string id, Control control)
        {
            // if id is explicitly defined
            if (!String.IsNullOrEmpty(id))
            {
                // map specified ID to ClientID
                var c = ControlHelper.GetControlById(control.Controls, id);
                if (c != null)
                {
                    return c.ClientID;
                }
                return null;
            }
            string childId = null;
            // iterate child controls
            foreach (Control child in control.Controls)
            {
                // check non-Literal controls
                if (!(child is LiteralControl))
                {
                    // if the first, note ID
                    if (String.IsNullOrEmpty(id))
                    {
                        childId = child.ClientID;
                    }
                    // if not the first, return null
                    else
                    {
                        return null;
                    }
                }
            }
            return childId;
        }
    }
}

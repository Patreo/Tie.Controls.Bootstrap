// Modal.cs

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
    /// The three sizes a modal may have.
    /// </summary>
    public enum ModalSizes
    {        
        /// <summary>A smaller size.</summary>
        Small = 0,
        /// <summary>The default size.</summary>
        Default = 1,
        /// <summary>A larger size.</summary>
        Large = 2
    }

    /// <summary>
    /// The background shown behind a <see cref="Modal"/> when it is shown.
    /// </summary>
    public enum ModalBackdrops : byte
    {
        /// <summary>No background.</summary>
        None = 0,
        /// <summary>Standard background, closes modal on click.</summary>
        Default = 1,
        /// <summary>Standard background, does not close modal on click.</summary>
        Static = 2
    }

    /// <summary>
    /// Represents a Bootstrap modal.
    /// </summary>
    [ToolboxData("<{0}:Modal runat=server></{0}:Modal>")]
    [DefaultProperty("Text")]
    [ParseChildren(true, "Content")]
    [PersistChildren(false)]
    public class Modal : AccessibleWebControl, INamingContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Modal"/> class.
        /// </summary>
        public Modal()
        {
            this.Title = "";
            this.TitleTag = HtmlTextWriterTag.H4;
            this.Fade = true;
            this.Size = ModalSizes.Default;
            this.BackdropType = ModalBackdrops.Default;
            this.CloseOnEscKey = true;
            this.Show = true;
            this.RemotePath = String.Empty;
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [Category("Behavior")]
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
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(ModalSizes.Default)]
        public ModalSizes Size
        {
            get { return (ModalSizes)this.ViewState["Size"]; }
            set { this.ViewState["Size"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Modal"/> is fade.
        /// </summary>
        /// <value>
        ///   <c>true</c> if fade; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool Fade
        {
            get { return (bool)this.ViewState["Fade"]; }
            set { this.ViewState["Fade"] = value; }
        }

        /// <summary>
        /// Includes a modal-backdrop element. Alternatively, specify static for a backdrop which doesn't close the modal on click.
        /// </summary>
        [Category("Appearance")]
        [DefaultValue(ModalBackdrops.Default)]
        public ModalBackdrops BackdropType
        {
            get { return (ModalBackdrops)this.ViewState["BackdropType"]; }
            set { this.ViewState["BackdropType"] = value; }
        }

        /// <summary>
        /// If true, closes the modal when escape key is pressed.
        /// </summary>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool CloseOnEscKey
        {
            get { return (bool)this.ViewState["CloseOnEscKey"]; }
            set { this.ViewState["CloseOnEscKey"] = value; }
        }

        /// <summary>
        /// If true, shows the modal when initialized.
        /// </summary>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool Show
        {
            get { return (bool)this.ViewState["Show"]; }
            set { this.ViewState["Show"] = value; }
        }

        /// <summary>
        /// If a remote URL is provided, content will be loaded via jQuery's load method and injected into the root of the modal element.
        /// </summary>
        [Category("Appearance")]
        [DefaultValue("")]
        public string RemotePath
        {
            get { return (string)this.ViewState["RemotePath"]; }
            set { this.ViewState["RemotePath"] = value; }
        }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(Modal))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Content
        {
            get;
            set;
        }


        /// <summary>
        /// Gets or sets the footer.
        /// </summary>
        /// <value>
        /// The footer.
        /// </value>
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [TemplateContainer(typeof(Modal))]
        [TemplateInstance(TemplateInstance.Single)]
        public virtual ITemplate Footer
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
            this.EnsureClassesPresent();
            writer.AddAttribute(HtmlTextWriterAttribute.Tabindex, "-1");
            writer.AddAttribute("role", "dialog");
            writer.AddAttribute("aria-labelledby", ClientID + "_title");
            writer.AddAttribute("aria-hidden", "true");

            switch (BackdropType)
            {
                case ModalBackdrops.None:
                    writer.AddAttribute("data-backdrop", "false");
                    break;
                case ModalBackdrops.Static:
                    writer.AddAttribute("data-backdrop", "static");
                    break;
                case ModalBackdrops.Default:
                default:
                    // no data attribute needed for default value
                    break;
            }

            if (!CloseOnEscKey)
            {
                writer.AddAttribute("data-keyboard", "false");
            }

            if(!Show)
            {
                writer.AddAttribute("data-show", "false");
            }

            if (!String.IsNullOrEmpty(RemotePath))
            {
                writer.AddAttribute("data-remote", RemotePath);
            }

            base.Render(writer);
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            string cssClass = "modal-dialog";
            if(Size != ModalSizes.Default)
            {
                cssClass = String.Concat(cssClass, " modal-", StringHelper.ToLower(Size));
            }
            writer.AddAttribute(HtmlTextWriterAttribute.Class, cssClass);
            writer.AddAttribute("role", "document");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "modal-content");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "modal-header");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            writer.AddAttribute(HtmlTextWriterAttribute.Type, "button");
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "close");
            writer.AddAttribute("data-dismiss", "modal");
            writer.AddAttribute("aria-hidden", "true");
            writer.RenderBeginTag(HtmlTextWriterTag.Button);
            writer.Write("&times;");
            writer.RenderEndTag(); // Button

            writer.AddAttribute(HtmlTextWriterAttribute.Class, "modal-title");
            writer.AddAttribute(HtmlTextWriterAttribute.Id, ClientID + "_title");
            writer.RenderBeginTag(this.TitleTag);
            writer.Write(this.Title);
            writer.RenderEndTag(); // TitleTag

            writer.RenderEndTag(); // Div

            this.RenderChildren(writer);

            writer.RenderEndTag(); // Div
            writer.RenderEndTag(); // Div
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
            // Remove any controls
#if _4_0 || _4_5
            this.ClearCachedClientID();
#endif
            this.Controls.Clear();

            if (this.Content != null)
            {
                // Add all content to a container.
                var container = new System.Web.UI.WebControls.Panel();
                container.CssClass = "modal-body";
                this.Content.InstantiateIn(container);
                this.Controls.Add(container);
            }

            if (this.Footer != null)
            {
                // Add all footer to a container.
                var footer = new System.Web.UI.WebControls.Panel();
                footer.CssClass = "modal-footer";
                this.Footer.InstantiateIn(footer);
                this.Controls.Add(footer);
            }
        }

        /// <summary>
        /// Opens this instance.
        /// </summary>
        public void Open()
        {
#if !_2_0
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<script type=\"text/javascript\">");
            sb.AppendLine(" $('#" + this.ClientID  + "').modal('show');");
            sb.AppendLine("</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ModalScript", sb.ToString(), false);
#else
            throw new InvalidOperationException(".NET 2.0 does not support ScriptManager.");
#endif
        }

        /// <summary>
        /// Closes this instance.
        /// </summary>
        public void Close()
        {
#if !_2_0
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<script type=\"text/javascript\">");
            sb.AppendLine(" $('#" + this.ClientID + "').modal('hide');");
            sb.AppendLine("</script>");
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ModalScript", sb.ToString(), false);
#else
            throw new InvalidOperationException(".NET 2.0 does not support ScriptManager.");
#endif
        }

        /// <summary>
        /// Ensures that necessary classes are present on the control before rendering.
        /// </summary>
        protected virtual void EnsureClassesPresent()
        {
            ControlHelper.EnsureCssClassPresent(this, "modal");
            if(Fade)
            {
                ControlHelper.EnsureCssClassPresent(this, "fade");
            }
        }

        /// <summary>
        /// Finds the control recursive.
        /// </summary>
        /// <param name="rootControl">The root control.</param>
        /// <param name="controlID">The control identifier.</param>
        /// <returns></returns>
        internal static Control FindControlRecursive(Control rootControl, string controlID)
        {
            if (rootControl.ID == controlID)
            {
                return rootControl;
            }

            foreach (Control controlToSearch in rootControl.Controls)
            {
                Control controlToReturn = Modal.FindControlRecursive(controlToSearch, controlID);
                if (controlToReturn != null)
                {
                    return controlToReturn;
                }
            }

            return null;
        }
    }
}

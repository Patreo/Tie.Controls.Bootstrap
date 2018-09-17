// TabControl.cs

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
using System.Drawing;
using System.Text;
using System.Web.UI;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Occurs when the selected tab page index has changed.
    /// </summary>
    public class TabPageChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets the index of the page.
        /// </summary>
        /// <value>
        /// The index of the page.
        /// </value>
        public int Index
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Represents a series of Bootstrap tabs.
    /// </summary>
    [ToolboxData("<{0}:TabControl runat=server></{0}:TabControl>")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Image))]
    [ParseChildren(true, "TabPages")]
    [PersistChildren(false)]
    public class TabControl : AccessibleWebControl, INamingContainer, IPostBackDataHandler
    {
        /// <summary>
        /// Occurs when the <see cref="ActiveTabPage"/> property has changed.
        /// </summary>
        public event EventHandler<TabPageChangedEventArgs> TabPageChanged;
        readonly TabCollection _Tabs;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TabControl" /> class.
        /// </summary>
        public TabControl()
        {
            _Tabs = new TabCollection(this);
            this.ActiveTabPage = 0;
            this.Pills = false;
            this.Stacked = false;
            this.Justified = false;
            this.AutoPostBack = false;
        }

        /// <summary>
        /// Gets the tab pages.
        /// </summary>
        /// <value>
        /// The tab pages.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] 
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        public TabCollection TabPages
        {
            get { return _Tabs; }
        }

        /// <summary>
        /// Gets or sets the active tab page.
        /// </summary>
        /// <value>
        /// The active tab page.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public int ActiveTabPage
        {
            get { return (int)this.ViewState["ActiveTabPage"]; }
            set { this.ViewState["ActiveTabPage"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TabControl"/> is rendered as pills.
        /// </summary>
        /// <value>
        ///   <c>true</c> if rendered as pills; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool Pills
        {
            get { return (bool)this.ViewState["Pills"]; }
            set { this.ViewState["Pills"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TabControl"/> is stacked.
        /// </summary>
        /// <value>
        ///   <c>true</c> if stacked; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Stacked
        {
            get { return (bool)this.ViewState["Stacked"]; }
            set { this.ViewState["Stacked"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TabControl"/> is justified.
        /// </summary>
        /// <value>
        ///   <c>true</c> if justified; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Justified
        {
            get { return (bool)this.ViewState["Justified"]; }
            set { this.ViewState["Justified"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether a postback to the server automatically occurs when the user changes the list selection.
        /// </summary>
        /// <value>
        /// <c>true</c> if a postback to the server automatically occurs whenever the user changes the selection of the list; otherwise, <c>false</c>. The default is <c>false</c>.
        /// </value>
        [Category("Behavior")]
        [DefaultValue(false)]
        public bool AutoPostBack
        {
            get { return (bool)this.ViewState["AutoPostBack"]; }
            set { this.ViewState["AutoPostBack"] = value; }
        }

        /// <summary>
        /// Renders the HTML end tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "tab-content");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            for (int i = 0; i < this.TabPages.Count; i++)
            {
                TabPage tabPage = this.TabPages[i];

                string cssClass = StringHelper.AppendIf("tab-pane fade", this.ActiveTabPage == i, " in active");
                writer.AddAttribute(HtmlTextWriterAttribute.Id, tabPage.GetTabName());
                writer.AddAttribute("aria-labelledby", tabPage.GetTabName() + "-label");
                writer.AddAttribute(HtmlTextWriterAttribute.Class, cssClass);
                writer.AddAttribute("role", "tabpanel");
                writer.RenderBeginTag(HtmlTextWriterTag.Div);

                foreach (Control ctrl in tabPage.Controls)
                {
                    ctrl.RenderControl(writer);
                }

                writer.RenderEndTag();
            }

            writer.RenderEndTag();
            writer.RenderEndTag();
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Id, this.ClientID);
            writer.AddAttribute(HtmlTextWriterAttribute.Name, this.UniqueID);

            base.Render(writer);           
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());
            writer.AddAttribute("role", "tablist");
            writer.RenderBeginTag(HtmlTextWriterTag.Ul);

            for (int i = 0; i < this.TabPages.Count; i++)
            {
                TabPage tabPage = this.TabPages[i];
                tabPage.Index = i;

                StringBuilder classes = new StringBuilder();
                StringHelper.AppendIf(classes, this.ActiveTabPage == i, " active");
                StringHelper.AppendIf(classes, !tabPage.Enabled, " disabled");

                if (classes.Length > 0)
                {
                    writer.AddAttribute(HtmlTextWriterAttribute.Class, classes.ToString());
                }

                writer.AddAttribute("role", "presentation");
                writer.RenderBeginTag(HtmlTextWriterTag.Li);
                tabPage.RenderControl(writer);

                writer.RenderEndTag();
            }
            writer.RenderEndTag();
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
            StringBuilder classes = new StringBuilder("nav");
            classes.Append(this.Pills ? " nav-pills" : " nav-tabs");
            StringHelper.AppendIf(classes, this.Stacked, " nav-stacked");
            StringHelper.AppendIf(classes, this.Justified, " nav-justified");
            StringHelper.AppendWithSpaceIfNotEmpty(classes, this.CssClass);
            return classes.ToString();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event. This notifies the control to perform any steps necessary for its creation on a page request.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit(EventArgs e)
        {
            if (this.AutoPostBack)
            {
                this.Page.RegisterRequiresPostBack(this);
            }
            base.OnInit(e);
            this.CreateChildControls();
            this.ChildControlsCreated = true;
        }

        /// <summary>
        /// When implemented by a class, processes postback data for an ASP.NET server control.
        /// </summary>
        /// <param name="postDataKey">The key identifier for the control.</param>
        /// <param name="postCollection">The collection of all incoming name values.</param>
        /// <returns>
        /// true if the server control's state changes as a result of the postback; otherwise, false.
        /// </returns>
        public bool LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection)
        {
            if (this.AutoPostBack)
            {
                if (postCollection["__EVENTTARGET"] != this.UniqueID)
                {
                    return false;
                }

                int tabPageIndex = Convert.ToInt32(postCollection["__EVENTARGUMENT"]);

                if (this.ActiveTabPage != tabPageIndex)
                {
                    this.ActiveTabPage = tabPageIndex;
                    return true;
                }        
            }

            return false;
        }

        /// <summary>
        /// Signals the server control to notify the ASP.NET application that the state of the control has changed.
        /// </summary>
        public void RaisePostDataChangedEvent()
        {
            OnTabPageChanged();
        }

        /// <summary>
        /// Called when [tab page changed].
        /// </summary>
        private void OnTabPageChanged()
        {
            if (TabPageChanged != null)
            {
                TabPageChanged(this, new TabPageChangedEventArgs { Index = this.ActiveTabPage });
            }
        }

    }
}
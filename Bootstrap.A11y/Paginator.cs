// Paginator.cs

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
using System.Web.UI;
using System.Web.UI.WebControls;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// The three sizes a paginator may have.
    /// </summary>
    public enum PaginationSizes
    {
        /// <summary>The default size.</summary>
        Default = 0,
        /// <summary>A smaller size.</summary>
        Small = 1,
        /// <summary>A larger size.</summary>
        Large = 2
    }

    /// <summary>
    /// Occurs when the selected page index has changed.
    /// </summary>
    public class PageChangedEventArgs : EventArgs
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
    /// Represents a Bootstrap paginator.
    /// </summary>
    [ToolboxData("<{0}:Paginator runat=server></{0}:Paginator>")]
    public class Paginator : WebControl, INamingContainer, IPostBackDataHandler
    {
        /// <summary>
        /// Occurs when the <see cref="CurrentPageIndex"/> property has changed.
        /// </summary>
        public event EventHandler<PageChangedEventArgs> PageIndexChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="Paginator" /> class.
        /// </summary>
        public Paginator() : base("nav")
        {
            this.ItemCount = 100;
            this.PageSize = 25;
            this.CurrentPageIndex = 0;
            this.Size = PaginationSizes.Default;
            this.Label = "Paginator";
            this.PreviousArrowVisible = true;
            this.NextArrowVisible = true;
        }

        /// <summary>
        /// Gets the index of the current page.
        /// </summary>
        /// <value>
        /// The index of the current page.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(0)]
        public int CurrentPageIndex
        {
            get { return (int)this.ViewState["CurrentPageIndex"]; }
            set { this.ViewState["CurrentPageIndex"] = value; }
        }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(PaginationSizes.Default)]
        public PaginationSizes Size
        {
            get { return (PaginationSizes)this.ViewState["Size"]; }
            set { this.ViewState["Size"] = value; }
        }

        /// <summary>
        /// Gets or sets the size of the page.
        /// </summary>
        /// <value>
        /// The size of the page.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(25)]
        public int PageSize
        {
            get { return (int)this.ViewState["PageSize"]; }
            set { this.ViewState["PageSize"] = value; }
        }

        /// <summary>
        /// Gets or sets the item count.
        /// </summary>
        /// <value>
        /// The item count.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(0)]
        public int ItemCount
        {
            get { return (int)this.ViewState["ItemCount"]; }
            set { this.ViewState["ItemCount"] = value; }
        }

        /// <summary>
        /// Gets or sets a label to be shown to screen readers.
        /// </summary>
        /// <value>
        /// The label to be shown to screen readers.
        /// </value>
        [Category("Appearance")]
        [DefaultValue("Paginator")]
        public string Label
        {
            get { return (string)this.ViewState["Label"]; }
            set { this.ViewState["Label"] = value; }
        }

        /// <summary>
        /// Gets or sets whether to show the previous page arrow.
        /// </summary>
        /// <value>
        /// Whether to show the previous page arrow.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool PreviousArrowVisible
        {
            get { return (bool)this.ViewState["PreviousArrowVisible"]; }
            set { this.ViewState["PreviousArrowVisible"] = value; }
        }

        /// <summary>
        /// Gets or sets whether to show the next page arrow.
        /// </summary>
        /// <value>
        /// Whether to show the next page arrow.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(true)]
        public bool NextArrowVisible
        {
            get { return (bool)this.ViewState["NextArrowVisible"]; }
            set { this.ViewState["NextArrowVisible"] = value; }
        }

        /// <summary>
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            if (!String.IsNullOrEmpty(this.Label))
            {
                writer.AddAttribute("aria-label", Label);
            }
            base.RenderBeginTag(writer); // nav
            string listClass = "pagination";
            if (Size != PaginationSizes.Default)
            {
                listClass = String.Concat(listClass, " pagination-", StringHelper.ToLower(Size));
            }
            writer.AddAttribute(HtmlTextWriterAttribute.Class, listClass);
            writer.RenderBeginTag(HtmlTextWriterTag.Ul); // ul
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            PagingHelper.RenderPagingElement(writer, this, CurrentPageIndex, GetTotalPages(), PreviousArrowVisible, NextArrowVisible);
            this.RenderChildren(writer);
        }

        /// <summary>
        /// Renders the HTML end tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
            writer.RenderEndTag(); // ul
            base.RenderEndTag(writer); // nav
        }

        /// <summary>
        /// Gets the total pages.
        /// </summary>
        /// <returns></returns>
        private int GetTotalPages()
        {
            return Convert.ToInt32(Math.Ceiling(Decimal.Divide((decimal)ItemCount, (decimal)PageSize)));
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event. This notifies the control to perform any steps necessary for its creation on a page request.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit(System.EventArgs e)
        {
            this.Page.RegisterRequiresPostBack(this);
            base.OnInit(e);
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
            if (postCollection["__EVENTTARGET"] != this.UniqueID)
            {
                return false;
            }

            int pageIndex = Convert.ToInt32(postCollection["__EVENTARGUMENT"]) - 1;

            if (this.CurrentPageIndex != pageIndex)
            {
                this.CurrentPageIndex = pageIndex;
                return true;                
            }

            return false;
        }

        /// <summary>
        /// When implemented by a class, signals the server control to notify the ASP.NET application that the state of the control has changed.
        /// </summary>
        public void RaisePostDataChangedEvent()
        {
            OnPageIndexChanged();  
        }

        /// <summary>
        /// Called when [page index changed].
        /// </summary>
        private void OnPageIndexChanged()
        {
            if (PageIndexChanged != null)
            {
                PageIndexChanged(this, new PageChangedEventArgs { Index = this.CurrentPageIndex });
            }
        }
    }
}

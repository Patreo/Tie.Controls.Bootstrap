// GridViewPager.cs

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
using System.Collections;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a paginator for use with a <see cref="System.Web.UI.WebControls.GridView"/>.
    /// </summary>
    [ToolboxData("<{0}:GridViewPager runat=server></{0}:GridViewPager>")]
    public class GridViewPager : WebControl, INamingContainer, IPostBackDataHandler
    {
        private System.Web.UI.WebControls.GridView GridView;

        /// <summary>
        /// Occurs when [page index changed].
        /// </summary>
        public event EventHandler<PageChangedEventArgs> PageIndexChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="GridViewPager"/> class.
        /// </summary>
        public GridViewPager() : base(HtmlTextWriterTag.Ul)
        {
            this.GridViewID = String.Empty;
            this.Label = "Grid Pages";
            this.PreviousArrowVisible = true;
            this.NextArrowVisible = true;
        }

        /// <summary>
        /// Gets or sets the grid view identifier.
        /// </summary>
        /// <value>
        /// The grid view identifier.
        /// </value>
        [Category("Behavior")]
        [DefaultValue("")]
        public string GridViewID
        {
            get { return (string)this.ViewState["GridViewID"]; }
            set { this.ViewState["GridViewID"] = value; }
        }

        /// <summary>
        /// Gets or sets a label to be shown to screen readers.
        /// </summary>
        /// <value>
        /// The label to be shown to screen readers.
        /// </value>
        [Category("Appearance")]
        [DefaultValue("Grid Pages")]
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

        #region IPostBackDataHandler methods

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

#if _4_0 || _4_5
            this.GridView.SetPageIndex(pageIndex);
#else
            this.GridView.PageIndex = pageIndex;
#endif
            return true;
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
                PageIndexChanged(this, new PageChangedEventArgs { Index = this.GridView.PageIndex });
            }
        }

        #endregion

        /// <summary>
        /// Gets the total pages.
        /// </summary>
        /// <returns></returns>
        private int GetTotalPages()
        {
            int intTotalRows = 0;

            System.Data.DataSet ds = this.GridView.DataSource as System.Data.DataSet;
            if (ds != null)
            {
                if (String.IsNullOrEmpty(this.GridView.DataMember))
                {
                    intTotalRows = ds.Tables[0].Rows.Count;
                }
                else
                {
                    intTotalRows = ds.Tables[this.GridView.DataMember].Rows.Count;
                }
            }

            System.Data.DataTable dt = this.GridView.DataSource as System.Data.DataTable;
            if (dt != null)
            {
               intTotalRows = dt.Rows.Count;
            }

            ICollection dataSource = this.GridView.DataSource as ICollection;
            if (dataSource != null)
            {
                intTotalRows = dataSource.Count;
            }

            return Convert.ToInt32(Math.Ceiling(Decimal.Divide((decimal)intTotalRows, (decimal)this.GridView.PageSize)));
        }

        /// <summary>
        /// Handles the PageIndexChanging event of the ctrl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="GridViewPageEventArgs"/> instance containing the event data.</param>
        void ctrl_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView.PageIndex = e.NewPageIndex;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event. This notifies the control to perform any steps necessary for its creation on a page request.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit(EventArgs e)
        {
            this.GridView = ControlHelper.GetControlById(Page, this.GridViewID) as System.Web.UI.WebControls.GridView;

            if (this.GridView == null)
            {
                this.Visible = false;
            }
            else
            {
                this.GridView.PageIndexChanging += ctrl_PageIndexChanging;
                this.Page.RegisterRequiresPostBack(this);
            }
            base.OnInit(e);
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            PagingHelper.RenderPagingElement(writer, this, this.GridView.PageIndex, GetTotalPages(), PreviousArrowVisible, NextArrowVisible);

            this.RenderChildren(writer);
        }
       
        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            ControlHelper.EnsureCssClassPresent(this, "pagination");
            writer.AddAttribute("aria-label", Label);
            base.Render(writer);
        }
    }
}

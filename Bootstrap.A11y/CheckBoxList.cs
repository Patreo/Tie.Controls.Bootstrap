// CheckBoxList.cs

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
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Bootstrap check box list.
    /// </summary>
    public class CheckBoxList : System.Web.UI.WebControls.CheckBoxList, INamingContainer
    {
        #region properties

        private bool _hasNotifiedOfChange;

        /// <summary>
        /// This property is unused, since Bootstrap grids are used for layout.
        /// </summary>
        public override int CellPadding
        {
            get
            {
                return -1;
            }
            set
            {
                throw new InvalidOperationException("Bootstrap CheckBoxList does not support custom CellPadding (uses Bootstrap grid system).");
            }
        }

        /// <summary>
        /// This property is unused, since Bootstrap grids are used for layout.
        /// </summary>
        public override int CellSpacing
        {
            get
            {
                return -1;
            }
            set
            {
                throw new InvalidOperationException("Bootstrap CheckBoxList does not support custom CellSpacing (uses Bootstrap grid system).");
            }
        }

#if _4_5
        /// <summary>
        /// This property is unused, empty lists are not rendered.
        /// </summary>
        public override bool RenderWhenDataEmpty
        {
            get
            {
                return false;
            }
            set
            {
                throw new InvalidOperationException("Bootstrap CheckBoxList does not support custom RenderWhenDataEmpty (always false).");
            }
        }
#endif

        /// <summary>
        /// This property is unused, since Bootstrap grids are used for layout.
        /// </summary>
        public override RepeatLayout RepeatLayout
        {
            get
            {
                return System.Web.UI.WebControls.RepeatLayout.Flow;
            }
            set
            {
                throw new InvalidOperationException("Bootstrap CheckBoxList does not support custom RepeatLayout (uses Bootstrap grid system).");
            }
        }

        /// <summary>
        /// Indicates the column count of checkboxes within the group.
        /// Must be a factor of 12 (1, 2, 3, 4, 6, or 12).
        /// </summary>
        [Category("Layout")]
        [DefaultValue(1)]
        public override int RepeatColumns
        {
            get
            {
                object obj2 = this.ViewState["RepeatColumns"];
                return ((obj2 == null) ? 1 : ((int)obj2));
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("value", "Minimum value for RepeatColumns is 1.");
                }
                if (value > 12)
                {
                    throw new ArgumentOutOfRangeException("value", "Maximum value for RepeatColumns is 12.");
                }
                if ((12 % value) > 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Value of RepeatColumns must be a factor of 12 (1, 2, 3, 4, 6, or 12).");
                }
                this.ViewState["RepeatColumns"] = value;
            }
        }

        /// <summary>
        /// The smallest Bootstrap breakpoint at which the checkboxes should be shown in columns.
        /// At smaller breakpoints, the buttons will appear as a list.
        /// </summary>
        [Category("Layout")]
        [DefaultValue(Breakpoints.Small)]
        public Breakpoints MinimumColumnsBreakpoint
        {
            get
            {
                return (Breakpoints)this.ViewState["MinimumColumnsBreakpoint"];
            }
            set
            {
                this.ViewState["MinimumColumnsBreakpoint"] = value;
            }
        }

        /// <summary>
        /// Describes the group of options. If this property is populated, the control is wrapped within a fieldset tag
        /// for improved accessibility.
        /// </summary>
        [Category("Behavior")]
        [DefaultValue("")]
        public string Legend
        {
            get { return (string)this.ViewState["Legend"]; }
            set { this.ViewState["Legend"] = value; }
        }

        /// <summary>
        /// If Legend is populated, this controls whether the rendered legend tag is visible to sighted users.
        /// If false, the legend is classed "sr-only".
        /// </summary>
        [Category("Behavior")]
        [DefaultValue(true)]
        public bool ShowLegend
        {
            get { return (bool)this.ViewState["ShowLegend"]; }
            set { this.ViewState["ShowLegend"] = value; }
        }

        #endregion

        #region GetSelectedItems()

        /// <summary>
        /// Gets an array of the currently selected <see cref="System.Web.UI.WebControls.ListItem"/>s.
        /// </summary>
        /// <returns>The selected items.</returns>
        public System.Web.UI.WebControls.ListItem[] GetSelectedItems()
        {
            List<System.Web.UI.WebControls.ListItem> selected = new List<System.Web.UI.WebControls.ListItem>();
            foreach (System.Web.UI.WebControls.ListItem item in this.Items)
            {
                if(item.Selected)
                {
                    selected.Add(item);
                }
            }
            return selected.ToArray();
        }

        #endregion

        #region Rendering

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxList" /> class.
        /// </summary>
        public CheckBoxList()
        {
            this.RepeatColumns = 1;
            this.MinimumColumnsBreakpoint = Breakpoints.Small;
            this.Legend = "";
            this.ShowLegend = true;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.PreRender" /> event. This notifies the control to perform any steps necessary for its creation on a page request.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnPreRender(EventArgs e)
        {
            // don't render empty lists
            if (this.Items == null || this.Items.Count == 0)
            {
                this.Visible = false;
            }
            base.OnPreRender(e);
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            // TabIndex here is special... it needs to be applied to the individual
            // CheckBoxs and not the outer control itself

            // cache away the TabIndex property state
            short tabIndex = this.TabIndex;
            bool undirtyTabIndex = false;
            if (tabIndex > 0)
            {
                if (!this.ViewState.IsItemDirty("TabIndex"))
                {
                    undirtyTabIndex = true;
                }
                this.TabIndex = 0;
            }
            // register scripts
            if (this.Page != null)
            {
                this.Page.ClientScript.RegisterForEventValidation(this.UniqueID);
            }
            // compute the grid columns per checkbox column
            int repeatColumns = this.RepeatColumns;
            int gridColumns = 12 / repeatColumns;
            string columnClass = String.Format("col-{0}-{1}", BreakpointsHelper.GetAbbreviation(this.MinimumColumnsBreakpoint), gridColumns);
            // render based on repeat columns and direction
            if (RepeatColumns == 1 || RepeatDirection == RepeatDirection.Vertical)
            {
                RenderVertical(writer, tabIndex, repeatColumns, columnClass);
            }
            else
            {
                RenderHorizontal(writer, tabIndex, repeatColumns, columnClass);
            }
            // restore the state of the TabIndex property
            if (tabIndex > 0)
            {
                this.TabIndex = tabIndex;
            }
            if (undirtyTabIndex)
            {
                this.ViewState.SetItemDirty("TabIndex", false);
            }
        }

        private void RenderHorizontal(HtmlTextWriter writer, short tabIndex, int repeatColumns, string columnClass)
        {
            // open wrapper
            this.RenderBeginTag(writer);
            // write style tag
            writer.RenderBeginTag(HtmlTextWriterTag.Style);
            writer.Write(".checkbox-list-horizontal .checkbox { margin-top: -5px; }");
            writer.RenderEndTag();
            // 
            for (int i = 0; i < Items.Count; i++)
            {
                System.Web.UI.WebControls.ListItem item = Items[i];
                int col = i % repeatColumns;
                // open row if needed
                if (col == 0)
                {
                    RenderBeginRowDiv(writer);
                }

                // open column div
                RenderBeginColumnDiv(writer, columnClass);
                // render checkboxes
                this.RenderItem(writer, item, tabIndex);
                // close column div
                writer.RenderEndTag();

                // close row if needed
                if (col + 1 == repeatColumns || i + 1 == Items.Count)
                {
                    writer.RenderEndTag();
                }
            }
            // close wrapper
            this.RenderEndTag(writer);
        }

        private void RenderVertical(HtmlTextWriter writer, short tabIndex, int repeatColumns, string columnClass)
        {
            // open wrapper as row
            ControlHelper.EnsureCssClassPresent(this, "row");
            this.RenderBeginTag(writer);
            // determine items per column plus leftovers for final, partial row
            int itemsPerCol = this.Items.Count / repeatColumns;
            int leftoverItems = this.Items.Count % repeatColumns;
            // indices of first and last items in column
            int start;
            int end = 0;
            // build each column
            for (int col = 0; col < repeatColumns; col++)
            {
                // start where last column left off
                start = end;
                // determine number of items in the column, including leftovers as needed
                end += itemsPerCol;
                if (col < leftoverItems)
                {
                    end++;
                }
                // open column div
                RenderBeginColumnDiv(writer, columnClass);
                // render checkboxes
                this.RenderItems(writer, start, end, tabIndex);
                // close column div
                writer.RenderEndTag();
            }
            // close wrapper
            this.RenderEndTag(writer);
        }

        /// <summary>
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            // output fieldset and legend if Legend is set
            string legend = this.Legend;
            if(!String.IsNullOrEmpty(legend))
            {
                writer.RenderBeginTag(HtmlTextWriterTag.Fieldset);
                if (!this.ShowLegend)
                {
                    writer.AddAttribute(HtmlTextWriterAttribute.Class, "sr-only");
                }
                writer.RenderBeginTag(HtmlTextWriterTag.Legend);
                writer.Write(legend);
                writer.RenderEndTag(); // legend
            }
            // open div
            ControlHelper.EnsureCssClassPresent(this, "checkbox-list");
            ControlHelper.EnsureCssClassPresent(this, "checkbox-list-" + StringHelper.ToLower(this.RepeatDirection));
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.CssClass);
            if (base.HasAttributes)
            {
                base.Attributes.AddAttributes(writer);
            }
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
        }

        /// <summary>
        /// Renders the HTML end tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
            writer.RenderEndTag(); // div
            if(!String.IsNullOrEmpty(this.Legend))
            {
                writer.RenderEndTag(); // fieldset
            }
        }

        /// <summary>
        /// Renders the specified <paramref name="item"/> as a <see cref="CheckBox"/> into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        /// <param name="item">The <see cref="System.Web.UI.WebControls.ListItem"/> to render.</param>
        /// <param name="tabIndex">The TabIndex value for the rendered CheckBox.</param>
        protected void RenderItem(HtmlTextWriter writer, System.Web.UI.WebControls.ListItem item, short tabIndex)
        {
            CheckBox child = new CheckBox();
            child.EnableViewState = false;
            this.Controls.Add(child);
            child.Enabled = item.Enabled;
            child.Checked = item.Selected;
            child.Text = item.Text;
            child.Attributes["value"] = item.Value;
            if ((item.Attributes != null) && (item.Attributes.Count > 0))
            {
                foreach (string str in item.Attributes.Keys)
                {
                    child.Attributes[str] = item.Attributes[str];
                }
            }
            child.AutoPostBack = this.AutoPostBack;
            child.CausesValidation = this.CausesValidation;
            child.ValidationGroup = this.ValidationGroup;
            child.TabIndex = tabIndex;
            child.RenderControl(writer);
        }

        private void RenderItems(HtmlTextWriter writer, int start, int end, short tabIndex)
        {
            for (int i = start; i < Math.Min(end, this.Items.Count); i++)
            {
                this.RenderItem(writer, this.Items[i], tabIndex);
            }
        }

        private static void RenderBeginRowDiv(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "row");
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
        }

        private static void RenderBeginColumnDiv(HtmlTextWriter writer, string columnClass)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, columnClass);
            writer.RenderBeginTag(HtmlTextWriterTag.Div);
        }

        #endregion

        #region POST data

        /// <summary>
        /// Processes posted data for the <see cref='Bootstrap.A11y.CheckBoxList'/> control.
        /// </summary>
        /// <param name="postDataKey">The POST data key to process.</param>
        /// <param name="postCollection">Collection of POSTed values.</param>
        /// <returns>Whether the value changed.</returns>
        protected override bool LoadPostData(String postDataKey, NameValueCollection postCollection)
        {
            if (!IsEnabled)
            {
                // When a CheckBoxList is disabled, then there is no postback
                // data for it. Any checked state information has been loaded
                // via view state.
                return false;
            }

            string strIndex = postDataKey.Substring(UniqueID.Length + 1);
            // strIndex is now either (1) "<index>" or (2) "<id>_<index>"
            // Detect case #2 by looking for an underscore. Use LastIndexOf in case <id> contains one too.
            // No need to worry about a case that looks like "<uniqueid>$<id>", it would never have been rendered that way.
            int underscoreIndex = strIndex.LastIndexOf('_');
            if (underscoreIndex != -1)
            {
                strIndex = strIndex.Substring(underscoreIndex + 1);
            }
            // check that the resulting string is an integer
            // if not, this is an inner CheckBox control, skip for now (it'll be handled in IsChecked)
            if (!StringHelper.IsPositiveInteger(strIndex))
            {
                return false;
            }
            // strIndex is now definitely the index as a string, regardless of which case postDataKey was in.
            int index = Int32.Parse(strIndex, CultureInfo.InvariantCulture);

            // can't access EnsureDataBoundInLoadPostData();

            // Maintain state from the form
            if (index >= 0 && index < Items.Count)
            {
                System.Web.UI.WebControls.ListItem item = Items[index];
                if (!item.Enabled)
                {
                    return false;
                }
                bool newCheckState = IsChecked(postCollection, index);

                if (item.Selected != newCheckState)
                {
                    item.Selected = newCheckState;
                    // LoadPostData will be invoked for each CheckBox that changed
                    // Suppress multiple change notification and fire only ONE change event
                    if (!_hasNotifiedOfChange)
                    {
                        _hasNotifiedOfChange = true;
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks <paramref name="postCollection"/> to see if the <paramref name="i"/>th
        /// CheckBox is checked.
        /// </summary>
        /// <param name="postCollection">The POSTed data to search in.</param>
        /// <param name="i">The item's index to search for.</param>
        /// <returns>True if checked, false otherwise.</returns>
        private bool IsChecked(NameValueCollection postCollection, int i)
        {
            string key = String.Format("{0}$ctl{1:D2}", this.UniqueID, i);
            return postCollection[key] != null;
        }

        #endregion
    }
}
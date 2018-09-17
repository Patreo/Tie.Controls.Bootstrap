// Popover.cs

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
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Represents a Bootstrap popover.
    /// </summary>
    [ToolboxData("<{0}:Popover runat=server />")]
    [ToolboxBitmap(typeof(System.Web.UI.WebControls.Label))]
    public class Popover : WebControl, INamingContainer
    {
        internal const Triggers DEFAULT_TRIGGER = Triggers.Click;

        /// <summary>
        /// Initializes a new instance of the <see cref="Popover" /> class.
        /// </summary>
        public Popover()
        {
            this.Position = PopoverPositions.Right;
            this.Title = "";
            this.Text = "";
            this.DismissOnNextClick = false;
            this.Trigger = DEFAULT_TRIGGER;
        }

        /// <summary>
        /// Gets or sets the title displayed on the <see cref="Popover"/>.
        /// </summary>
        [Category("Behavior")]
        [DefaultValue("")]
        public string Title
        {
            get { return (string)this.ViewState["Title"]; }
            set { this.ViewState["Title"] = value; }
        }

        /// <summary>
        /// Gets or sets the text displayed in the <see cref="Popover"/>.
        /// </summary>
        [Category("Behavior")]
        [DefaultValue("")]
        public string Text
        {
            get { return (string)this.ViewState["Text"]; }
            set { this.ViewState["Text"] = value; }
        }

        /// <summary>
        /// Gets or sets the position of the <see cref="Popover"/>.
        /// </summary>
        [Category("Appearance")]
        [DefaultValue(PopoverPositions.Right)]
        public PopoverPositions Position
        {
            get { return (PopoverPositions)this.ViewState["Position"]; }
            set { this.ViewState["Position"] = value; }
        }

        /// <summary>
        /// Gets or sets the triggering action that shows the <see cref="Popover"/>.
        /// </summary>
        [Category("Appearance")]
        [DefaultValue(DEFAULT_TRIGGER)]
        public Triggers Trigger
        {
            get { return (Triggers)this.ViewState["Trigger"]; }
            set { this.ViewState["Trigger"] = value; }
        }

        /// <summary>
        /// Gets or sets whether the <see cref="Popover"/> should be dismissed on the next click that the user makes.
        /// </summary>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool DismissOnNextClick
        {
            get { return (bool)this.ViewState["DismissOnNextClick"]; }
            set { this.ViewState["DismissOnNextClick"] = value; }
        }

        internal static void RegisterJsInit(Page page)
        {
            // inject initialization javascript
            string js = "$(function () { $('[data-toggle=\"popover\"]').popover(); });";
            page.ClientScript.RegisterClientScriptBlock(typeof(Popover), "popover-init", js, true);
        }
    }
}

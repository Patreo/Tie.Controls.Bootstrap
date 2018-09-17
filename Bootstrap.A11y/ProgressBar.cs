// ProgressBar.cs

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
using System.Globalization;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bootstrap.A11y.Helpers;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Contextual styles used on Bootstrap progress bars.
    /// </summary>
    public enum ProgressBarStyles
    {
        /// <summary>Primary brand color</summary>
        Default = 0,
        /// <summary>Indicates informational messages (usually light-blue)</summary>
        Info = 1,
        /// <summary>Indicates a successful or positive action (usually green)</summary>
        Success = 2,
        /// <summary>Indicates caution should be taken with this action (usually yellow-orange)</summary>
        Warning = 3,
        /// <summary>Indicates a dangerous or potentially negative action (usually red)</summary>
        Danger = 4
    }

    /// <summary>
    /// Represents a Bootstrap progress bar.
    /// </summary>
    [ToolboxData("<{0}:ProgressBar runat=\"server\" />")]
    public class ProgressBar : WebControl, INamingContainer
    {
        #region constants

        const ProgressBarStyles DEFAULT_STYLE = ProgressBarStyles.Default;
        const string DEFAULT_LABEL_FORMAT = "{0:F0}%";
        const string DEFAULT_CAPTION_FORMAT = "{0:F0}% Complete";
        const string DEFAULT_LABEL_MIN_WIDTH = "2em";

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressBar" /> class.
        /// </summary>
        public ProgressBar()
        {
            this.Animated = false;
            this.Striped = false;
            this.ShowLabel = false;
            this.Value = 50;
            this.MinValue = 0;
            this.MaxValue = 100;
            this.ProgressBarStyle = DEFAULT_STYLE;
            this.LabelMinWidth = DEFAULT_LABEL_MIN_WIDTH;
            this.LabelFormat = DEFAULT_LABEL_FORMAT;
            this.CaptionFormat = DEFAULT_CAPTION_FORMAT;
        }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [Category("Behavior")]
        public decimal Value
        {
            get { return (decimal)this.ViewState["Value"]; }
            set { this.ViewState["Value"] = value; }
        }

        /// <summary>
        /// Gets or sets the minimum value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [Category("Behavior")]
        [DefaultValue(0)]
        public decimal MinValue
        {
            get { return (decimal)this.ViewState["MinValue"]; }
            set { this.ViewState["MinValue"] = value; }
        }

        /// <summary>
        /// Gets or sets the maximum value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [Category("Behavior")]
        [DefaultValue(100)]
        public decimal MaxValue
        {
            get { return (decimal)this.ViewState["MaxValue"]; }
            set { this.ViewState["MaxValue"] = value; }
        }
        
        /// <summary>
        /// Computes the percentage (from 0-100) that <see name="Value"/> represents between <see name="MinValue"/> and <see name="MinValue"/>.
        /// </summary>
        private decimal Percentage
        {
            get { return (Value - MinValue) / (MaxValue - MinValue) * 100M; }
        }

        /// <summary>
        /// Determines whether this <see cref="ProgressBar" /> is the child of a <see cref="StackedProgressBars" /> control.
        /// </summary>
        private bool IsStacked
        {
            get { return this.Parent is StackedProgressBars; }
        }

        /// <summary>
        /// Gets or sets the progress bar style.
        /// </summary>
        /// <value>
        /// The progress bar style.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(DEFAULT_STYLE)]
        public ProgressBarStyles ProgressBarStyle
        {
            get { return (ProgressBarStyles)this.ViewState["ProgressBarStyle"]; }
            set { this.ViewState["ProgressBarStyle"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show label].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show label]; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool ShowLabel
        {
            get { return (bool)this.ViewState["ShowLabel"]; }
            set { this.ViewState["ShowLabel"] = value; }
        }

        /// <summary>
        /// Gets or sets the minimum width of the label div when <see name="ShowLabel"/> is <c>true</c>.
        /// </summary>
        /// <value>
        /// A string containing a valid CSS unit (e.g. "2em", "5%").
        /// </value>
        [Category("Appearance")]
        [DefaultValue(DEFAULT_LABEL_MIN_WIDTH)]
        public string LabelMinWidth
        {
            get { return (string)this.ViewState["LabelMinWidth"]; }
            set { this.ViewState["LabelMinWidth"] = value; }
        }

        /// <summary>
        /// Gets or sets the format string for label text for sighted users if <see name="ShowLabel"/> is <c>true</c>.
        /// </summary>
        /// <value>
        /// Format string with the following arguments:
        /// {0} is Percentage, 
        /// {1} is Value,
        /// {2} is MaxValue,
        /// {3} is MinValue
        /// </value>
        [Category("Appearance")]
        [DefaultValue(DEFAULT_LABEL_FORMAT)]
        public string LabelFormat
        {
            get { return (string)this.ViewState["LabelFormat"]; }
            set { this.ViewState["LabelFormat"] = value; }
        }

        /// <summary>
        /// Gets or sets the format string for screen reader caption.
        /// </summary>
        /// <value>
        /// Format string with the following arguments:
        /// {0} is <see name="Percentage"/>, 
        /// {1} is <see name="Value"/>,
        /// {2} is <see name="MaxValue"/>,
        /// {3} is <see name="MinValue"/>
        /// </value>
        [Category("Appearance")]
        [DefaultValue(DEFAULT_CAPTION_FORMAT)]
        public string CaptionFormat
        {
            get { return (string)this.ViewState["CaptionFormat"]; }
            set { this.ViewState["CaptionFormat"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ProgressBar"/> is animated.
        /// </summary>
        /// <value>
        ///   <c>true</c> if animated; otherwise, <c>false</c>.
        /// </value>
        [Category("Appearance")]
        [DefaultValue(false)]
        public bool Animated
        {
            get { return (bool)this.ViewState["Animated"]; }
            set { this.ViewState["Animated"] = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ProgressBar" /> is striped.
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
        /// Renders the opening HTML tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            if (!IsStacked)
            {
                writer.RenderBeginTag(HtmlTextWriterTag.Div);
            }
        }

        /// <summary>
        /// Renders the control to the specified HTML writer.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        protected override void Render(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Id, this.ClientID);
            writer.AddAttribute(HtmlTextWriterAttribute.Name, this.UniqueID);
            if (!IsStacked)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildCss());
            }

            base.Render(writer);
        }

        /// <summary>
        /// Renders the contents of the control to the specified <paramref name="writer"/>. This method is used primarily by control developers.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, this.BuildInternalCss());
            // add style markup
            writer.AddStyleAttribute(HtmlTextWriterStyle.Width, Percentage.ToString(CultureInfo.InvariantCulture) + "%");
            if (this.ShowLabel && !String.IsNullOrEmpty(LabelMinWidth))
            {
                writer.AddStyleAttribute("min-width", LabelMinWidth);
            }
            // add ARIA markup
            writer.AddAttribute("role", "progressbar");
            writer.AddAttribute("aria-valuenow", Value.ToString(CultureInfo.InvariantCulture));
            writer.AddAttribute("aria-valuemin", MinValue.ToString(CultureInfo.InvariantCulture));
            writer.AddAttribute("aria-valuemax", MaxValue.ToString(CultureInfo.InvariantCulture));
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            // output label
            if (ShowLabel)
            {
                // if label and caption are the same, the same text can be used for sighted and screen readers
                if (LabelFormat == CaptionFormat)
                {
                    writer.Write(DoFormat(LabelFormat));
                }
                // otherwise output different versions for display versus screen reading
                else
                {
                    // output span for sighted users
                    writer.AddAttribute("aria-hidden", "true");
                    writer.RenderBeginTag(HtmlTextWriterTag.Span);
                    writer.Write(DoFormat(LabelFormat));
                    writer.RenderEndTag();
                    // output screen reader caption
                    WriteScreenReaderSpan(writer);
                }
            }
            // output screen reader caption
            else
            {
                WriteScreenReaderSpan(writer);
            }

            writer.RenderEndTag();
        }

        /// <summary>
        /// Renders the HTML end tag of the control into the specified <paramref name="writer"/>.
        /// </summary>
        /// <param name="writer">A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.</param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
            if (!IsStacked)
            {
                writer.RenderEndTag();
            }
        }

        /// <summary>
        /// Builds the internal CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildInternalCss()
        {
            StringBuilder classes = new StringBuilder("progress-bar");
            classes.Append(this.GetContextStyles());
            StringHelper.AppendIf(classes, this.Striped, " progress-bar-striped");
            StringHelper.AppendIf(classes, this.Animated, " active");
            return classes.ToString();
        }

        /// <summary>
        /// Builds the CSS.
        /// </summary>
        /// <returns></returns>
        private string BuildCss()
        {
            StringBuilder classes = new StringBuilder();
            StringHelper.AppendIf(classes, !IsStacked, "progress");
            StringHelper.AppendWithSpaceIfNotEmpty(classes, this.CssClass);
            return classes.ToString().Trim();
        }

        /// <summary>
        /// Gets the progress bar styles.
        /// </summary>
        /// <returns></returns>
        private string GetContextStyles()
        {
            switch (this.ProgressBarStyle)
            {
                case ProgressBarStyles.Success:
                    return " progress-bar-success";

                case ProgressBarStyles.Warning:
                    return " progress-bar-warning";

                case ProgressBarStyles.Danger:
                    return " progress-bar-danger";

                case ProgressBarStyles.Info:
                    return " progress-bar-info";

                default:
                    return String.Empty;
            }
        }

        /// <summary>
        /// Calls String.Format on <paramref name="format"/> with the following parameters: 
        /// {0} is Percentage, 
        /// {1} is Value,
        /// {2} is MaxValue,
        /// {3} is MinValue
        /// </summary>
        /// <param name="format">
        /// Format string.
        /// </param>
        /// <returns>
        /// Formatted string.
        /// </returns>
        private string DoFormat(string format)
        {
            return String.Format(format, Percentage, Value, MaxValue, MinValue);
        }

        /// <summary>
        /// Renders a span classed "sr-only" containing the caption text.
        /// </summary>
        /// <param name="writer">
        /// A <see cref="T:System.Web.UI.HtmlTextWriter" /> that represents the output stream to render HTML content on the client.
        /// </param>
        private void WriteScreenReaderSpan(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Class, "sr-only");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.Write(DoFormat(CaptionFormat));
            writer.RenderEndTag();
        }

    }
}

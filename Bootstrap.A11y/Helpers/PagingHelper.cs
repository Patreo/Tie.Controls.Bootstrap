// PagingHelper.cs

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
using System.Web.UI;

namespace Bootstrap.A11y.Helpers
{
    internal static class PagingHelper
    {
        internal static void RenderPagingElement(HtmlTextWriter writer, Control control, int currentPage, int totalPages, bool previousArrowVisible, bool nextArrowVisible)
        {
            if (previousArrowVisible)
            {
                RenderPreviousArrow(writer, control, currentPage);
            }

            for (int i = 0; i < totalPages; i++)
            {
                RenderPageIndicator(writer, control, currentPage, i);
            }

            if (nextArrowVisible)
            {
                RenderNextArrow(writer, control, currentPage, totalPages);
            }
        }

        internal static void RenderPreviousArrow(HtmlTextWriter writer, Control control, int currentPage)
        {
            bool enabled = currentPage != 0;
            if (!enabled)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "disabled");
            }
            writer.RenderBeginTag(HtmlTextWriterTag.Li);
            writer.AddAttribute("aria-label", "Previous");
            if (enabled)
            {
                int index = Math.Max(currentPage, 0);
                writer.AddAttribute(HtmlTextWriterAttribute.Href, GetLink(control, index - 1));
                writer.RenderBeginTag(HtmlTextWriterTag.A);
            }
            writer.AddAttribute("aria-hidden", "true");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.Write("&laquo;");
            writer.RenderEndTag(); // span
            if (enabled)
            {
                writer.RenderEndTag(); // a
            }
            writer.RenderEndTag(); // li
        }

        internal static void RenderPageIndicator(HtmlTextWriter writer, Control control, int currentPage, int index)
        {
            bool isActive = currentPage == index;
            if (isActive)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "active");
            }

            writer.RenderBeginTag(HtmlTextWriterTag.Li);
            if (!isActive)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Href, GetLink(control, index));
                writer.RenderBeginTag(HtmlTextWriterTag.A);
            }
            else
            {
                writer.RenderBeginTag(HtmlTextWriterTag.Span);
            }
            writer.Write((index + 1).ToString());
            if (isActive)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "sr-only");
                writer.RenderBeginTag(HtmlTextWriterTag.Span);
                writer.Write(" (current)");
                writer.RenderEndTag(); // span
            }
            writer.RenderEndTag(); // a/span
            writer.RenderEndTag(); // li
        }

        internal static void RenderNextArrow(HtmlTextWriter writer, Control control, int currentPage, int totalPages)
        {
            bool enabled = currentPage < (totalPages - 1);
            if (!enabled)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Class, "disabled");
            }
            writer.RenderBeginTag(HtmlTextWriterTag.Li);
            writer.AddAttribute("aria-label", "Next");
            if (enabled)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Href, GetLink(control, currentPage + 1));
                writer.RenderBeginTag(HtmlTextWriterTag.A);
            }
            writer.AddAttribute("aria-hidden", "true");
            writer.RenderBeginTag(HtmlTextWriterTag.Span);
            writer.Write("&raquo;");
            writer.RenderEndTag(); // span
            if (enabled)
            {
                writer.RenderEndTag(); // a
            }
            writer.RenderEndTag(); // li
        }

        /// <summary>
        /// Generates the PostBackClientHyperlink to select a new page.
        /// </summary>
        /// <param name="control">The control to post back to.</param>
        /// <param name="page">The zero-based index page number.</param>
        /// <returns>A PostBackClientHyperlink to the one-based index of <paramref name="page"/>.</returns>
        private static string GetLink(Control control, int page)
        {
            return control.Page.ClientScript.GetPostBackClientHyperlink(control, (page + 1).ToString(), false);
        }
    }
}

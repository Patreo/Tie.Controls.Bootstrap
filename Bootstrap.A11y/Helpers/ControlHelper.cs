// ControlHelper.cs

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

using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bootstrap.A11y.Helpers
{
    /// <summary>
    /// Helper methods for dealing with <see cref="Control"/>s.
    /// </summary>
    public static class ControlHelper
    {
        #region GetControlById

        /// <summary>
        /// Finds the control on <paramref name="page"/> with the given <paramref name="controlId"/>.
        /// </summary>
        /// <param name="page">The page to search in.</param>
        /// <param name="controlId">The control identifier to search for.</param>
        /// <returns>The <see cref="Control"/>, if found, or null.</returns>
        public static Control GetControlById(Page page, string controlId)
        {
            if (page != null)
            {
                return GetControlById(page.Controls, controlId);
            }
            return null;
        }

        /// <summary>
        /// Finds the control on the current <see cref="Page"/> with the given <paramref name="controlId"/>.
        /// </summary>
        /// <param name="controlId">The control identifier to search for.</param>
        /// <returns>The <see cref="Control"/>, if found, or null.</returns>
        public static Control GetControlById(string controlId)
        {
            return GetControlById(System.Web.HttpContext.Current.Handler as Page, controlId);
        }

        /// <summary>
        /// Finds the control in <paramref name="controls"/> (and their descendants) with the given <paramref name="controlId"/>.
        /// </summary>
        /// <param name="controls">The controls to search amongst.</param>
        /// <param name="controlId">The control identifier to search for.</param>
        /// <returns>The <see cref="Control"/>, if found, or null.</returns>
        public static Control GetControlById(ControlCollection controls, string controlId)
        {
            if (controls != null)
            {
                // iterate controls
                foreach (Control control in controls)
                {
                    // check ID
                    if (control.ID == controlId)
                    {
                        return control;
                    }
                    // recurse to children
                    Control child = GetControlById(control.Controls, controlId);
                    // if found, return
                    if (child != null)
                    {
                        return child;
                    }
                }
            }
            // not found
            return null;
        }

        #endregion

        /// <summary>
        /// Ensures that <paramref name="control"/> has <paramref name="cssClass"/> in its CssClass property.
        /// </summary>
        /// <param name="control">The <see cref="Control"/> to check.</param>
        /// <param name="cssClass">The class to add.</param>
        public static void EnsureCssClassPresent(WebControl control, string cssClass)
        {
            control.CssClass = StringHelper.EnsureClassPresent(control.CssClass, cssClass);
        }
    }
}

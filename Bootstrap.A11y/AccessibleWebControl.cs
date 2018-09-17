// AccessibleWebControl.cs

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
using System.Configuration;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bootstrap.A11y
{
    /// <summary>
    /// Base class for any <see cref="System.Web.UI.WebControls.WebControl"/> that requires an accessibility plugin.
    /// </summary>
    public class AccessibleWebControl : WebControl
    {
        #region JavaScript

        /// <summary>
        /// MIME type to use when serving JavaScript files.
        /// </summary>
        internal const string JsMimeType = "application/javascript";

        /// <summary>
        /// Embedded resource name of the PayPal bootstrap-accessibility JS.
        /// NOTE: The assembly name varies by project, so precompiler directives
        /// are used to define the correct value.
        /// </summary>
        internal const string PayPalJsResourceName =
#if _3_5
            "Bootstrap.A11y.v35.Resources.paypal.bootstrap-accessibility.min.js";
#elif _4_0
            "Bootstrap.A11y.v40.Resources.paypal.bootstrap-accessibility.min.js";
#elif _4_5
            "Bootstrap.A11y.v45.Resources.paypal.bootstrap-accessibility.min.js";
#else
            "Bootstrap.A11y.Resources.paypal.bootstrap-accessibility.min.js";
#endif

        /// <summary>
        /// Embedded resource name of the JonGund bootstrap-accessibility JS.
        /// NOTE: The assembly name varies by project, so precompiler directives
        /// are used to define the correct value.
        /// </summary>
        internal const string JonGundJsResourceName =
#if _3_5
            "Bootstrap.A11y.v35.Resources.jongund.bootstrap-accessibility.min.js";
#elif _4_0
            "Bootstrap.A11y.v40.Resources.jongund.bootstrap-accessibility.min.js";
#elif _4_5
            "Bootstrap.A11y.v45.Resources.jongund.bootstrap-accessibility.min.js";
#else
            "Bootstrap.A11y.Resources.jongund.bootstrap-accessibility.min.js";
#endif

        /// <summary>
        /// The embedded resource name for the JavaScript associated with the configured <see cref="AccessibilityPlugin"/>.
        /// </summary>
        protected static string JsResourceName
        {
            get
            {
                switch (AccessibilityPlugin)
                {
                    case AccessibilityPlugins.PayPal:
                        return PayPalJsResourceName;
                    case AccessibilityPlugins.JonGund:
                        return JonGundJsResourceName;
                    case AccessibilityPlugins.None:
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// The ClientScript key used to refer to the bootstrap-accessibility JavaScript.
        /// </summary>
        internal const string JsResourceKey = "bootstrap-accessiblity.js";

        /// <summary>
        /// By default, the Bootstrap Accessibility Plugin's JavaScript is included in
        /// the page from an embedded resource. This can be deactivated in the AppSettings section
        /// of web.config by adding key="Bootstrap.InjectA11yJs" with value="false".
        /// </summary>
        internal static bool InjectA11yJs
        {
            get
            {
                return GetConfigAsBoolean("Bootstrap.InjectA11yJs", true);
            }
        }

        /// <summary>
        /// Inject the PayPal Bootstrap Accessibility Plugin's JavaScript into the page using ClientScript.
        /// </summary>
        private void RegisterJs()
        {
            // append to end of body so loaded after bootstrap.css
            string link = this.Page.ClientScript.GetWebResourceUrl(ClientScriptType, JsResourceName);
            string js = String.Format(
                "var scr=document.createElement('script');" +
                "scr.setAttribute('src', '{0}');" +
                "document.getElementsByTagName('body')[0].appendChild(scr);", link);
            this.Page.ClientScript.RegisterClientScriptBlock(ClientScriptType, JsResourceKey, js, true);
        }

        #endregion

        #region CSS

        /// <summary>
        /// MIME type to use when serving CSS files.
        /// </summary>
        internal const string CssMimeType = "text/css";

        /// <summary>
        /// Embedded resource name of the PayPal bootstrap-accessibility CSS.
        /// NOTE: The assembly name varies by project, so precompiler directives
        /// are used to define the correct value.
        /// </summary>
        internal const string PayPalCssResourceName =
#if _3_5
            "Bootstrap.A11y.v35.Resources.paypal.bootstrap-accessibility.min.css";
#elif _4_0
            "Bootstrap.A11y.v40.Resources.paypal.bootstrap-accessibility.min.css";
#elif _4_5
            "Bootstrap.A11y.v45.Resources.paypal.bootstrap-accessibility.min.css";
#else
            "Bootstrap.A11y.Resources.paypal.bootstrap-accessibility.min.css";
#endif

        /// <summary>
        /// Embedded resource name of the JonGund bootstrap-accessibility CSS.
        /// NOTE: The assembly name varies by project, so precompiler directives
        /// are used to define the correct value.
        /// </summary>
        internal const string JonGundCssResourceName =
#if _3_5
            "Bootstrap.A11y.v35.Resources.jongund.bootstrap-accessibility.min.css";
#elif _4_0
            "Bootstrap.A11y.v40.Resources.jongund.bootstrap-accessibility.min.css";
#elif _4_5
            "Bootstrap.A11y.v45.Resources.jongund.bootstrap-accessibility.min.css";
#else
            "Bootstrap.A11y.Resources.jongund.bootstrap-accessibility.min.css";
#endif

        /// <summary>
        /// The embedded resource name for the CSS associated with the configured <see cref="AccessibilityPlugin"/>.
        /// </summary>
        protected static string CssResourceName
        {
            get
            {
                switch (AccessibilityPlugin)
                {
                    case AccessibilityPlugins.PayPal:
                        return PayPalCssResourceName;
                    case AccessibilityPlugins.JonGund:
                        return JonGundCssResourceName;
                    case AccessibilityPlugins.None:
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// The ClientScript key used to refer to the bootstrap-accessibility CSS.
        /// </summary>
        internal const string CssResourceKey = "bootstrap-accessibility.css";

        /// <summary>
        /// By default, the Bootstrap Accessibility Plugin's CSS is included in
        /// the page from an embedded resource. This can be deactivated in the AppSettings section
        /// of web.config by adding key="Bootstrap.InjectA11yCss" with value="false".
        /// </summary>
        internal static bool InjectA11yCss
        {
            get
            {
                return GetConfigAsBoolean("Bootstrap.InjectA11yCss", true);
            }
        }

        /// <summary>
        /// Inject the PayPal Bootstrap Accessibility Plugin's CSS into the page using ClientScript.
        /// </summary>
        private void RegisterCss()
        {
            string link = this.Page.ClientScript.GetWebResourceUrl(ClientScriptType, CssResourceName);
            string css = String.Format(
                "var lin=document.createElement('link');" +
                "lin.setAttribute('rel','stylesheet');" +
                "lin.setAttribute('type','text/css');" +
                "lin.setAttribute('href', '{0}');" +
                "document.getElementsByTagName('head')[0].appendChild(lin);", link);
            this.Page.ClientScript.RegisterClientScriptBlock(ClientScriptType, CssResourceKey, css, true);
        }

        #endregion

        #region GetConfig

        /// <summary>
        /// Gets the value associated with <paramref name="key"/> in the AppSettings section of web.config and
        /// parses it as a boolean, returning <paramref name="nullValue"/> if the value is not present or is invalid.
        /// When parsing, the first character is looked at. If '1', 't', or 'y', the value is parsed as true; 
        /// '0', 'f', or 'n', the value is parsed as false.
        /// </summary>
        /// <param name="key">The AppSettings key to look for.</param>
        /// <param name="nullValue">The value to return if <paramref name="key"/> is not present or is invalid.</param>
        /// <returns>A boolean representation of the value associated with <paramref name="key"/>, or <paramref name="nullValue"/>.</returns>
        private static bool GetConfigAsBoolean(string key, bool nullValue)
        {
            string config = ConfigurationManager.AppSettings[key];
            if (String.IsNullOrEmpty(config))
            {
                return nullValue;
            }
            switch (config.ToLower(CultureInfo.InvariantCulture)[0])
            {
                case 'f':
                case 'n':
                case '0':
                    return false;
                case 't':
                case 'y':
                case '1':
                    return true;
                default:
                    return nullValue;
            }
        }

        /// <summary>
        /// Gets the value of Bootstrap.AccessibilityPlugin from AppSettings.
        /// </summary>
        [DefaultValue(AccessibilityPlugins.PayPal)]
        private static AccessibilityPlugins? _accessibilityPlugin = null;


        /// <summary>
        /// The <see cref="AccessibilityPlugin"/> defined in the web.config file.
        /// Value is defined using the "<c>Bootstrap.AccessibilityPlugin</c>" key in AppSettings.
        /// </summary>
        [DefaultValue(AccessibilityPlugins.PayPal)]
        public static AccessibilityPlugins AccessibilityPlugin
        {
            get
            {
                if (!_accessibilityPlugin.HasValue)
                {
                    string config = ConfigurationManager.AppSettings["Bootstrap.AccessibilityPlugin"] ?? " ";
                    switch (config.ToLower(CultureInfo.InvariantCulture)[0])
                    {
                        case 'n':
                            _accessibilityPlugin = AccessibilityPlugins.None;
                            break;
                        case 'j':
                            _accessibilityPlugin = AccessibilityPlugins.JonGund;
                            break;
                        default:
                            _accessibilityPlugin = AccessibilityPlugins.PayPal;
                            break;
                    }
                }
                return _accessibilityPlugin.Value;
            }
        }

        #endregion

        #region static fields

        /// <summary>
        /// The Type to use when registering scripts with ClientScript.
        /// </summary>
        private static Type ClientScriptType
        {
            get { return typeof(AccessibleWebControl); }
        }

        #endregion

        #region page lifecycle overrides

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event. This notifies the control to perform any steps necessary for its creation on a page request.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (AccessibilityPlugin != AccessibilityPlugins.None)
            {
                if (InjectA11yJs)
                {
                    RegisterJs();
                }
                if (InjectA11yCss)
                {
                    RegisterCss();
                }
            }
        }

        #endregion

        /// <summary>
        /// Gets the <see cref="HtmlTextWriterTag"/> value that corresponds to this Web server control.
        /// </summary>
        /// <value>
        /// One of the <see cref="HtmlTextWriterTag"/> enumeration values.
        /// </value>
        protected override HtmlTextWriterTag TagKey
        {
            get { return HtmlTextWriterTag.Div; }
        }
    }
}

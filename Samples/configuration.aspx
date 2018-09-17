<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Configuration" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">

<section>
  <h2>Bootstrap Accessibility Plugins</h2>
  <p>By default, the CSS and JavaScript of the <a href="https://github.com/paypal/bootstrap-accessibility-plugin" target="_blank">PayPal Bootstrap Accessibility Plugin</a> are added to the page (using embedded resources and ClientScriptManager) when any of the following controls are added to a page:</p>
  <ul>
    <li>Alert</li>
    <li>Dropdown</li>
    <li>Carousel</li>
    <li>Modal</li>
    <li>TabControl</li>
  </ul>
  <p>This behavior can be modified in the <code>appSettings</code> section of your root <code>web.config</code> file.</p>
  <p>If you are already including the Bootstrap Accessibility Plugin CSS and/or JS in your site, you can disable the ClientScriptManager injection by adding one or both of the following settings:</p>
  <pre><code>&lt;add key="Bootstrap.InjectA11yCss" value="False" /&gt;
&lt;add key="Bootstrap.InjectA11yJs" value="False" /&gt;</code></pre>
  <p>Alternatively, if you don't want either injected, you can use this setting instead:</p>
  <pre><code>&lt;add key="Bootstrap.AccessibilityPlugin" value="None" /&gt;</code></pre>
  <p>If you prefer to use <a href="https://github.com/jongund/bootstrap-accessibility-plugin/" target="_blank">jongund's modified version of the PayPal Bootstrap Accessibility Plugin</a>, you can add this setting:</p>
  <pre><code>&lt;add key="Bootstrap.AccessibilityPlugin" value="JonGund" /&gt;</code></pre>
  <p><strong>Note:</strong> The value of <code>Bootstrap.AccessibilityPlugin</code> should be the same across the site. Changing the value in a child <code>web.config</code> file will lead to unexpected results as the value is loaded from configuration once and stored in a static property.</p>
</section>

<section>
  <h2>Registering the Controls</h2>
  <p>Add the following entry to your root <code>web.config</code> file. This registers the controls for use anywhere on your site with the <code>twt:</code> prefix:</p>
  <pre><code>&lt;system.web&gt;
    &lt;pages&gt;
        &lt;controls&gt;
            &lt;add tagPrefix="twt" namespace="Bootstrap.A11y" assembly="Bootstrap.A11y" /&gt;
        &lt;/controls&gt;
    &lt;/pages&gt;
&lt;/system.web&gt;</code></pre>
  <p>If you only want the Bootstrap controls to be available in part of your website, you can add the above entry to a non-root web.config file. If you want a different tag prefix than <code>twt:</code>, edit the entry accordingly.</p>
</section>
</asp:Content>

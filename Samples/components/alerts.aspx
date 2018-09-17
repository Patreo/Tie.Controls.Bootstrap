<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Alerts" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<p class="lead">Provide contextual feedback messages for typical user actions with the handful of available and flexible alert messages.</p>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#alerts-examples" target="_blank">Examples</a></h2>
  <p>Use a <code>&lt;twt:Alert&gt;</code> for basic alert messages, using the <code>AlertType</code> property defines the style.</p>
  <div class="bs-example">
    <twt:Alert runat="server" AlertType="Success">
      <strong>Well done!</strong> You successfully read this important alert message.
    </twt:Alert>
    <twt:Alert runat="server" AlertType="Info">
      <strong>Heads up!</strong> This alert needs your attention, but it's not super important.
    </twt:Alert>
    <twt:Alert runat="server" AlertType="Warning">
      <strong>Warning!</strong> Better check yourself, you're not looking too good.
    </twt:Alert>
    <twt:Alert runat="server" AlertType="Danger">
      <strong>Oh snap!</strong> Change a few things up and try submitting again.
    </twt:Alert>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Alert runat="server" AlertType="Success"&gt;
  &lt;strong&gt;Well done!&lt;/strong&gt; You successfully read this important alert message.
&lt;/twt:Alert&gt;
&lt;twt:Alert runat="server" AlertType="Info"&gt;
  &lt;strong&gt;Heads up!&lt;/strong&gt; This alert needs your attention, but it's not super important.
&lt;/twt:Alert&gt;
&lt;twt:Alert runat="server" AlertType="Warning"&gt;
  &lt;strong&gt;Warning!&lt;/strong&gt; Better check yourself, you're not looking too good.
&lt;/twt:Alert&gt;
&lt;twt:Alert runat="server" AlertType="Danger"&gt;
  &lt;strong&gt;Oh snap!&lt;/strong&gt; Change a few things up and try submitting again.
&lt;/twt:Alert&gt;
</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#alerts-dismissible" target="_blank">Dismissible alerts</a></h2>
  <p>Build on any alert by adding <code>Dismissible="true"</code>.</p>
  <div class="bs-callout bs-callout-info" id="callout-alerts-dismiss-plugin" target="_blank"><h3 class="h4">Requires JavaScript alert plugin</h3><p>For fully functioning, dismissible alerts, you must use the <a href="https://getbootstrap.com/docs/3.3/javascript/#alerts">alerts JavaScript plugin</a>.</p> </div>
  <div class="bs-example">
    <twt:Alert runat="server" AlertType="Info" Dismissible="true">
      <strong>Heads up!</strong> This alert needs your attention, but it's not super important.
    </twt:Alert>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Alert runat="server" AlertType="Info" Dismissible="true"&gt;
  &lt;strong&gt;Heads up!&lt;/strong&gt; This alert needs your attention, but it's not super important.
&lt;/twt:Alert&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#alerts-links" target="_blank">Links in alerts</a></h2>
  <p>Use the <code>.alert-link</code> utility class to quickly provide matching colored links within any alert.</p>
  <div class="bs-example">
    <twt:Alert runat="server" AlertType="Success">
      <strong>Well done!</strong> You successfully read <a href="#" class="alert-link">this important alert message</a>.
    </twt:Alert>
    <twt:Alert runat="server" AlertType="Info">
      <strong>Heads up!</strong> This <a href="#" class="alert-link">alert needs your attention</a>, but it's not super important.
    </twt:Alert>
    <twt:Alert runat="server" AlertType="Warning">
      <strong>Warning!</strong> Better check yourself, you're <a href="#" class="alert-link">not looking too good</a>.
    </twt:Alert>
    <twt:Alert runat="server" AlertType="Danger">
      <strong>Oh snap!</strong> <a href="#" class="alert-link">Change a few things up</a> and try submitting again.
    </twt:Alert>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Alert runat="server" AlertType="Success"&gt;
  &lt;strong&gt;Well done!&lt;/strong&gt; You successfully read &lt;a href="#" class="alert-link"&gt;this important alert message&lt;/a&gt;.
&lt;/twt:Alert&gt;
&lt;twt:Alert runat="server" AlertType="Info"&gt;
  &lt;strong&gt;Heads up!&lt;/strong&gt; This &lt;a href="#" class="alert-link"&gt;alert needs your attention&lt;/a&gt;, but it's not super important.
&lt;/twt:Alert&gt;
&lt;twt:Alert runat="server" AlertType="Warning"&gt;
  &lt;strong&gt;Warning!&lt;/strong&gt; Better check yourself, you're &lt;a href="#" class="alert-link"&gt;not looking too good&lt;/a&gt;.
&lt;/twt:Alert&gt;
&lt;twt:Alert runat="server" AlertType="Danger"&gt;
  &lt;strong&gt;Oh snap!&lt;/strong&gt; &lt;a href="#" class="alert-link"&gt;Change a few things up&lt;/a&gt; and try submitting again.
&lt;/twt:Alert&gt;</code></pre></figure>
</section>
</asp:Content>

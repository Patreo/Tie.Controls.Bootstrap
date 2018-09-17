<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Buttons" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#buttons-tags" target="_blank">Button Tags</a></h2>
  <p>Use a <code>&lt;twt:HyperLinkButton&gt;</code> to generate an <code>&lt;a&gt;</code> or
    <code>&lt;twt:Button&gt;</code> to generate a  <code>&lt;button&gt;</code>.</p>
  <div class="bs-example">
    <twt:HyperLinkButton runat="server" Text="Link" NavigateUrl="#" />
    <twt:Button runat="server" Text="Button" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:HyperLinkButton runat="server" Text="Link" NavigateUrl="#" /&gt;
&lt;twt:Button runat="server" Text="Button" /&gt;</code></pre></figure>
</section>

<div class="bs-callout bs-callout-warning" id="callout-buttons-context-usage">
	<h3>Context-specific usage</h3>
	<p>Only <code>&lt;twt:Button&gt;</code> controls are supported within Bootstrap nav and navbar components.</p>
</div>

<div class="bs-callout bs-callout-warning" id="callout-buttons-ff-height">
	<h3>Cross-browser rendering</h3>
	<p>As a best practice, <strong>we highly recommend using the <code>&lt;twt:Button&gt;</code> element whenever possible</strong> to ensure matching cross-browser rendering.</p>
	<p>Among other things, there's <a href="https://bugzilla.mozilla.org/show_bug.cgi?id=697451" target="_blank">a bug in Firefox &lt;30</a> that prevents us from setting the <code>line-height</code> of <code>&lt;input&gt;</code>-based buttons, causing them to not exactly match the height of other buttons on Firefox.</p>
</div>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#buttons-options" target="_blank">Options</a></h2>
  <p>Use the <code>ButtonType</code> property to quickly create a styled button.</p>
  <div class="bs-example">
    <twt:Button runat="server" ButtonType="Default" Text="Default" />
    <twt:Button runat="server" ButtonType="Primary" Text="Primary" />
    <twt:Button runat="server" ButtonType="Success" Text="Success" />
    <twt:Button runat="server" ButtonType="Info"    Text="Info" />
    <twt:Button runat="server" ButtonType="Warning" Text="Warning" />
    <twt:Button runat="server" ButtonType="Danger"  Text="Danger" />
    <twt:Button runat="server" ButtonType="Link"    Text="Link" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Button runat="server" ButtonType="Default" Text="Default" /&gt;
&lt;twt:Button runat="server" ButtonType="Primary" Text="Primary" /&gt;
&lt;twt:Button runat="server" ButtonType="Success" Text="Success" /&gt;
&lt;twt:Button runat="server" ButtonType="Info"    Text="Info" /&gt;
&lt;twt:Button runat="server" ButtonType="Warning" Text="Warning" /&gt;
&lt;twt:Button runat="server" ButtonType="Danger"  Text="Danger" /&gt;
&lt;twt:Button runat="server" ButtonType="Link"    Text="Link" /&gt;</code></pre></figure>
</section>
<div class="bs-callout bs-callout-warning" id="callout-buttons-color-accessibility"> <h3 class="h4">Conveying meaning to assistive technologies</h3> <p>Using color to add meaning to a button only provides a visual indication, which will not be conveyed to users of assistive technologies – such as screen readers. Ensure that information denoted by the color is either obvious from the content itself (the visible text of the button), or is included through alternative means, such as additional text hidden with the <code>.sr-only</code> class.</p> </div>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#buttons-sizes" target="_blank">Sizes</a></h2>
  <p>Fancy larger or smaller buttons? Use the <code>ButtonSize</code> property for additional sizes.</p>
  <div class="bs-example">
    <p>
      <twt:Button runat="server" ButtonType="Primary" ButtonSize="Large"   Text="Large button" />
      <twt:Button runat="server" ButtonType="Default" ButtonSize="Large"   Text="Large button" />
    </p>
    <p>
      <twt:Button runat="server" ButtonType="Primary" ButtonSize="Default" Text="Default button" />
      <twt:Button runat="server" ButtonType="Default" ButtonSize="Default" Text="Default button" />
    </p>
    <p>
      <twt:Button runat="server" ButtonType="Primary" ButtonSize="Small"   Text="Small button" />
      <twt:Button runat="server" ButtonType="Default" ButtonSize="Small"   Text="Small button" />
    </p>
    <p>
      <twt:Button runat="server" ButtonType="Primary" ButtonSize="Mini"    Text="Extra small button" />
      <twt:Button runat="server" ButtonType="Default" ButtonSize="Mini"    Text="Extra small button" />
    </p>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;p&gt;
  &lt;twt:Button runat="server" ButtonType="Primary" ButtonSize="Large"   Text="Large button" /&gt;
  &lt;twt:Button runat="server" ButtonType="Default" ButtonSize="Large"   Text="Large button" /&gt;
&lt;/p&gt;
&lt;p&gt;
  &lt;twt:Button runat="server" ButtonType="Primary" ButtonSize="Default" Text="Default button" /&gt;
  &lt;twt:Button runat="server" ButtonType="Default" ButtonSize="Default" Text="Default button" /&gt;
&lt;/p&gt;
&lt;p&gt;
  &lt;twt:Button runat="server" ButtonType="Primary" ButtonSize="Small"   Text="Small button" /&gt;
  &lt;twt:Button runat="server" ButtonType="Default" ButtonSize="Small"   Text="Small button" /&gt;
&lt;/p&gt;
&lt;p&gt;
  &lt;twt:Button runat="server" ButtonType="Primary" ButtonSize="Mini"    Text="Extra small button" /&gt;
  &lt;twt:Button runat="server" ButtonType="Default" ButtonSize="Mini"    Text="Extra small button" /&gt;
&lt;/p&gt;</code></pre></figure>
</section>
<hr />
<section>
  <h3>Block level buttons</h3>
  <p>Create block level buttons—those that span the full width of a parent—by setting <code>Block="true"</code>.</p>
  <div class="bs-example">
    <twt:Button runat="server" ButtonType="Primary" Block="true" Text="Block level button" />
    <twt:Button runat="server" ButtonType="Default" Block="true" Text="Block level button" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Button runat="server" ButtonType="Primary" Block="true" Text="Block level button" /&gt;
&lt;twt:Button runat="server" ButtonType="Default" Block="true" Text="Block level button" /&gt;</code></pre></figure>
</section>
<hr />
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#buttons-active" target="_blank">Active state</a></h2>
  <p><code>&lt;twt:Button&gt;</code>s and <code>&lt;twt:HyperLinkButton&gt;</code>s will appear pressed (with a darker background, darker border, and inset shadow) when <code>Pressed="true"</code>.</p>
  <div class="bs-example">
    <twt:Button runat="server" ButtonType="Primary" Pressed="true" Text="Primary button" />
    <twt:HyperLinkButton runat="server" ButtonType="Default" Pressed="true" Text="Button" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Button runat="server" ButtonType="Primary" Pressed="true" Text="Primary button" /&gt;
&lt;twt:HyperLinkButton runat="server" ButtonType="Default" Pressed="true" Text="Button" /&gt;</code></pre></figure>
</section>
<hr />
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#buttons-disabled" target="_blank">Disabled state</a></h2>
  <p>Make buttons unclickable by setting <code>Enabled="false"</code>.</p>
  <div class="bs-example">
    <twt:Button runat="server" ButtonType="Primary" Enabled="false" Text="Primary button" />
    <twt:Button runat="server" ButtonType="Default" Enabled="false" Text="Button" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Button runat="server" ButtonType="Primary" Enabled="false" Text="Primary button" /&gt;
&lt;twt:Button runat="server" ButtonType="Default" Enabled="false" Text="Button" /&gt;</code></pre></figure>
</section>



</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Popovers" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<p>Add small overlays of content, like those on the iPad, to any element for housing secondary information.</p>
<div class="bs-callout bs-callout-danger" id="callout-popover-needs-tooltip"> <h2 class="h4">Plugin dependency</h2> <p>Popovers require the <a href="https://getbootstrap.com/docs/3.3/javascript/#tooltips">tooltip plugin</a> to be included in your version of Bootstrap.</p> </div>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/javascript/#live-demo-1" target="_blank">Live demo</a></h2>
  <div class="bs-example">
    <twt:Button runat="server" ButtonSize="Large" ButtonType="Danger" Text="Click to toggle popover">
      <Popover runat="server" Title="Popover title"  Position="Right"
         Text="And here's some amazing content. It's very engaging. Right?"/>
    </twt:Button>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Button runat="server" ButtonSize="Large" ButtonType="Danger" Text="Click to toggle popover"&gt;
  &lt;Popover runat="server" Title="Popover title"  Position="Right"
     Text="And here's some amazing content. It's very engaging. Right?"/&gt;
&lt;/twt:Button&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/javascript/#four-directions-1" target="_blank">Four directions</a></h2>
  <p>Four <code>Position</code> options are available: <code>Top</code>, <code>Right</code>, <code>Bottom</code>, and <code>Left</code>.</p>
  <div class="bs-example">
    <twt:Button runat="server" Text="Popover on right">
      <Popover runat="server" Position="Right" Text="Vivamus sagittis lacus vel augue laoreet rutrum faucibus."/>
    </twt:Button>
    <twt:Button runat="server" Text="Popover on top">
      <Popover runat="server" Position="Top" Text="Vivamus sagittis lacus vel augue laoreet rutrum faucibus."/>
    </twt:Button>
    <twt:Button runat="server" Text="Popover on bottom">
      <Popover runat="server" Position="Bottom" Text="Vivamus sagittis lacus vel augue laoreet rutrum faucibus."/>
    </twt:Button>
    <twt:Button runat="server" Text="Popover on left">
      <Popover runat="server" Position="Left" Text="Vivamus sagittis lacus vel augue laoreet rutrum faucibus."/>
    </twt:Button>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Button runat="server" Text="Popover on right"&gt;
  &lt;Popover runat="server" Position="Right" Text="Vivamus sagittis lacus vel augue laoreet rutrum faucibus."/&gt;
&lt;/twt:Button&gt;
&lt;twt:Button runat="server" Text="Popover on top"&gt;
  &lt;Popover runat="server" Position="Top" Text="Vivamus sagittis lacus vel augue laoreet rutrum faucibus."/&gt;
&lt;/twt:Button&gt;
&lt;twt:Button runat="server" Text="Popover on bottom"&gt;
  &lt;Popover runat="server" Position="Bottom" Text="Vivamus sagittis lacus vel augue laoreet rutrum faucibus."/&gt;
&lt;/twt:Button&gt;
&lt;twt:Button runat="server" Text="Popover on left"&gt;
  &lt;Popover runat="server" Position="Left" Text="Vivamus sagittis lacus vel augue laoreet rutrum faucibus."/&gt;
&lt;/twt:Button&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/javascript/#dismiss-on-next-click" target="_blank">Dismiss on next click</a></h2>
  <p>Use <code>DismissOnNextClick="true"</code> to dismiss popovers on the next click that the user makes.</p>
  <div class="bs-example">
    <twt:HyperLinkButton runat="server" ButtonSize="Large" ButtonType="Danger" Text="Dismissible popover">
      <Popover runat="server" Title="Dismissible popover"  Position="Right" DismissOnNextClick="true"
         Text="And here's some amazing content. It's very engaging. Right?"/>
    </twt:HyperLinkButton>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:HyperLinkButton runat="server" ButtonSize="Large" ButtonType="Danger" Text="Dismissible popover"&gt;
  &lt;Popover runat="server" Title="Dismissible popover"  Position="Right" DismissOnNextClick="true"
     Text="And here's some amazing content. It's very engaging. Right?"/&gt;
&lt;/twt:HyperLinkButton&gt;</code></pre></figure>
</section>
</asp:Content>

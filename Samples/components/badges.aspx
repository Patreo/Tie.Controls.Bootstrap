<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" Title="Badges" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
  <p class="lead">Easily highlight new or unread items by adding a <code>&lt;twt:Badge&gt;</code> to links, Bootstrap navs, and more.</p>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#badges" target="_blank">Basic example</a></h2>
  <div class="bs-example">
    <a href="#">
      Inbox
      <twt:Badge runat="server">42</twt:Badge>
    </a>
    <twt:Button runat="server" ButtonType="Primary">
      Messages <twt:Badge runat="server" text="4" />
    </twt:Button>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;a href="#"&gt;
  Inbox
  &lt;twt:Badge runat="server"&gt;42&lt;/twt:Badge&gt;
&lt;/a&gt;
&lt;twt:Button runat="server" ButtonType="Primary"&gt;
  Messages &lt;twt:Badge runat="server" text="4" /&gt;
&lt;/twt:Button&gt;</code></pre></figure>
  <hr />
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#self-collapsing" target="_blank">Self collapsing</a></h2>
  <p>When there are no new or unread items, badges will simply collapse (via CSS's <code>:empty</code> selector) provided no content exists within.</p>
  <div class="bs-callout bs-callout-danger" id="callout-badges-ie8-empty"> <h3 class="h4">Cross-browser compatibility</h3> <p>Badges won't self collapse in Internet Explorer 8 because it lacks support for the <code>:empty</code> selector.</p> </div>
  <div class="bs-example">
    <a href="#">
      Inbox
      <twt:Badge runat="server" />
    </a>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;a href="#"&gt;
  Inbox
  &lt;twt:Badge runat="server" /&gt;
&lt;/a&gt;</code></pre></figure>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#adapts-to-active-nav-states" target="_blank">Adapts to active nav states</a></h2>
  <p>Built-in styles are included for placing badges in active states in pill navigations.</p>
  <div class="bs-example">
    <ul class="nav nav-pills" role="tablist">
      <li role="presentation" class="active"><a href="#">Home <twt:Badge runat="server">42</twt:Badge></a></li>
      <li role="presentation"><a href="#">Profile</a></li>
      <li role="presentation"><a href="#">Messages <twt:Badge runat="server">3</twt:Badge></a></li>
    </ul>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;ul class="nav nav-pills" role="tablist"&gt;
  &lt;li role="presentation" class="active"&gt;&lt;a href="#"&gt;Home &lt;twt:Badge runat="server"&gt;42&lt;/twt:Badge&gt;&lt;/a&gt;&lt;/li&gt;
  &lt;li role="presentation"&gt;&lt;a href="#"&gt;Profile&lt;/a&gt;&lt;/li&gt;
  &lt;li role="presentation"&gt;&lt;a href="#"&gt;Messages &lt;twt:Badge runat="server"&gt;3&lt;/twt:Badge&gt;&lt;/a&gt;&lt;/li&gt;
&lt;/ul&gt;</code></pre></figure>

</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Dropdowns" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<p class="lead">Toggleable, contextual menu for displaying lists of links. Made interactive with the <a href="https://getbootstrap.com/docs/3.3/javascript/#dropdowns" target="_blank">dropdown JavaScript plugin</a>.</p>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#dropdowns-example" target="_blank">Example</a></h2>
  <div class="bs-example" data-example-id="static-dropdown">
    <twt:Dropdown runat="server"
      Text="Dropdown"
      Expanded="true"
      ID="dropdownMenu1"
      ClientIDMode="Static"
      CssClass="clearfix"
    >
      <Items>
        <twt:ListItem runat="server" NavigateUrl="#" Text="Action" />
        <twt:ListItem runat="server" NavigateUrl="#" Text="Another action" />
        <twt:ListItem runat="server" NavigateUrl="#" Text="Something else here" />
      </Items>
    </twt:Dropdown>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Dropdown runat="server"
  Text="Dropdown"
  Expanded="true"
  ID="dropdownMenu1"
  ClientIDMode="Static"
&gt;
  &lt;Items&gt;
    &lt;twt:ListItem runat="server" NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem runat="server" NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem runat="server" NavigateUrl="#" Text="Something else here" /&gt;
  &lt;/Items&gt;
&lt;/twt:Dropdown&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#dropdowns" target="_blank">Dropup</a></h2>
  <p>Dropdown menus can be changed to expand upwards (instead of downwards) by setting <code>DropUp="true"</code>.</p>
  <div class="bs-example">
    <twt:Dropdown runat="server"
      Text="Dropup"
      DropUp="true"
      ID="dropdownMenu2"
      ClientIDMode="Static"
    >
      <Items>
        <twt:ListItem runat="server" NavigateUrl="#" Text="Action" />
        <twt:ListItem runat="server" NavigateUrl="#" Text="Another action" />
        <twt:ListItem runat="server" NavigateUrl="#" Text="Something else here" />
      </Items>
    </twt:Dropdown>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Dropdown runat="server"
  Text="Dropup"
  DropUp="true"
  ID="dropdownMenu2"
  ClientIDMode="Static"
&gt;
  &lt;Items&gt;
    &lt;twt:ListItem runat="server" NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem runat="server" NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem runat="server" NavigateUrl="#" Text="Something else here" /&gt;
  &lt;/Items&gt;
&lt;/twt:Dropdown&gt;
&lt;pre&gt;&lt;/pre&gt;
&lt;/section&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#dropdowns-alignment" target="_blank">Alignment</a></h2>
  <p>
    By default, a dropdown menu is automatically positioned 100% from the top and along the left side of its parent.
    Add <code>RightToLeft="true"</code> to right align the dropdown menu.
  </p>
  <div class="bs-callout bs-callout-warning" id="callout-dropdown-positioning"><h3 class="h4">May require additional positioning</h3> <p>Dropdowns are automatically positioned via CSS within the normal flow of the document. This means dropdowns may be cropped by parents with certain <code>overflow</code> properties or appear out of bounds of the viewport. Address these issues on your own as they arise.</p> </div>
  <div class="bs-example">
    <div class="pull-right">
      <twt:Dropdown runat="server"
        Text="Right to left"
        RightToLeft="true"
        Expanded="true"
      >
        <Items>
          <twt:ListItem runat="server" NavigateUrl="#" Text="Action" />
          <twt:ListItem runat="server" NavigateUrl="#" Text="Another action" />
          <twt:ListItem runat="server" NavigateUrl="#" Text="Something else here" />
        </Items>
      </twt:Dropdown>
    </div>
    <div class="clearfix"></div>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Dropdown runat="server"
  Text="Right to left"
  RightToLeft="true"
&gt;
  &lt;Items&gt;
    &lt;twt:ListItem runat="server" NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem runat="server" NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem runat="server" NavigateUrl="#" Text="Something else here" /&gt;
  &lt;/Items&gt;
&lt;/twt:Dropdown&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#dropdowns-headers" target="_blank">Headers, Dividers, and Disabled menu items</a></h2>
  <p>
    Add a <code>&lt;twt:ListHeader&gt;</code> to label sections of actions in any dropdown menu or a 
    <code>&lt;twt:ListSeparator&gt;</code> to separate series of links in a dropdown menu.
    Set <code>Enabled="false"</code> on a <code>&lt;twt:ListItem&gt;</code> to disable the link.
  </p>
  <div class="bs-example">
    <twt:Dropdown runat="server"
      Text="Dropdown"
      ID="dropdownMenu3"
      ClientIDMode="Static"
      Expanded="true"
      CssClass="clearfix"
    >
      <Items>
        <twt:ListHeader runat="server" Text="Dropdown header" />
        <twt:ListItem runat="server" NavigateUrl="#" Text="Action" />
        <twt:ListItem runat="server" NavigateUrl="#" Text="Another action" />
        <twt:ListItem runat="server" NavigateUrl="#" Enabled="false" Text="Disabled link" />
        <twt:ListSeparator runat="server" />
        <twt:ListHeader runat="server" Text="Dropdown header" />
        <twt:ListItem runat="server" NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:Dropdown>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Dropdown runat="server"
  Text="Dropdown"
  ID="dropdownMenu3"
  ClientIDMode="Static"
&gt;
  &lt;Items&gt;
    &lt;twt:ListHeader runat="server" Text="Dropdown header" /&gt;
    &lt;twt:ListItem runat="server" NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem runat="server" NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem runat="server" NavigateUrl="#" Enabled="false" Text="Disabled link" /&gt;
    &lt;twt:ListSeparator runat="server" /&gt;
    &lt;twt:ListHeader runat="server" Text="Dropdown header" /&gt;
    &lt;twt:ListItem runat="server" NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:Dropdown&gt;</code></pre></figure>
</section>

</asp:Content>

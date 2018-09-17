<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Breadcrumbs" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<p class="lead">Indicate the current page's location within a navigational hierarchy.</p>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#breadcrumbs" target="_blank">Example</a></h2>
  <p>Separators are automatically added in CSS through <code>:before</code> and <code>content</code>.</p>
  <div class="bs-example">
    <twt:Breadcrumbs runat="server">
      <Items>
        <twt:BreadcrumbsItem runat="server" NavigateUrl="#" Text="Data" />
      </Items>
    </twt:Breadcrumbs>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Breadcrumbs runat="server"&gt;
  &lt;Items&gt;
    &lt;twt:BreadcrumbsItem runat="server" NavigateUrl="#" Text="Data" /&gt;
  &lt;/Items&gt;
&lt;/twt:Breadcrumbs&gt;</code></pre></figure>
  <div class="bs-example">
    <twt:Breadcrumbs runat="server">
      <Items>
        <twt:BreadcrumbsItem runat="server" NavigateUrl="#" Text="Home" />
        <twt:BreadcrumbsItem runat="server" Text="Library" />
      </Items>
    </twt:Breadcrumbs>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Breadcrumbs runat="server"&gt;
  &lt;Items&gt;
    &lt;twt:BreadcrumbsItem runat="server" NavigateUrl="#" Text="Home" /&gt;
    &lt;twt:BreadcrumbsItem runat="server" Text="Library" /&gt;
  &lt;/Items&gt;
&lt;/twt:Breadcrumbs&gt;</code></pre></figure>
  <p>
    By default, the output will include <a href="http://schema.org/BreadcrumbList" target="_blank">schema.org BreadcrumbList</a> markup.
    To disable this behavior, set <code>AddSchemaMarkup="false"</code>.
  </p>
  <div class="bs-example">
    <twt:Breadcrumbs runat="server" AddSchemaMarkup="false">
      <Items>
        <twt:BreadcrumbsItem runat="server" NavigateUrl="#" Text="Home" />
        <twt:BreadcrumbsItem runat="server" NavigateUrl="#" Text="Library" />
        <twt:BreadcrumbsItem runat="server" Text="Data" />
      </Items>
    </twt:Breadcrumbs>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Breadcrumbs runat="server" AddSchemaMarkup="false"&gt;
  &lt;Items&gt;
    &lt;twt:BreadcrumbsItem runat="server" NavigateUrl="#" Text="Home" /&gt;
    &lt;twt:BreadcrumbsItem runat="server" NavigateUrl="#" Text="Library" /&gt;
    &lt;twt:BreadcrumbsItem runat="server" Text="Data" /&gt;
  &lt;/Items&gt;
&lt;/twt:Breadcrumbs&gt;</code></pre></figure>
</section>

</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Pagination" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<p class="lead">Provide pagination links for your site or app with the multi-page pagination component.</p>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#pagination-default" target="_blank">Default pagination</a></h2>
  <p>Simple pagination inspired by Rdio, great for apps and search results. The large block is hard to miss, easily scalable, and provides large click areas.</p>
  <div class="bs-example">
    <twt:Paginator runat="server" ItemCount="5" PageSize="1" CurrentPageIndex="-1" Label="Search results pages" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Paginator runat="server" ItemCount="5" PageSize="1" CurrentPageIndex="-1" Label="Search results pages" /&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#disabled-and-active-states" target="_blank">Disabled and active states</a></h2>
  <p>Links are customizable for different circumstances. Use <code>CurrentPageIndex</code> to indicate the current page.</p>
  <div class="bs-example">
    <twt:Paginator runat="server" ItemCount="5" PageSize="1" CurrentPageIndex="0" Label="Search results pages" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Paginator runat="server" ItemCount="5" PageSize="1" CurrentPageIndex="0" Label="Search results pages" /&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#sizing" target="_blank">Sizing</a></h2>
  <p>Fancy larger or smaller pagination? Add <code>Size="Large"</code> or <code>Size="Small"</code>.</p>
  <div class="bs-example">
    <twt:Paginator runat="server" ItemCount="5" PageSize="1" CurrentPageIndex="-1" Label="Search results pages" Size="Large" />
    <twt:Paginator runat="server" ItemCount="5" PageSize="1" CurrentPageIndex="-1" Label="Search results pages" Size="Default" />
    <twt:Paginator runat="server" ItemCount="5" PageSize="1" CurrentPageIndex="-1" Label="Search results pages" Size="Small" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Paginator runat="server" ItemCount="5" PageSize="1" CurrentPageIndex="-1" Label="Search results pages" Size="Large" /&gt;
&lt;twt:Paginator runat="server" ItemCount="5" PageSize="1" CurrentPageIndex="-1" Label="Search results pages" Size="Default" /&gt;
&lt;twt:Paginator runat="server" ItemCount="5" PageSize="1" CurrentPageIndex="-1" Label="Search results pages" Size="Small" /&gt;</code></pre></figure>
</section>
  
</asp:Content>

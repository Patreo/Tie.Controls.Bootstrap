<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Tables" CodeBehind="tables.aspx.cs" CodeFile="tables.aspx.cs" Inherits="Samples.css.Tables" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#tables-example" target="_blank">Basic example</a> <small>with GridViewPager</small></h2>
  <p>Use the <code>&lt;twt:GridView&gt;</code> (and, optionally, <code>&lt;twt:GridViewPager&gt;</code>) for Bootstrap tables.</p>
  <div class="bs-example bs-example-type" data-example-id="simple-headings">
    <twt:GridView runat="server" ID="gvBasic" AutoGenerateColumns="true" Responsive="false" Caption="User grid with paging"
      OnPageIndexChanging="gvBasic_PageIndexChanging" 
      OnSorting="gvBasic_Sorting">
      <PagerTemplate>
        <twt:GridViewPager runat="server" ID="gvBasicPager" GridViewID="gvBasic" Label="User Pages" />
      </PagerTemplate>
    </twt:GridView>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:GridView runat="server" ID="gvBasic" AutoGenerateColumns="true" Responsive="false" Caption="User grid with paging"
  OnPageIndexChanging="gvBasic_PageIndexChanging" 
  OnSorting="gvBasic_Sorting"&gt;
  &lt;PagerTemplate&gt;
    &lt;twt:GridViewPager runat="server" ID="gvBasicPager" GridViewID="gvBasic" Label="User Pages" /&gt;
  &lt;/PagerTemplate&gt;
&lt;/twt:GridView&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#tables-striped" target="_blank">Striped rows</a></h2>
  <p>Use <code>Striped="true"</code> to add zebra-striping to any table row within the <code>&lt;tbody&gt;</code>.</p>
  <div class="bs-example">
    <twt:GridView runat="server" ID="gvStriped" Responsive="false" Striped="true" Caption="User grid with striped rows" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:GridView runat="server" ID="gvStriped" Responsive="false" Striped="true" Caption="User grid with striped rows" /&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#tables-bordered" target="_blank">Bordered table</a></h2>
  <p>Add <code>GridLines="Both"</code> for borders on all sides of the table and cells.</p>
  <div class="bs-example">
    <twt:GridView runat="server" ID="gvBordered" Responsive="false" GridLines="Both" Caption="User grid with cell borders" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:GridView runat="server" ID="gvBordered" Responsive="false" GridLines="Both" Caption="User grid with cell borders" /&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#tables-hover-rows" target="_blank">Hover rows</a></h2>
  <p>Add <code>HoverRow="true"</code> to enable a hover state on table rows within a <code>&lt;tbody&gt;</code>.</p>
  <div class="bs-example">
    <twt:GridView runat="server" ID="gvHover" Responsive="false" HoverRow="true" Caption="User grid with highlight on hover" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:GridView runat="server" ID="gvHover" Responsive="false" HoverRow="true" Caption="User grid with highlight on hover" /&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#tables-condensed" target="_blank">Condensed table</a></h2>
  <p>Add <code>Condensed="true"</code> to make tables more compact by cutting cell padding in half.</p>
  <div class="bs-example">
    <twt:GridView runat="server" ID="gvCondensed" Responsive="false" Condensed="true" Caption="User grid with reduced cell padding" />
  <//div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:GridView runat="server" ID="gvCondensed" Responsive="false" Condensed="true" Caption="User grid with reduced cell padding" /&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#tables-responsive" target="_blank">Responsive tables</a></h2>
  <p>
    Create responsive tables by setting <code>Responsive="true"</code> to make them scroll horizontally on small devices (under 768px). 
    When viewing on anything larger than 768px wide, you will not see any difference in these tables.
  </p>
  <div class="bs-example">
    <twt:GridView runat="server" ID="gvResponsive" Responsive="true" Caption="User grid with horizontal scroll on narrow screens" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:GridView runat="server" ID="gvResponsive" Responsive="true" Caption="User grid with horizontal scroll on narrow screens" /&gt;</code></pre></figure>
</section>

</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" Title="Jumbotron" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
  <p class="lead">A lightweight, flexible component that can optionally extend the entire viewport to showcase key content on your site.</p>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#jumbotron" target="_blank">Jumbotron example</a></h2>
  <div class="bs-example">
    <twt:Jumbotron runat="server">
      <Header>
        <h3 class="h1">Hello, world!</h3>
      </Header>
      <Content>
        <p>This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
        <p><a href="#" class="btn btn-primary btn-lg" role="button">Learn more</a></p>
      </Content>
    </twt:Jumbotron>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Jumbotron runat="server"&gt;
  &lt;Header&gt;
    &lt;h3 class="h1"&gt;Hello, world!&lt;/h3&gt;
  &lt;/Header&gt;
  &lt;Content&gt;
    &lt;p&gt;This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.&lt;/p&gt;
    &lt;p&gt;&lt;a href="#" class="btn btn-primary btn-lg" role="button"&gt;Learn more&lt;/a&gt;&lt;/p&gt;
  &lt;/Content&gt;
&lt;/twt:Jumbotron&gt;</code></pre></figure>
</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Images" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#images-responsive" target="_blank">Responsive images</a></h2>
  <p><code>&lt;twt:Image&gt;</code>s can be made responsive-friendly via the addition of the <code>Responsive="true"</code>.</p>
  <div class="bs-example">
    <twt:Image runat="server"
      ImageUrl="https://via.placeholder.com/1400x400"
      Responsive="true"
      AlternateText="Responsive image"
    />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Image runat="server"
  ImageUrl="https://via.placeholder.com/1400x400"
  Responsive="true"
  AlternateText="Responsive image"
/&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#images-shapes" target="_blank">Image shapes</a></h2>
  <p>Set the <code>ImageType</code> property to easily style images in any project.</p>
  <div class="bs-callout bs-callout-danger" id="callout-images-ie-rounded-corners"> <h3 class="h4">Cross-browser compatibility</h3> <p>Keep in mind that Internet Explorer 8 lacks support for rounded corners.</p> </div>
  <div class="bs-example">
    <twt:Image runat="server"
      ImageUrl="https://via.placeholder.com/140x140"
      ImageType="Rounded"
      AlternateText="Rounded image"
    />
    <twt:Image runat="server"
      ImageUrl="https://via.placeholder.com/140x140"
      ImageType="Circle"
      AlternateText="Circle image"
    />
    <twt:Image runat="server"
      ImageUrl="https://via.placeholder.com/140x140"
      ImageType="Polaroid"
      AlternateText="Polaroid image"
    />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Image runat="server"
  ImageUrl="https://via.placeholder.com/140x140"
  ImageType="Rounded"
  AlternateText="Rounded image"
/&gt;
&lt;twt:Image runat="server"
  ImageUrl="https://via.placeholder.com/140x140"
  ImageType="Circle"
  AlternateText="Circle image"
/&gt;
&lt;twt:Image runat="server"
  ImageUrl="https://via.placeholder.com/140x140"
  ImageType="Polaroid"
  AlternateText="Polaroid image"
/&gt;</code></pre></figure>
</section>
</asp:Content>

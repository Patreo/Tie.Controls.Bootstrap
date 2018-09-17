<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" Title="Responsive Embed" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#responsive-embed" target="_blank">Responsive embed</a></h2>
  <p>Allow browsers to determine video or slideshow dimensions based on the width of their containing block by creating an intrinsic ratio that will properly scale on any device.</p>
  <p>Valid values for <code>AspectRatio</code> are <code>SixteenByNine</code> (default) and <code>FourByThree</code>.</p>
  <p>Rules are directly applied to <code>&lt;iframe&gt;</code>, <code>&lt;embed&gt;</code>, <code>&lt;video&gt;</code>, and <code>&lt;object&gt;</code> elements; optionally use an explicit descendant class <code>.embed-responsive-item</code> when you want to match the styling for other attributes.</p>
  <p><strong>Pro-Tip!</strong> You don't need to include <code>frameborder="0"</code> in your <code>&lt;iframe&gt;</code>s as we override that for you.</p>
  <div class="bs-example">
    <twt:ResponsiveEmbed runat="server" AspectRatio="SixteenByNine">
      <iframe class="embed-responsive-item" src="//www.youtube.com/embed/zpOULjyy-n8?rel=0" allowfullscreen></iframe>
    </twt:ResponsiveEmbed>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ResponsiveEmbed runat="server" AspectRatio="SixteenByNine"&gt;
  &lt;iframe class="embed-responsive-item" src="//www.youtube.com/embed/zpOULjyy-n8?rel=0" allowfullscreen&gt;&lt;/iframe&gt;
&lt;/twt:ResponsiveEmbed&gt;</code></pre></figure>
</section>
</asp:Content>

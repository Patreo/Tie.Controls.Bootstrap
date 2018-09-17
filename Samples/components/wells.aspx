<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Wells" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#default-well" target="_blank">Default well</a></h2>
  <p>Use the <code>&lt;twt:Well&gt;</code> as a simple effect on an element to give it an inset effect.</p>
  <div class="bs-example">
    <twt:Well runat="server">
      <Content>
        Look, I'm in a well!
      </Content>
    </twt:Well>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Well runat="server"&gt;
  &lt;Content&gt;
    Look, I'm in a well!
  &lt;/Content&gt;
&lt;/twt:Well&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#optional-classes" target="_blank">Optional classes</a></h2>
  <p>Control padding and rounded corners with <code>Size="Large"</code> or <code>Size="Small"</code>.</p>
  <div class="bs-example">
    <twt:Well runat="server" Size="Large">
      <Content>
        Look, I'm in a large well!
      </Content>
    </twt:Well>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Well runat="server" Size="Large"&gt;
  &lt;Content&gt;
    Look, I'm in a large well!
  &lt;/Content&gt;
&lt;/twt:Well&gt;</code></pre></figure>

  <div class="bs-example">
    <twt:Well runat="server" Size="Small">
      <Content>
        Look, I'm in a small well!
      </Content>
    </twt:Well>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Well runat="server" Size="Small"&gt;
  &lt;Content&gt;
    Look, I'm in a small well!
  &lt;/Content&gt;
&lt;/twt:Well&gt;</code></pre></figure>
</section>
</asp:Content>

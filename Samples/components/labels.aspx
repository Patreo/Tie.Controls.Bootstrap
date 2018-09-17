<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Labels" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#example" target="_blank">Example</a></h2>
  <div class="bs-example">
    <twt:Heading H="1" runat="server">
      Example heading
      <twt:Label runat="server" Text="New" />
    </twt:Heading>
    <twt:Heading H="2" runat="server">
      Example heading
      <twt:Label runat="server" Text="New" />
    </twt:Heading>
    <twt:Heading H="3" runat="server">
      Example heading
      <twt:Label runat="server" Text="New" />
    </twt:Heading>
    <twt:Heading H="4" runat="server">
      Example heading
      <twt:Label runat="server" Text="New" />
    </twt:Heading>
    <twt:Heading H="5" runat="server">
      Example heading
      <twt:Label runat="server" Text="New" />
    </twt:Heading>
    <twt:Heading H="6" runat="server">
      Example heading
      <twt:Label runat="server" Text="New" />
    </twt:Heading>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Heading H="1" runat="server"&gt;
  Example heading
  &lt;twt:Label runat="server" Text="New" /&gt;
&lt;/twt:Heading&gt;
&lt;twt:Heading H="2" runat="server"&gt;
  Example heading
  &lt;twt:Label runat="server" Text="New" /&gt;
&lt;/twt:Heading&gt;
&lt;twt:Heading H="3" runat="server"&gt;
  Example heading
  &lt;twt:Label runat="server" Text="New" /&gt;
&lt;/twt:Heading&gt;
&lt;twt:Heading H="4" runat="server"&gt;
  Example heading
  &lt;twt:Label runat="server" Text="New" /&gt;
&lt;/twt:Heading&gt;
&lt;twt:Heading H="5" runat="server"&gt;
  Example heading
  &lt;twt:Label runat="server" Text="New" /&gt;
&lt;/twt:Heading&gt;
&lt;twt:Heading H="6" runat="server"&gt;
  Example heading
  &lt;twt:Label runat="server" Text="New" /&gt;
&lt;/twt:Heading&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#available-variations" target="_blank">Available variations</a></h2>
  <p>Use the <code>LabelType</code> property to change the appearance of a label.</p>
  <div class="bs-example">
    <twt:Label runat="server" LabelType="Default" Text="Default" />
    <twt:Label runat="server" LabelType="Primary" Text="Primary" />
    <twt:Label runat="server" LabelType="Success" Text="Success" />
    <twt:Label runat="server" LabelType="Info"    Text="Info" />
    <twt:Label runat="server" LabelType="Warning" Text="Warning" />
    <twt:Label runat="server" LabelType="Danger"  Text="Danger" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Label runat="server" LabelType="Default" Text="Default" /&gt;
&lt;twt:Label runat="server" LabelType="Primary" Text="Primary" /&gt;
&lt;twt:Label runat="server" LabelType="Success" Text="Success" /&gt;
&lt;twt:Label runat="server" LabelType="Info"    Text="Info" /&gt;
&lt;twt:Label runat="server" LabelType="Warning" Text="Warning" /&gt;
&lt;twt:Label runat="server" LabelType="Danger"  Text="Danger" /&gt;</code></pre></figure>
</section>

</asp:Content>

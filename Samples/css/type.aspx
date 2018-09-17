<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Typography" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">

<section>
  <div class="bs-example">
    <twt:PageHeader runat="server"
      Title="Foo"
      SubText="Bar" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:PageHeader runat="server"
    Title="Foo"
    SubText="Bar" /&gt;</code></pre></figure>
</section>
    
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#type-headings" target="_blank">Headings</a></h2>
  <p>
    All HTML headings, <code>&lt;h1&gt;</code> through <code>&lt;h6&gt;</code>, are available using the <code>&lt;twt:Heading&gt;</code>
    tag and its <code>H</code> property.
  </p>
  <div class="bs-example">
    <twt:Heading runat="server" H="1">h1. Bootstrap heading</twt:Heading>
    <twt:Heading runat="server" H="2">h2. Bootstrap heading</twt:Heading>
    <twt:Heading runat="server" H="3">h3. Bootstrap heading</twt:Heading>
    <twt:Heading runat="server" H="4">h4. Bootstrap heading</twt:Heading>
    <twt:Heading runat="server" H="5">h5. Bootstrap heading</twt:Heading>
    <twt:Heading runat="server" H="6">h6. Bootstrap heading</twt:Heading>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Heading runat="server" H="1"&gt;h1. Bootstrap heading&lt;/twt:Heading&gt;
&lt;twt:Heading runat="server" H="2"&gt;h2. Bootstrap heading&lt;/twt:Heading&gt;
&lt;twt:Heading runat="server" H="3"&gt;h3. Bootstrap heading&lt;/twt:Heading&gt;
&lt;twt:Heading runat="server" H="4"&gt;h4. Bootstrap heading&lt;/twt:Heading&gt;
&lt;twt:Heading runat="server" H="5"&gt;h5. Bootstrap heading&lt;/twt:Heading&gt;
&lt;twt:Heading runat="server" H="6"&gt;h6. Bootstrap heading&lt;/twt:Heading&gt;
</code></pre></figure>
</section>

<section>
  <p>Create lighter, secondary text in any heading with a generic <code>&lt;small&gt;</code> tag.</p>
  <div class="bs-example">
    <twt:Heading runat="server" H="1">h1. Bootstrap heading <small>Secondary text</small></twt:Heading>
    <twt:Heading runat="server" H="2">h2. Bootstrap heading <small>Secondary text</small></twt:Heading>
    <twt:Heading runat="server" H="3">h3. Bootstrap heading <small>Secondary text</small></twt:Heading>
    <twt:Heading runat="server" H="4">h4. Bootstrap heading <small>Secondary text</small></twt:Heading>
    <twt:Heading runat="server" H="5">h5. Bootstrap heading <small>Secondary text</small></twt:Heading>
    <twt:Heading runat="server" H="6">h6. Bootstrap heading <small>Secondary text</small></twt:Heading>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Heading runat="server" H="1"&gt;h1. Bootstrap heading &lt;small&gt;Secondary text&lt;/small&gt;&lt;/twt:Heading&gt;
&lt;twt:Heading runat="server" H="2"&gt;h2. Bootstrap heading &lt;small&gt;Secondary text&lt;/small&gt;&lt;/twt:Heading&gt;
&lt;twt:Heading runat="server" H="3"&gt;h3. Bootstrap heading &lt;small&gt;Secondary text&lt;/small&gt;&lt;/twt:Heading&gt;
&lt;twt:Heading runat="server" H="4"&gt;h4. Bootstrap heading &lt;small&gt;Secondary text&lt;/small&gt;&lt;/twt:Heading&gt;
&lt;twt:Heading runat="server" H="5"&gt;h5. Bootstrap heading &lt;small&gt;Secondary text&lt;/small&gt;&lt;/twt:Heading&gt;
&lt;twt:Heading runat="server" H="6"&gt;h6. Bootstrap heading &lt;small&gt;Secondary text&lt;/small&gt;&lt;/twt:Heading&gt;
</code></pre></figure>
</section>

</asp:Content>

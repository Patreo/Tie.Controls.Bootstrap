<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" Title="Glyphicons" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<section>
  <h2>Available glyphs</h2>
  <p>Includes over 250 glyphs in font format from the Glyphicon Halflings set. <a href="http://glyphicons.com/" target="_blank">Glyphicons</a> Halflings are normally not available for free, but their creator has made them available for Bootstrap free of cost. As a thank you, we only ask that you include a link back to Glyphicons whenever possible.</p>
  <div class="bs-example">
    <twt:HyperLinkButton runat="server"  Target="_blank" ButtonSize="Large" ButtonType="Primary"
      NavigateUrl="https://getbootstrap.com/docs/3.3/components/#glyphicons-glyphs">
      View available glyphs
      <twt:Glyphicon runat="server" Icon="new-window" AlternateText="(external link, opens in new tab)" />
    </twt:HyperLinkButton>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:HyperLinkButton runat="server"  Target="_blank" ButtonSize="Large" ButtonType="Primary"
  NavigateUrl="https://getbootstrap.com/docs/3.3/components/#glyphicons-glyphs"&gt;
  View available glyphs
  &lt;twt:Glyphicon runat="server" Icon="new-window" AlternateText="(external link, opens in new tab)" /&gt;
&lt;/twt:HyperLinkButton&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#glyphicons-examples" target="_blank">Examples</a></h2>
  <p>Use them in buttons, button groups for a toolbar, navigation, or prepended form inputs.</p>
  <div class="bs-example">
    <twt:ButtonGroup runat="server">
      <twt:Button runat="server">
        <twt:Glyphicon runat="server" Icon="align-left" AlternateText="Left Align" />
      </twt:Button>
      <twt:Button runat="server">
        <twt:Glyphicon runat="server" Icon="align-center" AlternateText="Center Align" />
      </twt:Button>
      <twt:Button runat="server">
        <twt:Glyphicon runat="server" Icon="align-right" AlternateText="Right Align" />
      </twt:Button>
      <twt:Button runat="server">
        <twt:Glyphicon runat="server" Icon="align-justify" AlternateText="Justify" />
      </twt:Button>
    </twt:ButtonGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt twt:ButtonGroup runat="server"&gt;
  &lt;twt:Button runat="server"&gt;
    &lt;twt:Glyphicon runat="server" Icon="align-left" AlternateText="Left Align" /&gt;
  &lt;/twt:Button&gt;
  &lt;twt:Button runat="server"&gt;
    &lt;twt:Glyphicon runat="server" Icon="align-center" AlternateText="Center Align" /&gt;
  &lt;/twt:Button&gt;
  &lt;twt:Button runat="server"&gt;
    &lt;twt:Glyphicon runat="server" Icon="align-right" AlternateText="Right Align" /&gt;
  &lt;/twt:Button&gt;
  &lt;twt:Button runat="server"&gt;
    &lt;twt:Glyphicon runat="server" Icon="align-justify" AlternateText="Justify" /&gt;
  &lt;/twt:Button&gt;
&lt;/twt:ButtonGroup&gt;</code></pre></figure>

  <div class="bs-example">
    <twt:Button runat="server" ButtonSize="Large">
      <twt:Glyphicon runat="server" Icon="star" /> Star
    </twt:Button>
    <twt:Button runat="server" ButtonSize="Default">
      <twt:Glyphicon runat="server" Icon="star" /> Star
    </twt:Button>
    <twt:Button runat="server" ButtonSize="Small">
      <twt:Glyphicon runat="server" Icon="star" /> Star
    </twt:Button>
    <twt:Button runat="server" ButtonSize="Mini">
      <twt:Glyphicon runat="server" Icon="star" /> Star
    </twt:Button>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Button runat="server" ButtonSize="Large"&gt;
  &lt;twt:Glyphicon runat="server" Icon="star" /&gt; Star
&lt;/twt:Button&gt;
&lt;twt:Button runat="server" ButtonSize="Default"&gt;
  &lt;twt:Glyphicon runat="server" Icon="star" /&gt; Star
&lt;/twt:Button&gt;
&lt;twt:Button runat="server" ButtonSize="Small"&gt;
  &lt;twt:Glyphicon runat="server" Icon="star" /&gt; Star
&lt;/twt:Button&gt;
&lt;twt:Button runat="server" ButtonSize="Mini"&gt;
  &lt;twt:Glyphicon runat="server" Icon="star" /&gt; Star
&lt;/twt:Button&gt;</code></pre></figure>
  <p>An icon used in an <code>&lt;twt:Alert&gt;</code> to convey that it's an error message, with <code>AlternateText</code> to convey this hint to users of assistive technologies.</p>
  <div class="bs-example">
    <twt:Alert runat="server" AlertType="Danger">
      <twt:Glyphicon runat="server" Icon="exclamation-sign" AlternateText="Error:" />
      Enter a valid email address
    </twt:Alert>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Alert runat="server" AlertType="Danger"&gt;
  &lt;twt:Glyphicon runat="server" Icon="exclamation-sign" AlternateText="Error:" /&gt;
  Enter a valid email address
&lt;/twt:Alert&gt;</code></pre></figure>

</section>
</asp:Content>

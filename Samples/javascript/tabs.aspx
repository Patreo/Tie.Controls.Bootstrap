<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Tabs" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/javascript/#tabs-examples" target="_blank">Example tabs</a></h2>
  <p>Add quick, dynamic tab functionality to transition through panes of local content, even via dropdown menus. <strong>Nested tabs are not supported.</strong></p>
  <div class="bs-example">
    <twt:TabControl runat="server">
      <TabPages>
        <twt:TabPage runat="server" Title="Home">
          <Content>
            <p>Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.</p>
          </Content>
        </twt:TabPage>
        <twt:TabPage runat="server" Title="Profile">
          <Content>
            <p>Food truck fixie locavore, accusamus mcsweeney's marfa nulla single-origin coffee squid. Exercitation +1 labore velit, blog sartorial PBR leggings next level wes anderson artisan four loko farm-to-table craft beer twee. Qui photo booth letterpress, commodo enim craft beer mlkshk aliquip jean shorts ullamco ad vinyl cillum PBR. Homo nostrud organic, assumenda labore aesthetic magna delectus mollit. Keytar helvetica VHS salvia yr, vero magna velit sapiente labore stumptown. Vegan fanny pack odio cillum wes anderson 8-bit, sustainable jean shorts beard ut DIY ethical culpa terry richardson biodiesel. Art party scenester stumptown, tumblr butcher vero sint qui sapiente accusamus tattooed echo park.</p>
          </Content>
        </twt:TabPage>
      </TabPages>
    </twt:TabControl>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:TabControl runat="server"&gt;
  &lt;TabPages&gt;
    &lt;twt:TabPage runat="server" Title="Home"&gt;
      &lt;Content&gt;
        &lt;p&gt;[...]&lt;/p&gt;
      &lt;/Content&gt;
    &lt;/twt:TabPage&gt;
    &lt;twt:TabPage runat="server" Title="Profile"&gt;
      &lt;Content&gt;
        &lt;p&gt;[...]&lt;/p&gt;
      &lt;/Content&gt;
    &lt;/twt:TabPage&gt;
  &lt;/TabPages&gt;
&lt;/twt:TabControl&gt;</code></pre></figure>
<div class="bs-callout bs-callout-info" id="callout-tabs-extends-component"><h3 class="h4">Extends tabbed navigation</h3> <p>This plugin extends the <a href="https://getbootstrap.com/docs/3.3/components/#nav-tabs" target="_blank">tabbed navigation component</a> to add tabbable areas.</p> </div>
</section>
<section>
  <h2>Pills example</h2>
  <p>Take that same markup, but set <code>Pills="true"</code>:</p>
  <div class="bs-example">
    <twt:TabControl runat="server" Pills="true">
      <TabPages>
        <twt:TabPage runat="server" Title="Home">
          <Content>
            <p>Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.</p>
          </Content>
        </twt:TabPage>
        <twt:TabPage runat="server" Title="Profile">
          <Content>
            <p>Food truck fixie locavore, accusamus mcsweeney's marfa nulla single-origin coffee squid. Exercitation +1 labore velit, blog sartorial PBR leggings next level wes anderson artisan four loko farm-to-table craft beer twee. Qui photo booth letterpress, commodo enim craft beer mlkshk aliquip jean shorts ullamco ad vinyl cillum PBR. Homo nostrud organic, assumenda labore aesthetic magna delectus mollit. Keytar helvetica VHS salvia yr, vero magna velit sapiente labore stumptown. Vegan fanny pack odio cillum wes anderson 8-bit, sustainable jean shorts beard ut DIY ethical culpa terry richardson biodiesel. Art party scenester stumptown, tumblr butcher vero sint qui sapiente accusamus tattooed echo park.</p>
          </Content>
        </twt:TabPage>
      </TabPages>
    </twt:TabControl>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:TabControl runat="server" Pills="true"&gt;
  &lt;TabPages&gt;
    &lt;twt:TabPage runat="server" Title="Home"&gt;
      &lt;Content&gt;
        &lt;p&gt;[...]&lt;/p&gt;
      &lt;/Content&gt;
    &lt;/twt:TabPage&gt;
    &lt;twt:TabPage runat="server" Title="Profile"&gt;
      &lt;Content&gt;
        &lt;p&gt;[...]&lt;/p&gt;
      &lt;/Content&gt;
    &lt;/twt:TabPage&gt;
  &lt;/TabPages&gt;
&lt;/twt:TabControl&gt;</code></pre></figure>
  <p>Pills are also vertically stackable. Just add <code>Stacked="true"</code>.</p>
  <div class="bs-example">
    <twt:TabControl runat="server" Pills="true" Stacked="true">
      <TabPages>
        <twt:TabPage runat="server" Title="Home">
          <Content>
            <p>Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.</p>
          </Content>
        </twt:TabPage>
        <twt:TabPage runat="server" Title="Profile">
          <Content>
            <p>Food truck fixie locavore, accusamus mcsweeney's marfa nulla single-origin coffee squid. Exercitation +1 labore velit, blog sartorial PBR leggings next level wes anderson artisan four loko farm-to-table craft beer twee. Qui photo booth letterpress, commodo enim craft beer mlkshk aliquip jean shorts ullamco ad vinyl cillum PBR. Homo nostrud organic, assumenda labore aesthetic magna delectus mollit. Keytar helvetica VHS salvia yr, vero magna velit sapiente labore stumptown. Vegan fanny pack odio cillum wes anderson 8-bit, sustainable jean shorts beard ut DIY ethical culpa terry richardson biodiesel. Art party scenester stumptown, tumblr butcher vero sint qui sapiente accusamus tattooed echo park.</p>
          </Content>
        </twt:TabPage>
      </TabPages>
    </twt:TabControl>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:TabControl runat="server" Pills="true" Stacked="true"&gt;
  &lt;TabPages&gt;
    &lt;twt:TabPage runat="server" Title="Home"&gt;
      &lt;Content&gt;
        &lt;p&gt;[...]&lt;/p&gt;
      &lt;/Content&gt;
    &lt;/twt:TabPage&gt;
    &lt;twt:TabPage runat="server" Title="Profile"&gt;
      &lt;Content&gt;
        &lt;p&gt;[...]&lt;/p&gt;
      &lt;/Content&gt;
    &lt;/twt:TabPage&gt;
  &lt;/TabPages&gt;
&lt;/twt:TabControl&gt;</code></pre></figure>
</section>
<section>
  <h2>Justified example</h2>
  <p>Easily make tabs or pills equal widths of their parent at screens wider than 768px with <code>.nav-justified</code>. On smaller screens, the nav links are stacked.</p>
  <p><strong class="text-danger">Justified navbar nav links are currently not supported.</strong></p>
  <div class="bs-callout bs-callout-warning" id="callout-navs-justified-safari"> <h3 class="h4">Safari and responsive justified navs</h3> <p>As of v9.1.2, Safari exhibits a bug in which resizing your browser horizontally causes rendering errors in the justified nav that are cleared upon refreshing. This bug is also shown in the <a href="https://getbootstrap.com/docs/3.3/examples/justified-nav/" target="_blank">justified nav example</a>.</p> </div>
  <div class="bs-example">
    <twt:TabControl runat="server" Justified="true">
      <TabPages>
        <twt:TabPage runat="server" Title="Home">
          <Content>
            <p>Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua, retro synth master cleanse. Mustache cliche tempor, williamsburg carles vegan helvetica. Reprehenderit butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.</p>
          </Content>
        </twt:TabPage>
        <twt:TabPage runat="server" Title="Profile">
          <Content>
            <p>Food truck fixie locavore, accusamus mcsweeney's marfa nulla single-origin coffee squid. Exercitation +1 labore velit, blog sartorial PBR leggings next level wes anderson artisan four loko farm-to-table craft beer twee. Qui photo booth letterpress, commodo enim craft beer mlkshk aliquip jean shorts ullamco ad vinyl cillum PBR. Homo nostrud organic, assumenda labore aesthetic magna delectus mollit. Keytar helvetica VHS salvia yr, vero magna velit sapiente labore stumptown. Vegan fanny pack odio cillum wes anderson 8-bit, sustainable jean shorts beard ut DIY ethical culpa terry richardson biodiesel. Art party scenester stumptown, tumblr butcher vero sint qui sapiente accusamus tattooed echo park.</p>
          </Content>
        </twt:TabPage>
      </TabPages>
    </twt:TabControl>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:TabControl runat="server" Justified="true"&gt;
  &lt;TabPages&gt;
    &lt;twt:TabPage runat="server" Title="Home"&gt;
      &lt;Content&gt;
        &lt;p&gt;[...]&lt;/p&gt;
      &lt;/Content&gt;
    &lt;/twt:TabPage&gt;
    &lt;twt:TabPage runat="server" Title="Profile"&gt;
      &lt;Content&gt;
        &lt;p&gt;[...]&lt;/p&gt;
      &lt;/Content&gt;
    &lt;/twt:TabPage&gt;
  &lt;/TabPages&gt;
&lt;/twt:TabControl&gt;</code></pre></figure>
</section>

</asp:Content>

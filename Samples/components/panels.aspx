<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Panels" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#panels-basic" target="_blank">Basic example</a></h2>
  <p>By default, all the <code>&lt;twt:Panel&gt;</code> does is apply some basic border and padding to contain some content.</p>
  <twt:Panel runat="server">
    <Content>
      Basic panel example
    </Content>
  </twt:Panel>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Panel runat="server"&gt;
  &lt;Content&gt;
    Basic panel example
  &lt;/Content&gt;
&lt;/twt:Panel&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#panels-heading" target="_blank">Panel with heading</a></h2>
  <p>
    Easily add a heading container to your panel with the <code>Title</code> property. 
    You may also include any <code>&lt;h1&gt;</code>-<code>&lt;h6&gt;</code> using the <code>TitleTag</code> property. 
    However, the font sizes of <code>&lt;h1&gt;</code>-<code>&lt;h6&gt;</code> are overridden by <code>.panel-heading</code>.
  </p>
  <div class="bs-example">
    <twt:Panel runat="server"
        Title="Panel heading without title">
      <Content>
        Panel content
      </Content>
    </twt:Panel>
    <twt:Panel runat="server"
        Title="Panel title"
        TitleTag="h3">
      <Content>
        Panel content
      </Content>
    </twt:Panel>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Panel runat="server"
    Title="Panel heading without title"&gt;
  &lt;Content&gt;
    Panel content
  &lt;/Content&gt;
&lt;/twt:Panel&gt;
&lt;twt:Panel runat="server"
    Title="Panel title"
    TitleTag="h3"&gt;
  &lt;Content&gt;
    Panel content
  &lt;/Content&gt;
&lt;/twt:Panel&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#panels-footer" target="_blank">Panel with footer</a></h2>
  <p>Add buttons or secondary text to the <code>&lt;Footer&gt;</code> template. Note that panel footers <strong>do not</strong> inherit colors and borders when using contextual variations as they are not meant to be in the foreground.</p>
  <div class="bs-example">
    <twt:Panel runat="server">
      <Content>
        Panel content
      </Content>
      <Footer>
        Panel footer
      </Footer>
    </twt:Panel>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Panel runat="server"&gt;
  &lt;Content&gt;
    Panel content
  &lt;/Content&gt;
  &lt;Footer&gt;
    Panel footer
  &lt;/Footer&gt;
&lt;/twt:Panel&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#panels-alternatives" target="_blank">Contextual alternatives</a></h2>
  <p>Like other components, easily make a panel more meaningful to a particular context using the <code>PanelType</code> property.</p>
  <div class="bs-example">
    <twt:Panel runat="server"
        Title="Panel title"
        TitleTag="h3"
        PanelType="Primary">
      <Content>
        Panel content
      </Content>
    </twt:Panel>

    <twt:Panel runat="server"
        Title="Panel title"
        TitleTag="h3"
        PanelType="Success">
      <Content>
        Panel content
      </Content>
    </twt:Panel>

    <twt:Panel runat="server"
        Title="Panel title"
        TitleTag="h3"
        PanelType="Info">
      <Content>
        Panel content
      </Content>
    </twt:Panel>

    <twt:Panel runat="server"
        Title="Panel title"
        TitleTag="h3"
        PanelType="Warning">
      <Content>
        Panel content
      </Content>
    </twt:Panel>

    <twt:Panel runat="server"
        Title="Panel title"
        TitleTag="h3"
        PanelType="Danger">
      <Content>
        Panel content
      </Content>
    </twt:Panel>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Panel runat="server"
    Title="Panel title"
    TitleTag="h3"
    PanelType="Primary"&gt;
  &lt;Content&gt;
    Panel content
  &lt;/Content&gt;
&lt;/twt:Panel&gt;
&lt;twt:Panel runat="server"
    Title="Panel title"
    TitleTag="h3"
    PanelType="Success"&gt;
  &lt;Content&gt;
    Panel content
  &lt;/Content&gt;
&lt;/twt:Panel&gt;
&lt;twt:Panel runat="server"
    Title="Panel title"
    TitleTag="h3"
    PanelType="Info"&gt;
  &lt;Content&gt;
    Panel content
  &lt;/Content&gt;
&lt;/twt:Panel&gt;
&lt;twt:Panel runat="server"
    Title="Panel title"
    TitleTag="h3"
    PanelType="Warning"&gt;
  &lt;Content&gt;
    Panel content
  &lt;/Content&gt;
&lt;/twt:Panel&gt;
&lt;twt:Panel runat="server"
    Title="Panel title"
    TitleTag="h3"
    PanelType="Danger"&gt;
  &lt;Content&gt;
    Panel content
  &lt;/Content&gt;
&lt;/twt:Panel&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#panels-tables" target="_blank">With tables</a></h2>
  <p>
    Add any non-bordered <code>&lt;table&gt;</code> within the <code>&lt;PostContent&gt;</code> template for a seamless design. 
    If the <code>&lt;Content&gt;</code> template has contents, we add an extra border to the top of the table for separation.
  </p>
  <div class="bs-example">
    <twt:Panel runat="server"
      Title="Panel heading">
      <Content>
        <p>Some default panel content here. Nulla vitae elit libero, a pharetra augue. Aenean lacinia bibendum nulla sed consectetur. Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
      </Content>
      <PostContent>
        <table class="table">
          <thead>
            <tr>
              <th>#</th>
              <th>First Name</th>
              <th>Last Name</th>
              <th>Username</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <th scope="row">1</th>
              <td>Mark</td>
              <td>Otto</td>
              <td>@mdo</td>
            </tr>
            <tr>
              <th scope="row">2</th>
              <td>Jacob</td>
              <td>Thornton</td>
              <td>@fat</td>
            </tr>
            <tr>
              <th scope="row">3</th>
              <td>Larry</td>
              <td>the Bird</td>
              <td>@twitter</td>
            </tr>
          </tbody>
        </table>
      </PostContent>
    </twt:Panel>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Panel runat="server"
  Title="Panel heading"&gt;
  &lt;Content&gt;
    &lt;p&gt;Some default panel content here. Nulla vitae elit libero, a pharetra augue. Aenean lacinia bibendum nulla sed consectetur. Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum. Nullam id dolor id nibh ultricies vehicula ut id elit.&lt;/p&gt;
  &lt;/Content&gt;
  &lt;PostContent&gt;
    &lt;table class="table"&gt;
      &lt;thead&gt;
        &lt;tr&gt;
          &lt;th&gt;#&lt;/th&gt;
          &lt;th&gt;First Name&lt;/th&gt;
          &lt;th&gt;Last Name&lt;/th&gt;
          &lt;th&gt;Username&lt;/th&gt;
        &lt;/tr&gt;
      &lt;/thead&gt;
      &lt;tbody&gt;
        &lt;tr&gt;
          &lt;th scope="row"&gt;1&lt;/th&gt;
          &lt;td&gt;Mark&lt;/td&gt;
          &lt;td&gt;Otto&lt;/td&gt;
          &lt;td&gt;@mdo&lt;/td&gt;
        &lt;/tr&gt;
        &lt;tr&gt;
          &lt;th scope="row"&gt;2&lt;/th&gt;
          &lt;td&gt;Jacob&lt;/td&gt;
          &lt;td&gt;Thornton&lt;/td&gt;
          &lt;td&gt;@fat&lt;/td&gt;
        &lt;/tr&gt;
        &lt;tr&gt;
          &lt;th scope="row"&gt;3&lt;/th&gt;
          &lt;td&gt;Larry&lt;/td&gt;
          &lt;td&gt;the Bird&lt;/td&gt;
          &lt;td&gt;@twitter&lt;/td&gt;
        &lt;/tr&gt;
      &lt;/tbody&gt;
    &lt;/table&gt;
  &lt;/PostContent&gt;
&lt;/twt:Panel&gt;</code></pre></figure>
  <p>If the <code>&lt;Content&gt;</code> template is empty, the component moves from panel header to table without interruption.</p>
  <div class="bs-example">
    <twt:Panel runat="server"
      Title="Panel heading">
      <PostContent>
        <table class="table">
          <thead>
            <tr>
              <th>#</th>
              <th>First Name</th>
              <th>Last Name</th>
              <th>Username</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <th scope="row">1</th>
              <td>Mark</td>
              <td>Otto</td>
              <td>@mdo</td>
            </tr>
            <tr>
              <th scope="row">2</th>
              <td>Jacob</td>
              <td>Thornton</td>
              <td>@fat</td>
            </tr>
            <tr>
              <th scope="row">3</th>
              <td>Larry</td>
              <td>the Bird</td>
              <td>@twitter</td>
            </tr>
          </tbody>
        </table>
      </PostContent>
    </twt:Panel>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Panel runat="server"
  Title="Panel heading"&gt;
  &lt;PostContent&gt;
    &lt;table class="table"&gt;
      &lt;thead&gt;
        &lt;tr&gt;
          &lt;th&gt;#&lt;/th&gt;
          &lt;th&gt;First Name&lt;/th&gt;
          &lt;th&gt;Last Name&lt;/th&gt;
          &lt;th&gt;Username&lt;/th&gt;
        &lt;/tr&gt;
      &lt;/thead&gt;
      &lt;tbody&gt;
        &lt;tr&gt;
          &lt;th scope="row"&gt;1&lt;/th&gt;
          &lt;td&gt;Mark&lt;/td&gt;
          &lt;td&gt;Otto&lt;/td&gt;
          &lt;td&gt;@mdo&lt;/td&gt;
        &lt;/tr&gt;
        &lt;tr&gt;
          &lt;th scope="row"&gt;2&lt;/th&gt;
          &lt;td&gt;Jacob&lt;/td&gt;
          &lt;td&gt;Thornton&lt;/td&gt;
          &lt;td&gt;@fat&lt;/td&gt;
        &lt;/tr&gt;
        &lt;tr&gt;
          &lt;th scope="row"&gt;3&lt;/th&gt;
          &lt;td&gt;Larry&lt;/td&gt;
          &lt;td&gt;the Bird&lt;/td&gt;
          &lt;td&gt;@twitter&lt;/td&gt;
        &lt;/tr&gt;
      &lt;/tbody&gt;
    &lt;/table&gt;
  &lt;/PostContent&gt;
&lt;/twt:Panel&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#panels-list-group" target="_blank">With list groups</a></h2>
  <p>Easily include a full-width <code>&lt;twt:ListGroup&gt;</code> within the <code>&lt;PostContent&gt;</code> template.</p>
  <div class="bs-example">
    <twt:Panel runat="server"
      Title="Panel heading">
      <Content>
        <p>Some default panel content here. Nulla vitae elit libero, a pharetra augue. Aenean lacinia bibendum nulla sed consectetur. Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
      </Content>
      <PostContent>
        <twt:ListGroup runat="server" RenderAsList="true">
          <twt:ListGroupItem Text="Cras justo odio"          />
          <twt:ListGroupItem Text="Dapibus ac facilisis in"  />
          <twt:ListGroupItem Text="Morbi leo risus"          />
          <twt:ListGroupItem Text="Porta ac consectetur ac"  />
          <twt:ListGroupItem Text="Vestibulum at eros"       />
        </twt:ListGroup>
      </PostContent>
    </twt:Panel>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Panel runat="server"
  Title="Panel heading"&gt;
  &lt;Content&gt;
    &lt;p&gt;Some default panel content here. Nulla vitae elit libero, a pharetra augue. Aenean lacinia bibendum nulla sed consectetur. Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum. Nullam id dolor id nibh ultricies vehicula ut id elit.&lt;/p&gt;
  &lt;/Content&gt;
  &lt;PostContent&gt;
    &lt;twt:ListGroup runat="server" RenderAsList="true"&gt;
      &lt;twt:ListGroupItem Text="Cras justo odio"          /&gt;
      &lt;twt:ListGroupItem Text="Dapibus ac facilisis in"  /&gt;
      &lt;twt:ListGroupItem Text="Morbi leo risus"          /&gt;
      &lt;twt:ListGroupItem Text="Porta ac consectetur ac"  /&gt;
      &lt;twt:ListGroupItem Text="Vestibulum at eros"       /&gt;
    &lt;/twt:ListGroup&gt;
  &lt;/PostContent&gt;
&lt;/twt:Panel&gt;</code></pre></figure>
</section>


</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Grid System" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<p class="lead">
  Bootstrap includes a responsive, mobile first fluid grid system that appropriately scales up to 12 columns as the device or 
  viewport size increases.
</p>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#grid-example-basic" target="_blank">Stacked-to-horizontal</a></h2>
  <p>
    By setting only the <code>Medium</code> property, you can create a basic grid system that starts out stacked on 
    mobile devices and tablet devices (the extra small to small range) before becoming horizontal on desktop (medium) devices. 
    Place <code>&lt;twt:Column&gt;</code>s inside a <code>&lt;twt:Row&gt;</code>.
  </p>
  <div class="bs-example">
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" Medium="1">.col-md-1</twt:Column>
      <twt:Column runat="server" Medium="1">.col-md-1</twt:Column>
      <twt:Column runat="server" Medium="1">.col-md-1</twt:Column>
      <twt:Column runat="server" Medium="1">.col-md-1</twt:Column>
      <twt:Column runat="server" Medium="1">.col-md-1</twt:Column>
      <twt:Column runat="server" Medium="1">.col-md-1</twt:Column>
      <twt:Column runat="server" Medium="1">.col-md-1</twt:Column>
      <twt:Column runat="server" Medium="1">.col-md-1</twt:Column>
      <twt:Column runat="server" Medium="1">.col-md-1</twt:Column>
      <twt:Column runat="server" Medium="1">.col-md-1</twt:Column>
      <twt:Column runat="server" Medium="1">.col-md-1</twt:Column>
      <twt:Column runat="server" Medium="1">.col-md-1</twt:Column>
    </twt:Row>
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" Medium="8">.col-md-8</twt:Column>
      <twt:Column runat="server" Medium="4">.col-md-4</twt:Column>
    </twt:Row>
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" Medium="4">.col-md-4</twt:Column>
      <twt:Column runat="server" Medium="4">.col-md-4</twt:Column>
      <twt:Column runat="server" Medium="4">.col-md-4</twt:Column>
    </twt:Row>
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" Medium="6">.col-md-6</twt:Column>
      <twt:Column runat="server" Medium="6">.col-md-6</twt:Column>
    </twt:Row>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" Medium="1"&gt;.col-md-1&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="1"&gt;.col-md-1&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="1"&gt;.col-md-1&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="1"&gt;.col-md-1&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="1"&gt;.col-md-1&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="1"&gt;.col-md-1&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="1"&gt;.col-md-1&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="1"&gt;.col-md-1&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="1"&gt;.col-md-1&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="1"&gt;.col-md-1&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="1"&gt;.col-md-1&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="1"&gt;.col-md-1&lt;/twt:Column&gt;
&lt;/twt:Row&gt;
&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" Medium="8"&gt;.col-md-8&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="4"&gt;.col-md-4&lt;/twt:Column&gt;
&lt;/twt:Row&gt;
&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" Medium="4"&gt;.col-md-4&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="4"&gt;.col-md-4&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="4"&gt;.col-md-4&lt;/twt:Column&gt;
&lt;/twt:Row&gt;
&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" Medium="6"&gt;.col-md-6&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="6"&gt;.col-md-6&lt;/twt:Column&gt;
&lt;/twt:Row&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#grid-example-mixed" target="_blank">Mobile and desktop</a></h2>
  <p>
    Don't want your columns to simply stack in smaller devices? Use the extra small and medium device grid classes by setting the
    <code>ExtraSmall</code> property in addition to <code>Medium</code>. See the example below for a better idea of how it all works.
  </p>
  <div class="bs-example">
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" ExtraSmall="12" Medium="8">.col-xs-12 .col-md-8</twt:Column>
      <twt:Column runat="server" ExtraSmall="6" Medium="4">.col-xs-6 .col-md-4</twt:Column>
    </twt:Row>
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" ExtraSmall="6" Medium="4">.col-xs-6 .col-md-4</twt:Column>
      <twt:Column runat="server" ExtraSmall="6" Medium="4">.col-xs-6 .col-md-4</twt:Column>
      <twt:Column runat="server" ExtraSmall="6" Medium="4">.col-xs-6 .col-md-4</twt:Column>
    </twt:Row>
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" ExtraSmall="6">.col-xs-6</twt:Column>
      <twt:Column runat="server" ExtraSmall="6">.col-xs-6</twt:Column>
    </twt:Row>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" ExtraSmall="12" Medium="8"&gt;.col-xs-12 .col-md-8&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" ExtraSmall="6" Medium="4"&gt;.col-xs-6 .col-md-4&lt;/twt:Column&gt;
&lt;/twt:Row&gt;
&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" ExtraSmall="6" Medium="4"&gt;.col-xs-6 .col-md-4&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" ExtraSmall="6" Medium="4"&gt;.col-xs-6 .col-md-4&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" ExtraSmall="6" Medium="4"&gt;.col-xs-6 .col-md-4&lt;/twt:Column&gt;
&lt;/twt:Row&gt;
&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" ExtraSmall="6"&gt;.col-xs-6&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" ExtraSmall="6"&gt;.col-xs-6&lt;/twt:Column&gt;
&lt;/twt:Row&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#grid-example-mixed-complete" target="_blank">Mobile, tablet, desktop</a></h2>
  <p>
    Build on the previous example by creating even more dynamic and powerful layouts on tablets by setting the <code>Small</code> property as well.
  </p>
  <div class="bs-example">
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" ExtraSmall="12" Small="6" Medium="8">.col-xs-12 .col-sm-6 .col-md-8</twt:Column>
      <twt:Column runat="server" ExtraSmall="6" Medium="4">.col-xs-6 .col-md-4</twt:Column>
    </twt:Row>
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" ExtraSmall="6" Small="4">.col-xs-6 .col-sm-4</twt:Column>
      <twt:Column runat="server" ExtraSmall="6" Small="4">.col-xs-6 .col-sm-4</twt:Column>
      <twt:Column runat="server" ExtraSmall="6" Small="4">.col-xs-6 .col-sm-4</twt:Column>
    </twt:Row>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" ExtraSmall="12" Small="6" Medium="8"&gt;.col-xs-12 .col-sm-6 .col-md-8&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" ExtraSmall="6" Medium="4"&gt;.col-xs-6 .col-md-4&lt;/twt:Column&gt;
&lt;/twt:Row&gt;
&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" ExtraSmall="6" Small="4"&gt;.col-xs-6 .col-sm-4&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" ExtraSmall="6" Small="4"&gt;.col-xs-6 .col-sm-4&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" ExtraSmall="6" Small="4"&gt;.col-xs-6 .col-sm-4&lt;/twt:Column&gt;
&lt;/twt:Row&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#grid-example-wrapping" target="_blank">Column wrapping</a></h2>
  <p>If more than 12 columns are placed within a single row, each group of extra columns will, as one unit, wrap onto a new line.</p>
  <div class="bs-example">
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" ExtraSmall="9">.col-xs-9</twt:Column>
      <twt:Column runat="server" ExtraSmall="4">
          .col-xs-4<br />
          Since 9 + 4 = 13 &gt; 12, this 4-column-wide div gets wrapped onto a new line as one contiguous unit.
        </twt:Column>
      <twt:Column runat="server" ExtraSmall="6">
          .col-xs-6<br />
          Subsequent columns continue along the new line.
        </twt:Column>
    </twt:Row>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" ExtraSmall="9"&gt;.col-xs-9&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" ExtraSmall="4"&gt;
      .col-xs-4&lt;br /&gt;
      Since 9 + 4 = 13 &gt; 12, this 4-column-wide div gets wrapped onto a new line as one contiguous unit.
    &lt;/twt:Column&gt;
  &lt;twt:Column runat="server" ExtraSmall="6"&gt;
      .col-xs-6&lt;br /&gt;
      Subsequent columns continue along the new line.
    &lt;/twt:Column&gt;
&lt;/twt:Row&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#grid-offsetting" target="_blank">Offsetting columns</a></h2>
  <p>
    Move columns to the right using the <code>MediumOffset</code> property to increase the left margin of a column by * columns. 
    For example, <code>MediumOffset="4"</code> moves the column over four columns at Medium and larger breakpoints.
  </p>
  <div class="bs-example">
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" Medium="4">.col-md-4</twt:Column>
      <twt:Column runat="server" Medium="4" MediumOffset="4">.col-md-4 .col-md-offset-4</twt:Column>
    </twt:Row>
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" Medium="3" MediumOffset="3">.col-md-3 .col-md-offset-3</twt:Column>
      <twt:Column runat="server" Medium="3" MediumOffset="3">.col-md-3 .col-md-offset-3</twt:Column>
    </twt:Row>
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" Medium="6" MediumOffset="3">.col-md-6 .col-md-offset-3</twt:Column>
    </twt:Row>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" Medium="4"&gt;.col-md-4&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="4" MediumOffset="4"&gt;.col-md-4 .col-md-offset-4&lt;/twt:Column&gt;
&lt;/twt:Row&gt;
&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" Medium="3" MediumOffset="3"&gt;.col-md-3 .col-md-offset-3&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="3" MediumOffset="3"&gt;.col-md-3 .col-md-offset-3&lt;/twt:Column&gt;
&lt;/twt:Row&gt;
&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" Medium="6" MediumOffset="3"&gt;.col-md-6 .col-md-offset-3&lt;/twt:Column&gt;
&lt;/twt:Row&gt;</code></pre></figure>
  <p>You can also override offsets from lower grid tiers with the <code>*Offset</code> properties.</p>
  <div class="bs-example">
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" ExtraSmall="6" Small="4">.col-xs-6 .col-sm-4</twt:Column>
      <twt:Column runat="server" ExtraSmall="6" Small="4">.col-xs-6 .col-sm-4</twt:Column>
      <twt:Column runat="server" ExtraSmall="6" ExtraSmallOffset="3" Small="4" SmallOffset="0">.col-xs-6 .col-xs-offset-3 .col-sm-4 .col-sm-offset-0</twt:Column>
    </twt:Row>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" ExtraSmall="6" Small="4"&gt;.col-xs-6 .col-sm-4&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" ExtraSmall="6" Small="4"&gt;.col-xs-6 .col-sm-4&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" ExtraSmall="6" ExtraSmallOffset="3" Small="4" SmallOffset="0"&gt;.col-xs-6 .col-xs-offset-3 .col-sm-4 .col-sm-offset-0&lt;/twt:Column&gt;
&lt;/twt:Row&gt;</code></pre></figure>
</section>
  
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#grid-nesting" target="_blank">Nesting columns</a></h2>
  <p>
    To nest your content with the default grid, add a new <code>&lt;twt:Row&gt;</code> and set of <code>&lt;twt:Column&gt;</code>s within an existing <code>&lt;twt:Column&gt;</code>.
    Nested rows should include a set of columns that add up to 12 or fewer (it is not required that you use all 12 available columns).
  </p>
  <div class="bs-example">
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" Medium="9">
          Level 1: .col-sm-9        
          <twt:Row CssClass="show-grid" runat="server">
                  <twt:Column runat="server" ExtraSmall="8" Small="6">Level 2: .col-xs-8 .col-sm-6</twt:Column>
            <twt:Column runat="server" ExtraSmall="4" Small="6">.col-xs-4 .col-sm-6</twt:Column>
                </twt:Row>
        </twt:Column>
    </twt:Row>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" Medium="9"&gt;
      Level 1: .col-sm-9        
      &lt;twt:Row runat="server"&gt;
              &lt;twt:Column runat="server" ExtraSmall="8" Small="6"&gt;Level 2: .col-xs-8 .col-sm-6&lt;/twt:Column&gt;
        &lt;twt:Column runat="server" ExtraSmall="4" Small="6"&gt;.col-xs-4 .col-sm-6&lt;/twt:Column&gt;
            &lt;/twt:Row&gt;
    &lt;/twt:Column&gt;
&lt;/twt:Row&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#grid-column-ordering" target="_blank">Column ordering</a></h2>
  <p>Easily change the order of our built-in grid columns with the <code>*Push</code> and <code>*Pull</code> properties.</p>
  <div class="bs-example">
    <twt:Row CssClass="show-grid" runat="server">
      <twt:Column runat="server" Medium="9" MediumPush="3">.col-md-9 .col-md-push-3</twt:Column>
      <twt:Column runat="server" Medium="3" MediumPull="9">.col-md-3 .col-md-pull-9</twt:Column>
    </twt:Row>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Row runat="server"&gt;
  &lt;twt:Column runat="server" Medium="9" MediumPush="3"&gt;.col-md-9 .col-md-push-3&lt;/twt:Column&gt;
  &lt;twt:Column runat="server" Medium="3" MediumPull="9"&gt;.col-md-3 .col-md-pull-9&lt;/twt:Column&gt;
&lt;/twt:Row&gt;</code></pre></figure>
</section>

</asp:Content>

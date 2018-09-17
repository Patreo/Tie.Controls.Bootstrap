<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" Title="Navbar" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<p class="lead">Navbars are responsive meta components that serve as navigation headers for your application or site. They begin collapsed (and are toggleable) in mobile views and become horizontal as the available viewport width increases.</p>

<div class="bs-callout bs-callout-warning" id="callout-navbar-overflow"> <h2 class="h4">Overflowing content</h2> <p>Since Bootstrap doesn't know how much space the content in your navbar needs, you might run into issues with content wrapping into a second row. To resolve this, you can:</p> <ol type="a"> <li>Reduce the amount or width of navbar items.</li> <li>Hide certain navbar items at certain screen sizes using <a href="https://getbootstrap.com/docs/3.3/css/#responsive-utilities" target="_blank">responsive utility classes</a>.</li> <li>Change the point at which your navbar switches between collapsed and horizontal mode. Customize the <code>@grid-float-breakpoint</code> variable or add your own media query.</li> </ol> </div>
<div class="bs-callout bs-callout-danger" id="callout-navbar-js"> <h2 class="h4">Requires JavaScript plugin</h2> <p>If JavaScript is disabled and the viewport is narrow enough that the navbar collapses, it will be impossible to expand the navbar and view the content within the <code>.navbar-collapse</code>.</p> <p>The responsive navbar requires the <a href="https://getbootstrap.com/docs/3.3/javascript/#collapse" target="_blank">collapse plugin</a> to be included in your version of Bootstrap.</p> </div>
<div class="bs-callout bs-callout-info" id="callout-navbar-breakpoint"> <h2 class="h4">Changing the collapsed mobile navbar breakpoint</h2> <p>The navbar collapses into its vertical mobile view when the viewport is narrower than <code>@grid-float-breakpoint</code>, and expands into its horizontal non-mobile view when the viewport is at least <code>@grid-float-breakpoint</code> in width. Adjust this variable in the Less source to control when the navbar collapses/expands. The default value is <code>768px</code> (the smallest "small" or "tablet" screen).</p> </div>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#navbar-default" target="_blank">Default navbar</a></h2>
  <div class="bs-example">
    <twt:NavBar runat="server" Inverted="false">
      <Brand>
        <twt:Hamburger runat="server" Text="Brand" />
      </Brand>
      <LeftContent>
        <twt:Menu runat="server">
          <Items>
            <twt:ListItem NavigateUrl="#" Text="Link" />
            <twt:ListItem NavigateUrl="#" Text="Link" Enabled="false" />
            <twt:ListItem Text="Dropdown">
              <Items>
                <twt:ListItem NavigateUrl="#" Text="Action" />
                <twt:ListItem NavigateUrl="#" Text="Another action" />
                <twt:ListItem NavigateUrl="#" Text="Something else here" />
                <twt:ListSeparator />
                <twt:ListItem Text="Separated link"></twt:ListItem>
                <twt:ListSeparator />
                <twt:ListItem Text="One more separated link"></twt:ListItem>
              </Items>
            </twt:ListItem>
          </Items>
        </twt:Menu>
        <div class="navbar-form navbar-left" role="search">
          <div class="form-group">
            <twt:TextBox runat="server" ID="TextBox1" PlaceholderText="Search" />
            <asp:Label runat="server" AssociatedControlID="TextBox1" CssClass="sr-only" Text="Search" />
          </div>
          <twt:Button runat="server" ButtonType="Default" Text="Submit" />
        </div>
      </LeftContent>
      <RightContent>
        <twt:Menu runat="server">
          <Items>
            <twt:ListItem NavigateUrl="#" Text="Link" />
            <twt:ListItem Text="Dropdown">
              <Items>
                <twt:ListItem NavigateUrl="#" Text="Action" />
                <twt:ListItem NavigateUrl="#" Text="Another action" />
                <twt:ListItem NavigateUrl="#" Text="Something else here" />
                <twt:ListSeparator />
                <twt:ListItem Text="Separated link"></twt:ListItem>
              </Items>
            </twt:ListItem>
          </Items>
        </twt:Menu>
      </RightContent>
    </twt:NavBar>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:NavBar runat="server" Inverted="false"&gt;
  &lt;Brand&gt;
    &lt;twt:Hamburger runat="server" Text="Brand" /&gt;
  &lt;/Brand&gt;
  &lt;LeftContent&gt;
    &lt;twt:Menu runat="server"&gt;
      &lt;Items&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Link" /&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Link" Enabled="false" /&gt;
        &lt;twt:ListItem Text="Dropdown"&gt;
          &lt;Items&gt;
            &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
            &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
            &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
            &lt;twt:ListSeparator /&gt;
            &lt;twt:ListItem Text="Separated link"&gt;&lt;/twt:ListItem&gt;
            &lt;twt:ListSeparator /&gt;
            &lt;twt:ListItem Text="One more separated link"&gt;&lt;/twt:ListItem&gt;
          &lt;/Items&gt;
        &lt;/twt:ListItem&gt;
      &lt;/Items&gt;
    &lt;/twt:Menu&gt;
    &lt;div class="navbar-form" role="search"&gt;
      &lt;div class="form-group"&gt;
        &lt;twt:TextBox runat="server" ID="searchBox" PlaceholderText="Search" /&gt;
        &lt;asp:Label runat="server" AssociatedControlID="searchBox" CssClass="sr-only" Text="Search" /&gt;
      &lt;/div&gt;
      &lt;twt:Button runat="server" ButtonType="Default" Text="Submit" /&gt;
    &lt;/div&gt;
  &lt;/LeftContent&gt;
  &lt;RightContent&gt;
    &lt;twt:Menu runat="server"&gt;
      &lt;Items&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Link" /&gt;
        &lt;twt:ListItem Text="Dropdown"&gt;
          &lt;Items&gt;
            &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
            &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
            &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
            &lt;twt:ListSeparator /&gt;
            &lt;twt:ListItem Text="Separated link"&gt;&lt;/twt:ListItem&gt;
          &lt;/Items&gt;
        &lt;/twt:ListItem&gt;
      &lt;/Items&gt;
    &lt;/twt:Menu&gt;
  &lt;/RightContent&gt;
&lt;/twt:NavBar&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#navbar-brand-image" target="_blank">Brand image</a></h2>
  <p>
    Replace the navbar brand with your own image by setting <code>ImageUrl</code> and <code>AlternativeText</code> on the <code>&lt;twt:Hamburger&gt;</code>. 
    Since the <code>.navbar-brand</code> has its own padding and height, you may need to override some CSS depending on your image.
  </p>
  <div class="bs-example">
    <twt:NavBar runat="server" Inverted="false">
      <Brand>
        <twt:Hamburger runat="server" Text="" ImageHeight="20" ImageWidth="20" AlternativeText="Bootstrap logo"
          ImageUrl="data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAB+0lEQVR4AcyYg5LkUBhG+1X2PdZGaW3btm3btm3bHttWrPomd1r/2Jn/VJ02TpxcH4CQ/dsuazWgzbIdrm9dZVd4pBz4zx2igTaFHrhvjneVXNHCSqIlFEjiwMyyyOBilRgGSqLNF1jnwNQdIvAt48C3IlBmHCiLQHC2zoHDu6zG1iXn6+y62ScxY9AODO6w0pvAqf23oSE4joOfH6OxfMoRnoGUm+de8wykbFt6wZtA07QwtNOqKh3ZbS3Wzz2F+1c/QJY0UCJ/J3kXWJfv7VhxCRRV1jGw7XI+gcO7rEFFRvdYxydwcPsVsC0bQdKScngt4iUTD4Fy/8p7PoHzRu1DclwmgmiqgUXjD3oTKHbAt869qdJ7l98jNTEblPTkXMwetpvnftA0LLHb4X8kiY9Kx6Q+W7wJtG0HR7fdrtYz+x7iya0vkEtUULIzCjC21wY+W/GYXusRH5kGytWTLxgEEhePPwhKYb7EK3BQuxWwTBuUkd3X8goUn6fMHLyTT+DCsQdAEXNzSMeVPAJHdF2DmH8poCREp3uwm7HsGq9J9q69iuunX6EgrwQVObjpBt8z6rdPfvE8kiiyhsvHnomrQx6BxYUyYiNS8f75H1w4/ISepDZLoDhNJ9cdNUquhRsv+6EP9oNH7Iff2A9g8h8CLt1gH0Qf9NMQAFnO60BJFQe0AAAAAElFTkSuQmCC" />
      </Brand>
    </twt:NavBar>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;h2&gt;Brand image&lt;/h2&gt;
&lt;twt:NavBar runat="server" Inverted="false"&gt;
  &lt;Brand&gt;
    &lt;twt:Hamburger runat="server" Text="" ImageHeight="20" ImageWidth="20"
      ImageUrl="[...]" /&gt;
  &lt;/Brand&gt;
&lt;/twt:NavBar&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#navbar-forms" target="_blank">Forms</a></h2>
  <p>Place form content within <code>.navbar-form</code> for proper vertical alignment and collapsed behavior in narrow viewports. Use the alignment options to decide where it resides within the navbar content.</p>
  <p>As a heads up, <code>.navbar-form</code> shares much of its code with <code>.form-inline</code> via mixin. <strong class="text-danger">Some form controls, like input groups, may require fixed widths to be show up properly within a navbar.</strong></p>
  <div class="bs-example">
    <twt:NavBar runat="server" Inverted="false">
      <Brand>
        <twt:Hamburger runat="server" Text="Brand" />
      </Brand>
      <LeftContent>
        <div class="navbar-form navbar-left" role="search">
          <div class="form-group">
            <twt:TextBox runat="server" ID="searchBox" PlaceholderText="Search" />
            <asp:Label runat="server" AssociatedControlID="searchBox" CssClass="sr-only" Text="Search" />
          </div>
          <twt:Button runat="server" ButtonType="Default" Text="Submit" />
        </div>
      </LeftContent>
    </twt:NavBar>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:NavBar runat="server" Inverted="false"&gt;
  &lt;Brand&gt;
    &lt;twt:Hamburger runat="server" Text="Brand" /&gt;
  &lt;/Brand&gt;
  &lt;LeftContent&gt;
    &lt;div class="navbar-form navbar-left" role="search"&gt;
      &lt;div class="form-group"&gt;
        &lt;twt:TextBox runat="server" ID="searchBox" PlaceholderText="Search" /&gt;
        &lt;asp:Label runat="server" AssociatedControlID="searchBox" CssClass="sr-only" Text="Search" /&gt;
      &lt;/div&gt;
      &lt;twt:Button runat="server" ButtonType="Default" Text="Submit" /&gt;
    &lt;/div&gt;
  &lt;/LeftContent&gt;
&lt;/twt:NavBar&gt;</code></pre></figure>
  <div class="bs-callout bs-callout-warning" id="callout-navbar-mobile-caveats"> <h3 class="h4">Mobile device caveats</h3> <p>There are some caveats regarding using form controls within fixed elements on mobile devices. <a href="https://getbootstrap.com/docs/3.3/getting-started/#support-fixed-position-keyboards" target="_blank">See our browser support docs</a> for details.</p> </div>
  <div class="bs-callout bs-callout-warning" id="callout-navbar-form-labels"> <h3 class="h4">Always add labels</h3> <p>Screen readers will have trouble with your forms if you don't include a label for every input. For these inline forms, you can hide the labels using the <code>.sr-only</code> class.</p> </div>
</section>

<hr />

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#navbar-buttons" target="_blank">Buttons</a></h2>
  <p>Add the <code>.navbar-btn</code> class to <code>&lt;twt:Button&gt;</code> elements not residing in a <code>&lt;form&gt;</code> to vertically center them in the navbar.</p>
  <div class="bs-example">
    <twt:NavBar runat="server" Inverted="false">
      <Brand>
        <twt:Hamburger runat="server" Text="Brand" />
      </Brand>
      <LeftContent>
        <twt:Button runat="server" ButtonType="Default" Text="Submit" CssClass="navbar-btn" />
      </LeftContent>
    </twt:NavBar>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:NavBar runat="server" Inverted="false"&gt;
  &lt;Brand&gt;
    &lt;twt:Hamburger runat="server" Text="Brand" /&gt;
  &lt;/Brand&gt;
  &lt;LeftContent&gt;
    &lt;twt:Button runat="server" ButtonType="Default" Text="Submit" CssClass="navbar-btn" /&gt;
  &lt;/LeftContent&gt;
&lt;/twt:NavBar&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#navbar-text" target="_blank">Text</a></h2>
  <p>Wrap strings of text in an element with <code>.navbar-text</code>, usually on a <code>&lt;p&gt;</code> tag for proper leading and color.</p>
  <div class="bs-example">
    <twt:NavBar runat="server" Inverted="false">
      <Brand>
        <twt:Hamburger runat="server" Text="Brand" />
      </Brand>
      <LeftContent>
        <p class="navbar-text">Signed in as Mark Otto</p>
      </LeftContent>
    </twt:NavBar>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:NavBar runat="server" Inverted="false"&gt;
  &lt;Brand&gt;
    &lt;twt:Hamburger runat="server" Text="Brand" /&gt;
  &lt;/Brand&gt;
  &lt;LeftContent&gt;
    &lt;p class="navbar-text"&gt;Signed in as Mark Otto&lt;/p&gt;
  &lt;/LeftContent&gt;
&lt;/twt:NavBar&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#navbar-fixed-top" target="_blank">Fixed to top</a></h2>
  <p>Add <code>Fixed="true"</code> and <code>Position="Top"</code>.</p>
  <div class="bs-callout bs-callout-danger" id="callout-navbar-fixed-top-padding"> <h3 class="h4">Body padding required</h3> <p>The fixed navbar will overlay your other content, unless you add <code>padding</code> to the top of the <code>&lt;body&gt;</code>. Try out your own values or use our snippet below. Tip: By default, the navbar is 50px high.</p> <figure class="highlight"><pre><code class="language-scss" data-lang="scss"><span class="nt">body</span> <span class="p">{</span> <span class="nl">padding-top</span><span class="p">:</span> <span class="m">70px</span><span class="p">;</span> <span class="p">}</span></code></pre></figure> <p>Make sure to include this <strong>after</strong> the core Bootstrap CSS.</p> </div>
  <div class="bs-example bs-navbar-top-example">
    <twt:NavBar runat="server" Inverted="false" Fixed="true" Position="Top">
      <Brand>
        <twt:Hamburger runat="server" Text="Brand" />
      </Brand>
      <LeftContent>
        <twt:Menu runat="server">
          <Items>
            <twt:ListItem NavigateUrl="#" Text="Home" Active="true" />
            <twt:ListItem NavigateUrl="#" Text="Link" />
            <twt:ListItem NavigateUrl="#" Text="Link" />
          </Items>
        </twt:Menu>
      </LeftContent>
    </twt:NavBar>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:NavBar runat="server" Inverted="false" Fixed="true" Position="Top"&gt;
  &lt;Brand&gt;
    &lt;twt:Hamburger runat="server" Text="Brand" /&gt;
  &lt;/Brand&gt;
  &lt;LeftContent&gt;
    &lt;twt:Menu runat="server"&gt;
      &lt;Items&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Home" Active="true" /&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Link" /&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Link" /&gt;
      &lt;/Items&gt;
    &lt;/twt:Menu&gt;
  &lt;/LeftContent&gt;
&lt;/twt:NavBar&gt;</code></pre></figure>
</section>

<hr />

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#navbar-fixed-bottom" target="_blank">Fixed to bottom</a></h2>
  <p>Add <code>Fixed="true"</code> and <code>Position="Bottom"</code>.</p>
  <div class="bs-callout bs-callout-danger" id="callout-navbar-fixed-bottom-padding"> <h3 class="h4">Body padding required</h3> <p>The fixed navbar will overlay your other content, unless you add <code>padding</code> to the bottom of the <code>&lt;body&gt;</code>. Try out your own values or use our snippet below. Tip: By default, the navbar is 50px high.</p> <figure class="highlight"><pre><code class="language-scss" data-lang="scss"><span class="nt">body</span> <span class="p">{</span> <span class="nl">padding-bottom</span><span class="p">:</span> <span class="m">70px</span><span class="p">;</span> <span class="p">}</span></code></pre></figure> <p>Make sure to include this <strong>after</strong> the core Bootstrap CSS.</p> </div>  
  <div class="bs-example bs-navbar-bottom-example">
    <twt:NavBar runat="server" Inverted="false" Fixed="true" Position="Bottom">
      <Brand>
        <twt:Hamburger runat="server" Text="Brand" />
      </Brand>
      <LeftContent>
        <twt:Menu runat="server">
          <Items>
            <twt:ListItem NavigateUrl="#" Text="Home" Active="true" />
            <twt:ListItem NavigateUrl="#" Text="Link" />
            <twt:ListItem NavigateUrl="#" Text="Link" />
          </Items>
        </twt:Menu>
      </LeftContent>
    </twt:NavBar>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:NavBar runat="server" Inverted="false" Fixed="true" Position="Bottom"&gt;
  &lt;Brand&gt;
    &lt;twt:Hamburger runat="server" Text="Brand" /&gt;
  &lt;/Brand&gt;
  &lt;LeftContent&gt;
    &lt;twt:Menu runat="server"&gt;
      &lt;Items&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Home" Active="true" /&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Link" /&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Link" /&gt;
      &lt;/Items&gt;
    &lt;/twt:Menu&gt;
  &lt;/LeftContent&gt;
&lt;/twt:NavBar&gt;</code></pre></figure>
</section>

<hr />

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#navbar-static-top" target="_blank">Static top</a></h2>
  <p>Create a full-width navbar that scrolls away with the page by adding <code>Fixed="false"</code> and <code>Position="Top"</code>. Unlike a fixed navbar, you do not need to change any padding on the body.</p>
  <div class="bs-example">
    <twt:NavBar runat="server" Inverted="false" Fixed="false" Position="Top">
      <Brand>
        <twt:Hamburger runat="server" Text="Brand" />
      </Brand>
      <LeftContent>
        <twt:Menu runat="server">
          <Items>
            <twt:ListItem NavigateUrl="#" Text="Home" Active="true" />
            <twt:ListItem NavigateUrl="#" Text="Link" />
            <twt:ListItem NavigateUrl="#" Text="Link" />
          </Items>
        </twt:Menu>
      </LeftContent>
    </twt:NavBar>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:NavBar runat="server" Inverted="false" Fixed="false" Position="Top"&gt;
  &lt;Brand&gt;
    &lt;twt:Hamburger runat="server" Text="Brand" /&gt;
  &lt;/Brand&gt;
  &lt;LeftContent&gt;
    &lt;twt:Menu runat="server"&gt;
      &lt;Items&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Home" Active="true" /&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Link" /&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Link" /&gt;
      &lt;/Items&gt;
    &lt;/twt:Menu&gt;
  &lt;/LeftContent&gt;
&lt;/twt:NavBar&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#navbar-inverted" target="_blank">Inverted navbar</a></h2>
  <p>Modify the look of the navbar by adding <code>Inverted="true"</code>.</p>
  <div class="bs-example">
    <twt:NavBar runat="server" Inverted="true">
      <Brand>
        <twt:Hamburger runat="server" Text="Brand" />
      </Brand>
      <LeftContent>
        <twt:Menu runat="server">
          <Items>
            <twt:ListItem NavigateUrl="#" Text="Home" Active="true" />
            <twt:ListItem NavigateUrl="#" Text="Link" />
            <twt:ListItem NavigateUrl="#" Text="Link" />
          </Items>
        </twt:Menu>
      </LeftContent>
    </twt:NavBar>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:NavBar runat="server" Inverted="true"Top"&gt;
  &lt;Brand&gt;
    &lt;twt:Hamburger runat="server" Text="Brand" /&gt;
  &lt;/Brand&gt;
  &lt;LeftContent&gt;
    &lt;twt:Menu runat="server"&gt;
      &lt;Items&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Home" Active="true" /&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Link" /&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Link" /&gt;
      &lt;/Items&gt;
    &lt;/twt:Menu&gt;
  &lt;/LeftContent&gt;
&lt;/twt:NavBar&gt;</code></pre></figure>
</section>

</asp:Content>

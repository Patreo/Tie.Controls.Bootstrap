<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Carousel" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<p>A slideshow component for cycling through elements, like a carousel. <strong>Nested carousels are not supported.</strong></p>

<div class="bs-callout bs-callout-danger" id="callout-carousel-accessibility">
  <h2 class="h4">Accessibility issue</h2>
  <p>In general, carousels are notorious for having accessibility issues.  Please consider other options for presenting your content.</p>
  <p>
    By default, the <a href="https://github.com/paypal/bootstrap-accessibility-plugin" target="_blank">PayPal Bootstrap Accessibility Plugin</a> is included in any page with a <code>&lt;twt:Carousel&gt;</code>. 
    This mitigates some of the accessibility issues inherent in carousels. 
    You can <a href="../configuration.aspx">configure the package</a> to use <a href="https://github.com/jongund/bootstrap-accessibility-plugin" target="_blank">@jongund's modified version of the PayPal plugin</a> instead.
  </p>
</div>
<div class="bs-callout bs-callout-warning" id="callout-carousel-transitions">
  <h2 class="h4">Transition animations not supported in Internet Explorer 8 &amp; 9</h2>
  <p>Bootstrap exclusively uses CSS3 for its animations, but Internet Explorer 8 &amp; 9 don't support the necessary CSS properties. Thus, there are no slide transition animations when using these browsers. We have intentionally decided not to include jQuery-based fallbacks for the transitions.</p>
</div>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/javascript/#carousel-examples" target="_blank">Basic example</a></h2>
  <div class="bs-example">
    <twt:Carousel runat="server">
      <Items>
        <twt:CarouselItem runat="server"
          NavigateUrl="#" 
          ImageUrl="https://via.placeholder.com/1140x600/444444/999999"
          Title="First slide title"
          Text="First slide text"
          AltText="Placeholder image with text '1140 x 600'" />
        <twt:CarouselItem runat="server"
          NavigateUrl="#"
          ImageUrl="https://via.placeholder.com/1140x600/444444/999999"
          Title="Second slide title"
          Text="Second slide text"
          AltText="Placeholder image with text '1140 x 600'" />
        <twt:CarouselItem runat="server"
          NavigateUrl="#"
          ImageUrl="https://via.placeholder.com/1140x600/444444/999999"
          Title="Third slide title"
          Text="Third slide text"
          AltText="Placeholder image with text '1140 x 600'" />
      </Items>
    </twt:Carousel>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Carousel runat="server"&gt;
  &lt;Items&gt;
    &lt;twt:CarouselItem runat="server"
      NavigateUrl="#"
      ImageUrl="https://via.placeholder.com/1140x600/444444/999999"
      Title="First slide title"
      Text="First slide text"
      AltText="Placeholder image with text '1140 x 600'" /&gt;
    &lt;twt:CarouselItem runat="server"
      NavigateUrl="#"
      ImageUrl="https://via.placeholder.com/1140x600/444444/999999"
      Title="Second slide title"
      Text="Second slide text"
      AltText="Placeholder image with text '1140 x 600'" /&gt;
    &lt;twt:CarouselItem runat="server"
      NavigateUrl="#"
      ImageUrl="https://via.placeholder.com/1140x600/444444/999999"
      Title="Third slide title"
      Text="Third slide text"
      AltText="Placeholder image with text '1140 x 600'" /&gt;
  &lt;/Items&gt;
&lt;/twt:Carousel&gt;</code></pre></figure>
</section>

  <div class="bs-callout bs-callout-info" id="callout-carousel-without-glyphicons">
  <h2 class="h4">Forward/back icons</h2>
  <p>The <code>LeftArrowClass</code> and <code>RightArrowClass</code> properties define the CSS classes used for the arrow icons.</p>
  <p>By default, glyphicon icons are used (<code>LeftArrowClass="glyphicon glyphicon-chevron-left" RightArrowClass="glyphicon glyphicon-chevron-right"</code>).</p>
  <p>For plain unicode alternatives, you can use <code>LeftArrowClass="icon-prev" RightArrowClass="icon-next"</code>. Or you can use the appropriate classes from another icon package (such as FontAwesome).</p>
</div>

<section>
  <h2>Custom Contents</h2>
  <p>
    Add captions to your slides easily with the <code>&lt;Content&gt;</code> template. 
    Place just about any optional HTML within there and it will be automatically aligned and formatted.
  </p>
  <div class="bs-example">
    <twt:Carousel runat="server" ShowIndicators="false" LeftArrowClass="icon-prev" RightArrowClass="icon-next">
      <Items>
        <twt:CarouselItem runat="server">
          <Content>
            <div class="row">
              <div class="col-xs-8 col-xs-push-2">
                <h3><a href="#">Heading 1</a></h3>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam tristique neque quis nulla accumsan, et fringilla ex accumsan. Vestibulum euismod diam vel dolor rutrum suscipit. Mauris eu leo ac enim rhoncus tristique sit amet et magna. Duis varius, dui sed ullamcorper auctor, felis leo lobortis lorem, at finibus dui risus eget tellus. Cras elementum massa non commodo congue. Ut in orci vitae eros dictum blandit. Nam id neque varius, iaculis tellus eu, ornare dui. Donec accumsan vitae risus eu gravida. Phasellus at pretium lorem. In hac habitasse platea dictumst.</p>
              </div>
            </div>
          </Content>
        </twt:CarouselItem>
        <twt:CarouselItem runat="server">
          <Content>
            <div class="row">
              <div class="col-xs-8 col-xs-push-2">
                <h3><a href="#">Heading 2</a></h3>
                <p>In eget feugiat ipsum. Quisque enim nisi, laoreet ut suscipit in, blandit vel libero. Nunc dignissim tortor nec nisi blandit malesuada. Morbi sed rutrum sem. Fusce aliquet velit in rhoncus cursus. Quisque porta ante eget sapien accumsan efficitur. Proin vestibulum ex sit amet justo convallis fermentum. Sed hendrerit feugiat nisl eget hendrerit. Phasellus elementum nibh commodo leo fringilla, at egestas nulla finibus. Suspendisse non fermentum ipsum. In hac habitasse platea dictumst. Sed eget elit vel lorem posuere varius vel at arcu. Curabitur vitae sem tempus, pellentesque urna et, suscipit lorem.</p>
              </div>
            </div>
          </Content>
        </twt:CarouselItem>
        <twt:CarouselItem runat="server">
          <Content>
            <div class="row">
              <div class="col-xs-8 col-xs-push-2">
                <h3><a href="#">Heading 3</a></h3>
                <p>In eget nunc quis eros faucibus scelerisque. Integer porta, quam placerat fermentum ultricies, tortor justo consectetur tellus, eu mollis magna magna vitae augue. Nunc dignissim nunc purus, fermentum placerat tortor varius non. Phasellus sit amet imperdiet enim. Sed nec eros malesuada ante auctor aliquam at ullamcorper mi. Maecenas a dolor dignissim, scelerisque metus sit amet, lacinia lorem. In lobortis arcu ac tempor placerat. Etiam in interdum elit. Nullam vel eros ligula. Aenean tempus, sapien eget porttitor consequat, massa magna tempus turpis, sed consequat leo tellus ut tellus. Morbi ut tristique metus, sit amet consequat ipsum. Ut posuere gravida justo ut lacinia. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sollicitudin quis magna sit amet ullamcorper. Nulla sed pretium sem. Integer et erat nec nisi eleifend mattis feugiat id libero.</p>
              </div>
            </div>
          </Content>
        </twt:CarouselItem>
        <twt:CarouselItem runat="server">
          <Content>
            <div class="row">
              <div class="col-xs-8 col-xs-push-2">
                <h3><a href="#">Heading 4</a></h3>
                <p>Duis sed luctus turpis, at sodales nulla. Etiam mauris odio, vulputate sit amet tempus et, varius ut felis. Cras diam massa, bibendum quis quam et, convallis porta lectus. Duis pharetra eleifend velit, at pharetra magna feugiat vel. Aliquam ut sagittis tellus, ut tincidunt mi. Nullam blandit purus porta, interdum nunc quis, tempor ex. Ut condimentum metus eget lectus accumsan ullamcorper. Donec scelerisque faucibus tellus. Proin vitae dignissim nisl, id hendrerit lacus. Mauris efficitur est nec tincidunt faucibus. Maecenas ullamcorper, diam malesuada maximus efficitur, sapien lorem vestibulum mauris, vel molestie est urna in est. Integer interdum dui vel mollis fringilla.</p>
              </div>
            </div>
          </Content>
        </twt:CarouselItem>
        <twt:CarouselItem runat="server">
          <Content>
            <div class="row">
              <div class="col-xs-8 col-xs-push-2">
                <h3><a href="#">Heading 5</a></h3>
                <p>Etiam ac tortor libero. Suspendisse quam sapien, convallis et ante vestibulum, tempus sagittis augue. Aliquam vel scelerisque dolor, vel porttitor erat. Donec consectetur convallis congue. Sed in nisi nec nunc mattis dignissim a eget felis. Nulla sit amet commodo mi. Proin vel lorem vel est cursus finibus. Donec velit sapien, vulputate non orci sit amet, mollis auctor nisl. Pellentesque ut justo mollis, vestibulum nulla et, feugiat lectus. Fusce ultricies neque in felis efficitur congue. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nam viverra quam nec arcu pretium vulputate.</p>
              </div>
            </div>
          </Content>
        </twt:CarouselItem>
      </Items>
    </twt:Carousel>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Carousel runat="server" ShowIndicators="false"&gt;
  &lt;Items&gt;
    &lt;twt:CarouselItem runat="server"&gt;
      &lt;Content&gt;
        &lt;div class="row"&gt;
          &lt;div class="col-xs-8 col-xs-push-2"&gt;
            &lt;h3&gt;&lt;a href="#"&gt;Heading 1&lt;/a&gt;&lt;/h3&gt;
            &lt;p&gt;Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam tristique neque quis nulla accumsan, et fringilla ex accumsan. Vestibulum euismod diam vel dolor rutrum suscipit. Mauris eu leo ac enim rhoncus tristique sit amet et magna. Duis varius, dui sed ullamcorper auctor, felis leo lobortis lorem, at finibus dui risus eget tellus. Cras elementum massa non commodo congue. Ut in orci vitae eros dictum blandit. Nam id neque varius, iaculis tellus eu, ornare dui. Donec accumsan vitae risus eu gravida. Phasellus at pretium lorem. In hac habitasse platea dictumst.&lt;/p&gt;
          &lt;/div&gt;
        &lt;/div&gt;
      &lt;/Content&gt;
    &lt;/twt:CarouselItem&gt;
    &lt;twt:CarouselItem runat="server"&gt;
      &lt;Content&gt;
        &lt;div class="row"&gt;
          &lt;div class="col-xs-8 col-xs-push-2"&gt;
            &lt;h3&gt;&lt;a href="#"&gt;Heading 2&lt;/a&gt;&lt;/h3&gt;
            &lt;p&gt;In eget feugiat ipsum. Quisque enim nisi, laoreet ut suscipit in, blandit vel libero. Nunc dignissim tortor nec nisi blandit malesuada. Morbi sed rutrum sem. Fusce aliquet velit in rhoncus cursus. Quisque porta ante eget sapien accumsan efficitur. Proin vestibulum ex sit amet justo convallis fermentum. Sed hendrerit feugiat nisl eget hendrerit. Phasellus elementum nibh commodo leo fringilla, at egestas nulla finibus. Suspendisse non fermentum ipsum. In hac habitasse platea dictumst. Sed eget elit vel lorem posuere varius vel at arcu. Curabitur vitae sem tempus, pellentesque urna et, suscipit lorem.&lt;/p&gt;
          &lt;/div&gt;
        &lt;/div&gt;
      &lt;/Content&gt;
    &lt;/twt:CarouselItem&gt;
    &lt;twt:CarouselItem runat="server"&gt;
      &lt;Content&gt;
        &lt;div class="row"&gt;
          &lt;div class="col-xs-8 col-xs-push-2"&gt;
            &lt;h3&gt;&lt;a href="#"&gt;Heading 3&lt;/a&gt;&lt;/h3&gt;
            &lt;p&gt;In eget nunc quis eros faucibus scelerisque. Integer porta, quam placerat fermentum ultricies, tortor justo consectetur tellus, eu mollis magna magna vitae augue. Nunc dignissim nunc purus, fermentum placerat tortor varius non. Phasellus sit amet imperdiet enim. Sed nec eros malesuada ante auctor aliquam at ullamcorper mi. Maecenas a dolor dignissim, scelerisque metus sit amet, lacinia lorem. In lobortis arcu ac tempor placerat. Etiam in interdum elit. Nullam vel eros ligula. Aenean tempus, sapien eget porttitor consequat, massa magna tempus turpis, sed consequat leo tellus ut tellus. Morbi ut tristique metus, sit amet consequat ipsum. Ut posuere gravida justo ut lacinia. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sollicitudin quis magna sit amet ullamcorper. Nulla sed pretium sem. Integer et erat nec nisi eleifend mattis feugiat id libero.&lt;/p&gt;
          &lt;/div&gt;
        &lt;/div&gt;
      &lt;/Content&gt;
    &lt;/twt:CarouselItem&gt;
    &lt;twt:CarouselItem runat="server"&gt;
      &lt;Content&gt;
        &lt;div class="row"&gt;
          &lt;div class="col-xs-8 col-xs-push-2"&gt;
            &lt;h3&gt;&lt;a href="#"&gt;Heading 4&lt;/a&gt;&lt;/h3&gt;
            &lt;p&gt;Duis sed luctus turpis, at sodales nulla. Etiam mauris odio, vulputate sit amet tempus et, varius ut felis. Cras diam massa, bibendum quis quam et, convallis porta lectus. Duis pharetra eleifend velit, at pharetra magna feugiat vel. Aliquam ut sagittis tellus, ut tincidunt mi. Nullam blandit purus porta, interdum nunc quis, tempor ex. Ut condimentum metus eget lectus accumsan ullamcorper. Donec scelerisque faucibus tellus. Proin vitae dignissim nisl, id hendrerit lacus. Mauris efficitur est nec tincidunt faucibus. Maecenas ullamcorper, diam malesuada maximus efficitur, sapien lorem vestibulum mauris, vel molestie est urna in est. Integer interdum dui vel mollis fringilla.&lt;/p&gt;
          &lt;/div&gt;
        &lt;/div&gt;
      &lt;/Content&gt;
    &lt;/twt:CarouselItem&gt;
    &lt;twt:CarouselItem runat="server"&gt;
      &lt;Content&gt;
        &lt;div class="row"&gt;
          &lt;div class="col-xs-8 col-xs-push-2"&gt;
            &lt;h3&gt;&lt;a href="#"&gt;Heading 5&lt;/a&gt;&lt;/h3&gt;
            &lt;p&gt;Etiam ac tortor libero. Suspendisse quam sapien, convallis et ante vestibulum, tempus sagittis augue. Aliquam vel scelerisque dolor, vel porttitor erat. Donec consectetur convallis congue. Sed in nisi nec nunc mattis dignissim a eget felis. Nulla sit amet commodo mi. Proin vel lorem vel est cursus finibus. Donec velit sapien, vulputate non orci sit amet, mollis auctor nisl. Pellentesque ut justo mollis, vestibulum nulla et, feugiat lectus. Fusce ultricies neque in felis efficitur congue. Interdum et malesuada fames ac ante ipsum primis in faucibus. Nam viverra quam nec arcu pretium vulputate.&lt;/p&gt;
          &lt;/div&gt;
        &lt;/div&gt;
      &lt;/Content&gt;
    &lt;/twt:CarouselItem&gt;
  &lt;/Items&gt;
&lt;/twt:Carousel&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/javascript/#carousel-options" target="_blank">Options</a></h2>
  <p>Options can set in markup or code-behind to control behavior.</p>
    <div class="table-responsive">
    <table class="table table-bordered table-striped js-options-table">
      <thead>
        <tr>
          <th>Name</th>
          <th>Type</th>
          <th>Default</th>
          <th>Description</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td>Interval</td>
          <td>int</td>
          <td>0</td>
          <td>The amount of time to delay between automatically cycling an item. If zero or negative, carousel will not automatically cycle.</td>
        </tr>
        <tr>
          <td>PauseType</td>
          <td>PauseTypes enum</td>
          <td>Hover</td>
          <td>
            If set to <code>"Hover"</code>, pauses the cycling of the carousel on <code>MouseEnter</code> and resumes the cycling of the carousel on <code>MouseLeave</code>. 
            If set to <code>null</code>, hovering over the carousel won't pause it.
          </td>
        </tr>
        <tr>
          <td>Wrap</td>
          <td>bool</td>
          <td>true</td>
          <td>Whether the carousel should cycle continuously or have hard stops.</td>
        </tr>
        <tr>
          <td>KeyboardEvents</td>
          <td>bool</td>
          <td>true</td>
          <td>Whether the carousel should react to keyboard events.</td>
        </tr>
        <tr>
          <td>ActiveCarouselItem</td>
          <td>int</td>
          <td>0</td>
          <td>The zero-based index of the currently active item.</td>
        </tr>
        <tr>
          <td>TitleTag</td>
          <td>HtmlTextWriterTag enum</td>
          <td>H2</td>
          <td>The tag type rendered for a CarouselItem's title. Adjust to fit page structure.</td>
        </tr>
        <tr>
          <td>LeftArrowClass</td>
          <td>string</td>
          <td>glyphicon glyphicon-chevron-left</td>
          <td>The class assigned to the left indicator arrow.</td>
        </tr>
        <tr>
          <td>RightArrowClass</td>
          <td>string</td>
          <td>glyphicon glyphicon-chevron-right</td>
          <td>The class assigned to the right indicator arrow.</td>
        </tr>
        <tr>
          <td>ShowIndicators</td>
          <td>bool</td>
          <td>true</td>
          <td>Whether the carousel indicators should be shown for sighted users.</td>
        </tr>
        <tr>
          <td>ShowArrows</td>
          <td>bool</td>
          <td>true</td>
          <td>Whether the carousel arrows should be shown for sighted users.</td>
        </tr>
      </tbody>
    </table>
  </div>
</section>
</asp:Content>

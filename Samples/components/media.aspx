<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" Title="Media Objects" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<p class="lead">Abstract object styles for building various types of components (like blog comments, Tweets, etc) that feature a left- or right-aligned image alongside textual content.</p>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#media-default" target="_blank">Default media</a></h2>
  <p>The default media displays an image to the left or right of a content block.</p>
  <div class="bs-example">
    <twt:MediaObject runat="server"
      NavigationUrl="#"
      ImageAlign="Left"
      ImageUrl="https://via.placeholder.com/64x64"
      AlternativeText="Placeholder image"
      Title="Media heading"
      TitleTag="H3"
      Description="Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus."
    />
    <twt:MediaObject runat="server"
      NavigationUrl="#"
      ImageAlign="Left"
      ImageUrl="https://via.placeholder.com/64x64"
      AlternativeText="Placeholder image"
      Title="Media heading"
      TitleTag="H3"
      Description="Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus."
    >
      <Content>
        <twt:MediaObject runat="server"
          NavigationUrl="#"
          ImageAlign="Left"
          ImageUrl="https://via.placeholder.com/64x64"
          AlternativeText="Placeholder image"
          Title="Nested media heading"
          TitleTag="H4"
          Description="Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus."
        />
      </Content>
    </twt:MediaObject>
    <twt:MediaObject runat="server"
      NavigationUrl="#"
      ImageAlign="Right"
      AlternativeText="Placeholder image"
      ImageUrl="https://via.placeholder.com/64x64"
      Title="Media heading"
      TitleTag="H3"
      Description="Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis."
    />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:MediaObject runat="server"
  NavigationUrl="#"
  ImageAlign="Left"
  ImageUrl="https://via.placeholder.com/64x64"
  AlternativeText="Placeholder image"
  Title="Media heading"
  TitleTag="H3"
  Description="[...]"
/&gt;
&lt;twt:MediaObject runat="server"
  NavigationUrl="#"
  ImageAlign="Left"
  ImageUrl="https://via.placeholder.com/64x64"
  AlternativeText="Placeholder image"
  Title="Media heading"
  TitleTag="H3"
  Description="[...]"
&gt;
  &lt;Content&gt;
    &lt;twt:MediaObject runat="server"
      NavigationUrl="#"
      ImageAlign="Left"
      ImageUrl="https://via.placeholder.com/64x64"
      AlternativeText="Placeholder image"
      Title="Nested media heading"
      TitleTag="H4"
      Description="[...]"
    /&gt;
  &lt;/Content&gt;
&lt;/twt:MediaObject&gt;
&lt;twt:MediaObject runat="server"
  NavigationUrl="#"
  ImageAlign="Right"
  AlternativeText="Placeholder image"
  ImageUrl="https://via.placeholder.com/64x64"
  Title="Media heading"
  TitleTag="H3"
  Description="[...]"
/&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#media-alignment" target="_blank">Media alignment</a></h2>
  <p>The images or other media can be aligned Top, Middle, or Bottom using the <code>VerticalAlign</code> property. The default is Top aligned.</p>
  <div class="bs-example">
    <twt:MediaObject runat="server"
      NavigationUrl="#"
      ImageAlign="Left"
      VerticalAlign="Top"
      ImageUrl="https://via.placeholder.com/64x64"
      AlternativeText="Placeholder image"
      Title="Media heading"
      TitleTag="H3"
      Description="<p>Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.</p><p>Donec sed odio dui. Nullam quis risus eget urna mollis ornare vel eu leo. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p>"
    />
    <twt:MediaObject runat="server"
      NavigationUrl="#"
      ImageAlign="Left"
      VerticalAlign="Middle"
      ImageUrl="https://via.placeholder.com/64x64"
      AlternativeText="Placeholder image"
      Title="Media heading"
      TitleTag="H3"
      Description="<p>Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.</p><p>Donec sed odio dui. Nullam quis risus eget urna mollis ornare vel eu leo. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p>"
    />
    <twt:MediaObject runat="server"
      NavigationUrl="#"
      ImageAlign="Left"
      VerticalAlign="Bottom"
      ImageUrl="https://via.placeholder.com/64x64"
      AlternativeText="Placeholder image"
      Title="Media heading"
      TitleTag="H3"
      Description="<p>Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus.</p><p>Donec sed odio dui. Nullam quis risus eget urna mollis ornare vel eu leo. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.</p>"
    />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:MediaObject runat="server"
  NavigationUrl="#"
  ImageAlign="Left"
  VerticalAlign="Top"
  ImageUrl="https://via.placeholder.com/64x64"
  AlternativeText="Placeholder image"
  Title="Media heading"
  TitleTag="H3"
  Description="&lt;p&gt;[...]&lt;/p&gt;&lt;p&gt;[...]&lt;/p&gt;"
/&gt;
&lt;twt:MediaObject runat="server"
  NavigationUrl="#"
  ImageAlign="Left"
  VerticalAlign="Middle"
  ImageUrl="https://via.placeholder.com/64x64"
  AlternativeText="Placeholder image"
  Title="Media heading"
  TitleTag="H3"
  Description="&lt;p&gt;[...]&lt;/p&gt;&lt;p&gt;[...]&lt;/p&gt;"
/&gt;
&lt;twt:MediaObject runat="server"
  NavigationUrl="#"
  ImageAlign="Left"
  VerticalAlign="Bottom"
  ImageUrl="https://via.placeholder.com/64x64"
  AlternativeText="Placeholder image"
  Title="Media heading"
  TitleTag="H3"
  Description="&lt;p&gt;[...]&lt;/p&gt;&lt;p&gt;[...]&lt;/p&gt;"
/&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#media-list" target="_blank">Media list</a></h2>
  <p>With a bit of extra markup, you can use media inside list (useful for comment threads or articles lists).</p>
  <div class="bs-example">
    <twt:MediaList runat="server">
      <Content>
        <twt:MediaObject runat="server"
          NavigationUrl="#"
          ImageAlign="Left"
          ImageUrl="https://via.placeholder.com/64x64"
          AlternativeText="Placeholder image"
          Title="Media heading"
          TitleTag="H3"
          Description="Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus."
        >
          <Content>
            <twt:MediaObject runat="server"
              NavigationUrl="#"
              ImageAlign="Left"
              ImageUrl="https://via.placeholder.com/64x64"
              AlternativeText="Placeholder image"
              Title="Nested media heading"
              TitleTag="H4"
              Description="Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus."
            >
              <Content>
                <twt:MediaObject runat="server"
                  NavigationUrl="#"
                  ImageAlign="Left"
                  ImageUrl="https://via.placeholder.com/64x64"
                  AlternativeText="Placeholder image"
                  Title="Nested media heading"
                  TitleTag="H5"
                  Description="Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus."
                />
              </Content>
            </twt:MediaObject>
            <twt:MediaObject runat="server"
              NavigationUrl="#"
              ImageAlign="Left"
              ImageUrl="https://via.placeholder.com/64x64"
              AlternativeText="Placeholder image"
              Title="Nested media heading"
              TitleTag="H4"
              Description="Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante sollicitudin commodo. Cras purus odio, vestibulum in vulputate at, tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue felis in faucibus."
            />
          </Content>
        </twt:MediaObject>
      </Content>
    </twt:MediaList>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:MediaList runat="server"&gt;
  &lt;Content&gt;
    &lt;twt:MediaObject runat="server"
      NavigationUrl="#"
      ImageAlign="Left"
      ImageUrl="https://via.placeholder.com/64x64"
      AlternativeText="Placeholder image"
      Title="Media heading"
      TitleTag="H3"
      Description="[...]"
    &gt;
      &lt;Content&gt;
        &lt;twt:MediaObject runat="server"
          NavigationUrl="#"
          ImageAlign="Left"
          ImageUrl="https://via.placeholder.com/64x64"
          AlternativeText="Placeholder image"
          Title="Nested media heading"
          TitleTag="H4"
          Description="[...]"
        &gt;
          &lt;Content&gt;
            &lt;twt:MediaObject runat="server"
              NavigationUrl="#"
              ImageAlign="Left"
              ImageUrl="https://via.placeholder.com/64x64"
              AlternativeText="Placeholder image"
              Title="Nested media heading"
              TitleTag="H5"
              Description="[...]"
            /&gt;
          &lt;/Content&gt;
        &lt;/twt:MediaObject&gt;
        &lt;twt:MediaObject runat="server"
          NavigationUrl="#"
          ImageAlign="Left"
          ImageUrl="https://via.placeholder.com/64x64"
          AlternativeText="Placeholder image"
          Title="Nested media heading"
          TitleTag="H4"
          Description="[...]"
        /&gt;
      &lt;/Content&gt;
    &lt;/twt:MediaObject&gt;
  &lt;/Content&gt;
&lt;/twt:MediaList&gt;</code></pre></figure>
</section>
</asp:Content>

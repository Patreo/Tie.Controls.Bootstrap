<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Modals" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<p>Modals are streamlined, but flexible, dialog prompts with the minimum required functionality and smart defaults.</p>
<div class="bs-callout bs-callout-warning" id="callout-stacked-modals"> <h2 class="h4">Multiple open modals not supported</h2> <p>Be sure not to open a modal while another is still visible. Showing more than one modal at a time requires custom code.</p> </div>
<div class="bs-callout bs-callout-warning" id="callout-modal-mobile-caveats"> <h2 class="h4">Mobile device caveats</h2> <p>There are some caveats regarding using modals on mobile devices. <a href="https://getbootstrap.com/docs/3.3/getting-started/#support-fixed-position-keyboards">See our browser support docs</a> for details.</p> </div>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/javascript/#static-example" target="_blank">Static example</a></h2>
  <p>A rendered modal with header, body, and set of actions in the footer.</p>
  <div class="bs-example bs-example-modal">
    <twt:Modal runat="server" 
      Title="Modal title"
      TitleTag="H3"
      Fade="false"
    >
      <Content>
        <p>One fine body&hellip;</p>
      </Content>
      <Footer>
        <twt:Button runat="server"
          Text="Close"
          UseSubmitBehavior="false"
          data-dismiss="modal"
        />
        <twt:Button runat="server"
          ButtonType="Primary"
          Text="Save Changes"
          UseSubmitBehavior="false"
        />
      </Footer>
    </twt:Modal>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Modal runat="server" 
  Title="Modal title"
  TitleTag="H3"
  Fade="false"
&gt;
  &lt;Content&gt;
    &lt;p&gt;One fine body&hellip;&lt;/p&gt;
  &lt;/Content&gt;
  &lt;Footer&gt;
    &lt;twt:Button runat="server"
      Text="Close"
      UseSubmitBehavior="false"
      data-dismiss="modal"
    /&gt;
    &lt;twt:Button runat="server"
      ButtonType="Primary"
      Text="Save Changes"
      UseSubmitBehavior="false"
    /&gt;
  &lt;/Footer&gt;
&lt;/twt:Modal&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://paypal.github.io/bootstrap-accessibility-plugin/demo.html#modals-examples" target="_blank">Live demo</a></h2>
  <p>Toggle a modal via JavaScript by clicking the button below. It will slide down and fade in from the top of the page.</p>
  <div class="bs-example">
    <twt:Button runat="server" 
      Text="Launch demo modal" 
      ButtonSize="Large" 
      ButtonType="Primary" 
      ModalID="liveModal" 
    />
    <twt:Modal runat="server" 
      Title="Modal title" 
      TitleTag="H3"
      ID="liveModal"
    >
      <Content>
        <h4>Text in a modal</h4>
        <p>Duis mollis, est non commodo luctus, nisi erat porttitor ligula.</p>
        <h4>Popover in a modal</h4>
        <p>This
          <twt:Button runat="server" ButtonType="Default" Text="button">
            <Popover runat="server" Position="Right" Title="A title" Text="And here's some amazing content. It's very engaging. right?"/>
          </twt:Button>
          should trigger a popover on click.
        </p>
        <h4>Tooltips in a modal</h4>
        <p>
          <a href="#" class="tooltip-test" title="" data-original-title="Tooltip">This link</a> and
          <a href="#" class="tooltip-test" title="" data-original-title="Tooltip">that link</a> should have tooltips on hover.
        </p>
        <hr />
        <h4>Overflowing text to show scroll behavior</h4>
        <p>Cras mattis consectetur purus sit amet fermentum. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Morbi leo risus, porta ac consectetur ac, vestibulum at eros.</p>
        <p>Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor.</p>
        <p>Aenean lacinia bibendum nulla sed consectetur. Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Donec sed odio dui. Donec ullamcorper nulla non metus auctor fringilla.</p>
        <p>Cras mattis consectetur purus sit amet fermentum. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Morbi leo risus, porta ac consectetur ac, vestibulum at eros.</p>
        <p>Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor.</p>
        <p>Aenean lacinia bibendum nulla sed consectetur. Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Donec sed odio dui. Donec ullamcorper nulla non metus auctor fringilla.</p>
        <p>Cras mattis consectetur purus sit amet fermentum. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Morbi leo risus, porta ac consectetur ac, vestibulum at eros.</p>
        <p>Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Vivamus sagittis lacus vel augue laoreet rutrum faucibus dolor auctor.</p>
        <p>Aenean lacinia bibendum nulla sed consectetur. Praesent commodo cursus magna, vel scelerisque nisl consectetur et. Donec sed odio dui. Donec ullamcorper nulla non metus auctor fringilla.</p>
      </Content>
      <Footer>
        <twt:Button runat="server"
          Text="Close"
          UseSubmitBehavior="false"
          data-dismiss="modal"
        />
        <twt:Button runat="server"
          ButtonType="Primary"
          Text="Save Changes"
          UseSubmitBehavior="false"
        />
      </Footer>
    </twt:Modal>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Button runat="server" 
  Text="Launch demo modal" 
  ButtonSize="Large" 
  ButtonType="Primary" 
  ModalID="liveModal" 
/&gt;
&lt;twt:Modal runat="server" 
  Title="Modal title" 
  TitleTag="H3"
  ID="liveModal"
&gt;
  &lt;Content&gt;
    &lt;p&gt;[&hellip;]&lt;/p&gt;
  &lt;/Content&gt;
  &lt;Footer&gt;
    &lt;twt:Button runat="server"
      Text="Close"
      UseSubmitBehavior="false"
      data-dismiss="modal"
    /&gt;
    &lt;twt:Button runat="server"
      ButtonType="Primary"
      Text="Save Changes"
      UseSubmitBehavior="false"
    /&gt;
  &lt;/Footer&gt;
&lt;/twt:Modal&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/javascript/#modals-sizes" target="_blank">Optional sizes</a></h2>
  <p>Modals have two optional sizes, available via the <code>Size</code> property.</p>
  <div class="bs-example">
    <twt:Button runat="server" 
      Text="Large modal (static background, remote contents)" 
      ButtonType="Primary" 
      ModalID="largeModal" 
    />
    <twt:Modal runat="server" 
      Title="Large modal" 
      TitleTag="H3"
      ID="largeModal"
      Size="Large"
      BackdropType="Static"
      RemotePath="modal-remote.html"
    />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Button runat="server" 
  Text="Large modal (static background)" 
  ButtonType="Primary" 
  ModalID="largeModal" 
/&gt;
&lt;twt:Modal runat="server" 
  Title="Large modal" 
  TitleTag="H3"
  ID="largeModal"
  Size="Large"
  BackdropType="Static"
  RemotePath="modal-remote.html"
/&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/javascript/#modals-remove-animation" target="_blank">Remove animation</a></h2>
  <p>For modals that simply appear rather than fade in to view, set <code>Fade="false"</code>.</p>
  <div class="bs-example">
    <twt:Button runat="server" 
      Text="Small modal (no animation, no backgound)" 
      ButtonType="Primary" 
      ModalID="smallModal" 
    />
    <twt:Modal runat="server" 
      Title="Small modal" 
      TitleTag="H3"
      Fade="false" 
      ID="smallModal"
      Size="Small"
      BackdropType="None"
    >
      <Content>
        &hellip;
      </Content>
      <Footer>
        <twt:Button runat="server"
          Text="Close"
          UseSubmitBehavior="false"
          data-dismiss="modal"
        />
        <twt:Button runat="server"
          ButtonType="Primary"
          Text="Save Changes"
          UseSubmitBehavior="false"
        />
      </Footer>
    </twt:Modal>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Button runat="server" 
  Text="Small modal (no animation, no backgound)" 
  ButtonType="Primary" 
  ModalID="smallModal" 
/&gt;
&lt;twt:Modal runat="server" 
  Title="Small modal" 
  TitleTag="H3"
  Fade="false" 
  ID="smallModal"
  Size="Small"
  BackdropType="None"
&gt;
  &lt;Content&gt;
    &amp;hellip;
  &lt;/Content&gt;
  &lt;Footer&gt;
    &lt;twt:Button runat="server"
      Text="Close"
      UseSubmitBehavior="false"
      data-dismiss="modal"
    /&gt;
    &lt;twt:Button runat="server"
      ButtonType="Primary"
      Text="Save Changes"
      UseSubmitBehavior="false"
    /&gt;
  &lt;/Footer&gt;
&lt;/twt:Modal&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/javascript/#modals-grid-system" target="_blank">Using the grid system</a></h2>
  <p>To take advantage of the Bootstrap grid system within a modal, just nest <code>&lt;twt:Rows&gt;</code>s and <code>&lt;twt:Columns&gt;</code>s within the <code>&lt;Content&gt;</code> template.</p>
  <div class="bs-example">
    <twt:Button runat="server" 
      Text="Launch demo modal" 
      ButtonType="Primary" 
      ButtonSize="Large"
      ModalID="gridModal" 
    />
    <twt:Modal runat="server" 
      Title="Modal title" 
      TitleTag="H3"
      ID="gridModal"
    >
      <Content>
        <twt:Row runat="server">
          <twt:Column runat="server" Medium="4">.col-md-4</twt:Column>
          <twt:Column runat="server" Medium="4" MediumOffset="4">.col-md-4 .col-md-offset-4</twt:Column>
        </twt:Row>
        <twt:Row runat="server">
          <twt:Column runat="server" Medium="3" MediumOffset="3">.col-md-3 .col-md-offset-3</twt:Column>
          <twt:Column runat="server" Medium="2" MediumOffset="4">.col-md-2 .col-md-offset-4</twt:Column>
        </twt:Row>
        <twt:Row runat="server">
          <twt:Column runat="server" Medium="6" MediumOffset="3">.col-md-6 .col-md-offset-3</twt:Column>
        </twt:Row>
        <twt:Row runat="server">
          <twt:Column runat="server" Small="9">
            Level 1: .col-sm-9
            <twt:Row runat="server">
              <twt:Column runat="server" ExtraSmall="8" Small="6">Level 2: .col-xs-8 .col-sm-6</twt:Column>
              <twt:Column runat="server" ExtraSmall="4" Small="6">Level 2: .col-xs-4 .col-sm-6</twt:Column>
            </twt:Row>
          </twt:Column>
        </twt:Row>
      </Content>
      <Footer>
        <twt:Button runat="server"
          Text="Close"
          UseSubmitBehavior="false"
          data-dismiss="modal"
        />
        <twt:Button runat="server"
          ButtonType="Primary"
          Text="Save Changes"
          UseSubmitBehavior="false"
        />
      </Footer>
    </twt:Modal>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:Button runat="server" 
  Text="Launch demo modal" 
  ButtonType="Primary" 
  ButtonSize="Large"
  ModalID="gridModal" 
/&gt;
&lt;twt:Modal runat="server" 
  Title="Modal title" 
  TitleTag="H3"
  ID="gridModal"
&gt;
  &lt;Content&gt;
    &lt;twt:Row runat="server"&gt;
      &lt;twt:Column runat="server" Medium="4"&gt;.col-md-4&lt;/twt:Column&gt;
      &lt;twt:Column runat="server" Medium="4" MediumOffset="4"&gt;.col-md-4 .col-md-offset-4&lt;/twt:Column&gt;
    &lt;/twt:Row&gt;
    &lt;twt:Row runat="server"&gt;
      &lt;twt:Column runat="server" Medium="3" MediumOffset="3"&gt;.col-md-3 .col-md-offset-3&lt;/twt:Column&gt;
      &lt;twt:Column runat="server" Medium="2" MediumOffset="4"&gt;.col-md-2 .col-md-offset-4&lt;/twt:Column&gt;
    &lt;/twt:Row&gt;
    &lt;twt:Row runat="server"&gt;
      &lt;twt:Column runat="server" Medium="6" MediumOffset="3"&gt;.col-md-6 .col-md-offset-3&lt;/twt:Column&gt;
    &lt;/twt:Row&gt;
    &lt;twt:Row runat="server"&gt;
      &lt;twt:Column runat="server" Small="9"&gt;
        Level 1: .col-sm-9
        &lt;twt:Row runat="server"&gt;
          &lt;twt:Column runat="server" ExtraSmall="8" Small="6"&gt;Level 2: .col-xs-8 .col-sm-6&lt;/twt:Column&gt;
          &lt;twt:Column runat="server" ExtraSmall="4" Small="6"&gt;Level 2: .col-xs-4 .col-sm-6&lt;/twt:Column&gt;
        &lt;/twt:Row&gt;
      &lt;/twt:Column&gt;
    &lt;/twt:Row&gt;
  &lt;/Content&gt;
  &lt;Footer&gt;
    &lt;twt:Button runat="server"
      Text="Close"
      UseSubmitBehavior="false"
      data-dismiss="modal"
    /&gt;
    &lt;twt:Button runat="server"
      ButtonType="Primary"
      Text="Save Changes"
      UseSubmitBehavior="false"
    /&gt;
  &lt;/Footer&gt;
&lt;/twt:Modal&gt;</code></pre></figure>
</section>
</asp:Content>

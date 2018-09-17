<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" Title="List Groups" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<p class="lead">List groups are a flexible and powerful component for displaying not only simple lists of elements, but complex ones with custom content.</p>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#list-group-basic" target="_blank">Basic example</a></h2>
  <p>The most basic list group is simply an unordered list with list items. Build upon it with the options that follow.</p>
  <div class="bs-example">
    <twt:ListGroup runat="server" RenderAsList="true">
      <twt:ListGroupItem Text="Cras justo odio"          />
      <twt:ListGroupItem Text="Dapibus ac facilisis in"  />
      <twt:ListGroupItem Text="Morbi leo risus"          />
      <twt:ListGroupItem Text="Porta ac consectetur ac"  />
      <twt:ListGroupItem Text="Vestibulum at eros"       />
    </twt:ListGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ListGroup runat="server" RenderAsList="true"&gt;
  &lt;twt:ListGroupItem Text="Cras justo odio"          /&gt;
  &lt;twt:ListGroupItem Text="Dapibus ac facilisis in"  /&gt;
  &lt;twt:ListGroupItem Text="Morbi leo risus"          /&gt;
  &lt;twt:ListGroupItem Text="Porta ac consectetur ac"  /&gt;
  &lt;twt:ListGroupItem Text="Vestibulum at eros"       /&gt;
&lt;/twt:ListGroup&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#list-group-badges" target="_blank">Badges</a></h2>
  <p>Add the badges component to any list group item and it will automatically be positioned on the right.</p>
  <div class="bs-example">
    <twt:ListGroup runat="server" RenderAsList="true">
      <twt:ListGroupItem Text="Cras justo odio"         BadgeValue="14" />
      <twt:ListGroupItem Text="Dapibus ac facilisis in" BadgeValue="2" />
      <twt:ListGroupItem Text="Morbi leo risus"         BadgeValue="1" />
    </twt:ListGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ListGroup runat="server" RenderAsList="true"&gt;
  &lt;twt:ListGroupItem Text="Cras justo odio"         BadgeValue="14" /&gt;
  &lt;twt:ListGroupItem Text="Dapibus ac facilisis in" BadgeValue="2" /&gt;
  &lt;twt:ListGroupItem Text="Morbi leo risus"         BadgeValue="1" /&gt;
&lt;/twt:ListGroup&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#list-group-linked" target="_blank">Linked items</a></h2>
  <p>Linkify items by setting the <code>NavigateUrl</code> property on a <code>&lt;twt:ListGroupItem&gt;</code>.</p>
  <div class="bs-example">
    <twt:ListGroup runat="server">
      <twt:ListGroupItem Text="Cras justo odio"         NavigateUrl="#" Selected="true" />
      <twt:ListGroupItem Text="Dapibus ac facilisis in" NavigateUrl="#" />
      <twt:ListGroupItem Text="Morbi leo risus"         NavigateUrl="#" />
      <twt:ListGroupItem Text="Porta ac consectetur ac" NavigateUrl="#" />
      <twt:ListGroupItem Text="Vestibulum at eros"      NavigateUrl="#" />
    </twt:ListGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ListGroup runat="server"&gt;
  &lt;twt:ListGroupItem Text="Cras justo odio"         NavigateUrl="#" Selected="true" /&gt;
  &lt;twt:ListGroupItem Text="Dapibus ac facilisis in" NavigateUrl="#" /&gt;
  &lt;twt:ListGroupItem Text="Morbi leo risus"         NavigateUrl="#" /&gt;
  &lt;twt:ListGroupItem Text="Porta ac consectetur ac" NavigateUrl="#" /&gt;
  &lt;twt:ListGroupItem Text="Vestibulum at eros"      NavigateUrl="#" /&gt;
&lt;/twt:ListGroup&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#list-group-buttons" target="_blank">Button items</a></h2>
  <p>List group items may be rendered as buttons instead of list items by setting <code>RenderAsButton="true"</code> on a <code>&lt;twt:ListGroupItem&gt;</code>.</p>
  <div class="bs-example">
    <twt:ListGroup runat="server">
      <twt:ListGroupItem Text="Cras justo odio"         RenderAsButton="true" />
      <twt:ListGroupItem Text="Dapibus ac facilisis in" RenderAsButton="true" />
      <twt:ListGroupItem Text="Morbi leo risus"         RenderAsButton="true" />
      <twt:ListGroupItem Text="Porta ac consectetur ac" RenderAsButton="true" />
      <twt:ListGroupItem Text="Vestibulum at eros"      RenderAsButton="true" />
    </twt:ListGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ListGroup runat="server"&gt;
  &lt;twt:ListGroupItem Text="Cras justo odio"         RenderAsButton="true" /&gt;
  &lt;twt:ListGroupItem Text="Dapibus ac facilisis in" RenderAsButton="true" /&gt;
  &lt;twt:ListGroupItem Text="Morbi leo risus"         RenderAsButton="true" /&gt;
  &lt;twt:ListGroupItem Text="Porta ac consectetur ac" RenderAsButton="true" /&gt;
  &lt;twt:ListGroupItem Text="Vestibulum at eros"      RenderAsButton="true" /&gt;
&lt;/twt:ListGroup&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#list-group-disabled" target="_blank">Disabled items</a></h2>
  <p>Set <code>Enabled="false"</code> on a <code>&lt;twt:ListGroupItem&gt;</code> to gray it out to appear disabled.</p>
  <div class="bs-example">
    <twt:ListGroup runat="server">
      <twt:ListGroupItem Text="Cras justo odio"         Enabled="false" />
      <twt:ListGroupItem Text="Dapibus ac facilisis in"  />
      <twt:ListGroupItem Text="Morbi leo risus"          />
      <twt:ListGroupItem Text="Porta ac consectetur ac"  />
      <twt:ListGroupItem Text="Vestibulum at eros"       />
    </twt:ListGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ListGroup runat="server"&gt;
  &lt;twt:ListGroupItem Text="Cras justo odio"         Enabled="false" /&gt;
  &lt;twt:ListGroupItem Text="Dapibus ac facilisis in"  /&gt;
  &lt;twt:ListGroupItem Text="Morbi leo risus"          /&gt;
  &lt;twt:ListGroupItem Text="Porta ac consectetur ac"  /&gt;
  &lt;twt:ListGroupItem Text="Vestibulum at eros"       /&gt;
&lt;/twt:ListGroup&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#list-group-contextual-classes" target="_blank">Contextual classes</a></h2>
  <p>Set the <code>ContextStyle</code> property to style a <code>&lt;twt:ListGroupItem&gt;</code>.</p>
  <div class="bs-example">
    <div class="row">
      <div class="col-sm-6">
        <twt:ListGroup runat="server" RenderAsList="true">
          <twt:ListGroupItem Text="Dapibus ac facilisis in"   ContextStyle="Success" />
          <twt:ListGroupItem Text="Cras sit amet nibh libero" ContextStyle="Info" />
          <twt:ListGroupItem Text="Porta ac consectetur ac"   ContextStyle="Warning"/>
          <twt:ListGroupItem Text="Vestibulum at eros"        ContextStyle="Danger"/>
        </twt:ListGroup>
      </div>
      <div class="col-sm-6">
        <twt:ListGroup runat="server">
          <twt:ListGroupItem Text="Dapibus ac facilisis in"   ContextStyle="Success" />
          <twt:ListGroupItem Text="Cras sit amet nibh libero" ContextStyle="Info" />
          <twt:ListGroupItem Text="Porta ac consectetur ac"   ContextStyle="Warning"/>
          <twt:ListGroupItem Text="Vestibulum at eros"        ContextStyle="Danger"/>
        </twt:ListGroup>
      </div>
    </div>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;div class="row"&gt;
  &lt;div class="col-sm-6"&gt;
    &lt;twt:ListGroup runat="server" RenderAsList="true"&gt;
      &lt;twt:ListGroupItem Text="Dapibus ac facilisis in"   ContextStyle="Success" /&gt;
      &lt;twt:ListGroupItem Text="Cras sit amet nibh libero" ContextStyle="Info" /&gt;
      &lt;twt:ListGroupItem Text="Porta ac consectetur ac"   ContextStyle="Warning"/&gt;
      &lt;twt:ListGroupItem Text="Vestibulum at eros"        ContextStyle="Danger"/&gt;
    &lt;/twt:ListGroup&gt;
  &lt;/div&gt;
  &lt;div class="col-sm-6"&gt;
    &lt;twt:ListGroup runat="server"&gt;
      &lt;twt:ListGroupItem Text="Dapibus ac facilisis in"   ContextStyle="Success" /&gt;
      &lt;twt:ListGroupItem Text="Cras sit amet nibh libero" ContextStyle="Info" /&gt;
      &lt;twt:ListGroupItem Text="Porta ac consectetur ac"   ContextStyle="Warning"/&gt;
      &lt;twt:ListGroupItem Text="Vestibulum at eros"        ContextStyle="Danger"/&gt;
    &lt;/twt:ListGroup&gt;
  &lt;/div&gt;
&lt;/div&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#list-group-custom-content" target="_blank">Custom content</a></h2>
  <p>Add nearly any HTML within a <code>&lt;twt:ListGroupItem&gt;</code>.</p>
  <p class="text-danger"><strong>Note:</strong> Do not set the <code>Text</code> property when specifying custom contents.</p>
  <div class="bs-example">
    <twt:ListGroup runat="server">
      <twt:ListGroupItem Selected="true">
        <h3 class="list-group-item-heading">List group item heading</h3>
        <p class="list-group-item-text">Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit.</p>
      </twt:ListGroupItem>
      <twt:ListGroupItem>
        <h3 class="list-group-item-heading">List group item heading</h3>
        <p class="list-group-item-text">Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit.</p>
      </twt:ListGroupItem>
      <twt:ListGroupItem>
        <h3 class="list-group-item-heading">List group item heading</h3>
        <p class="list-group-item-text">Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit.</p>
      </twt:ListGroupItem>
    </twt:ListGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ListGroup runat="server"&gt;
  &lt;twt:ListGroupItem Selected="true"&gt;
    &lt;h3 class="list-group-item-heading"&gt;List group item heading&lt;/h3&gt;
    &lt;p class="list-group-item-text"&gt;Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit.&lt;/p&gt;
  &lt;/twt:ListGroupItem&gt;
  &lt;twt:ListGroupItem&gt;
    &lt;h3 class="list-group-item-heading"&gt;List group item heading&lt;/h3&gt;
    &lt;p class="list-group-item-text"&gt;Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit.&lt;/p&gt;
  &lt;/twt:ListGroupItem&gt;
  &lt;twt:ListGroupItem&gt;
    &lt;h3 class="list-group-item-heading"&gt;List group item heading&lt;/h3&gt;
    &lt;p class="list-group-item-text"&gt;Donec id elit non mi porta gravida at eget metus. Maecenas sed diam eget risus varius blandit.&lt;/p&gt;
  &lt;/twt:ListGroupItem&gt;
&lt;/twt:ListGroup&gt;</code></pre></figure>
</section>

</asp:Content>

<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Button Groups" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#btn-groups-single" target="_blank">Basic example</a></h2>
  <p>Wrap a series of <code>&lt;twt:Button&gt;</code>s in a <code>&lt;twt:ButtonGroup&gt;</code>.</p>
  <div class="bs-example">
    <twt:ButtonGroup runat="server" Label="Basic example">
      <Buttons>
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Left" />
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Middle" />
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Right" />
      </Buttons>
    </twt:ButtonGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ButtonGroup runat="server" Label="Basic example"&gt;
  &lt;Buttons&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Left" /&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Middle" /&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Right" /&gt;
  &lt;/Buttons&gt;
&lt;/twt:ButtonGroup&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#btn-groups-toolbar" target="_blank">Button toolbar</a></h2>
  <p>Combine sets of <code>&lt;twt:ButtonGroup&gt;</code>s with a <code>&lt;twt:ButtonGroup&gt;</code> with <code>Toolbar="true"</code> for more complex components.</p>
  <p></p>
  <div class="bs-example">
    <twt:ButtonGroup runat="server" Toolbar="true" Label="Toolbar with button groups">
      <Buttons>
        <twt:ButtonGroup runat="server" Label="First group">
          <Buttons>
            <twt:Button runat="server" UseSubmitBehavior="false" Text="1" />
            <twt:Button runat="server" UseSubmitBehavior="false" Text="2" />
            <twt:Button runat="server" UseSubmitBehavior="false" Text="3" />
            <twt:Button runat="server" UseSubmitBehavior="false" Text="4" />
          </Buttons>
        </twt:ButtonGroup>
        <twt:ButtonGroup runat="server" Label="Second group">
          <Buttons>
            <twt:Button runat="server" UseSubmitBehavior="false" Text="5" />
            <twt:Button runat="server" UseSubmitBehavior="false" Text="6" />
            <twt:Button runat="server" UseSubmitBehavior="false" Text="7" />
          </Buttons>
        </twt:ButtonGroup>
        <twt:ButtonGroup runat="server" Label="Third group">
          <Buttons>
            <twt:Button runat="server" UseSubmitBehavior="false" Text="8" />
          </Buttons>
        </twt:ButtonGroup>
      </Buttons>
    </twt:ButtonGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ButtonGroup runat="server" Toolbar="true" Label="Toolbar with button groups"&gt;
  &lt;Buttons&gt;
    &lt;twt:ButtonGroup runat="server" Label="First group"&gt;
      &lt;Buttons&gt;
        &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="1" /&gt;
        &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="2" /&gt;
        &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="3" /&gt;
        &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="4" /&gt;
      &lt;/Buttons&gt;
    &lt;/twt:ButtonGroup&gt;
    &lt;twt:ButtonGroup runat="server" Label="Second group"&gt;
      &lt;Buttons&gt;
        &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="5" /&gt;
        &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="6" /&gt;
        &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="7" /&gt;
      &lt;/Buttons&gt;
    &lt;/twt:ButtonGroup&gt;
    &lt;twt:ButtonGroup runat="server" Label="Third group"&gt;
      &lt;Buttons&gt;
        &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="8" /&gt;
      &lt;/Buttons&gt;
    &lt;/twt:ButtonGroup&gt;
  &lt;/Buttons&gt;
&lt;/twt:ButtonGroup&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#btn-groups-sizing" target="_blank">Sizing</a></h2>
  <p>Instead of applying button sizing classes to every <code>&lt;twt:Button&gt;</code> in a <code>&lt;twt:ButtonGroup&gt;</code>, just add <code>ButtonSize</code> on the <code>&lt;twt:ButtonGroup&gt;</code>.</p>
  <div class="bs-example">
    <twt:ButtonGroup runat="server" Label="Large button group" ButtonSize="Large">
      <Buttons>
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Left" />
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Middle" />
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Right" />
      </Buttons>
    </twt:ButtonGroup>
    <twt:ButtonGroup runat="server" Label="Default button group" ButtonSize="Default">
      <Buttons>
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Left" />
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Middle" />
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Right" />
      </Buttons>
    </twt:ButtonGroup>
    <twt:ButtonGroup runat="server" Label="Small button group" ButtonSize="Small">
      <Buttons>
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Left" />
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Middle" />
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Right" />
      </Buttons>
    </twt:ButtonGroup>
    <twt:ButtonGroup runat="server" Label="Mini button group" ButtonSize="Mini">
      <Buttons>
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Left" />
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Middle" />
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Right" />
      </Buttons>
    </twt:ButtonGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ButtonGroup runat="server" Label="Large button group" ButtonSize="Large"&gt;
  &lt;Buttons&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Left" /&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Middle" /&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Right" /&gt;
  &lt;/Buttons&gt;
&lt;/twt:ButtonGroup&gt;
&lt;twt:ButtonGroup runat="server" Label="Default button group" ButtonSize="Default"&gt;
  &lt;Buttons&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Left" /&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Middle" /&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Right" /&gt;
  &lt;/Buttons&gt;
&lt;/twt:ButtonGroup&gt;
&lt;twt:ButtonGroup runat="server" Label="Small button group" ButtonSize="Small"&gt;
  &lt;Buttons&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Left" /&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Middle" /&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Right" /&gt;
  &lt;/Buttons&gt;
&lt;/twt:ButtonGroup&gt;
&lt;twt:ButtonGroup runat="server" Label="Mini button group" ButtonSize="Mini"&gt;
  &lt;Buttons&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Left" /&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Middle" /&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Right" /&gt;
  &lt;/Buttons&gt;
&lt;/twt:ButtonGroup&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#btn-groups-nested" target="_blank">Nesting</a></h2>
  <p>Place a <code>&lt;twt:DropdownButton&gt;</code> within a <code>&lt;twt:ButtonGroup&gt;</code> when you want dropdown menus mixed with a series of buttons.</p>
  <div class="bs-example">
    <twt:ButtonGroup runat="server" Label="Button group with nested dropdown">
      <Buttons>
        <twt:Button runat="server" UseSubmitBehavior="false" Text="1" />
        <twt:Button runat="server" UseSubmitBehavior="false" Text="2" />
        <twt:DropdownButton runat="server" Text="Dropdown">
          <Items>
            <twt:ListItem NavigateUrl="#" Text="Dropdown link" />
            <twt:ListItem NavigateUrl="#" Text="Dropdown link" />
          </Items>
        </twt:DropdownButton>
      </Buttons>
    </twt:ButtonGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ButtonGroup runat="server" Label="Button group with nested dropdown"&gt;
  &lt;Buttons&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="1" /&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="2" /&gt;
    &lt;twt:DropdownButton runat="server" Text="Dropdown"&gt;
      &lt;Items&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Dropdown link" /&gt;
        &lt;twt:ListItem NavigateUrl="#" Text="Dropdown link" /&gt;
      &lt;/Items&gt;
    &lt;/twt:DropdownButton&gt;
  &lt;/Buttons&gt;
&lt;/twt:ButtonGroup&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#btn-groups-vertical" target="_blank">Vertical variation</a></h2>
  <p>Make buttons appear vertically stacked rather than horizontally by setting <code>Orientation="Vertical"</code>. Split button dropdowns are not supported here.</p>
  <div class="bs-example">
    <twt:ButtonGroup runat="server" Orientation="Vertical" Label="Button group with nested dropdown">
      <Buttons>
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Button" />
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Button" />
        <twt:DropdownButton runat="server" Text="Dropdown">
          <twt:ListItem NavigateUrl="#" Text="Dropdown link" />
          <twt:ListItem NavigateUrl="#" Text="Dropdown link" />
        </twt:DropdownButton>
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Button" />
        <twt:Button runat="server" UseSubmitBehavior="false" Text="Button" />
        <twt:DropdownButton runat="server" Text="Dropdown">
          <twt:ListItem NavigateUrl="#" Text="Dropdown link" />
          <twt:ListItem NavigateUrl="#" Text="Dropdown link" />
        </twt:DropdownButton>
        <twt:DropdownButton runat="server" Text="Dropdown">
          <twt:ListItem NavigateUrl="#" Text="Dropdown link" />
          <twt:ListItem NavigateUrl="#" Text="Dropdown link" />
        </twt:DropdownButton>
        <twt:DropdownButton runat="server" Text="Dropdown">
          <twt:ListItem NavigateUrl="#" Text="Dropdown link" />
          <twt:ListItem NavigateUrl="#" Text="Dropdown link" />
        </twt:DropdownButton>
      </Buttons>
    </twt:ButtonGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ButtonGroup runat="server" Orientation="Vertical" Label="Button group with nested dropdown"&gt;
  &lt;Buttons&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Button" /&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Button" /&gt;
    &lt;twt:DropdownButton runat="server" Text="Dropdown"&gt;
      &lt;twt:ListItem NavigateUrl="#" Text="Dropdown link" /&gt;
      &lt;twt:ListItem NavigateUrl="#" Text="Dropdown link" /&gt;
    &lt;/twt:DropdownButton&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Button" /&gt;
    &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Button" /&gt;
    &lt;twt:DropdownButton runat="server" Text="Dropdown"&gt;
      &lt;twt:ListItem NavigateUrl="#" Text="Dropdown link" /&gt;
      &lt;twt:ListItem NavigateUrl="#" Text="Dropdown link" /&gt;
    &lt;/twt:DropdownButton&gt;
    &lt;twt:DropdownButton runat="server" Text="Dropdown"&gt;
      &lt;twt:ListItem NavigateUrl="#" Text="Dropdown link" /&gt;
      &lt;twt:ListItem NavigateUrl="#" Text="Dropdown link" /&gt;
    &lt;/twt:DropdownButton&gt;
    &lt;twt:DropdownButton runat="server" Text="Dropdown"&gt;
      &lt;twt:ListItem NavigateUrl="#" Text="Dropdown link" /&gt;
      &lt;twt:ListItem NavigateUrl="#" Text="Dropdown link" /&gt;
    &lt;/twt:DropdownButton&gt;
  &lt;/Buttons&gt;
&lt;/twt:ButtonGroup&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#btn-groups-justified" target="_blank">Justified button groups</a></h2>
  <p>Make a group of buttons stretch at equal sizes to span the entire width of its parent. Also works with button dropdowns within the button group.</p>
  <div class="bs-callout bs-callout-warning" id="callout-btn-group-justified-dbl-border"> <h3 class="h4">Handling borders</h3> <p>Due to the specific HTML and CSS used to justify buttons (namely <code>display: table-cell</code>), the borders between them are doubled. In regular button groups, <code>margin-left: -1px</code> is used to stack the borders instead of removing them. However, <code>margin</code> doesn't work with <code>display: table-cell</code>. As a result, depending on your customizations to Bootstrap, you may wish to remove or re-color the borders.</p> </div>
  <div class="bs-callout bs-callout-warning" id="callout-btn-group-ie8-border"> <h3 class="h4">IE8 and borders</h3> <p>Internet Explorer 8 doesn't render borders on buttons in a justified button group, whether it's on <code>&lt;a&gt;</code> or <code>&lt;button&gt;</code> elements. To get around that, wrap each button in another <code>.btn-group</code>.</p> <p>See <a href="https://github.com/twbs/bootstrap/issues/12476" target="_blank">#12476</a> for more information.</p></div>
  <h3 class="h4">Using <code>HyperLinkButton</code></h3>
  <div class="bs-example">
    <twt:ButtonGroup runat="server" Label="Justified button group" Justified="true">
      <Buttons>
        <twt:HyperLinkButton runat="server" NavigateUrl="#" Text="Left" />
        <twt:HyperLinkButton runat="server" NavigateUrl="#" Text="Middle" />
        <twt:HyperLinkButton runat="server" NavigateUrl="#" Text="Right" />
      </Buttons>
    </twt:ButtonGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ButtonGroup runat="server" Label="Justified button group" Justified="true"&gt;
  &lt;Buttons&gt;
    &lt;twt:HyperLinkButton runat="server" NavigateUrl="#" Text="Left" /&gt;
    &lt;twt:HyperLinkButton runat="server" NavigateUrl="#" Text="Middle" /&gt;
    &lt;twt:HyperLinkButton runat="server" NavigateUrl="#" Text="Right" /&gt;
  &lt;/Buttons&gt;
&lt;/twt:ButtonGroup&gt;</code></pre></figure>
  
  <h3 class="h4">Using <code>Button</code></h3>
  <p>
    To use justified button groups with <code>&lt;twt:Button&gt;</code> elements, <strong class="text-danger">you must wrap each <code>&lt;twt:Button&gt;</code> in a <code>&lt;twt:ButtonGroup&gt;</code></strong>.
    Most browsers don't properly apply our CSS for justification to <code>&lt;twt:Button&gt;</code> elements, but since we support button dropdowns, we can work around that.
  </p>
  <div class="bs-example">
    <twt:ButtonGroup runat="server" Label="Justified button group" Justified="true">
      <Buttons>
        <twt:ButtonGroup runat="server">
          <Buttons>
            <twt:Button runat="server" UseSubmitBehavior="false" Text="Left" />
          </Buttons>
        </twt:ButtonGroup>
        <twt:ButtonGroup runat="server">
          <Buttons>
            <twt:Button runat="server" UseSubmitBehavior="false" Text="Middle" />
          </Buttons>
        </twt:ButtonGroup>
        <twt:ButtonGroup runat="server">
          <Buttons>
            <twt:Button runat="server" UseSubmitBehavior="false" Text="Right" />
          </Buttons>
        </twt:ButtonGroup>
      </Buttons>
    </twt:ButtonGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ButtonGroup runat="server" Label="Justified button group" Justified="true"&gt;
  &lt;Buttons&gt;
    &lt;twt:ButtonGroup runat="server"&gt;
      &lt;Buttons&gt;
        &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Left" /&gt;
      &lt;/Buttons&gt;
    &lt;/twt:ButtonGroup&gt;
    &lt;twt:ButtonGroup runat="server"&gt;
      &lt;Buttons&gt;
        &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Middle" /&gt;
      &lt;/Buttons&gt;
    &lt;/twt:ButtonGroup&gt;
    &lt;twt:ButtonGroup runat="server"&gt;
      &lt;Buttons&gt;
        &lt;twt:Button runat="server" UseSubmitBehavior="false" Text="Right" /&gt;
      &lt;/Buttons&gt;
    &lt;/twt:ButtonGroup&gt;
  &lt;/Buttons&gt;
&lt;/twt:ButtonGroup&gt;</code></pre></figure>
</section>

</asp:Content>

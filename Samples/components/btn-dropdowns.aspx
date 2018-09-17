<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Button Dropdowns" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#btn-dropdowns-single" target="_blank">Single button dropdowns</a></h2>
  <p>Use <code>&lt;twt:DropdownButton&gt;</code> to trigger a dropdown menu on click.</p>
  <div class="bs-callout bs-callout-danger" id="callout-btndropdown-dependency"> <h3 class="h4">Plugin dependency</h3> <p>Button dropdowns require the <a href="https://getbootstrap.com/docs/3.3/javascript/#dropdowns" target="_blank">dropdown plugin</a> to be included in your version of Bootstrap.</p> </div>
  <div class="bs-example">
    <twt:DropdownButton runat="server" Text="Default" ButtonType="Default">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
    <twt:DropdownButton runat="server" Text="Primary" ButtonType="Primary">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
    <twt:DropdownButton runat="server" Text="Success" ButtonType="Success">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
    <twt:DropdownButton runat="server" Text="Info" ButtonType="Info">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
    <twt:DropdownButton runat="server" Text="Warning" ButtonType="Warning">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
    <twt:DropdownButton runat="server" Text="Danger" ButtonType="Danger">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:DropdownButton runat="server" Text="Default" ButtonType="Default"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;
&lt;twt:DropdownButton runat="server" Text="Primary" ButtonType="Primary"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;
&lt;twt:DropdownButton runat="server" Text="Success" ButtonType="Success"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;
&lt;twt:DropdownButton runat="server" Text="Info" ButtonType="Info"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;
&lt;twt:DropdownButton runat="server" Text="Warning" ButtonType="Warning"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;
&lt;twt:DropdownButton runat="server" Text="Danger" ButtonType="Danger"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#btn-dropdowns-split" target="_blank">Split button dropdowns</a></h2>
  <p>Similarly, create split button dropdowns by setting <code>Split="true"</code>.</p>
  <div class="bs-example">
    <twt:DropdownButton runat="server" Split="true" Text="Default" ButtonType="Default">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
    <twt:DropdownButton runat="server" Split="true" Text="Primary" ButtonType="Primary">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
    <twt:DropdownButton runat="server" Split="true" Text="Success" ButtonType="Success">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
    <twt:DropdownButton runat="server" Split="true" Text="Info" ButtonType="Info">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
    <twt:DropdownButton runat="server" Split="true" Text="Warning" ButtonType="Warning">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
    <twt:DropdownButton runat="server" Split="true" Text="Danger" ButtonType="Danger">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:DropdownButton runat="server" Split="true" Text="Default" ButtonType="Default"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;
&lt;twt:DropdownButton runat="server" Split="true" Text="Primary" ButtonType="Primary"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;
&lt;twt:DropdownButton runat="server" Split="true" Text="Success" ButtonType="Success"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;
&lt;twt:DropdownButton runat="server" Split="true" Text="Info" ButtonType="Info"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;
&lt;twt:DropdownButton runat="server" Split="true" Text="Warning" ButtonType="Warning"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;
&lt;twt:DropdownButton runat="server" Split="true" Text="Danger" ButtonType="Danger"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#btn-dropdowns-sizing" target="_blank">Sizing</a></h2>
  <p>Use the <code>ButtonSize</code> property to control the size.</p>
  <div class="bs-example">
    <twt:DropdownButton runat="server" ButtonType="Default" ButtonSize="Large" Text="Large button">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
    <twt:DropdownButton runat="server" ButtonType="Default" ButtonSize="Small" Text="Small button">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
    <twt:DropdownButton runat="server" ButtonType="Default" ButtonSize="Mini" Text="Extra small button">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:DropdownButton runat="server" ButtonType="Default" ButtonSize="Large" Text="Large button"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;
&lt;twt:DropdownButton runat="server" ButtonType="Default" ButtonSize="Small" Text="Small button"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;
&lt;twt:DropdownButton runat="server" ButtonType="Default" ButtonSize="Mini" Text="Extra small button"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#btn-dropdowns-dropup" target="_blank">Dropup variation</a></h2>
  <p>Trigger dropdown menus above elements by adding <code>DropUp="true"</code>.</p>
  <div class="bs-example">
    <twt:DropdownButton runat="server" DropUp="true" Split="true" ButtonType="Default" Text="Dropup">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
    <twt:DropdownButton runat="server" DropUp="true" Split="true" ButtonType="Primary" RightToLeft="true" Text="Right dropup">
      <Items>
        <twt:ListItem NavigateUrl="#" Text="Action" />
        <twt:ListItem NavigateUrl="#" Text="Another action" />
        <twt:ListItem NavigateUrl="#" Text="Something else here" />
        <twt:ListSeparator />
        <twt:ListItem NavigateUrl="#" Text="Separated link" />
      </Items>
    </twt:DropdownButton>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:DropdownButton runat="server" DropUp="true" Split="true" ButtonType="Default" Text="Dropup"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;
&lt;twt:DropdownButton runat="server" DropUp="true" Split="true" ButtonType="Primary" RightToLeft="true" Text="Right dropup"&gt;
  &lt;Items&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Another action" /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Something else here" /&gt;
    &lt;twt:ListSeparator /&gt;
    &lt;twt:ListItem NavigateUrl="#" Text="Separated link" /&gt;
  &lt;/Items&gt;
&lt;/twt:DropdownButton&gt;</code></pre></figure>
</section>
</asp:Content>

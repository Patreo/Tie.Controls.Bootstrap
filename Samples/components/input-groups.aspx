<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" Title="Input Groups" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<p class="lead">Extend form controls by adding text or buttons before, after, or on both sides of any text-based input.</p>
<div class="bs-callout bs-callout-danger" id="callout-inputgroup-text-input-only"> <h2 class="h4">Textual <code>&lt;input&gt;</code>s only</h2> <p>Avoid using <code>&lt;select&gt;</code> elements here as they cannot be fully styled in WebKit browsers.</p> <p>Avoid using <code>&lt;textarea&gt;</code> elements here as their <code>rows</code> attribute will not be respected in some cases.</p> </div>
<div class="bs-callout bs-callout-warning" id="callout-inputgroup-container-body"> <h2 class="4">Tooltips &amp; popovers in input groups require special setting</h2> <p>When using tooltips or popovers on elements within an <code>.input-group</code>, you'll have to specify the option <code>container: 'body'</code> to avoid unwanted side effects (such as the element growing wider and/or losing its rounded corners when the tooltip or popover is triggered).</p> </div>
<div class="bs-callout bs-callout-warning" id="callout-inputgroup-dont-mix"> <h2 class="h4">Don't mix with other components</h2> <p>Do not mix form groups or grid column classes directly with <code>&lt;twt:InputGroup&gt;</code>s. Instead, nest the input group inside of the form group or grid-related element.</p> </div>
<div class="bs-callout bs-callout-warning" id="callout-inputgroup-form-labels"> <h2 class="h4">Always add labels</h2> <p>Screen readers will have trouble with your forms if you don't include a label for every input. For these input groups, ensure that any additional label or functionality is conveyed to assistive technologies.</p></div>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#input-groups-basic" target="_blank">Basic example</a></h2>
  <p>Place one add-on or button on either side of an input. You may also place one on both sides of an input.</p>
  <p><strong class="text-danger">We do not support multiple form-controls in a single input group.</strong></p>
  <div class="bs-example">
    <twt:InputGroup runat="server"
      Prefix="@"
    >
      <asp:Label runat="server" CssClass="sr-only" AssociatedControlID="username">Username</asp:Label>
      <twt:TextBox runat="server" PlaceholderText="Username" ID="username" />
    </twt:InputGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:InputGroup runat="server"
  Prefix="@"
&gt;
  &lt;asp:Label runat="server" CssClass="sr-only" AssociatedControlID="username"&gt;Username&lt;/asp:Label&gt;
  &lt;twt:TextBox runat="server" PlaceholderText="Username" ID="username" /&gt;
&lt;/twt:InputGroup&gt;</code></pre></figure>

  <div class="bs-example">
    <twt:InputGroup runat="server"
      Suffix="@example.com"
    >
      <asp:Label runat="server" CssClass="sr-only" AssociatedControlID="recipient">Recipient's username ("@example.com" is automatically added to the end)</asp:Label>
      <twt:TextBox runat="server" PlaceholderText="Recipient's username" ID="recipient" />
    </twt:InputGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:InputGroup runat="server"
  Suffix="@example.com"
&gt;
  &lt;asp:Label runat="server" CssClass="sr-only" AssociatedControlID="recipient"&gt;Recipient's username ("@example.com" is automatically added to the end)&lt;/asp:Label&gt;
  &lt;twt:TextBox runat="server" PlaceholderText="Recipient's username" ID="recipient" /&gt;
&lt;/twt:InputGroup&gt;</code></pre></figure>

  <div class="bs-example">
    <twt:InputGroup runat="server"
      Prefix="$"
      Suffix=".00"
    >
      <asp:Label runat="server" CssClass="sr-only" AssociatedControlID="amount">Amount (in dollars)</asp:Label>
      <twt:TextBox runat="server" ID="amount" />
    </twt:InputGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:InputGroup runat="server"
  Prefix="$"
  Suffix=".00"
&gt;
  &lt;asp:Label runat="server" CssClass="sr-only" AssociatedControlID="amount"&gt;Amount (in dollars)&lt;/asp:Label&gt;
  &lt;twt:TextBox runat="server" ID="amount" /&gt;
&lt;/twt:InputGroup&gt;</code></pre></figure>
</section>
<section>
  <h2>Labels outside the InputGroup</h2>
  <p>In the following example, the <code>&lt;twt:TextBox&gt;</code> is in a template but its corresponding <code>&lt;twt:Label&gt;</code> is not. In cases like this, the label must be associated manually in the code-behind.</p>
  <div class="bs-example">
    <label runat="server" ID="lblVanity">
      Your vanity URL
      <span class="sr-only">("https://example.com/users/" is automatically added to the beginning)</span>
    </label>
    <twt:InputGroup runat="server"
      ID="groupVanity"
      Prefix="https://example.com/users/"
    >
      <twt:TextBox runat="server" ID="vanityurl" />
    </twt:InputGroup>
    <script runat="server">
      protected void Page_Load(object sender, EventArgs e)
      {
        // since the TextBox is in a template and the Label is not,
        // the label must be associated manually
        var txt = groupVanity.FindControl("vanityurl") as WebControl;
        if(txt != null)
        {
          lblVanity.Attributes["for"] = txt.ClientID;
        }
      }
    </script>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;label runat="server" ID="lblVanity"&gt;
  Your vanity URL
  &lt;span class="sr-only"&gt;("https://example.com/users/" is automatically added to the beginning)&lt;/span&gt;
&lt;/label&gt;
&lt;twt:InputGroup runat="server"
  ID="groupVanity"
  Prefix="https://example.com/users/"
&gt;
  &lt;twt:TextBox runat="server" ID="vanityurl" /&gt;
&lt;/twt:InputGroup&gt;
&lt;script runat="server"&gt;
  protected void Page_Load(object sender, EventArgs e)
  {
    var txt = groupVanity.FindControl("vanityurl") as WebControl;
    if(txt != null)
    {
      lblVanity.Attributes["for"] = txt.ClientID;
    }
  }
&lt;/script&gt;</code></pre></figure>
</section>
</asp:Content>

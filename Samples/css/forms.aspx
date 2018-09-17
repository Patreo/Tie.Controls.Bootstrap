<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Forms" CodeBehind="forms.aspx.cs" Inherits="Samples.css.Forms" %>

<%@ Register TagPrefix="cc1" Namespace="System.Web.UI" Assembly="System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<asp:ScriptManager runat="server" />
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#forms-example" target="_blank">Basic example</a></h2>
  <p>Use the <code>&lt;twt:FormGroup&gt;</code> tag and <code>&lt;twt:*&gt;</code> inputs for optimal styling and spacing.</p>
  <div class="bs-example">
    <twt:FormGroup runat="server" LabelText="Email address">
      <twt:TextBox ID="exampleInputEmail1" runat="server" TextMode="Email" PlaceholderText="Email" />
    </twt:FormGroup>
    <twt:FormGroup runat="server" LabelText="Password">
      <twt:TextBox ID="exampleInputPassword1" runat="server" TextMode="Password" PlaceholderText="Password" />
    </twt:FormGroup>
    <twt:FormGroup runat="server" LabelText="File input">
      <asp:FileUpload runat="server" ID="exampleInputFile" />
      <p class="help-block">Example block-level help text here.</p>
    </twt:FormGroup>
    <twt:CheckBox runat="server" Text="Remember me" />
    <twt:Button runat="server" ButtonType="Default" Text="Submit" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:FormGroup runat="server" LabelText="Email address"&gt;
  &lt;twt:TextBox ID="exampleInputEmail1" runat="server" TextMode="Email" PlaceholderText="Email" /&gt;
&lt;/twt:FormGroup&gt;
&lt;twt:FormGroup runat="server" LabelText="Password"&gt;
  &lt;twt:TextBox ID="exampleInputPassword1" runat="server" TextMode="Password" PlaceholderText="Password" /&gt;
&lt;/twt:FormGroup&gt;
&lt;twt:FormGroup runat="server" LabelText="File input"&gt;
  &lt;asp:FileUpload runat="server" ID="exampleInputFile" /&gt;
  &lt;p class="help-block"&gt;Example block-level help text here.&lt;/p&gt;
&lt;/twt:FormGroup&gt;
&lt;twt:CheckBox runat="server" Text="Remember me" /&gt;
&lt;twt:Button runat="server" ButtonType="Default" Text="Submit" /&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#forms-inline" target="_blank">Inline form</a></h2>
  <p>
    Wrap your inputs in an element classed <code>.form-inline</code> for left-aligned and inline-block controls. 
    This only applies to forms within viewports that are at least 768px wide.
  </p>
  <div class="bs-callout bs-callout-warning" id="callout-inline-form-labels">
    <h3 class="h4">Always add labels</h3>
    <p>
      Screen readers will have trouble with your forms if you don't include a <code>LabelText</code> for every input. 
      For these inline forms, you can hide the labels by setting <code>LabelVisible="false"</code> on the <code>&lt;twt:FormGroup&gt;</code>. 
      Note that use of <code>PlaceholderText</code> as a replacement for other labeling methods is not advised.
    </p> 
  </div>
  <div class="bs-example">
    <div class="form-inline">
      <twt:FormGroup runat="server" LabelText="Name">
        <twt:TextBox ID="exampleInputName2" runat="server" PlaceholderText="Jane Doe" />
      </twt:FormGroup>
      <twt:FormGroup runat="server" LabelText="Email">
        <twt:TextBox ID="exampleInputEmail2" runat="server" TextMode="Email" PlaceholderText="jane.doe@example.com" />
      </twt:FormGroup>
      <twt:Button runat="server" ButtonType="Default" Text="Send invitation" />
    </div>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;div class="form-inline"&gt;
  &lt;twt:FormGroup runat="server" LabelText="Name"&gt;
    &lt;twt:TextBox ID="exampleInputName2" runat="server" PlaceholderText="Jane Doe" /&gt;
  &lt;/twt:FormGroup&gt;
  &lt;twt:FormGroup runat="server" LabelText="Email"&gt;
    &lt;twt:TextBox ID="exampleInputEmail2" runat="server" TextMode="Email" PlaceholderText="jane.doe@example.com" /&gt;
  &lt;/twt:FormGroup&gt;
  &lt;twt:Button runat="server" ButtonType="Default" Text="Send invitation" /&gt;
&lt;/div&gt;</code></pre></figure>
  <div class="bs-example">
    <div class="form-inline">
      <twt:FormGroup runat="server" LabelText="Email address" LabelVisible="false">
        <twt:TextBox ID="exampleInputEmail3" runat="server" TextMode="Email" PlaceholderText="Email" />
      </twt:FormGroup>
      <twt:FormGroup runat="server" LabelText="Password" LabelVisible="false">
        <twt:TextBox ID="exampleInputPassword3" runat="server" TextMode="Password" PlaceholderText="Password" />
      </twt:FormGroup>
      <twt:CheckBox runat="server" Text="Remember me" />
      <twt:Button runat="server" ButtonType="Default" Text="Sign in" />
    </div>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;div class="form-inline"&gt;
  &lt;twt:FormGroup runat="server" LabelText="Email address" LabelVisible="false"&gt;
    &lt;twt:TextBox ID="exampleInputEmail3" runat="server" TextMode="Email" PlaceholderText="Email" /&gt;
  &lt;/twt:FormGroup&gt;
  &lt;twt:FormGroup runat="server" LabelText="Password" LabelVisible="false"&gt;
    &lt;twt:TextBox ID="exampleInputPassword3" runat="server" TextMode="Password" PlaceholderText="Password" /&gt;
  &lt;/twt:FormGroup&gt;
  &lt;twt:CheckBox runat="server" Text="Remember me" /&gt;
  &lt;twt:Button runat="server" ButtonType="Default" Text="Sign in" /&gt;
&lt;/div&gt;</code></pre></figure>
  <div class="bs-example">
    <div class="form-inline">
      <twt:FormGroup runat="server" LabelText="Amount (in dollars)" LabelVisible="false" ControlID="exampleInputAmount">
        <twt:InputGroup runat="server" Prefix="$" Suffix=".00">
          <twt:TextBox runat="server" PlaceholderText="Amount" ID="exampleInputAmount" />
        </twt:InputGroup>
      </twt:FormGroup>
      <twt:Button runat="server" ButtonType="Primary" Text="Transfer cash" />
    </div>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;div class="form-inline"&gt;
  &lt;twt:FormGroup runat="server" LabelText="Amount (in dollars)" LabelVisible="false" ControlID="exampleInputAmount"&gt;
    &lt;twt:InputGroup runat="server" Prefix="$" Suffix=".00"&gt;
      &lt;twt:TextBox runat="server" PlaceholderText="Amount" ID="exampleInputAmount" /&gt;
    &lt;/twt:InputGroup&gt;
  &lt;/twt:FormGroup&gt;
  &lt;twt:Button runat="server" ButtonType="Primary" Text="Transfer cash" /&gt;
&lt;/div&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#forms-horizontal" target="_blank">Horizontal form</a></h2>
  <p>
    Use Bootstrap's predefined grid classes to align labels and groups of form controls in a horizontal layout by 
    wrapping your inputs in an element classed <code>.form-inline</code>.
    Doing so changes <code>&lt;twt:FormGroup&gt;</code> to behave as grid rows. Use the <code>LabelClass</code> and <code>ControlClass</code>
    properties to set the column widths.
  </p>
  <div class="bs-example">
    <div class="form-horizontal">
      <twt:FormGroup runat="server" LabelText="Email address" LabelClass="col-sm-2 control-label" ControlClass="col-sm-10">
        <twt:TextBox ID="inputEmail3" runat="server" TextMode="Email" PlaceholderText="Email" />
      </twt:FormGroup>
      <twt:FormGroup runat="server" LabelText="Password" LabelClass="col-sm-2 control-label" ControlClass="col-sm-10">
        <twt:TextBox ID="inputPassword3" runat="server" TextMode="Password" PlaceholderText="Password" />
      </twt:FormGroup>
      <twt:FormGroup runat="server" ControlClass="col-sm-offset-2 col-sm-10">
        <twt:CheckBox runat="server" Text="Remember me" />
      </twt:FormGroup>
      <twt:FormGroup runat="server" ControlClass="col-sm-offset-2 col-sm-10">
        <twt:Button runat="server" ButtonType="Default" Text="Sign in" />
      </twt:FormGroup>
    </div>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;div class="form-horizontal"&gt;
  &lt;twt:FormGroup runat="server" LabelText="Email address" LabelClass="col-sm-2 control-label" ControlClass="col-sm-10"&gt;
    &lt;twt:TextBox ID="inputEmail3" runat="server" TextMode="Email" PlaceholderText="Email" /&gt;
  &lt;/twt:FormGroup&gt;
  &lt;twt:FormGroup runat="server" LabelText="Password" LabelClass="col-sm-2 control-label" ControlClass="col-sm-10"&gt;
    &lt;twt:TextBox ID="inputPassword3" runat="server" TextMode="Password" PlaceholderText="Password" /&gt;
  &lt;/twt:FormGroup&gt;
  &lt;twt:FormGroup runat="server" ControlClass="col-sm-offset-2 col-sm-10"&gt;
    &lt;twt:CheckBox runat="server" Text="Remember me" /&gt;
  &lt;/twt:FormGroup&gt;
  &lt;twt:FormGroup runat="server" ControlClass="col-sm-offset-2 col-sm-10"&gt;
    &lt;twt:Button runat="server" ButtonType="Default" Text="Sign in" /&gt;
  &lt;/twt:FormGroup&gt;
&lt;/div&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#forms-controls" target="_blank">Supported controls</a></h2>
  <p>
    Examples of standard form controls supported in an example form layout. All of these derive from the native ASP.NET
    user controls (from <code>System.Web.UI</code>) and should, for the most part, behave like their native counterparts. 
  </p>
  <h3><a href="https://getbootstrap.com/docs/3.3/css/#inputs" target="_blank">Inputs</a></h3>
  <p>Most common form control, text-based input fields can be created using the <code>&lt;twt:TextBox&gt;</code> control.</p>
  <div class="bs-example">
    <twt:FormGroup runat="server" LabelVisible="false" LabelText="Input">
      <twt:TextBox runat="server" />
    </twt:FormGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:FormGroup runat="server" LabelVisible="false" LabelText="Input"&gt;
  &lt;twt:TextBox runat="server" /&gt;
&lt;/twt:FormGroup&gt;</code></pre></figure>

  <h3><a href="https://getbootstrap.com/docs/3.3/css/#textarea" target="_blank">Textarea</a></h3>
  <p>Form control which supports multiple lines of text. Set <code>TextMode="MultiLine"</code> on the <code>&lt;twt:TextBox&gt;</code> control.</p>
  <div class="bs-example">
    <twt:FormGroup runat="server" LabelVisible="false" LabelText="Textarea">
      <twt:TextBox runat="server" TextMode="MultiLine" />
    </twt:FormGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:FormGroup runat="server" LabelVisible="false" LabelText="Textarea"&gt;
  &lt;twt:TextBox runat="server" TextMode="MultiLine" /&gt;
&lt;/twt:FormGroup&gt;</code></pre></figure>

  <h3><a href="https://getbootstrap.com/docs/3.3/css/#checkboxes-and-radios" target="_blank">Checkboxes and radios</a></h3>
  <p>Checkboxes are for selecting one or several options in a list, while radios are for selecting one option from many.</p>
  <h4>Default (stacked)</h4>
  <div class="bs-example">
    <twt:CheckBox runat="server" Text="Option one is this and that&mdash;be sure to include why it's great" />
    <twt:CheckBox runat="server" Text="Option two is disabled" Enabled="false" />
    <twt:RadioButtonList runat="server" ID="RadioButtonList1" Legend="Options">
      <asp:ListItem Value="option1" Text="Option one is this and that&mdash;be sure to include why it's great" />
      <asp:ListItem Value="option2" Text="Option two can be something else and selecting it will deselect option one" />
      <asp:ListItem Value="option3" Text="Option three is disabled" Enabled="false" />
    </twt:RadioButtonList>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:CheckBox runat="server" Text="Option one is this and that&mdash;be sure to include why it's great" /&gt;
&lt;twt:CheckBox runat="server" Text="Option two is disabled" Enabled="false" /&gt;
&lt;twt:RadioButtonList runat="server" ID="RadioButtonList1" Legend="Options"&gt;
  &lt;asp:ListItem Value="option1" Text="Option one is this and that&mdash;be sure to include why it's great" /&gt;
  &lt;asp:ListItem Value="option2" Text="Option two can be something else and selecting it will deselect option one" /&gt;
  &lt;asp:ListItem Value="option3" Text="Option three is disabled" Enabled="false" /&gt;
&lt;/twt:RadioButtonList&gt;</code></pre></figure>

  <h4>Inline checkboxes</h4>
  <p>Set <code>Inline="true"</code> on <code>&lt;twt:CheckBox&gt;</code> for controls that appear on the same line.</p>
  <div class="bs-example">
    <twt:CheckBox runat="server" Text="1" Inline="true" />
    <twt:CheckBox runat="server" Text="2" Inline="true" />
    <twt:CheckBox runat="server" Text="3" Inline="true" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:CheckBox runat="server" Text="1" Inline="true" /&gt;
&lt;twt:CheckBox runat="server" Text="2" Inline="true" /&gt;
&lt;twt:CheckBox runat="server" Text="3" Inline="true" /&gt;</code></pre></figure>

  <h4>RadioButtonList/CheckBoxList layout</h4>
  <p>
    The <code>RepeatColumns</code> property is implemented using Bootstrap grids and therefore must be a factor of 12 (1, 2, 3, 4, 6, or 12). 
    The <code>RepeatDirection</code> property determines the order as shown below.
    The <code>MinimumColumnsBreakpoint</code> property determines if/when the columns become a list on smaller breakpoints.
  </p>
  <div class="bs-example">
    <asp:UpdatePanel runat="server">
      <ContentTemplate>
        <twt:RadioButtonList runat="server" ID="RadioButtonList2" RepeatColumns="6" RepeatDirection="Horizontal" AutoPostBack="true" 
          MinimumColumnsBreakpoint="Medium" Legend="More Options" ShowLegend="false" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged">
          <asp:ListItem Value="option1" Text="Option one" />
          <asp:ListItem Value="option2" Text="Option two" />
          <asp:ListItem Value="option3" Text="Option three" />
          <asp:ListItem Value="option4" Text="Option four" />
          <asp:ListItem Value="option5" Text="Option five" />
          <asp:ListItem Value="option6" Text="Option six" />
          <asp:ListItem Value="option7" Text="Option seven" />
          <asp:ListItem Value="option8" Text="Option eight" />
          <asp:ListItem Value="option9" Text="Option nine" />
        </twt:RadioButtonList>
        <twt:Alert ID="RadioButtonList2_Alert" AlertType="Info" runat="server" Visible="false">
          <Content>
            <asp:Literal ID="RadioButtonList2_Literal" runat="server" />
          </Content>
        </twt:Alert>
      </ContentTemplate>
    </asp:UpdatePanel>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:RadioButtonList runat="server" ID="RadioButtonList2" RepeatColumns="6" RepeatDirection="Horizontal" AutoPostBack="true" 
    MinimumColumnsBreakpoint="Medium" Legend="More Options" ShowLegend="false" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged"&gt;
  &lt;asp:ListItem Value="option1" Text="Option one" /&gt;
  &lt;asp:ListItem Value="option2" Text="Option two" /&gt;
  &lt;asp:ListItem Value="option3" Text="Option three" /&gt;
  &lt;asp:ListItem Value="option4" Text="Option four" /&gt;
  &lt;asp:ListItem Value="option5" Text="Option five" /&gt;
  &lt;asp:ListItem Value="option6" Text="Option six" /&gt;
  &lt;asp:ListItem Value="option7" Text="Option seven" /&gt;
  &lt;asp:ListItem Value="option8" Text="Option eight" /&gt;
  &lt;asp:ListItem Value="option9" Text="Option nine" /&gt;
&lt;/twt:RadioButtonList&gt;</code></pre></figure>
  <div class="bs-example">
    <asp:UpdatePanel runat="server">
      <ContentTemplate>
        <twt:CheckBoxList runat="server" ID="CheckBoxList3" RepeatColumns="2" RepeatDirection="Vertical" 
          MinimumColumnsBreakpoint="ExtraSmall" Legend="Even More Options" 
          AutoPostBack="true" OnSelectedIndexChanged="CheckBoxList3_SelectedIndexChanged">
          <asp:ListItem Value="option1" Text="Option one" />
          <asp:ListItem Value="option2" Text="Option two" />
          <asp:ListItem Value="option3" Text="Option three" />
          <asp:ListItem Value="option4" Text="Option four" />
          <asp:ListItem Value="option5" Text="Option five" />
          <asp:ListItem Value="option6" Text="Option six" />
          <asp:ListItem Value="option7" Text="Option seven" />
          <asp:ListItem Value="option8" Text="Option eight" />
          <asp:ListItem Value="option9" Text="Option nine" />
        </twt:CheckBoxList>
        <twt:Alert ID="CheckBoxList3_Alert" AlertType="Info" runat="server" Visible="false">
          <Content>
            <asp:Literal ID="CheckBoxList3_Literal" runat="server" />
          </Content>
        </twt:Alert>
      </ContentTemplate>
    </asp:UpdatePanel>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:CheckBoxList runat="server" ID="CheckBoxList2" RepeatColumns="2" RepeatDirection="Vertical" 
    MinimumColumnsBreakpoint="ExtraSmall" Legend="Even More Options"
    AutoPostBack="true" OnSelectedIndexChanged="CheckBoxList3_SelectedIndexChanged"&gt;
  &lt;asp:ListItem Value="option1" Text="Option one" /&gt;
  &lt;asp:ListItem Value="option2" Text="Option two" /&gt;
  &lt;asp:ListItem Value="option3" Text="Option three" /&gt;
  &lt;asp:ListItem Value="option4" Text="Option four" /&gt;
  &lt;asp:ListItem Value="option5" Text="Option five" /&gt;
  &lt;asp:ListItem Value="option6" Text="Option six" /&gt;
  &lt;asp:ListItem Value="option7" Text="Option seven" /&gt;
  &lt;asp:ListItem Value="option8" Text="Option eight" /&gt;
  &lt;asp:ListItem Value="option9" Text="Option nine" /&gt;
&lt;/twt:CheckBoxList&gt;</code></pre></figure>

  <h3><a href="https://getbootstrap.com/docs/3.3/css/#selects" target="_blank">Selects</a></h3>
  <p>Note that many native select menus—namely in Safari and Chrome—have rounded corners that cannot be modified via <code>border-radius</code> properties.</p>
  <div class="bs-example">
    <twt:FormGroup runat="server" LabelVisible="false" LabelText="Selects">
      <twt:DropDownList runat="server">
        <asp:ListItem Value="1" />
        <asp:ListItem Value="2" />
        <asp:ListItem Value="3" />
        <asp:ListItem Value="4" />
        <asp:ListItem Value="5" />
      </twt:DropDownList>
    </twt:FormGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:FormGroup runat="server" LabelVisible="false" LabelText="Selects"&gt;
  &lt;twt:DropDownList runat="server"&gt;
    &lt;asp:ListItem Value="1" /&gt;
    &lt;asp:ListItem Value="2" /&gt;
    &lt;asp:ListItem Value="3" /&gt;
    &lt;asp:ListItem Value="4" /&gt;
    &lt;asp:ListItem Value="5" /&gt;
  &lt;/twt:DropDownList&gt;
&lt;/twt:FormGroup&gt;</code></pre></figure>
  <p>For <code>&lt;twt:FormGroup&gt;</code> controls with <code>SelectionMode="Multiple"</code>, multiple options are shown by default.</p>
  <div class="bs-example">
    <twt:FormGroup runat="server" LabelVisible="false" LabelText="Multiple Select">
      <twt:ListBox runat="server" SelectionMode="Multiple">
        <asp:ListItem Value="1" />
        <asp:ListItem Value="2" />
        <asp:ListItem Value="3" />
        <asp:ListItem Value="4" />
        <asp:ListItem Value="5" />
      </twt:ListBox>
    </twt:FormGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:FormGroup runat="server" LabelVisible="false" LabelText="Multiple Select"&gt;
  &lt;twt:ListBox runat="server" SelectionMode="Multiple"&gt;
    &lt;asp:ListItem Value="1" /&gt;
    &lt;asp:ListItem Value="2" /&gt;
    &lt;asp:ListItem Value="3" /&gt;
    &lt;asp:ListItem Value="4" /&gt;
    &lt;asp:ListItem Value="5" /&gt;
  &lt;/twt:ListBox&gt;
&lt;/twt:FormGroup&gt;</code></pre></figure>
</section>



<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#input-groups-basic" target="_blank">Input group</a></h2>
  <p>
    <strong>NOTE:</strong> The Prefix and Suffix properties will be hidden from screen readers. 
    A descriptive label should be provided as shown below.
  </p>
  <div class="bs-example">
    <twt:InputGroup runat="server"
      Prefix="$"
      Suffix=".00"
    >
      <asp:Label runat="server" CssClass="sr-only" AssociatedControlID="amount">Amount (in dollars)</asp:Label>
      <twt:TextBox runat="server" PlaceholderText="Amount" ID="amount" />
    </twt:InputGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:InputGroup runat="server"
  Prefix="$"
  Suffix=".00"
&gt;
  &lt;asp:Label runat="server" CssClass="sr-only" AssociatedControlID="amount"&gt;Amount (in dollars)&lt;/asp:Label&gt;
  &lt;twt:TextBox runat="server" PlaceholderText="Amount" ID="amount" /&gt;
&lt;/twt:InputGroup&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/css/#forms-disabled-fieldsets" target="_blank">Disabled Fieldsets</a></h2>
  <p>Add <code>Enabled="false"</code> to a <code>&lt;twt:FieldSet&gt;</code> to disable all the controls within it at once.</p>
  <div class="bs-example">
    <twt:FieldSet runat="server" Enabled="false" Legend="Disabled inputs">
      <Content>
        <div class="form-group">
          <asp:Label runat="server" AssociatedControlID="disabledTextInput">Disabled input</asp:Label>
          <twt:TextBox id="disabledTextInput" PlaceholderText="Disabled input" runat="server" />
        </div>
        <div class="form-group">
          <asp:Label runat="server" AssociatedControlID="disabledSelect">Disabled select menu</asp:Label>
          <asp:DropDownList id="disabledSelect" runat="server">
            <asp:ListItem Text="Disabled select" />
          </asp:DropDownList>
        </div>
        <twt:CheckBox runat="server" text="Can't check this" />
        <twt:Button runat="server" Text="Submit" />
      </Content>
    </twt:FieldSet>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:FieldSet runat="server" Enabled="false" Legend="Disabled inputs"&gt;
  &lt;Content&gt;
    &lt;div class="form-group"&gt;
      &lt;asp:Label runat="server" AssociatedControlID="disabledTextInput"&gt;Disabled input&lt;/asp:Label&gt;
      &lt;twt:TextBox id="disabledTextInput" PlaceholderText="Disabled input" runat="server" /&gt;
    &lt;/div&gt;
    &lt;div class="form-group"&gt;
      &lt;asp:Label runat="server" AssociatedControlID="disabledTextInput"&gt;Disabled select menu&lt;/asp:Label&gt;
      &lt;asp:DropDownList id="disabledSelect" runat="server"&gt;
        &lt;asp:ListItem Text="Disabled select" /&gt;
      &lt;/asp:DropDownList&gt;
    &lt;/div&gt;
    &lt;twt:CheckBox runat="server" text="Can't check this" /&gt;
    &lt;twt:Button runat="server" Text="Submit" /&gt;
  &lt;/Content&gt;
&lt;/twt:FieldSet&gt;</code></pre></figure>
</section>

<h2><a href="https://getbootstrap.com/docs/3.3/css/#forms-control-sizes" target="_blank">Control sizing</a></h2>
<section>
  <h3>Height Sizing</h3>
  <p>Create taller or shorter form controls that match button sizes by using the <code>InputSize</code> property.</p>
  <div class="bs-example">
    <twt:FormGroup runat="server" LabelVisible="false" LabelText="Large input">
      <twt:TextBox runat="server" InputSize="Large" PlaceholderText=".input-lg" />
    </twt:FormGroup>
    <twt:FormGroup runat="server" LabelVisible="false" LabelText="Default input">
      <twt:TextBox runat="server" InputSize="Default" PlaceholderText="Default input" />
    </twt:FormGroup>
    <twt:FormGroup runat="server" LabelVisible="false" LabelText="Small input">
      <twt:TextBox runat="server" InputSize="Small" PlaceholderText=".input-sm" />
    </twt:FormGroup>
    <twt:FormGroup runat="server" LabelVisible="false" LabelText="Large select">
      <twt:DropDownList runat="server" InputSize="Large">
        <asp:ListItem Value=".input-lg" />
      </twt:DropDownList>
    </twt:FormGroup>
    <twt:FormGroup runat="server" LabelVisible="false" LabelText="Default select">
      <twt:DropDownList runat="server" InputSize="Default">
        <asp:ListItem Value="Default input" />
      </twt:DropDownList>
    </twt:FormGroup>
    <twt:FormGroup runat="server" LabelVisible="false" LabelText="Small select">
      <twt:DropDownList runat="server" InputSize="Small">
        <asp:ListItem Value=".input-sm" />
      </twt:DropDownList>
    </twt:FormGroup>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:FormGroup runat="server" LabelVisible="false" LabelText="Large input"&gt;
  &lt;twt:TextBox runat="server" InputSize="Large" PlaceholderText=".input-lg" /&gt;
&lt;/twt:FormGroup&gt;
&lt;twt:FormGroup runat="server" LabelVisible="false" LabelText="Default input"&gt;
  &lt;twt:TextBox runat="server" InputSize="Default" PlaceholderText="Default input" /&gt;
&lt;/twt:FormGroup&gt;
&lt;twt:FormGroup runat="server" LabelVisible="false" LabelText="Small input"&gt;
  &lt;twt:TextBox runat="server" InputSize="Small" PlaceholderText=".input-sm" /&gt;
&lt;/twt:FormGroup&gt;
&lt;twt:FormGroup runat="server" LabelVisible="false" LabelText="Large select"&gt;
  &lt;twt:DropDownList runat="server" InputSize="Large"&gt;
    &lt;asp:ListItem Value=".input-lg" /&gt;
  &lt;/twt:DropDownList&gt;
&lt;/twt:FormGroup&gt;
&lt;twt:FormGroup runat="server" LabelVisible="false" LabelText="Default select"&gt;
  &lt;twt:DropDownList runat="server" InputSize="Default"&gt;
    &lt;asp:ListItem Value="Default input" /&gt;
  &lt;/twt:DropDownList&gt;
&lt;/twt:FormGroup&gt;
&lt;twt:FormGroup runat="server" LabelVisible="false" LabelText="Small select"&gt;
  &lt;twt:DropDownList runat="server" InputSize="Small"&gt;
    &lt;asp:ListItem Value=".input-sm" /&gt;
  &lt;/twt:DropDownList&gt;
&lt;/twt:FormGroup&gt;</code></pre></figure>
</section>

<section>
  <h3>Horizontal form group sizes</h3>
  <p>Quickly size labels and form controls within a <code>&lt;twt:FormGroup&gt;</code> by adding <code>InputSize="Large"</code> or <code>InputSize="Small"</code>.</p>
  <div class="bs-example">
    <div class="form-horizontal">
      <twt:FormGroup runat="server" InputSize="Large" LabelText="Large label" LabelClass="col-sm-2" ControlClass="col-sm-10">
        <twt:TextBox runat="server" PlaceholderText="Large input" />
      </twt:FormGroup>
      <twt:FormGroup runat="server" InputSize="Small" LabelText="Small label" LabelClass="col-sm-2" ControlClass="col-sm-10">
        <twt:TextBox runat="server" PlaceholderText="Small input" />
      </twt:FormGroup>
    </div>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;div class="form-horizontal"&gt;
  &lt;twt:FormGroup runat="server" InputSize="Large" LabelText="Large label" LabelClass="col-sm-2" ControlClass="col-sm-10"&gt;
    &lt;twt:TextBox runat="server" PlaceholderText="Large input" /&gt;
  &lt;/twt:FormGroup&gt;
  &lt;twt:FormGroup runat="server" InputSize="Small" LabelText="Small label" LabelClass="col-sm-2" ControlClass="col-sm-10"&gt;
    &lt;twt:TextBox runat="server" PlaceholderText="Small input" /&gt;
  &lt;/twt:FormGroup&gt;
&lt;/div&gt;</code></pre></figure>
</section>

</asp:Content>

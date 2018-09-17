<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Tooltips" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<p>Inspired by the excellent jQuery.tipsy plugin written by Jason Frame; Tooltips are an updated version, which don't rely on images, use CSS3 for animations, and data-attributes for local title storage.</p>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/javascript/#four-directions" target="_blank">Four directions</a></h2>
  <div class="bs-example tooltip-demo">
    <twt:ToolTip runat="server" Title="Tooltip on the left" Placement="Left">
      <twt:Button runat="server" text="Tooltip on left" />
    </twt:ToolTip>
    <twt:ToolTip runat="server" Title="Tooltip on the top" Placement="Top">
      <twt:Button runat="server" text="Tooltip on top" />
    </twt:ToolTip>
    <twt:ToolTip runat="server" Title="Tooltip on the bottom" Placement="Bottom">
      <twt:Button runat="server" text="Tooltip on bottom" />
    </twt:ToolTip>
    <twt:ToolTip runat="server" Title="Tooltip on the right" Placement="Right">
      <twt:Button runat="server" text="Tooltip on right" />
    </twt:ToolTip>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ToolTip runat="server" Title="Tooltip on the left" Placement="Left"&gt;
  &lt;twt:Button runat="server" text="Tooltip on left" /&gt;
&lt;/twt:ToolTip&gt;
&lt;twt:ToolTip runat="server" Title="Tooltip on the top" Placement="Top"&gt;
  &lt;twt:Button runat="server" text="Tooltip on top" /&gt;
&lt;/twt:ToolTip&gt;
&lt;twt:ToolTip runat="server" Title="Tooltip on the bottom" Placement="Bottom"&gt;
  &lt;twt:Button runat="server" text="Tooltip on bottom" /&gt;
&lt;/twt:ToolTip&gt;
&lt;twt:ToolTip runat="server" Title="Tooltip on the right" Placement="Right"&gt;
  &lt;twt:Button runat="server" text="Tooltip on right" /&gt;
&lt;/twt:ToolTip&gt;</code></pre></figure>
</section>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/javascript/#tooltips-options" target="_blank">Options</a></h2>
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
          <td>Animate</td>
          <td>bool</td>
          <td>true</td>
          <td>Apply a CSS fade transition to the tooltip</td>
        </tr>
        <tr>
          <td>ContainerSelector</td>
          <td>string</td>
          <td>[blank]</td>
          <td>Appends the tooltip to a specific element. Example: <code>ContainerSelector="body"</code>. This option is particularly useful in that it allows you to position the tooltip in the flow of the document near the triggering element - which will prevent the tooltip from floating away from the triggering element during a window resize.</td>
        </tr>
        <tr>
          <td>delay</td>
          <td>int</td>
          <td>0</td>
          <td>Delay showing and hiding the tooltip (ms) - does not apply to manual trigger type.</td>
        </tr>
        <tr>
          <td>IsHtml</td>
          <td>bool</td>
          <td>false</td>
          <td>Insert HTML into the tooltip. If false, jQuery's <code>text</code>method will be used to insert content into the DOM. Use text if you're worried about XSS attacks.</td>
        </tr>
        <tr>
          <td>Placement</td>
          <td>PopoverPositions enum</td>
          <td>Top</td>
          <td>
            <p>How to position the tooltip - <code>Top</code> | <code>Bottom</code> | <code>Left</code> | <code>Right</code> | <code>Auto</code>.</p>
            <p>When "Auto" is specified, it will dynamically reorient the tooltip. For example, if <code>Placement="Auto,Left"</code>, the tooltip will display to the left when possible, otherwise it will display right.</p>
          </td>
        </tr>
        <tr>
          <td>Title</td>
          <td>string</td>
          <td>[blank]</td>
          <td>Text to display in tooltip.</td>
        </tr>
        <tr>
          <td>Trigger</td>
          <td>Triggers enum</td>
          <td>Hover,Focus</td>
          <td>How tooltip is triggered - <code>Click</code> | <code>Hover</code> | <code>Focus</code> | <code>Manual</code>. You may pass multiple triggers; separate them with a comma. <code>Manual</code>cannot be combined with any other trigger.</td>
        </tr>
        <tr>
          <td>ViewportSelector</td>
          <td>string</td>
          <td>body</td>
          <td>Keeps the tooltip within the bounds of this element.</td>
        </tr>
        <tr>
          <td>ViewportPadding</td>
          <td>int</td>
          <td>0</td>
          <td>Padding around the tooltip within the bounds of <code>ViewPortSelector</code>.</td>
        </tr>
      </tbody>
    </table>
  </div>
</section>
</asp:Content>

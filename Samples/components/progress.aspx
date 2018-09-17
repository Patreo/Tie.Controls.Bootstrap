<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" Title="Progress Bars" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<p class="lead">Provide up-to-date feedback on the progress of a workflow or action with simple yet flexible progress bars.</p>
<div class="bs-callout bs-callout-danger" id="callout-progress-animation-css3"> <h2 class="h4">Cross-browser compatibility</h2> <p>Progress bars use CSS3 transitions and animations to achieve some of their effects. These features are not supported in Internet Explorer 9 and below or older versions of Firefox. Opera 12 does not support animations.</p> </div>
<div class="bs-callout bs-callout-info"> <h2 class="h4" id="callout-progress-csp">Content Security Policy (CSP) compatibility</h2> <p>If your website has a <a href="https://developer.mozilla.org/en-US/docs/Web/Security/CSP" target="_blank">Content Security Policy (CSP)</a> which doesn't allow <code>style-src 'unsafe-inline'</code>, then you won't be able to use inline <code>style</code> attributes to set progress bar widths as shown in our examples below. Alternative methods for setting the widths that are compatible with strict CSPs include using a little custom JavaScript (that sets <code>element.style.width</code>) or using custom CSS classes.</p> </div>
<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#progress-basic" target="_blank">Basic example</a></h2>
  <p>Default progress bar.</p>
  <div class="bs-example">
    <twt:ProgressBar runat="server" 
      Value="60" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ProgressBar runat="server" 
  Value="60" /&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#progress-label" target="_blank">With label</a></h2>
  <p>Set <code>ShowLabel="true"</code> to show a visible percentage.</p>
  <div class="bs-example">
    <twt:ProgressBar runat="server" 
      Value="60" 
      ShowLabel="true" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ProgressBar runat="server" 
  Value="60" 
  ShowLabel="true" /&gt;</code></pre></figure>
  <p>To ensure that the label text remains legible even for low percentages, a <code>min-width</code> style is added to the progress bar.</p>
  <div class="bs-example">
    <twt:ProgressBar runat="server" 
      Value="0" 
      ShowLabel="true" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ProgressBar runat="server" 
  Value="0" 
  ShowLabel="true" /&gt;</code></pre></figure>

  <p>The <code>LabelFormat</code> and <code>CaptionFormat</code> properties can be used to update the visible and screen-reader text, respectively, using the following placeholders:</p>
  <ul>
    <li>{0} is Percentage</li>
    <li>{1} is Value</li>
    <li>{2} is MaxValue</li>
    <li>{3} is MinValue</li>
  </ul>
  <p>The <code>LabelMinWidth</code> property can be used to adjust the minimum width of the progress bar.</p>
  <div class="bs-example">
    <twt:ProgressBar runat="server" 
      Value="83" 
      MaxValue="300" 
      ShowLabel="true" 
      LabelFormat="{1} of {2}" 
      CaptionFormat="{1} of {2} complete" 
      LabelMinWidth="4.5em" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ProgressBar runat="server" 
  Value="83" 
  MaxValue="300" 
  ShowLabel="true" 
  LabelFormat="{1} of {2}" 
  CaptionFormat="{1} of {2} complete" 
  LabelMinWidth="4.5em" /&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#progress-alternatives" target="_blank">Contextual alternatives</a></h2>
  <p>Progress bars use the <code>ProgressBarStyle</code> property for contextual alternatives.</p>
  <div class="bs-example">
    <twt:ProgressBar runat="server" 
      Value="40" 
      ShowLabel="true" 
      ProgressBarStyle="success" />
    <twt:ProgressBar runat="server" 
      Value="20" 
      ShowLabel="true" 
      ProgressBarStyle="info" />
    <twt:ProgressBar runat="server" 
      Value="60" 
      ShowLabel="true" 
      ProgressBarStyle="warning" />
    <twt:ProgressBar runat="server" 
      Value="80" 
      ShowLabel="true" 
      ProgressBarStyle="danger" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ProgressBar runat="server" 
  Value="40" 
  ShowLabel="true" 
  ProgressBarStyle="success" /&gt;
&lt;twt:ProgressBar runat="server" 
  Value="20" 
  ShowLabel="true" 
  ProgressBarStyle="info" /&gt;
&lt;twt:ProgressBar runat="server"
  Value="60" 
  ShowLabel="true" 
  ProgressBarStyle="warning" /&gt;
&lt;twt:ProgressBar runat="server" 
  Value="80" 
  ShowLabel="true" 
  ProgressBarStyle="danger" /&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#progress-striped" target="_blank">Striped</a></h2>
  <p>Add a gradient to create a striped effect with <code>Striped="true"</code>. Not available in IE9 and below.</p>
  <div class="bs-example">
    <twt:ProgressBar runat="server" 
      Value="40" 
      Striped="true" 
      ProgressBarStyle="success" />
    <twt:ProgressBar runat="server" 
      Value="20" 
      Striped="true" 
      ProgressBarStyle="info" />
    <twt:ProgressBar runat="server" 
      Value="60" 
      Striped="true" 
      ProgressBarStyle="warning" />
    <twt:ProgressBar runat="server" 
      Value="80" 
      Striped="true" 
      ProgressBarStyle="danger" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ProgressBar runat="server" 
  Value="40" Striped="true" 
  ProgressBarStyle="success" /&gt;
&lt;twt:ProgressBar runat="server" 
  Value="20" 
  Striped="true" 
  ProgressBarStyle="info" /&gt;
&lt;twt:ProgressBar runat="server" 
  Value="60" 
  Striped="true" 
  ProgressBarStyle="warning" /&gt;
&lt;twt:ProgressBar runat="server" 
  Value="80" 
  Striped="true" 
  ProgressBarStyle="danger" /&gt;</code></pre></figure>

  <h2><a href="https://getbootstrap.com/docs/3.3/components/#progress-animated" target="_blank">Animated</a></h2>
  <p>Add <code>Animated="true"</code> and <code>Striped="true"</code> to animate the stripes right to left. Not available in IE9 and below.</p>
  <div class="bs-example">
    <twt:ProgressBar runat="server" 
      Value="45" 
      Striped="true" 
      Animated="true" />
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:ProgressBar runat="server" 
  Value="45" 
  Striped="true" 
  Animated="true" /&gt;</code></pre></figure>
</section>

<section>
  <h2><a href="https://getbootstrap.com/docs/3.3/components/#progress-stacked" target="_blank">Stacked</a></h2>
  <p>Place multiple <code>&lt;twt:ProgressBar&gt;</code>s into a <code>&lt;twt:StackedProgressBars&gt;</code> to stack them.</p>
  <div class="bs-example">
    <twt:StackedProgressBars runat="server">
      <twt:ProgressBar runat="server"
        Value="35"
        ProgressBarStyle="Success" />
      <twt:ProgressBar runat="server"
        Value="20"
          Striped="true"
        ProgressBarStyle="Warning" />
      <twt:ProgressBar runat="server"
        Value="10"
        ProgressBarStyle="Danger" />
    </twt:StackedProgressBars>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:StackedProgressBars runat="server"&gt;
  &lt;twt:ProgressBar runat="server"
    Value="35"
    ProgressBarStyle="Success" /&gt;
  &lt;twt:ProgressBar runat="server"
    Value="20"
    Striped="true"
    ProgressBarStyle="Warning" /&gt;
  &lt;twt:ProgressBar runat="server"
    Value="10"
    ProgressBarStyle="Danger" /&gt;
&lt;/twt:StackedProgressBars&gt;</code></pre></figure>
</section>
</asp:Content>

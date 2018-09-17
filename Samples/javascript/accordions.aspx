<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Accordions" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    
  <h2><a href="https://paypal.github.io/bootstrap-accessibility-plugin/demo.html#collapse" target="_blank">Basic example</a></h2>
  <p>
    Use the <code>&lt;twt:AccordionControl&gt;</code> to create groups of collapsable panes. 
    Set a contextual style on all panes by setting <code>DefaultPanelType</code>.
    The <code>HeaderTagType</code> property sets the tag used for the title of each <code>&lt;twt:AccordionPane&gt;</code>. 
  </p>
  <div class="bs-example">
    <twt:AccordionControl runat="server" ID="accordion" ClientIDMode="Static" DefaultPanelType="Info" HeaderTagType="h3">
      <Panes>
        <twt:AccordionPane Expanded="true" ID="collapseOne" ClientIDMode="Static">
          <Header>
            Collapsible Group Item #1
          </Header>
          <Content>
            Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
          </Content>
        </twt:AccordionPane>
        <twt:AccordionPane ID="collapseTwo" ClientIDMode="Static">
          <Header>
            Collapsible Group Item #2
          </Header>
          <Content>
            Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
          </Content>
        </twt:AccordionPane>
        <twt:AccordionPane ID="collapseThree" ClientIDMode="Static">
          <Header>
            Collapsible Group Item #3
          </Header>
          <Content>
            Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
          </Content>
        </twt:AccordionPane>
      </Panes>
    </twt:AccordionControl>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:AccordionControl runat="server" ID="accordion" ClientIDMode="Static" DefaultPanelType="Info"&gt;
  &lt;Panes&gt;
    &lt;twt:AccordionPane Expanded="true" ID="collapseOne" ClientIDMode="Static"&gt;
      &lt;Header&gt;
        Collapsible Group Item #1
      &lt;/Header&gt;
      &lt;Content&gt;
        Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
      &lt;/Content&gt;
    &lt;/twt:AccordionPane&gt;
    &lt;twt:AccordionPane ID="collapseTwo" ClientIDMode="Static"&gt;
      &lt;Header&gt;
        Collapsible Group Item #2
      &lt;/Header&gt;
      &lt;Content&gt;
        Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
      &lt;/Content&gt;
    &lt;/twt:AccordionPane&gt;
    &lt;twt:AccordionPane ID="collapseThree" ClientIDMode="Static"&gt;
      &lt;Header&gt;
        Collapsible Group Item #3
      &lt;/Header&gt;
      &lt;Content&gt;
        Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
      &lt;/Content&gt;
    &lt;/twt:AccordionPane&gt;
  &lt;/Panes&gt;
&lt;/twt:AccordionControl&gt;</code></pre></figure>
  <h2>Header Level 3, MultiSelectable, with Styles</h2>
  <p>
    Set <code>MultiSelectable="true"</code> on the <code>&lt;twt:AccordionControl&gt;</code> to allow multiple <code>&lt;twt:AccordionPane&gt;</code>s to be expanded at once.
    The <code>PanelType</code> property can be used to set each <code>&lt;twt:AccordionPane&gt;</code>'s contextual style, overriding the parent's <code>DefaultPanelType</code>.
  </p>
  <div class="bs-example">
    <twt:AccordionControl runat="server" HeaderTagType="h3" MultiSelectable="true">
      <Panes>
        <twt:AccordionPane Expanded="true" PanelType="Primary">
          <Header>
            Collapsible Group Item #1
          </Header>
          <Content>
            Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
          </Content>
        </twt:AccordionPane>
        <twt:AccordionPane PanelType="Info">
          <Header>
            Collapsible Group Item #2
          </Header>
          <Content>
            Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
          </Content>
        </twt:AccordionPane>
        <twt:AccordionPane PanelType="Danger">
          <Header>
            Collapsible Group Item #3
          </Header>
          <Content>
            Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
          </Content>
        </twt:AccordionPane>
      </Panes>
    </twt:AccordionControl>
  </div>
  <figure class="highlight"><pre><code class="language-asp-net" data-lang="asp-net">&lt;twt:AccordionControl runat="server" HeaderTagType="h3" MultiSelectable="true"&gt;
  &lt;Panes&gt;
    &lt;twt:AccordionPane Expanded="true" PanelType="Primary"&gt;
      &lt;Header&gt;
        Collapsible Group Item #1
      &lt;/Header&gt;
      &lt;Content&gt;
        Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
      &lt;/Content&gt;
    &lt;/twt:AccordionPane&gt;
    &lt;twt:AccordionPane PanelType="Info"&gt;
      &lt;Header&gt;
        Collapsible Group Item #2
      &lt;/Header&gt;
      &lt;Content&gt;
        Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
      &lt;/Content&gt;
    &lt;/twt:AccordionPane&gt;
    &lt;twt:AccordionPane PanelType="Danger"&gt;
      &lt;Header&gt;
        Collapsible Group Item #3
      &lt;/Header&gt;
      &lt;Content&gt;
        Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon tempor, sunt aliqua put a bird on it squid single-origin coffee nulla assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic synth nesciunt you probably haven't heard of them accusamus labore sustainable VHS.
      &lt;/Content&gt;
    &lt;/twt:AccordionPane&gt;
  &lt;/Panes&gt;
&lt;/twt:AccordionControl&gt;</code></pre></figure>


</asp:Content>

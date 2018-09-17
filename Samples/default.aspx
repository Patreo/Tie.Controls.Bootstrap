<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Bootstrap Controls" %>
<%@ Register Src="~/components/ComponentsContents.ascx" TagPrefix="demo" TagName="ComponentsContents" %>
<%@ Register Src="~/css/CssContents.ascx" TagPrefix="demo" TagName="CssContents" %>
<%@ Register Src="~/javascript/JavaScriptContents.ascx" TagPrefix="demo" TagName="JavaScriptContents" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<ul class="list-unstyled">
  <li>
    <h2><a href="configuration.aspx">Configuration</a></h2>
  </li>
  <li>
    <h2><a href="css/">CSS</a></h2>
    <demo:CssContents runat="server" />
  </li>
  <li>
    <h2><a href="components/">Components</a></h2>
    <demo:ComponentsContents runat="server" />
  </li>
  <li>
    <h2><a href="javascript/">JavaScript</a></h2>
    <demo:JavaScriptContents runat="server" />
  </li>
</ul>
  
</asp:Content>

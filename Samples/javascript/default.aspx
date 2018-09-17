<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Javascript" %>
<%@ Register Src="~/javascript/JavaScriptContents.ascx" TagPrefix="demo" TagName="JavaScriptContents" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <demo:JavaScriptContents runat="server" />
</asp:Content>

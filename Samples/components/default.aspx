<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" 
  Title="Components" %>
<%@ Register Src="~/components/ComponentsContents.ascx" TagPrefix="demo" TagName="ComponentsContents" %>
<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <demo:ComponentsContents runat="server" />
</asp:Content>

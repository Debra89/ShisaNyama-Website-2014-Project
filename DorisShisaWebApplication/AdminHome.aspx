<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="DorisShisaWebApplication.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>Welcome:
     <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </h2>
    <p>Welcome 
     <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    &nbsp; to Doris Shisanyama Control Panel, here you can manage the sites details such as adding, 
        editing &amp; deleting as necessary.</p>
</asp:Content>

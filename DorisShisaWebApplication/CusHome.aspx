<%@ Page Title="" Language="C#" MasterPageFile="~/CusMaster.Master" AutoEventWireup="true" CodeBehind="CusHome.aspx.cs" Inherits="DorisShisaWebApplication.CusHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrap">
       
<div id="main">

    <h2>Welcome: <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </h2>
 
 
    <p>Welcome 
     <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    &nbsp; to Doris shisanyama  here you can make a booking, Order food, manage your personal details and contact us as necessary, 
         &amp;As our valued customer we hope our fast food will always be faster to you!! .</p>
    </div>
            </div>
        
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

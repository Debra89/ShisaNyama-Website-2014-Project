<%@ Page Title="" MaintainScrollPositionOnPostBack="true" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Promotions.aspx.cs" Inherits="DorisShisaWebApplication.Promotions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
 <div class="wrap">
       
<div id="main">
 <h2> Promotions last till 30 October 2013</h2>

 <div>

<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
ConnectionString="<%$ ConnectionStrings:DorisShisaConnectionString3%>"
SelectCommand="SELECT * FROM [Products]">
</asp:SqlDataSource>
</div>

<asp:DataList ID="DataList1" runat="server" 
              DataSourceID="SqlDataSource1" 
              RepeatColumns="3"
              RepeatDirection="Horizontal" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
<ItemTemplate>
<asp:ImageButton ID="ImageButton1" runat="server" 
ImageUrl='<%# Eval("ImageUrl","~/images\\{0}") %>' 
PostBackUrl='<%# Eval("ProductId", 
"ProductDetails.aspx?ProductId={0}") %>' Height="250" Width="250" />
<br /> <br />
<asp:Label ID="NameLabel" runat="server" 
           Text='<%# Eval("Name") %>'>
</asp:Label>
<br /><br />
<asp:Label ID="PriceLabel" runat="server" 
           Text='<%# Eval("Price", "{0:R##0.00}") %>' Font-Size="XX-Large">
</asp:Label><br />

<asp:Button ID="cmdAdd" runat="server" onclick="cmdAdd_Click" 
                        Text="Order" Width="126px" CssClass="Button" />  


    <br />
    <br />

</ItemTemplate>
</asp:DataList><br /><br />
    
      

 </div>
 </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

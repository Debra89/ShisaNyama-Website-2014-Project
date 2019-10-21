<%@ Page Title="" MaintainScrollPositionOnPostBack="true" Language="C#" MasterPageFile="~/CusMaster.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="DorisShisaWebApplication.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrap">
       
<div id="main">
    <h2>Track your order</h2>
    <p>here are all the Orders you have placed with Doris Shisanyama, you allowed to delete as necessary.</p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="OrderID" DataSourceID="SqlDataSource1" Height="159px" Width="743px" AllowPaging="True" AllowSorting="True">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" />
            <asp:BoundField DataField="OrderID" HeaderText="OrderID" ReadOnly="True" SortExpression="OrderID" />
           
            <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
          
            <asp:BoundField DataField="ProductPrice" HeaderText="ProductPrice" SortExpression="ProductPrice" />
            <asp:BoundField DataField="OrderDate" HeaderText="OrderDate" SortExpression="OrderDate" />
            
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DorisShisaConnectionString3 %>" SelectCommand="SELECT [ProductName], [ProductID], [ProductPrice], [OrderDate], [OrderID] FROM [OrderTable] ORDER BY [OrderDate] DESC" DeleteCommand="DELETE FROM [OrderTable] WHERE [OrderID] = @OrderID" InsertCommand="INSERT INTO [OrderTable] ([ProductName], [ProductID], [ProductPrice], [OrderDate], [OrderID]) VALUES (@ProductName, @ProductID, @ProductPrice, @OrderDate, @OrderID)" UpdateCommand="UPDATE [OrderTable] SET [ProductName] = @ProductName, [ProductID] = @ProductID, [ProductPrice] = @ProductPrice, [OrderDate] = @OrderDate WHERE [OrderID] = @OrderID">
        <DeleteParameters>
            <asp:Parameter Name="OrderID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ProductName" Type="String" />
           
            <asp:Parameter Name="ProductPrice" Type="String" />
            <asp:Parameter DbType="Date" Name="OrderDate" />
            <asp:Parameter Name="OrderID" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="ProductName" Type="String" />
            
            <asp:Parameter Name="ProductPrice" Type="String" />
            <asp:Parameter DbType="Date" Name="OrderDate" />
            <asp:Parameter Name="OrderID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>

    <p>***Please note only the products whose date haven&#39;t passed will be considered as your order so you advised to delete those.</p>
    
    </div>
        </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

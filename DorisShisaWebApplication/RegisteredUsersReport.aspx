<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="RegisteredUsersReport.aspx.cs" Inherits="DorisShisaWebApplication.RegisteredUsersReport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class ="content-in">
    <h2>Website registered users report</h2>
   <br /><br />
   <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Email" DataSourceID="SqlDataSource1" Height="422px" Width="724px" ForeColor="#333333" GridLines="None">
       <AlternatingRowStyle BackColor="White" />
       <Columns>
           <asp:BoundField DataField="Email" HeaderText="Email" ReadOnly="True" SortExpression="Email" />
           <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
           <asp:BoundField DataField="Surname" HeaderText="Surname" SortExpression="Surname" />
           <asp:BoundField DataField="Cell" HeaderText="Cell" SortExpression="Cell" />
           <asp:BoundField DataField="RegDate" HeaderText="RegDate" SortExpression="RegDate" />
       </Columns>
       <EditRowStyle BackColor="#2461BF" />
       <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
       <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
       <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
       <RowStyle BackColor="#EFF3FB" />
       <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
       <SortedAscendingCellStyle BackColor="#F5F7FB" />
       <SortedAscendingHeaderStyle BackColor="#6D95E1" />
       <SortedDescendingCellStyle BackColor="#E9EBEF" />
       <SortedDescendingHeaderStyle BackColor="#4870BE" />
         </asp:GridView>

         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$  ConnectionStrings:DorisShisaConnectionString3 %>" SelectCommand="SELECT [Email], [Name], [Surname], [Cell], [RegDate] FROM [WebUsers] ORDER BY [RegDate] DESC"></asp:SqlDataSource>

</div>
</asp:Content>


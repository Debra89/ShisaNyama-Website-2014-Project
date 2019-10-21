<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ReportMostOrderedFood.aspx.cs" Inherits="DorisShisaWebApplication.ReportMostOrderedFood" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

 <div class ="content-in">
    <h2>Most ordered food report</h2>
        <br /><br />



    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


     <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="699px">
         <LocalReport ReportPath="MostOrderedFoodReport.rdlc">
             <DataSources>
                 <rsweb:ReportDataSource DataSourceId="SqlDataSource1" Name="DataSet1" />
             </DataSources>
         </LocalReport>
     </rsweb:ReportViewer>


        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DorisShisaConnectionString3 %>" SelectCommand="SELECT * FROM [FoodReport]"></asp:SqlDataSource>
     <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetData" TypeName="DorisShisaWebApplication.DorisShisaDataSetTableAdapters.FoodReportTableAdapter"></asp:ObjectDataSource>
     <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="DorisShisaWebApplication.DorisShisaDataSetTableAdapters.PageVisitTableTableAdapter"></asp:ObjectDataSource>


        </div>
</asp:Content>

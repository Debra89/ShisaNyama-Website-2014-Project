<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ReportSubscribers.aspx.cs" Inherits="DorisShisaWebApplication.ReportSubscribers" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class ="content-in">
    <h2>Subscriptions Report</h2>
        <br /><br />

<table>
    <tr>
        <td>   <asp:TextBox ID="txtStart" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Start Date"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtEnd" runat="server" TextMode="Date"></asp:TextBox>
        </td>
        <td>
            <asp:Label ID="Label2" runat="server" Text="End Date"></asp:Label>
        </td>
        <td>
            <asp:Button ID="cmdView" runat="server" Text="View Report" OnClick="cmdView_Click" />

           
        </td>
    </tr>
</table>   

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


     <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="707px">
         <LocalReport ReportPath="SubscriptionReport.rdlc">
             <DataSources>
                 <rsweb:ReportDataSource DataSourceId="SqlDataSource1" Name="DataSet1" />
             </DataSources>
         </LocalReport>
        </rsweb:ReportViewer>



        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DorisShisaConnectionString3 %>" SelectCommand="SELECT * FROM [SubscriptionReport] WHERE (([SubscriptionDate] &gt;= @SubscriptionDate) AND ([SubscriptionDate] &lt;= @SubscriptionDate2))">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtStart" DbType="Date" Name="SubscriptionDate" PropertyName="Text" />
                <asp:ControlParameter ControlID="txtEnd" DbType="Date" Name="SubscriptionDate2" PropertyName="Text" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="DorisShisaWebApplication.DorisShisaDataSetTableAdapters.SubscriptionReportTableAdapter"></asp:ObjectDataSource>



        </div>
</asp:Content>

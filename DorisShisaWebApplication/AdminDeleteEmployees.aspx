<%@ Page Title="" MaintainScrollPositionOnPostBack="true" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminDeleteEmployees.aspx.cs" Inherits="DorisShisaWebApplication.AdminDeleteEmployees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

.GridviewDiv {font-size: 100%; font-family: 'Lucida Grande', 'Lucida Sans Unicode', Verdana, Arial, Helevetica, sans-serif; color: #303933;}

Table.Gridview{border:solid 1px #df5015;}
.Gridview th{color:#FFFFFF;border-right-color:#abb079;border-bottom-color:#abb079;padding:0.5em 0.5em 0.5em 0.5em;text-align:center} 

.Gridview td{border-bottom-color:#f0f2da;border-right-color:#f0f2da;padding:0.5em 0.5em 0.5em 0.5em;}

.Gridview tr{color: Black; background-color: White; text-align:left}


.highlight {text-decoration: none;color:black;background:yellow;}

</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="GridviewDiv">
 <div class="content-in">
    <h2>Delete User</h2>
        &nbsp;&nbsp; Please enter Employee Name for the Employee you want to delete.&nbsp;&nbsp;<br />
        <br />
 
 <asp:Panel ID="Panel1" runat="server">
            <br />
            Search
            <asp:TextBox ID="txtSearch" runat="server" CssClass="TextinputNum" 
                Width="197px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cmdSearch" runat="server" Text="Search.." Width="127px" 
                CssClass="Button" onclick="cmdSearch_Click" />
            &nbsp;
            <asp:Button ID="cmdClear" runat="server" onclick="cmdClear_Click" 
                Text="Clear Search" Width="107px" />
        </asp:Panel>
        <br />
        <br />
        <p>
            <asp:Label ID="lblStatus" runat="server" Text="" style="color: Green"></asp:Label></p>
        <asp:Panel ID="Panel2" runat="server" ScrollBars="Auto">
            <asp:GridView ID="gvDetails" runat="server" AutoGenerateColumns="False" AllowPaging="True"

AllowSorting="True" DataSourceID="dsDetails" Width="540px" CssClass="Gridview" 
        BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" CellSpacing="2" DataKeyNames="Email" >

    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />

<HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />

<Columns>



    <asp:TemplateField HeaderText="Surname">

<ItemTemplate>

<asp:Label ID="lblsurname" Text='<%# Eval("Surname") %>' runat="server"/>

</ItemTemplate>

</asp:TemplateField>



<asp:TemplateField HeaderText="Name">

<ItemTemplate>

<asp:Label ID="lblName" Text='<%# HighlightText(Eval("Name").ToString()) %>' runat="server"/>

</ItemTemplate>

</asp:TemplateField>

<asp:TemplateField HeaderText="Email">

<ItemTemplate>

<asp:Label ID="lblEmail" Text='<%#Eval("Email") %>' runat="server"></asp:Label>

</ItemTemplate>

</asp:TemplateField>
<asp:TemplateField HeaderText="Cell number">

<ItemTemplate>

<asp:Label ID="lblCell" Text='<%# Eval("cell") %>' runat="server"></asp:Label>

</ItemTemplate>

</asp:TemplateField>

<asp:TemplateField HeaderText="UserLevel">

<ItemTemplate>

<asp:Label ID="lblUserLevel" Text='<%# Eval("UserLevel") %>' runat="server"></asp:Label>

</ItemTemplate>
</asp:TemplateField>

 <asp:TemplateField HeaderText="Delete" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">

                                                <ItemTemplate>

                                                    <asp:ImageButton ID="imgBtn" runat="server" CausesValidation="false" CommandArgument='<%#Eval("Email") %>'

                                                        OnCommand="imgDel_Command" ImageUrl="~/images/delete.jpg"

                                                         ToolTip="Delete" OnClientClick="return confirm('Are you sure you want to delete?')"   Height="30" Width="30" />

                                                </ItemTemplate>                                              

                                             <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                                          <ItemStyle HorizontalAlign="Center"></ItemStyle>

                                            </asp:TemplateField>





</Columns>

    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#FFF1D4" />
    <SortedAscendingHeaderStyle BackColor="#B95C30" />
    <SortedDescendingCellStyle BackColor="#F1E5CE" />
    <SortedDescendingHeaderStyle BackColor="#93451F" />

</asp:GridView>

   
</asp:Panel>
        
       <asp:SqlDataSource ID="dsDetails" runat="server" 
    ConnectionString="<%$  ConnectionStrings:DorisShisaConnectionString3 %>" 
    SelectCommand="SELECT Name, Surname, Email, Cell, UserLevel FROM WebUsers WHERE (UserLevel = 2)" 
    FilterExpression="Name LIKE '%{0}%'">
    
<FilterParameters>

<asp:ControlParameter Name="Name" ControlID="txtSearch" PropertyName="Text" />

</FilterParameters>


</asp:SqlDataSource>

</div>
</div>


</asp:Content>

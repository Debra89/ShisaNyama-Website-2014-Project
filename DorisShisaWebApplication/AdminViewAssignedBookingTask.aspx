<%@ Page Title="" MaintainScrollPositionOnPostBack="true" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminViewAssignedBookingTask.aspx.cs" Inherits="DorisShisaWebApplication.AdminViewAssignedBookingTask" %>
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
    <div class="content-in">
<div class="GridviewDiv">

    <h2>View Assigned Tasks and Update if necessary</h2>
        &nbsp;&nbsp; Please entert the Employee or table you want to view.&nbsp;&nbsp;<br />
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
        
        <asp:Panel ID="Panel2" runat="server" ScrollBars="Auto">
            <asp:GridView ID="gvDetails" runat="server" AutoGenerateColumns="False" AllowPaging="True"

AllowSorting="True" DataSourceID="dsDetails" Width="578px" CssClass="Gridview" 
        BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" CellSpacing="2" DataKeyNames="TaskID" Height="16px" >

    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />

<HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />

<Columns>



    <asp:TemplateField HeaderText="TaskID">

<ItemTemplate>

<asp:Label ID="lbltaskID" Text='<%# Eval("TaskID") %>' runat="server"/>

</ItemTemplate>

</asp:TemplateField>
<asp:TemplateField HeaderText="Table">

<ItemTemplate>

<asp:Label ID="lblTable" Text='<%# HighlightText(Eval("TableNo").ToString()) %>' runat="server"/>

</ItemTemplate>

</asp:TemplateField>
<asp:TemplateField HeaderText="BookingID">

<ItemTemplate>

<asp:Label ID="lblbookingID" Text='<%#Eval("BookingID") %>' runat="server"></asp:Label>

</ItemTemplate>

</asp:TemplateField>
<asp:TemplateField HeaderText="Employee Name">

<ItemTemplate>

<asp:Label ID="lblemail" Text='<%#Eval("EmpName") %>' runat="server"></asp:Label>

</ItemTemplate>

</asp:TemplateField>


<asp:TemplateField HeaderText="Date">

<ItemTemplate>

<asp:Label ID="lbldate" Text='<%# Eval("Dates") %>' runat="server"></asp:Label>

</ItemTemplate>

</asp:TemplateField>
<asp:TemplateField HeaderText="Time">

<ItemTemplate>
    <asp:Label ID="lbltime" Text='<%# Eval("Times") %>' runat="server"></asp:Label>

</ItemTemplate>

</asp:TemplateField>
<asp:TemplateField HeaderText="Edit" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">

                                                <ItemTemplate>

                                                    <asp:ImageButton ID="imgBtnn" runat="server" CausesValidation="false" CommandArgument='<%#Eval("TaskID") %>'

                                                        OnCommand="imgEdit_Command" ImageUrl="~/images/icon-edit.jpg"

                                                        ToolTip="Edit" Width="30" Height="30" />

                                                </ItemTemplate>                                              

                                             <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                                          <ItemStyle HorizontalAlign="Center"></ItemStyle>

                                            </asp:TemplateField>
<asp:TemplateField HeaderText="Delete" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">

                                                <ItemTemplate>

                                                    <asp:ImageButton ID="imgBtn" runat="server" CausesValidation="false" CommandArgument='<%#Eval("TaskID") %>'

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
    ConnectionString="<%$ ConnectionStrings:DorisShisaConnectionString3 %>" 
    SelectCommand="SELECT * FROM [BookingTask] ORDER BY [Dates] DESC" 
    FilterExpression="TableNo LIKE '%{0}%'">
    
<FilterParameters>

<asp:ControlParameter Name="TableNo" ControlID="txtSearch" PropertyName="Text" />

</FilterParameters>
</asp:SqlDataSource>
<p>
            <asp:Label ID="lblStatus" runat="server" Text="" style="color: Green"></asp:Label></p>

<h2>Assign</h2>
        <asp:Panel ID="Panel3" runat="server" GroupingText="..." 
            HorizontalAlign="Justify">
       <p>Please add the Employees you want to assign task to the booking</p>
            <br /><br />
         <div align:="center">
        <table class="tabledata"  >
            <tr>
                <td align:="left" class="style4">
              Select Employee:
                </td>
                 <td colspan="2"><asp:DropDownList ID="DropDownList1" runat="server" CssClass="regfont" AutoPostBack="True" DataSourceID="CompIDSource" DataTextField="Name" DataValueField="Email" Width="198px">
                            </asp:DropDownList><asp:SqlDataSource ID="CompIDSource" runat="server" ConnectionString="<%$ ConnectionStrings:DorisShisaConnectionString3%>"
                                SelectCommand="SELECT UserLevel, Email, Name FROM WebUsers WHERE (UserLevel = 2)" >
                
                                </asp:SqlDataSource>
                </td>
                
            </tr>
            <tr>
                
                <td align:="right" class="style5">
                    Select Table:</td>
                <td style="height: 25px; width: 148px">
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>select</asp:ListItem>
                        <asp:ListItem>Table 1</asp:ListItem>
                        <asp:ListItem>Table 2</asp:ListItem>
                        <asp:ListItem>Table 3</asp:ListItem>
                        <asp:ListItem>Table 4</asp:ListItem>
                        <asp:ListItem>Table 5</asp:ListItem>
                        <asp:ListItem>Table 6</asp:ListItem>
                        <asp:ListItem>Table 7</asp:ListItem>
                        <asp:ListItem>Table 8</asp:ListItem>
                        <asp:ListItem>Table 9</asp:ListItem>
                        <asp:ListItem>Table 10</asp:ListItem>
                    </asp:DropDownList>
                    
                </td>
                
            </tr>
 <tr>
               
                <td align:="right" class="style6">
                    Task ID:</td>
                <td style="width: 148px">
                    <asp:TextBox ID="txttask" runat="server" CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox>
                </td>
                <td align:="left">
                    
                </td>
            </tr>
            <tr>
               
                <td align:="right" class="style6">
                    Booking ID:</td>
                <td style="width: 148px">
                    <asp:TextBox ID="txtbooking" runat="server" CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox>
                </td>
                <td align:="left">
                    
                </td>
            </tr>
            
               
            <tr>
               
                <td align:="right" class="style6">
                    Date:</td>
                <td style="width: 148px">
                    <asp:TextBox ID="txtdate" runat="server" CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox>
                </td>
                <td align:="left">
                    
                </td>
            </tr>
            <tr>
              
                <td align:="right" class="style6">
                  time:</td>
                <td style="width: 148px">
                    <asp:TextBox ID="txttime" runat="server" CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox>
                </td>
                <td align:="left">
                  
                </td>
            </tr>
          <%-- <tr>
              
                <td align:="right" class="style6">
                  Customer Name:</td>
                <td style="width: 148px">
                    <asp:TextBox ID="txtname" runat="server" CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox>
                </td>
                <td align:="left">
                  
                </td>
            </tr>

<tr>
              
                <td align:="right" class="style6">
                  Number of people:</td>
                <td style="width: 148px">
                    <asp:TextBox ID="txtnumber" runat="server" CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox> 
                </td>
                <td align:="left">
                  
                </td>
            </tr>

<tr>
              
                <td align:="right" class="style6">
                  Request:</td>
                <td style="width: 148px">
                    <asp:TextBox ID="txtrequest" runat="server"  CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox> 
                </td>
                <td align:="left">
                  
                </td>
            </tr>--%>

<tr>
                
                <td align:="right" style="font-size: small;" valign="top" class="style6">
                    Notify Waitron:</td>
                <td style="width: 148px">
                    <asp:CheckBox ID="chkMailNotifyAdd" runat="server" 
                        oncheckedchanged="chkMailNotifyAdd_CheckedChanged" CssClass="Checkbox" />
                </td>
                <td>
                    
                </td>
            </tr>
            

          <tr>
                
                <td align:="right" valign="top" class="style10">
                    </td>
                <td style="width: 148px; height: 35px;">
                    <asp:Button ID="cmdUpdate" runat="server" onclick="cmdUpdate_Click" 
                        Text="Update" Width="126px" CssClass="Button" />
                </td>
                <td style="height: 35px">
                    
                </td>
            </tr>
            <tr>
              
                <td align:="right" valign="top" class="style10">
                    &nbsp;</td>
                <td style="width: 148px; height: 35px;">
                    <p>
                        
            <asp:Label ID="Label1" runat="server" Text="" style="color: Green"></asp:Label></p>
                     <p class="Msg">
                        
                        <br />
                        <asp:Label ID="lblMailNotifyAdd" runat="server" CssClass="LblSuccess"></asp:Label>
                    </p>  
                          
                </td>
                <td style="height: 35px">
                    &nbsp;</td>
            </tr> 
  
                 
        </table></div>
         </asp:Panel>
         <br />


</div>
</div>
    

</asp:Content>

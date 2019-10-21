<%@ Page Title="" MaintainScrollPositionOnPostBack="true" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminAssignBookingTask.aspx.cs" Inherits="DorisShisaWebApplication.AdminAssignBookingTask" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content-in">
<div class="GridviewDiv">

    <h2>Assign Booking to Employees and Tables</h2>
       
 
 
        
       
        <asp:Panel ID="Panel2" runat="server" ScrollBars="Auto">
            <asp:GridView ID="gvDetails" runat="server" AutoGenerateColumns="False" AllowPaging="True"

AllowSorting="True" DataSourceID="dsDetails" Width="540px" CssClass="Gridview" 
        BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" CellSpacing="2" DataKeyNames="BookingID" >

    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />

<HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />

<Columns>



    <asp:TemplateField HeaderText="BookingID">

<ItemTemplate>

<asp:Label ID="lblbookingID" Text='<%# Eval("BookingID") %>' runat="server"/>

</ItemTemplate>

</asp:TemplateField>
<%--<asp:TemplateField HeaderText="Email">

<ItemTemplate>

<asp:Label ID="lblemail" Text='<%# Eval("Email") %>' runat="server"/>

</ItemTemplate>

</asp:TemplateField>
<asp:TemplateField HeaderText="Customer">

<ItemTemplate>

<asp:Label ID="lblName" Text='<%#Eval("Name") %>' runat="server"></asp:Label>

</ItemTemplate>

</asp:TemplateField>
<asp:TemplateField HeaderText="Number of people">

<ItemTemplate>

<asp:Label ID="lblnumber" Text='<%#Eval("NumberOfPeople") %>' runat="server"></asp:Label>

</ItemTemplate>--%>

<%--</asp:TemplateField>--%>
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
<asp:TemplateField HeaderText="Assigned">

<ItemTemplate>

<asp:Label ID="lblassigned" Text='<%# Eval("Assigned") %>' runat="server"></asp:Label>
</ItemTemplate>

</asp:TemplateField>

<asp:TemplateField HeaderText="Assign" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">

                                                <ItemTemplate>

                                                    <asp:ImageButton ID="imgBtn" runat="server" CausesValidation="false" CommandArgument='<%#Eval("BookingID") %>'

                                                        OnCommand="imgEdit_Command" ImageUrl="~/images/icon-edit.jpg"

                                                        ToolTip="Assign" Width="30" Height="30" />

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
    SelectCommand="SELECT [Dates], [Times], [BookingID], [Assigned] FROM [Bookings] ORDER BY [Dates] DESC" >
 
</asp:SqlDataSource>
<h2>Assign</h2>
        <asp:Panel ID="Panel3" runat="server" GroupingText="..." 
            HorizontalAlign="Justify">
       <p>Please add the Employees you want to assign task to the booking</p>
            <br /><br />
         <div align:="center">
        <table class="tabledata"  >
            <tr>
                <td align:="left" class="style4">
                    Select&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employee:
                </td>
                 <td colspan="2"><asp:DropDownList ID="DropDownList1" runat="server" CssClass="regfont" AutoPostBack="True" DataSourceID="CompIDSource" DataTextField="Name" DataValueField="Email" Width="198px">
                            </asp:DropDownList><asp:SqlDataSource ID="CompIDSource" runat="server" ConnectionString="<%$  ConnectionStrings:DorisShisaConnectionString3%>"
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
         <%--  <tr>--%>
              
                <%--<td align:="right" class="style6">
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
                    Numberof people:</td>
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
    <td align:="right" style="font-size: small;" valign="top" class="style6">
                    Notify Customer:</td>
                <td style="width: 148px">
                    <asp:CheckBox ID="ChkMailNotifyCus" runat="server" 
                        oncheckedchanged="ChkMailNotifyCus_CheckedChanged" CssClass="Checkbox" />
                </td>
                <td>
                    
                </td>
            </tr>
            

          <tr>
                
                <td align:="right" valign="top" class="style10">
                    </td>
                <td style="width: 148px; height: 35px;">
                    <asp:Button ID="cmdAssign" runat="server" onclick="cmdAssign_Click" 
                        Text="Assign" Width="126px" CssClass="Button" />
                </td>
                <td style="height: 35px">
                    
                </td>
            </tr>
            <tr>
              
                <td align:="right" valign="top" class="style10">
                    &nbsp;</td>
                <td style="width: 148px; height: 35px;">
                    <p>
                        
            <asp:Label ID="lblStatus" runat="server" Text="" style="color: Green"></asp:Label></p>
                     <p class="Msg">
                        
                        <br />
                        <asp:Label ID="lblMailNotifyAdd" runat="server" CssClass="LblSuccess"></asp:Label>
                    </p>  
                          
                </td>
                <td style="height: 35px">
                    &nbsp;</td>
            </tr> 
  
                  <tr>
              
                <td align:="right" valign="top" class="style10">
                    &nbsp;</td>
                <td style="width: 148px; height: 35px;">
                    <p>
                        
            <asp:Label ID="Lblresults" runat="server" Text="" style="color: Green"></asp:Label></p>
                      
                          
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

<%@ Page Title="" MaintainScrollPositionOnPostBack="true" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminUpdateEmployees.aspx.cs" Inherits="DorisShisaWebApplication.AdminUpdateEmployees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class ="content-in">
    <h2>Update Employees Details</h2>
        &nbsp;&nbsp; Please enter Name for the user you want to Update.&nbsp;&nbsp;<br />
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

        <table>
                              
            <tr>

                <td colspan="2">

                    <asp:GridView ID="grdEmployees" runat="server" AutoGenerateColumns="False"

                        DataKeyNames="Email" CellPadding="3" 
                        Height="187px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" 
                        BorderWidth="1px" CellSpacing="2" AllowPaging="True" AllowSorting="True" DataSourceID="dsDetails">

                    <Columns>

                     <asp:TemplateField HeaderText="Email" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">

                                                <ItemTemplate>

                                                    <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Email") %>'></asp:Label>

                                                </ItemTemplate>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                                            </asp:TemplateField>

                            
                                              <asp:TemplateField HeaderText="Name" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">

                                                <ItemTemplate>

                                                    <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name")%>'></asp:Label>

                                                </ItemTemplate>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Surname" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">

                                                <ItemTemplate>

                                                    <asp:Label ID="lblSurname" runat="server" Text='<%#Eval("Surname") %>'></asp:Label>

                                                </ItemTemplate>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Contact No" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">

                                                <ItemTemplate>

                                                    <asp:Label ID="lblcell" runat="server" Text='<%#Eval("Cell") %>'></asp:Label>

                                                </ItemTemplate>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>

<ItemStyle HorizontalAlign="Center"></ItemStyle>

                                            </asp:TemplateField>

                                            


                                           

                                          

                                            <asp:TemplateField HeaderText="Edit" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">

                                                <ItemTemplate>

                                                    <asp:ImageButton ID="imgBtn" runat="server" CausesValidation="false" CommandArgument='<%#Eval("Email") %>'

                                                        OnCommand="imgEdit_Command" ImageUrl="~/images/icon-edit.jpg"

                                                        ToolTip="Edit" Width="30" Height="30" />

                                                </ItemTemplate>                                              

                                             <HeaderStyle HorizontalAlign="Center"></HeaderStyle>

                                          <ItemStyle HorizontalAlign="Center"></ItemStyle>

                                            </asp:TemplateField>

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

                </td>
  </tr>
 <tr>

                <td>

                    &nbsp;</td>

                <td>

                    <asp:Label ID="lblStatus" runat="server" Text="" style="color: Green"></asp:Label>

                </td>
 </tr> 
 <tr><td><asp:SqlDataSource ID="dsDetails" runat="server" 
    ConnectionString="<%$  ConnectionStrings:DorisShisaConnectionString3 %>" 
    SelectCommand="SELECT Name, Surname, Email, Cell, UserLevel FROM WebUsers WHERE (UserLevel = 2)" 
    FilterExpression="Name LIKE '%{0}%'">
    
<FilterParameters>

<asp:ControlParameter Name="Name" ControlID="txtSearch" PropertyName="Text" />

</FilterParameters>


</asp:SqlDataSource></td></tr> 

  </table>


  
        
        <h2>Update User</h2>
        <asp:Panel ID="Panel3" runat="server" GroupingText="..." 
            HorizontalAlign="Justify">
       <p>Edit or Add New User </p>
         <div align:="center">
        <table class="tabledata">

   


    
<tr style="font-weight: normal; color: #000000">
<td align:="right">
<span>Name:</span>

</td>

<td align:="left" style="padding-left: 10px;">

                                <asp:TextBox ID="TxtName" runat="server" CssClass="textbox" Width="200px"

                                    MaxLength="50" Height="25px"></asp:TextBox>


                            </td>

                        </tr>

                        <tr>

                            <td align:="right">

                                <span class="TextTitle">Surname:</span>

                            </td>

                            <td align:="left" style="padding-left: 10px;">

                                <asp:TextBox ID="Txtsurname" runat="server" CssClass="textbox" Width="200px"

                                    MaxLength="50" Height="25px"></asp:TextBox>

                                   
                              

                            </td>

                        </tr>

                       

                        <tr>

                            <td align:="right">

                                <span class="TextTitle">contact no:</span>

                            </td>

                            <td align:="left" style="padding-left: 10px;">

                                <asp:TextBox ID="Txtcell" runat="server" CssClass="textbox" Width="200px"

                                    MaxLength="50" Height="25px"></asp:TextBox>

                                     

                            </td>

                        </tr>

                      
 

 
        
       
               <tr>

               <td class="style1">

                    <asp:Button ID="btnSubmit" runat="server" Text="Submit"

                        onclick="btnSubmit_Click" Height="29px" />
                           </td>

                           <td>  
                               <asp:Button ID="Button2" runat="server" Text="Cancel"

                        onclick="btnCancel_Click" style="height: 26px" /></td>
           

            </tr>

           

            <tr>

                <td>

                    &nbsp;</td>

                <td>

                    &nbsp;</td>

            </tr>

   </table></div>
         </asp:Panel>
         <br />
       
                    
    
        </div>

</asp:Content>

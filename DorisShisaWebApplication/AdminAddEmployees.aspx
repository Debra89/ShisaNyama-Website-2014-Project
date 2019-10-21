<%@ Page Title="" MaintainScrollPositionOnPostBack="true" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminAddEmployees.aspx.cs" Inherits="DorisShisaWebApplication.AdminAddEmployees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <div class ="content-in">
    <h2>Add New User</h2>
        <asp:Panel ID="Panel1" runat="server" GroupingText="..." 
            HorizontalAlign="Justify">
       <p class="Pinfo">Please add user details and create the user</p>
         <div align:="center">
        <table class="tabledata"  >
            <tr>
                
                <td align:="right" class="style11">
                    Name:</td>
                <td style="height: 25px; width: 148px">
                    <asp:TextBox ID="txtname" runat="server" CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox>
                </td>
                <td align:="left" class="style4">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
                        ControlToValidate="txtname" ErrorMessage="Enter name" 
                        ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    
                </td>
            </tr>
            <tr>
                
                <td align:="right" class="style5">
                    Surname:</td>
                <td style="height: 25px; width: 148px">
                    <asp:TextBox ID="txtsurname" runat="server" CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox>
                </td>
                <td style="height: 25px" align:="left">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
                        ControlToValidate="txtsurname" ErrorMessage="Enter first name" 
                        ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    </td>
            </tr>
            <tr>
               
                <td align:="right" class="style6">
                    Email</td>
                <td style="width: 148px">
                    <asp:TextBox ID="txtemail" runat="server" CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox>
                </td>
                <td align:="left">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" 
                        ControlToValidate="txtemail" ErrorMessage="Enter Email" 
                        ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
               
                <td align:="right" class="style6">
                    mobile:</td>
                <td style="width: 148px">
                    <asp:TextBox ID="txtcell" runat="server" CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox>
                </td>
                <td align:="left">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" 
                        ControlToValidate="txtcell" ErrorMessage="Enter Contact number" 
                        ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                </td>
            </tr>
             



<tr>
                
                <td align:="right" style="font-size: small;" valign="top" class="style6">
                    Notify User:</td>
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
                    <asp:Button ID="cmdCreateUser" runat="server" onclick="cmdCreateUser_Click" 
                        Text="Create User" Width="126px" CssClass="Button" />
                </td>
                <td style="height: 35px">
                    
                </td>
            </tr>
            <tr>
              
                <td align:="right" valign="top" class="style10">
                    &nbsp;</td>
                <td style="width: 148px; height: 35px;">
                     <asp:Label ID="lblStatus" runat="server" Text="" style="color: Green"></asp:Label>
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

</asp:Content>

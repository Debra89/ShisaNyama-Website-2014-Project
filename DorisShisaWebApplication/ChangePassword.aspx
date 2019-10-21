<%@ Page Title=""MaintainScrollPositionOnPostBack="true" Language="C#" MasterPageFile="~/CusMaster.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="DorisShisaWebApplication.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
 <style type="text/css">
    #TableLogin {
        width: 122%;
    }
    .auto-style1 {
        height: 30px;
        width: 567px;
    }
    .auto-style3 {
        width: 693px;
    }
    .auto-style4 {
        width: 567px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="wrap">
       
<div id="main">
     <h2>Change Password</h2>
    
   <table width:="84%" cellpadding="0" cellspacing="0" 
         style="border: 1px solid #000000;" class="auto-style3">




            <tr>

                <td colspan="4" style="background-color: #000000;" class="auto-style1" >

                    <span class="TextTitle" style="color: #FFFFFF;">Update Form</span>

                </td>

            </tr>

            <tr>

                <td height:="20px" colspan="0" class="auto-style4">

                </td>

            </tr>

            <tr>

                <td width:="50%" valign="top" class="auto-style4">

                    <table id="TableLogin" class="HomePageControlBGLightGray" cellpadding="4" cellspacing="4"

                        runat="server">

                        <tr>

                            <td colspan="3" align="center">

                                <asp:Label ID="LabelMessage" ForeColor="Green" runat="server" EnableViewState="True"

                                    Visible="True"></asp:Label><br/>

                            </td>

                        </tr>

    <tr>
    <td>Email: * </td>
    <td>
        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
       
        </td>
    </tr>
    <tr>
    <td>New Password: * </td>
    <td>
        <asp:TextBox ID="txtNewPwd" runat="server" TextMode="Password"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="rfvNewPwd" runat="server"
            ErrorMessage="Please enter new password" ControlToValidate="txtNewPwd"
            Display="Dynamic" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>

         </td>
    </tr>
         <tr>
    <td>Confirm Password: * </td>
    <td>
        <asp:TextBox ID="txtConfirmPwd" runat="server" TextMode="Password"></asp:TextBox><br />
        <asp:RequiredFieldValidator ID="rfvConfirmPwd" runat="server"
            ErrorMessage="Please re-enter password to confirm"
            ControlToValidate="txtConfirmPwd" Display="Dynamic" ForeColor="Red"
            SetFocusOnError="True"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="cmvConfirmPwd" runat="server"
            ControlToCompare="txtNewPwd" ControlToValidate="txtConfirmPwd"
            Display="Dynamic" ErrorMessage="New and confirm password didn't match"
            ForeColor="Red" SetFocusOnError="True"></asp:CompareValidator>
             </td>
    </tr>
     <tr>
    <td>
        &nbsp;</td><td>
        <asp:Button ID="btnSubmit" runat="server" Text="Change Password"
             onclick="btnSubmit_Click" /></td>
    </tr>
     <tr>
    <td colspan="2">
        <asp:Label ID="lblStatus" runat="server" ForeColor="#009933"></asp:Label>
         </td>
    </tr>
     </table>

                </td>

            </tr>

        </table>
    </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

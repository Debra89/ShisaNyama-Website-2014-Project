<%@ Page Title="" MaintainScrollPositionOnPostBack="true" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DorisShisaWebApplication.Login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   
        <div class="wrap">
       
<div id="main">

    
     <h2>Login here</h2>

      <table width:="84%" cellpadding="0" cellspacing="0" 
         style="border: 1px solid #000000;">

          


            <tr>

                <td colspan="4" style="height: 30px; background-color: #000000;">

                    <span class="TextTitle" style="color: #FFFFFF;">LogIn Form</span>

                </td>

            </tr>
         
            <tr>

                <td height="20px" colspan="0">

                </td>

            </tr>

            <tr>

                <td width="50%" valign="top">

                    <table id="TableLogin" class="HomePageControlBGLightGray" cellpadding="4" cellspacing="4"

                        runat="server" width="100%">

                        <tr>

                            <td colspan="3" align="center">

                                <asp:Label ID="LabelMessage" ForeColor="Red" runat="server" EnableViewState="True"

                                    Visible="True"></asp:Label><br/>

                            </td>

                        </tr>





                        <tr>

                            <td align="right">

                                <span>Email:</span>

                            </td>

                            <td align="left" style="padding-left: 10px;">

                                <asp:TextBox ID="Txtemail" runat="server" CssClass="textbox" Width="200px"

                                    MaxLength="50" Height="25px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Runat="server" 
                        ErrorMessage="Username field is Required" Display="Dynamic" ControlToValidate="txtemail" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>

                        </tr>

                        <tr>

                            <td align="right">

                                <span class="TextTitle">Password:</span>

                            </td>

                            <td align="left" style="padding-left: 10px;">

                              <asp:TextBox ID="Txtpassword" runat="server" CssClass="textbox" Width="200px"

                                    MaxLength="50" Height="25px" TextMode="Password"></asp:TextBox>

                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Runat="server" 
                        ErrorMessage="Password Field is Required" Display="Dynamic" ControlToValidate="txtpassword" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />

                            </td>

                        </tr>

                       <tr>

                            <td align="right">

                            </td>

                            <td align="left" style="padding-left: 10px;">

                                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" Width="87px" />

                                <br />

                            </td>

                        </tr>
                      
                        <tr><td>
<a href="Register.aspx" style="color: #000000; font-size: small; font-weight: bold">New User?? Register Here</a>

                            </td>
                            <td><a href="ForgotPassword.aspx" style="color: #000000; font-size: small; font-weight: bold">Forgot Password??</a></td>
                        </tr>


                   </table>

                </td>
                  </tr>
 

        </table>

    </div>

 </div>
 </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

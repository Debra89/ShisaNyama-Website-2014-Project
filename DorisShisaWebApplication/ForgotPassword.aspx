<%@ Page Title=""MaintainScrollPositionOnPostBack="true"  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="DorisShisaWebApplication.ForgotPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="wrap">
       
<div id="main">

    
     <h2>Forgor Password</h2>
    <p>A temporary email will be sent to both this Email address, after logging in you can change to the Email of choice</p>

      <table width:="84%" cellpadding="0" cellspacing="0" 
         style="border: 1px solid #000000;">

          


            <tr>

                <td colspan="4" style="height: 30px; background-color: #000000; width: 600px;">

                    <span class="TextTitle" style="color: #FFFFFF;">Forgot Password Form</span>

                </td>

            </tr>
         
            <tr>

                <td height:="20px" colspan="0">

                </td>

            </tr>

            <tr>

                <td width:="50%" valign="top">

                    <table id="TableLogin" class="HomePageControlBGLightGray" cellpadding="4" cellspacing="4"

                        runat="server">

                        <tr>

                            <td colspan="3" align ="center">

                                <asp:Label ID="LabelMessage" ForeColor="Red" runat="server" EnableViewState="True"

                                    Visible="True"></asp:Label><br/>

                            </td>

                        </tr>





                        <tr>

                            <td align ="right">

                                <span>Email:</span>

                            </td>

                            <td align ="left" style="padding-left: 10px;">

                                <asp:TextBox ID="txtemail" runat="server" CssClass="textbox" Width="200px"

                                    MaxLength="50" Height="25px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Runat="server" 
                        ErrorMessage="Email field is Required" Display="Dynamic" ControlToValidate="txtemail" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>

                        </tr>

                       <tr>
                            <td align ="right">

                                <span>Contact Number:</span>

                            </td>
                           <td align ="left" style="padding-left: 10px;">

                                <asp:TextBox ID="txtcell" runat="server" CssClass="textbox" Width="200px"

                                    MaxLength="50" Height="25px"></asp:TextBox>

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Runat="server" 
                        ErrorMessage="Contact number field is Required" Display="Dynamic" ControlToValidate="txtcell" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                       </tr>

                       

                       <tr>

                            <td align ="right">

                            </td>

                            <td align="left" style="padding-left: 10px;">

                                <asp:Button ID="cmdsubmit" runat="server" Text="Submit" Width="110px" OnClick="cmdsubmit_Click" />
                                <br />

                            </td>

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

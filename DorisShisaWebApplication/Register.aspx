<%@ Page Title=""MaintainScrollPositionOnPostBack="true"  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="DorisShisaWebApplication.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div id="bg">
		<div class="wrap">
       
<div id="main">

    
     <h2>New User Register here</h2>

      <table width="84%" cellpadding="0" cellspacing="0" 
         style="border: 1px solid #000000;">




            <tr>

                <td colspan="4" style="height: 30px; background-color: #000000;" 
                    bgcolor="Black">

                    <span class="TextTitle" style="color: #FFFFFF;">Registration Form</span>

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

                                <asp:Label ID="LabelMessage" ForeColor="Green" runat="server" EnableViewState="True"

                                    Visible="True"></asp:Label><br/>

                            </td>

                        </tr>

 


                        <tr>

                            <td style="text-align:right" class="auto-style1">
                <asp:Label ID="Label4" runat="server" Text="Name:"></asp:Label>
            </td>

                            <td align="left" style="padding-left: 10px;">

                                <asp:TextBox ID="txtname" runat="server" CssClass="textbox" Width="200px"

                                    MaxLength="50" Height="25px"></asp:TextBox>

 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Runat="server" 
                        ErrorMessage="Name field is Required" Display="Dynamic" ControlToValidate="txtname" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>

                        </tr>

                        <tr>

                            <td style="text-align:right" class="auto-style1">
                <asp:Label ID="Label3" runat="server" Text="Surname:"></asp:Label>
            </td>

                            <td align="left" style="padding-left: 10px;">

                                <asp:TextBox ID="txtsurname" runat="server" CssClass="textbox" Width="200px"

                                    MaxLength="50" Height="25px"></asp:TextBox>

                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Runat="server" 
                        ErrorMessage="Surname field is required" Display="Dynamic" ControlToValidate="txtsurname" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />

                            </td>

                        </tr>



  <tr>

                            <td style="text-align:right" class="auto-style1">
                <asp:Label ID="Label6" runat="server" Text="Mobile:"></asp:Label>
            </td>

                            <td align="left" style="padding-left: 10px;">

                                <asp:TextBox ID="txtmobile" runat="server" CssClass="textbox" Width="200px"

                                    MaxLength="50" Height="25px"></asp:TextBox>

 <asp:RequiredFieldValidator ID="RequiredFieldValidator7" Runat="server" 
                        ErrorMessage="Mobile field is required required" Display="Dynamic" ControlToValidate="txtmobile" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>

                        </tr>

                

                        <tr>

                            <td align="right" class="auto-style1">

                                <span class="TextTitle">Email:</span>

                            </td>

                            <td align="left" style="padding-left: 10px;">

                                <asp:TextBox ID="txtemail" runat="server" CssClass="textbox" Width="200px"

                                    MaxLength="50" Height="25px" TextMode="Email"></asp:TextBox>

                                     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Runat="server" 
                        ErrorMessage="Email field is Required" Display="Dynamic" ControlToValidate="txtemail" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />

                            </td>

                        </tr>

             <tr>          
 
            <td style="text-align:right" class="auto-style1">
                <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
            </td>
            <td align="left" style="padding-left: 10px;">
                <asp:TextBox ID="txtPass" runat="server" style="margin-right: 0px" 
                    TextMode="Password" Width="200px" Height="25px"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" Runat="server" 
                        ErrorMessage="Password field is required" Display="Dynamic" ControlToValidate="txtPass" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
       
       <tr>
          <td style="text-align:right" class="auto-style1">
                <asp:Label ID="Label1" runat="server" Text="Re-type password:"></asp:Label>
            </td>
          <td align="left" style="padding-left: 10px;">
                <asp:TextBox ID="txtconpass" runat="server" style="margin-right: 0px" 
                    TextMode="Password" Width="200px" Height="25px"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtconpass" ForeColor="Red"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpass" ControlToValidate="txtconpass" ForeColor="Red"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                            
            </td>
          
       </tr>

                        <tr>

                            <td align="right" class="auto-style1">

                            </td>

                            <td align="left" style="padding-left: 10px;">

                                <asp:Button ID="Button1" runat="server" Text="Signup" OnClick="Button1_Click" 
                                    Width="87px" />
                                
                       
                               
                                <br />

                            </td>

                        </tr>

                    </table>

                </td>

            </tr>

        </table>

    </div>

 </div>

 </div>


</asp:Content>


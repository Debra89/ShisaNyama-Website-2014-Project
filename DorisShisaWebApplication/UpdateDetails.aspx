<%@ Page Title=""MaintainScrollPositionOnPostBack="true"  Language="C#" MasterPageFile="~/CusMaster.Master" AutoEventWireup="true" CodeBehind="UpdateDetails.aspx.cs" Inherits="DorisShisaWebApplication.UpdateDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrap">
       
<div id="main">

     <h2>Edit personal details</h2>

      <table width="84%" cellpadding="0" cellspacing="0" 
         style="border: 1px solid #000000;">




            <tr>

                <td colspan="4" style="height: 30px; background-color: #000000;" 
                    bgcolor="Black">

                    <span class="TextTitle" style="color: #FFFFFF;">Update Form</span>

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

                            <td align="right" class="auto-style1">

                                <span class="TextTitle">Email:</span>

                            </td>

                            <td align="left" style="padding-left: 10px;">

                                <asp:TextBox ID="txtemail" runat="server" Height="28px" Width="199px"></asp:TextBox>
                                     
                                <br />

                            </td>

                        </tr>


                        <tr>

                            <td style="text-align:right" class="auto-style1">
                <asp:Label ID="Label4" runat="server" Text="Name:"></asp:Label>
            </td>

                            <td align="left" style="padding-left: 10px;">

                                <asp:TextBox ID="txtname" runat="server" CssClass="textbox" Width="200px"

                                    MaxLength="50" Height="25px"></asp:TextBox>


                            </td>

                        </tr>

                        <tr>

                            <td style="text-align:right" class="auto-style1">
                <asp:Label ID="Label3" runat="server" Text="Surname:"></asp:Label>
            </td>

                            <td align="left" style="padding-left: 10px;">

                                <asp:TextBox ID="txtsurname" runat="server" CssClass="textbox" Width="200px"

                                    MaxLength="50" Height="25px"></asp:TextBox>

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

 
                            </td>

                        </tr>

                

                        

             
                        <tr>

                            <td align="right" class="auto-style1">

                            </td>

                            <td align="left" style="padding-left: 10px;">

                                <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" 
                                    Width="87px" style="height: 26px" />

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
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

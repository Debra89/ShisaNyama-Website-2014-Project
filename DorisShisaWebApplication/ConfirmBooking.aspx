﻿<%@ Page Title="" MaintainScrollPositionOnPostBack="true" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConfirmBooking.aspx.cs" Inherits="DorisShisaWebApplication.ConfirmBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <div class="wrap">
    <!-- main -->
			<div id="main">

                
                <h2 class="inner">Please Confirm your booking</h2>
                
                <p>
						<label for="email">E-mail Address:</label>
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
					</p>
              <p>
                    <label for="name">Name:</label>
						<asp:TextBox ID="txtName" runat="server" Height="25px" Width="190px" />
                         
					</p>
                
					<p>
						<label for="text">Contact number:</label>
						<asp:TextBox ID="txtphone" runat="server" Height="25px" Width="190px" />
                         
					</p>
              <p><label for="text">Number Of People:</label>
						<asp:TextBox ID="Txtnumber" runat="server" Height="25px" Width="190px" />
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" Runat="server" 
                        ErrorMessage="*" Display="Dynamic" ControlToValidate="txtnumber" 
                        ForeColor="Red"></asp:RequiredFieldValidator></p>
                    <p>
                        <label for="text">Date:</label>
                      


                       <asp:TextBox ID="txtDOB" runat="server" TextMode="Date"></asp:TextBox>
                      
                       
                      
                      
                       </p>
                        <p><label for="text">Time:</label>
                            <asp:TextBox ID="txttime" runat="server" TextMode="Time"></asp:TextBox>           
                        
					</p>
                    <p>
						<label for="text">Request:</label>
						<asp:TextBox ID="txtRequest" Rows="5" Columns="40" TextMode="MultiLine" 
                            runat="server" Height="114px"/>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" Runat="server" 
                        ErrorMessage="*" Display="Dynamic" ControlToValidate="txtRequest"
                        ForeColor="Red"></asp:RequiredFieldValidator>
					</p>
                  <p> <asp:Label ID="lblMsg" runat="server" CssClass="Label" Font-Bold="True" 
                                    ForeColor="Green"></asp:Label></p>
                <p> &nbsp;<asp:button ID="btnSubmit" Text="Confirms"  runat="server" onclick="btnSubmit_Click" CssClass="Button"/>

					    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:button ID="btncancel" Text="Cancel"  runat="server" onclick="btncancel_Click" CssClass="Button"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </p>
			
              
			
               
               

      
                </div>
       </div>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

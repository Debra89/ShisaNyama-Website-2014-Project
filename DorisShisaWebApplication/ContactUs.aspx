<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="DorisShisaWebApplication.ContactUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <div class="wrap">
    <!-- main -->
			<div id="main">


                <h2 class="inner">Contact Us</h2>
				 <p  style=" color:green"><asp:Label ID="lbltxt" runat="server"/>  </p>

					<p>
						<label for="name">Name:</label>
						<asp:TextBox ID="txtName" runat="server" Height="25px" Width="190px" />
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Runat="server" 
                        ErrorMessage="*" Display="Dynamic" ControlToValidate="txtName" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
					</p>
					<p>
						<label for="email">E-mail Address:</label>
						<asp:TextBox ID="txtEmail" runat="server" Height="25px" Width="190px" TextMode="Email" />
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" Runat="server" 
                        ErrorMessage="*" Display="Dynamic" ControlToValidate="txtEmail" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
					</p>
					<p>
						<label for="text">subject:</label>
						<asp:TextBox ID="txtSubject" runat="server" Height="25px" Width="190px" />
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" Runat="server" 
                        ErrorMessage="*" Display="Dynamic" ControlToValidate="txtSubject" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
					</p>
					<p>
						<label for="text">Message:</label>
						<asp:TextBox ID="txtMessage" Rows="5" Columns="40" TextMode="MultiLine" runat="server" Height="114px"/>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" Runat="server" 
                        ErrorMessage="*" Display="Dynamic" ControlToValidate="txtMessage" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
					</p>
					<p>
						<asp:button ID="btnSubmit" Text="Submit"  runat="server" onclick="btnSubmit_Click" CssClass="Button"/>
					</p>
			
               

                </div>
       </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

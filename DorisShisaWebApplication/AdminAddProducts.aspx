<%@ Page Title="" MaintainScrollPositionOnPostBack="true" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminAddProducts.aspx.cs" Inherits="DorisShisaWebApplication.AdminAddProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class ="content-in">
<h2>Add New Product</h2>
        <asp:Panel ID="Panel1" runat="server" GroupingText="..." 
            HorizontalAlign="Justify">
       <p>Please add Products details and create the Product</p>
         <div align:="center">
        <table class="tabledata"  >
            <tr>
                
                <td align:="right" class="style11">
                    Product Name:</td>
                <td class="style3">
                    <asp:TextBox ID="txtname" runat="server" CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox>
                </td>
                <td align:="left" class="style4">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
                        ControlToValidate="txtname" ErrorMessage="Enter Product name" 
                        ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    
                </td>
            </tr>
            <tr>
                
                <td align:="right" class="style5">
                    Description:</td>
                <td style="height: 25px; width: 148px">
                    <asp:TextBox ID="txtdescription" runat="server" CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox>
                </td>
                <td style="height: 25px" align:="left">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
                        ControlToValidate="txtdescription" ErrorMessage="Enter Product description" 
                        ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                    </td>
            </tr>
            <tr>
               
                <td align:="right" class="style6">
                    Category:</td>
                <td style="width: 148px">
                    <asp:TextBox ID="txtcategory" runat="server" CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox>
                </td>
                <td align:="left">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" 
                        ControlToValidate="txtcategory" ErrorMessage="Enter Product category" 
                        ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
               
                <td align:="right" class="style6">
                    Product ID:</td>
                <td style="width: 148px">
                    <asp:TextBox ID="txtproductid" runat="server" CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox>
                </td>
                <td align:="left">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" 
                        ControlToValidate="txtproductid" ErrorMessage="Enter Product ID" 
                        ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            
               
            <tr>
               
                <td align:="right" class="style6">
                    Price:</td>
                <td style="width: 148px">
                    <asp:TextBox ID="txtprice" runat="server" CssClass="TextinputText" 
                        Height="20px" Width="186px"></asp:TextBox>
                </td>
                <td align:="left">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" 
                        ControlToValidate="txtprice" ErrorMessage="Enter the Product Price" 
                        ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
              
                <td align:="right" class="style6">
                  Image:</td>
                <td style="width: 148px">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td align:="left">
                  
                </td>
            </tr>
          <tr>
                
                <td align:="right" valign="top" class="style10">
                    </td>
                <td style="width: 148px; height: 35px;">
                    <asp:Button ID="cmdCreateUser" runat="server" onclick="cmdCreateUser_Click" 
                        Text="Create Product" Width="126px" CssClass="Button" />
                </td>
                <td style="height: 35px">
                    
                </td>
            </tr>
            <tr>
              
                <td align:="right" valign="top" class="style10">
                    &nbsp;</td>
                <td style="width: 148px; height: 35px;">
                    <p class="Msg">
                        <asp:Label ID="Label1" runat="server" CssClass="LblSuccess" ForeColor="#009933"></asp:Label>
                       
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

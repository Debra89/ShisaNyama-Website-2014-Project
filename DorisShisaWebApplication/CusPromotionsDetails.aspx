<%@ Page Title="" MaintainScrollPositionOnPostBack="true" Language="C#" MasterPageFile="~/CusMaster.Master" AutoEventWireup="true" CodeBehind="CusPromotionsDetails.aspx.cs" Inherits="DorisShisaWebApplication.CusPromotionsDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
 <style type="text/css">
        .auto-style1 {
            height: 30px;
            width: 58%;
        }
        .auto-style2 {
            width: 58%;
        }
        .auto-style3 {
            width: 684px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="wrap">
       
<div id="main">

    
     <h2>Product Details</h2>

      <table cellpadding="0" cellspacing="0" 
         style="border: 1px solid #000000; width: 109%;">

          


            <tr>

                <td colspan="4" style="background-color: #000000;" class="auto-style1">

                    <span class="TextTitle" style="color: #FFFFFF;">Product Details</span>

                </td>

            </tr>
         
            <tr>

                <td height="20px" colspan="0" class="auto-style2">

                </td>

            </tr>

            <tr>

                <td valign="top" class="auto-style2">

                    <table style="width: 690px">

              <asp:SqlDataSource ID="SqlDataSource1" runat="server"
ConnectionString="<%$ ConnectionStrings:DorisShisaConnectionString4 %>"
SelectCommand="SELECT [ProductId], [Name], [Description], [Price], [ImageUrl] FROM [Products] WHERE ([ProductId] = @ProductId)">
    <SelectParameters>
        <asp:QueryStringParameter Name="ProductId" QueryStringField="ProductId" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>
 

<asp:DataList ID="DataList1" runat="server" 
              DataSourceID="SqlDataSource1">
<ItemTemplate>
  <asp:Image ID="Image1" runat="server" 
       ImageUrl='<%# Eval("ImageUrl","~/images\\{0}") %>'/>
  <asp:Label ID="ImageUrlLabel" runat="server" 
             Text='<%# Eval("ImageUrl") %>' 
             Visible="False">
  </asp:Label><br />
  <asp:Label ID="NameLabel" runat="server" 
             Text='<%# Eval("Name") %>' Font-Bold="False" Font-Italic="False">
  </asp:Label><br />
  <asp:Label ID="DescriptionLabel" runat="server" 
             Text='<%# Eval("Description") %>' Font-Size="Larger" Font-Bold="False" Font-Italic="True">
  </asp:Label><br />
  <asp:Label ID="PriceLabel" runat="server" 
             Text='<%# Eval("Price", "{0:R##0.00}" ) %>' Font-Italic="True" Font-Bold="True" Font-Size="X-Large">
  </asp:Label><br />
</ItemTemplate>
</asp:DataList>

<tr><td class="auto-style3"></td></tr>
                        
                        

     
                           
                   </table>

                </td>
                  </tr>
 

        </table>
    <asp:HyperLink ID="HyperLink1" runat="server" 
               NavigateUrl="~/CusPromotions.aspx" Font-Bold="True">
               Return to Products Page
</asp:HyperLink>  
    </div>
      </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

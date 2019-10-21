<%@ Page Title="" MaintainScrollPositionOnPostBack="true" Language="C#" MasterPageFile="~/CusMaster.Master" AutoEventWireup="true" CodeBehind="CusPlaceOrder.aspx.cs" Inherits="DorisShisaWebApplication.CusPlaceOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
  <style type="text/css">
        .regfont {}
    .auto-style1 {
        width: 100px;
        height: 28px;
    }
      .Button {}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  <div>
 <div class="wrap">
       
<div id="main">

    <h2>Place Order here</h2>
    <p>Add to the cart the food you wish to order, you can add as many as you like</p>
    <p>** After clicking submit your Order Details will be Emailed to you, checkOut allows you to Reorder and delete uncessary Orders,<asp:HyperLink ID="HyperLink1" runat="server">Click here to reorder</asp:HyperLink></p>
    
 <table>

 
                        <tr>
                          
               
                            <td colspan="2"><asp:DropDownList ID="DropDownList1" runat="server" CssClass="regfont" AutoPostBack="True" DataSourceID="CompIDSource" DataTextField="Name" DataValueField="Price" Width="198px">
                            </asp:DropDownList><asp:SqlDataSource ID="CompIDSource" runat="server" ConnectionString="<%$ ConnectionStrings:DorisShisaConnectionString3 %>"
                                SelectCommand="SELECT [ProductID], [Name], [Price] FROM [Products]" >
                                   
                                    
                  
                                </asp:SqlDataSource>
                               
                                <br />
                               
                               </td>
                        </tr>
     <tr>
                       <td class="auto-style1">

                    <asp:Button ID="btnAdd" runat="server" Text="Add to Cart" OnClick="btnAdd_Click" /></td>

            </tr>
  <tr>

                <td colspan="2">

                </td>

            </tr>

            <tr>

                <td colspan="2">

        <asp:GridView ID="GridView1"

  ShowFooter="True" DataKeyNames="ProductID"

  AutoGenerateColumns="False" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="528px">

<Columns>

<asp:BoundField DataField="ProductID" HeaderText="Product Id" />

<asp:BoundField DataField="Name" FooterText="Total" HeaderText="Product Name" />

<asp:TemplateField HeaderText="Price" FooterStyle-Font-Bold="True">

<ItemTemplate>

  <%# GetUnitPrice(decimal.Parse(Eval("Price").ToString())).ToString("N2") %>

</ItemTemplate>

<FooterTemplate>

  <%# GetTotal().ToString("N2") %>

</FooterTemplate>

<FooterStyle Font-Bold="True"></FooterStyle>

</asp:TemplateField>

  

</Columns>

            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />

</asp:GridView>

                </td>

            </tr>
     <tr><td>
       
			</td></tr>
     
     
     <tr>
                
                <td align:="right" style="font-size: small;" valign="top" class="style6">
                    Click to email order details:</td>
                <td style="width: 148px">
                    <asp:CheckBox ID="chkMailNotifyAdd" runat="server" 
                        oncheckedchanged="chkMailNotifyAdd_CheckedChanged" CssClass="Checkbox" />
                </td>
                <td>
                    
                </td>
            </tr>

   <tr><td></td>
       <td><asp:button ID="Button3" Text="View your orders"  runat="server" onclick="btnCheckout_Click" CssClass="Button" Height="49px" Width="154px"/></td>
   </tr>

              </table>              
          
        <p> 
                        <asp:Label ID="lblMailNotifyAdd" runat="server" CssClass="LblSuccess"></asp:Label>
            <asp:Label ID="lblMsg" runat="server" CssClass="Label" Font-Bold="True" 
                                    ForeColor="Green"></asp:Label></p>
					
			<p class="Msg">
                        
                        <br />
                    </p>			
                           

        &nbsp

               
       </div>     

    </div>

    </div>

  



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

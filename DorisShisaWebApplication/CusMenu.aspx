<%@ Page Title="" MaintainScrollPositionOnPostBack="true" Language="C#" MasterPageFile="~/CusMaster.Master" AutoEventWireup="true" CodeBehind="CusMenu.aspx.cs" Inherits="DorisShisaWebApplication.CusMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
		<div class="wrap">
       
<div id="main">
<h2 style="text-decoration: underline overline">OUR MENU</h2>
<h5 style="color: #000000">BREAKFAST</h5>
<table  ="100%"  style="width:100%;"  class="easy-table easy-table-cuscosky tablesorter">
<tbody>
<tr><td >Micro breakfast</td>
<td ><strong>R40</strong></td>
<td >with bacon/macon; tomato egg and toast</td><td>
    <asp:Button ID="cmdorder1" runat="server" Text="Order" OnClick="cmdorder1_Click" /></td>
</tr>

<tr><td >Farmstyle breakfast</td>
<td ><strong>R65</strong></td>
<td >with bacon/macon; tomato; mushrooms; steak; two eggs and toast</td><td>
    <asp:Button ID="cmdorder2" runat="server" Text="Order" OnClick="cmdorder2_Click" /></td>
</tr>

<tr><td >Southern style breakfast</td>
<td ><strong>R60</strong></td>
<td >with chourizo; cherry tomatoes; potato rosti; two eggs and toast</td><td>
    <asp:Button ID="cmdorder3" runat="server" Text="Order" OnClick="cmdorder3_Click" style="height: 26px" /></td>
</tr>

<tr><td >Egg Benedict</td>
<td ><strong>R60</strong></td>
<td >with ham/turkey/salmon/spinach; poached egg and hollandaise</td><td>
    <asp:Button ID="cmdorder4" runat="server" Text="Order" OnClick="cmdorder4_Click" /></td>
</tr>


<tr><td >Fresh fruit plate</td>
<td ><strong>R55</strong></td>
<td >with a bowl of yoghurt</td><td>
    <asp:Button ID="cmdorder5" runat="server" Text="Order" OnClick="cmdorder5_Click" /></td>
</tr>
<tr><td></td></tr>
<tr><td></td></tr>
<tr><td><h5 style="color: #000000">DESSERTS</h5></td></tr>

	
<tr><td >Cape Velvet Creme Brulee</td>
<td ><strong>R55</strong></td>
<td >buttermilk tuli and caramel brittle</td><td>
    <asp:Button ID="Button1" runat="server" Text="Order" OnClick="Button1_Click" /></td>
</tr>

<tr><td >Vanilla Panacotta</td>
<td ><strong>R55</strong></td>
<td >cherry; caramel vodka flamble and pistachio mousse</td><td>
    <asp:Button ID="Button2" runat="server" Text="Order" OnClick="Button2_Click" /></td>
</tr>

<tr><td >Chocolate Fondant</td>
<td ><strong>R65</strong></td>
<td >served with ice cream</td><td>
    <asp:Button ID="Button3" runat="server" Text="Order" OnClick="Button3_Click" /></td>
</tr>

<tr><td >Lindt Chocolate Bon-bons</td>
<td ><strong>R55</strong></td>
<td >amarula custard</td><td>
    <asp:Button ID="Button4" runat="server" Text="Order" OnClick="Button4_Click" /></td>
</tr>



<tr><td >Gluhwein Vanilla</td>
<td ><strong>R55</strong></td>
<td >poached pears</td><td>
    <asp:Button ID="Button5" runat="server" Text="Order" OnClick="Button5_Click" /></td>
</tr>
<tr><td></td></tr>
<tr><td><h5 style="color: #000000">SANDWICHES</h5></td></tr>


<tr><td >Moroccan falafel</td>
<td ><strong>R60</strong></td>
<td >harisa creme fraische; coriander; humus; tomato and gherkins</td><td>
    <asp:Button ID="Button6" runat="server" Text="Order" OnClick="Button6_Click" /></td>
</tr>

<tr><td >Sirloin pita</td>
<td ><strong>R65</strong></td>
<td >with sweet chilli; crispy potatoes and coriander</td><td>
    <asp:Button ID="Button7" runat="server" Text="Order" OnClick="Button7_Click" /></td>
</tr>

<tr><td >Tempura prawn wrap</td>
<td ><strong>R75</strong></td>
<td >with avo; crisp greens; Japanese mayo and sweet chilli</td><td>
    <asp:Button ID="Button8" runat="server" Text="Order" OnClick="Button8_Click" /></td>
</tr>

<tr><td >Fillet steak sandwich</td>
<td ><strong>R75</strong></td>
<td >with confit garlic and wholegrain mustard hollandaise and mushrooms</td><td>
    <asp:Button ID="Button9" runat="server" Text="Order" OnClick="Button9_Click" /></td>
</tr>

<tr><td >Beef or Chicken Portuguese prego</td>
<td ><strong>R75</strong></td>
<td >with garlic; red wine; bayleaf and olive oil</td><td>
    <asp:Button ID="Button10" runat="server" Text="Order" OnClick="Button10_Click" /></td>
</tr>
<tr><td></td></tr>
    <tr><td>
        <asp:Button ID="cmdvieworder" runat="server" Text="View your orders" OnClick="cmdvieworder_Click" Height="43px" Width="162px" /></td></tr>
</tbody></table>
</div>
</div>
</div>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

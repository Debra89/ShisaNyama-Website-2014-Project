<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DorisShisaWebApplication._Default" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="wrap">
    <!-- main -->
			<div id="main">
				<div id="intro">
					<h2>Welcome</h2>
<p>This is the best Sishanyama in Johannesburg located in Claim street Joubert park we offer the best food starting with our <a href = "breakfast.aspx" >breakfast</a>  our top prestige Menu includes <a href =" sandwiches.aspx">Sandwiches</a>,
<a href=" breakfast.aspx">Breakfast</a>, <a href =" desserts.aspx">Desserts</a>. Here best food never ends the best is always served from morning till late.
</p>
				</div>
			
				<!-- bits -->
				<div id="bits">
					<div class="bit">
						<h3><span>New Breakfast introduced this month.</span></h3>
						<div class="photo">
							<a href="#approach"><img src="images/breakfast12.jpg" alt="thumb" height="70" width="203" /></a>
						</div>
						
						<div id="approach">
							<img src="images/breakfast12.jpg" alt="Approach" height="300" width="500" />
						</div>
					
						<h5 class="more"><a href="Register.aspx"><i>subscribe for our promotions notifications</i></a></></h5>
						
					</div>
					<div class="bit">
						<h3><span>Sandwiches on sale this weekend</span></h3>
						<div class="photo">
							<a href="#methods"><img src="images/sandwiches2.png" alt="Thumb" height="70" width="203" /></a>
						</div>
						<div id="methods">
							<img src="images/sandwiches2.png" alt="Methods" height="300" width="500" />
						</div>
						<h5 class="more"><a href="Register.aspx"><i>subscribe for our promotions notifications</i></a></></h5>
						<div>
							
						</div>
					</div>
					<div class="bit last">
						<h3><span>New months means new food for Doris shisanyama</span></h3>
						<div class="photo">
							<a href="#results"><img src="images/desserts7.jpg" alt="Thumb" width="203" height="70" /></a>
						</div>
						<div id="results">
							<img src="images/desserts7.jpg" alt="Results" height="300" width="500" />
						</div>
						<h5 class="more"><a href="Register.aspx"><i>subscribe for our promotions notifications</i></a></></h5>
						<div>
							
						</div>
					</div>
					<div class="clear"></div>
				</div>
				<!-- /bits -->
		
			</div>
			<!-- /main -->
			

	</div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>

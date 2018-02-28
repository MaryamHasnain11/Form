<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Forms.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

		<center>
       
			<p>
				&nbsp;</p>
			<p>
			Username:&nbsp;
			<asp:TextBox ID="TextBox1" runat="server" required ></asp:TextBox>
		</p>
			<p>
				&nbsp;</p>
		<p>
			Password:&nbsp;
			<asp:TextBox ID="TextBox2"   TextMode="Password" runat="server" required></asp:TextBox>
		</p>
			<p>
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:ImageButton ImageUrl="images/login1.png" ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" Height="47px" Width="138px" />
			</p>
			
			<p>
				&nbsp;</p>
			<p>
				&nbsp;</p>
			<p>
				&nbsp;</p>
			<p>
				&nbsp;</p>

		</center>
        <div>
        </div>
    </form>
</body>
</html>

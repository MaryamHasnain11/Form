<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OnlineForm.aspx.cs" Inherits="Forms.OnlineForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	First Name<br />
			<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" ></asp:TextBox>
			<br />
			<br />
			Last Name<br />
			<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
			<br />
			<br />
			Email<br />
			<asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
			<br />
			<br />
			Country<br />
			<br />
			<asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
			<br />
			<br />
			
			Gender<br />
<asp:RadioButtonList ID="rb" runat="server" RepeatLayout="Flow" OnSelectedIndexChanged="rb_SelectedIndexChanged">
    <asp:ListItem Value="Male">Male</asp:ListItem>
    <asp:ListItem Value="Female">Female</asp:ListItem>
</asp:RadioButtonList>
        	<br />
		
        	<br />
			<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
		
        </div>
    </form>
</body>
</html>

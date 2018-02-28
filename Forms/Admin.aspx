<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Forms.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	First Name:
			<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
			<br />
			Last Name:
			<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    	<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" />
        </div>
<asp:GridView ID="GridView2" runat="server" Caption="Records Shown Below" CaptionAlign="Left" CellPadding="4" EmptyDataText="NO RESULTS FOUND!" ForeColor="Black" GridLines="Vertical" ShowHeaderWhenEmpty="True" style="margin-left: 10px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px">
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle BackColor="#CCCC99" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#F7F7DE" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                </asp:GridView>
    </form>
</body>
</html>

using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Forms
{
	public partial class OnlineForm : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			String fName = TextBox1.Text.ToString();
			String lName = TextBox2.Text.ToString();
			String email = TextBox3.Text.ToString();
			String country = TextBox4.Text.ToString();

			OleDbConnection conn = new OleDbConnection();
			//Use a string variable to hold the ConnectionString.
			conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\cms2\\Forms\\App_Data\\Database2.accdb";





			//new
			String query = @"INSERT INTO Users (FirstName,LastName,Username,Pasword) VALUES(@fName,@lname,@userName,@pasword)";
			System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, conn);
			cmd.Parameters.AddWithValue("@fName", fName);
			cmd.Parameters.AddWithValue("@lName", lName);
			cmd.Parameters.AddWithValue("@userName", userName);
			cmd.Parameters.AddWithValue("@pasword", pasword);

			conn.Open();




			cmd.ExecuteNonQuery();
			Response.Write("<script>alert('Registration successful');</script>");
		}
	}
}
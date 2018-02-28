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
			string gender = rb.SelectedItem.Value.ToString();
			OleDbConnection conn = new OleDbConnection();
			//Use a string variable to hold the ConnectionString.
			conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\Form\\Forms\\App_Data\\Database3.accdb";





			//new
			String query = @"INSERT INTO Users (FirstName,LastName,Email,Country,Gender) VALUES(@fName,@lname,@email,@country,@gender)";
			System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(query, conn);
			cmd.Parameters.AddWithValue("@fName", fName);
			cmd.Parameters.AddWithValue("@lName", lName);
			cmd.Parameters.AddWithValue("@email", email);
			cmd.Parameters.AddWithValue("@country", country);
			cmd.Parameters.AddWithValue("@gender", gender);

			conn.Open();




			cmd.ExecuteNonQuery();
			Response.Write("<script>alert('Form Successfully Submitted');</script>");
		}

		protected void TextBox2_TextChanged(object sender, EventArgs e)
		{

		}

		protected void TextBox3_TextChanged(object sender, EventArgs e)
		{

		}

		protected void TextBox4_TextChanged(object sender, EventArgs e)
		{

		}

		protected void rb_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Forms
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
		{
			string userName = TextBox1.Text.ToString();

			String pasword = TextBox2.Text.ToString();
			System.Data.OleDb.OleDbConnection con = new OleDbConnection();
			//Use a string variable to hold the ConnectionString.
			con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
			+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\Form\\Forms\\App_Data\\Database3.accdb";
			string query = @"select count(*) from Admin where Username=@userName and Pasword = @pasword;";
			OleDbCommand cmd = new OleDbCommand(query, con);
			String b_id = null;
			con.Open();
			cmd.Parameters.AddWithValue("@userName", TextBox1.Text);
			cmd.Parameters.AddWithValue("@pasword", TextBox2.Text);
			int result = (int)cmd.ExecuteScalar();
			query = @"select ID from Admin where Username=@userName and Pasword = @pasword;";
			cmd = new OleDbCommand(query, con);


			cmd.Parameters.AddWithValue("@userName", TextBox1.Text);
			cmd.Parameters.AddWithValue("@pasword", TextBox2.Text);
			
			if (result > 0)
			{
				if (userName == "Mana")
				{
					Response.Redirect("Admin.aspx");
					Response.Write("<script>alert('Login successful.');</script>");

				}
				
				
				//Response.Write("<script>alert('Login successful.');</script>");
			
			}

			else
			{
				Response.Write("<script>alert('login not successful.  Please enter your details again.');</script>");
			}


			con.Close();
		}
	}
}
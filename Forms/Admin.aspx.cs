using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Forms
{
	public partial class Admin : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		

		}

		protected void grid1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{

			String fname= TextBox1.Text.ToString();

			String lname = TextBox2.Text.ToString();
			OleDbConnection con = new OleDbConnection();
			con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
	+ "Data Source=C:\\Users\\Intag\\Documents\\GitHub\\Form\\Forms\\App_Data\\Database3.accdb";
			con.Open();
			string selectString = " SELECT FirstName,LastName,Email,Country,Gender FROM [Users] where ([FirstName] like '%'+ @fname + '%') AND LastName=@lname";
			OleDbCommand cmd = new OleDbCommand(selectString, con);
			

			//MessageBox.Show(txtMyDate.ToString("M/dd/yyyy"));
			cmd.Parameters.AddWithValue("@fname", fname);
			cmd.Parameters.AddWithValue("@lname",lname);


			cmd.Connection = con;
			foreach (DataGridViewColumn column in GridView2.Columns)
				column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			GridView2.AutoGenerateColumns = true;

			DataTable results = new DataTable();
			GridView2.AutoGenerateColumns = true;


			results.Load(cmd.ExecuteReader());
			GridView2.DataSource = results;
			GridView2.DataBind();
			OleDbDataReader dr = cmd.ExecuteReader();

		}

		protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
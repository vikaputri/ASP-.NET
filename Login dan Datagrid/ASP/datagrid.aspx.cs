using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class datagrid1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection v = new SqlConnection(ConfigurationManager.ConnectionStrings["Database1"].ConnectionString);
            v.Open();
            string cekNpm = "SELECT COUNT(*) FROM [Table] WHERE NPM='" + TextBox3.Text + "'";
            SqlCommand query = new SqlCommand(cekNpm, v);
            int jumlah = Convert.ToInt32(query.ExecuteScalar().ToString());
            v.Close();
            if (jumlah != 0)
            {
                Response.Write("NPM sudah digunakan");
                TextBox3.Text = null;
                TextBox1.Text = null;
                TextBox2.Text = null;
                TextBox4.Text = null;
                TextBox5.Text = null;
            }
            else
            {
                v.Open();
                string insert = "INSERT INTO [Table] (npm,nama,kelas,jurusan,fakultas) VALUES (@NPM, @Nama, @Kelas, @Jurusan, @Fakultas)";
                SqlCommand insertquery = new SqlCommand(insert, v);
                insertquery.Parameters.AddWithValue("@NPM", TextBox3.Text);
                insertquery.Parameters.AddWithValue("@Nama", TextBox1.Text);
                insertquery.Parameters.AddWithValue("@Kelas", TextBox2.Text);
                insertquery.Parameters.AddWithValue("@Jurusan", TextBox4.Text);
                insertquery.Parameters.AddWithValue("@Fakultas", TextBox5.Text);
                insertquery.ExecuteNonQuery();
                GridView1.DataBind();
                v.Close();

                TextBox3.Text = null;
                TextBox1.Text = null;
                TextBox2.Text = null;
                TextBox4.Text = null;
                TextBox5.Text = null;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}
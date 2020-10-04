using System;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication4
{
    public partial class registrasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text= "";
            TextBox3.Text = "";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection v = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            v.Open();
            string cekuser = "SELECT COUNT(*) FROM [Table] WHERE username = '" + TextBox1.Text + "'";
            SqlCommand query = new SqlCommand(cekuser, v);
            int jumlah = Convert.ToInt32(query.ExecuteScalar().ToString());
            v.Close();
            if (jumlah == 1)
            {
                v.Open();
                string passwordsql = "SELECT password FROM [Table] WHERE username = '" + TextBox1.Text + "'";
                SqlCommand passquery = new SqlCommand(passwordsql, v);
                string password = passquery.ExecuteScalar().ToString();
                v.Close();
                if (password == TextBox3.Text);
                {
                    Response.Redirect("datagrid.aspx");
                }
            }
            else
                {
                    Label4.Text = "Your username and password is incorrect";
                }
            }
        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
    }
    }
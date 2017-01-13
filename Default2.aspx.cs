using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;




public partial class Default2 : System.Web.UI.Page
{
    SqlConnection sc;
    SqlCommand cmd;
    SqlDataReader dr;
    String con;

    protected void Page_Load(object sender, EventArgs e)
    {
        con = ConfigurationManager.ConnectionStrings["conn"].ToString();
        sc = new SqlConnection(con);

  
    }
    private SqlDataReader bind(string query)
    {
        sc.Open();
        cmd = new SqlCommand(query, sc);
        dr = cmd.ExecuteReader();
        
       
      
        return dr;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(TextBox1.Text))
        {
            GridView1.Visible = false;
            Label2.Visible = true;
            Label2.Text = "The Employee ID" + TextBox1.Text + " is invalid";

        }
        else
        {
            string query = "SELECT * FROM Record where Emp_ID like '" + TextBox1.Text + "%'";
            SqlDataReader dr = bind(query);

            if (dr.HasRows)
            {
                dr.Read();


                GridView1.Visible = true;
                TextBox1.Text = "";
                Label2.Text = "";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();


            }
          
            else
            {
                GridView1.Visible = false;
                Label2.Visible = true;
                Label2.Text = "The Employee ID : " + TextBox1.Text + " is invalid";
            }
        }


        
        sc.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
}
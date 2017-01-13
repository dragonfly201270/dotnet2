using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.ComponentModel;
using System.Drawing;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;



using System.Text;

using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //insert
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(TextBox2.Text) || String.IsNullOrEmpty(TextBox3.Text) || String.IsNullOrEmpty(TextBox4.Text) || String.IsNullOrEmpty(TextBox5.Text))
        {

            Label5.Text = "Data not filled";
        }
        else
        {

           

            string conn = "";

            conn = ConfigurationManager.ConnectionStrings["conn"].ToString();

            SqlConnection objsqlconn = new SqlConnection(conn);

            objsqlconn.Open();

//         "INSERT INTO Groups 
//VALUES ('" + tb2.Text + "')
//WHERE NOT EXISTS (SELECT (1) FROM Groups WHERE columnName = '" + tb2.Text + "' )"

            SqlCommand objcmd = new SqlCommand("Insert into Record(First_Name,Last_Name,Address,City) Values('" + TextBox2.Text + "','"  + TextBox5.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')", objsqlconn);
       
           

            objcmd.ExecuteNonQuery();


            Response.Redirect("Default3.aspx");
            

        }


    }
    

//    //update
//    protected void Button2_Click(object sender, EventArgs e)
//    {
//        if (String.IsNullOrEmpty(TextBox2.Text) || String.IsNullOrEmpty(TextBox3.Text) || String.IsNullOrEmpty(TextBox4.Text))
//        {
//            Label5.Text = "Data not filled";

//        }
//        else
//        {


//            string conn = "";

//            conn = ConfigurationManager.ConnectionStrings["conn"].ToString();
//            SqlConnection objsqlconn = new SqlConnection(conn);

//            objsqlconn.Open();

//            SqlCommand objcmd = new SqlCommand("Update Record set Name='" + TextBox2.Text + "',Address='" + TextBox3.Text + "',City='" + TextBox4.Text + "' where Name='" + TextBox2.Text + "'", objsqlconn);
//            //  TextBox5.Text = "Record updated successfully";


//            objcmd.ExecuteNonQuery();

//            Response.Redirect(Request.RawUrl);

//        }


//    }


//    //delete
//    protected void Button3_Click(object sender, EventArgs e)
//    {

//        string conn = "";

//        conn = ConfigurationManager.ConnectionStrings["Conn"].ToString();

//        SqlConnection objsqlconn = new SqlConnection(conn);

//        objsqlconn.Open();

//        SqlCommand objcmd = new SqlCommand("Delete from Record Where Name='" + TextBox2.Text + "'", objsqlconn);

//        objcmd.ExecuteNonQuery();
//        Response.Redirect(Request.RawUrl);


//    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("default2.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("default3.aspx");
    }
}
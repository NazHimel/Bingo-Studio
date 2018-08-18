using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class contactus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnSave_Click(object sender, EventArgs e)
    {
        string strConn = "Data Source=manwarul-pc\\SQLEXPRESS;Initial Catalog=bingostudio;Integrated Security=True;Pooling=False";
        SqlConnection conn = new SqlConnection(strConn);
        conn.Open();

        string strCommand = "insert into CONTACTUS values(@name, @email, @subject, @message)";
        SqlCommand com = new SqlCommand(strCommand, conn);
        com.Parameters.AddWithValue("@name", txtName.Text);
        com.Parameters.AddWithValue("@email", txtemail.Text);
        com.Parameters.AddWithValue("@subject", txtsubject.Text);
        com.Parameters.AddWithValue("@message", txtmsg.Text);
        com.ExecuteNonQuery();

        conn.Close();
    }

}
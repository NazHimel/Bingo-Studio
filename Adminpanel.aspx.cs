using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Adminpanel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void delete_Click(object sender, EventArgs e)
    {

        string strConn = "Data Source=manwarul-pc\\SQLEXPRESS;Initial Catalog=bingostudio;Integrated Security=True;Pooling=False";
        SqlConnection conn = new SqlConnection(strConn);
        conn.Open();

        string strCommand = "delete from CONTACTUS where contactId='" + DropDownList1.SelectedItem + "'";
        SqlCommand com = new SqlCommand(strCommand, conn);
        com.ExecuteNonQuery();

        conn.Close();
    }
}
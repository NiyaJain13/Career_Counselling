using System.Data;
using System.Data.SqlClient;

namespace Career_Counselling.Models
{
    public class AdminRegDB
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-IA0SOGT\SQLEXPRESS;database=CareerCounsellingApp;Integrated security=true");

        public string InsertDB(AdminReg objcls)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_admininsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@admin_name", objcls.admin_name);
                cmd.Parameters.AddWithValue("@admin_email", objcls.admin_email);
                cmd.Parameters.AddWithValue("@admin_username", objcls.admin_username);
                cmd.Parameters.AddWithValue("@admin_password", objcls.admin_password);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Inserted successfully to Admin table");

            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return ex.Message.ToString();
            }

        }

    }
}


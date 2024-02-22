using System.Data;
using System.Data.SqlClient;


namespace Career_Counselling.Models
{
    public class CollegeRegDB
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-IA0SOGT\SQLEXPRESS;database=CareerCounsellingApp;Integrated security=true");

        public string InsertDB(CollegeReg objcls)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_collegeinsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@college_name", objcls.college_name);
                cmd.Parameters.AddWithValue("@college_description", objcls.college_description);
                cmd.Parameters.AddWithValue("@college_location", objcls.college_location);
                cmd.Parameters.AddWithValue("@college_email", objcls.college_email);
                cmd.Parameters.AddWithValue("@college_phone", objcls.college_phone);
                cmd.Parameters.AddWithValue("@college_username", objcls.college_username);
                cmd.Parameters.AddWithValue("@college_password", objcls.college_password);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Inserted successfully to College table");

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

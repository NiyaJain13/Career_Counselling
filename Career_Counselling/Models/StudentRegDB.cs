using System.Data;
using System.Data.SqlClient;


namespace Career_Counselling.Models
{
    public class StudentRegDB
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-IA0SOGT\SQLEXPRESS;database=CareerCounsellingApp;Integrated security=true");

        public string InsertDB(StudentReg objcls)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_studentinsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@student_name", objcls.student_name);
                cmd.Parameters.AddWithValue("@student_email", objcls.student_email);
                cmd.Parameters.AddWithValue("@student_phone", objcls.student_phone);
                cmd.Parameters.AddWithValue("@student_username", objcls.student_username);
                cmd.Parameters.AddWithValue("@student_password", objcls.student_password);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Inserted successfully to Student table");

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

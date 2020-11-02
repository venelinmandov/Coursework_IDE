using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Coursework_IDE
{
    class ConnectionManager
    {
        String connStr;
        public ConnectionManager()
        {
            connStr = ConfigurationManager.ConnectionStrings["DoctorDB"].ConnectionString;
        }


        public void RegisterDoctor(Doctor doctor)
        {
            String query = @"INSERT INTO doctors (first_name, middle_name, last_name, egn, sex, spec)
                     VALUES(@FName, @MName, @LName, @EGN, @SEX, @Spec); ";


            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FName", doctor.firstName);
                cmd.Parameters.AddWithValue("@MName", doctor.middleName);
                cmd.Parameters.AddWithValue("@LName", doctor.lastName);
                cmd.Parameters.AddWithValue("@EGN", doctor.egn);
                cmd.Parameters.AddWithValue("@SEX", doctor.sex);
                cmd.Parameters.AddWithValue("@Spec", doctor.spec);


                conn.Open();
                cmd.ExecuteNonQuery();
            }


        }
    }
}

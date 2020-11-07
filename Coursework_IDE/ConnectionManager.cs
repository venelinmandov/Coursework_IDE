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


         //Doctor
        public void RegisterDoctor(Doctor doctor)
        {
            String query = @"INSERT INTO doctors (first_name, middle_name, last_name, egn, sex, spec)
                            VALUES(@FName, @MName, @LName, @EGN, @SEX, @Spec)";


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

        public Doctor GetDoctor(String EGN)
        {
            Doctor doctor = new Doctor();
            String query = "SELECT * from doctors where egn = @egn";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@egn", EGN);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                

                doctor.id = reader.GetInt32(0);
                doctor.firstName = reader.GetString(1);
                doctor.middleName = reader.GetString(2);
                doctor.lastName = reader.GetString(3);
                doctor.egn = reader.GetString(4);
                doctor.sex = reader.GetString(5);
                doctor.spec = reader.GetString(5);
            }
            return doctor;
        }

        //Patient


        public void RegisterPatient(Patient patient)
        {
            String query = @"INSERT INTO patients (first_name, middle_name, last_name, egn, sex, birthday)
                            VALUES (@FName, @MName, @LName, @egn, @sex, @birthday)";

            using (SqlConnection conn = new SqlConnection())
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FName", patient.firstName);
                cmd.Parameters.AddWithValue("@MName", patient.middleName);
                cmd.Parameters.AddWithValue("@LName", patient.lastName);
                cmd.Parameters.AddWithValue("@egn", patient.egn);
                cmd.Parameters.AddWithValue("@sex", patient.sex);
                cmd.Parameters.AddWithValue("@birthday", patient.birthday);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Patient GetPatient(int id)
        {
            String query = @"SELECT * FROM patients
                            WHERE patient_id = @id";

            Patient patient = new Patient();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                patient.id = reader.GetInt32(0);
                patient.firstName = reader.GetString(1);
                patient.middleName = reader.GetString(2);
                patient.lastName = reader.GetString(3);
                patient.egn = reader.GetString(4);
                patient.sex = reader.GetString(5);
                patient.birthday = reader.GetDateTime(6);
            }
            return patient;

     
        }


        //Appointment
        public List<Appointment> GetAppointments(DateTime date, int doctorID)
        {
            String query = @"SELECT * FROM appointments
                            WHERE doctor_id = @docId AND CAST (date AS DATE) = @date";
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@docId", doctorID);
                cmd.Parameters.AddWithValue("@date", date.Date);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    appointments.Add(new Appointment());
                    appointments[appointments.Count - 1].id = reader.GetInt32(0);
                    appointments[appointments.Count - 1].patientId = reader.GetInt32(1);
                    appointments[appointments.Count - 1].doctorId = reader.GetInt32(2);
                    appointments[appointments.Count - 1].date = reader.GetDateTime(3);
                }



            }

            return appointments;
        }


    }
}

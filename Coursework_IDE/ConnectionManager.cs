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
        string connStr;
        public ConnectionManager()
        {
            connStr = ConfigurationManager.ConnectionStrings["DoctorDB"].ConnectionString;
        }


        //Doctor
        public void RegisterDoctor(Doctor doctor)
        {
            string query = @"INSERT INTO doctors (first_name, middle_name, last_name, egn, sex, spec)
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



        public Doctor GetDoctor(string EGN)
        {
            Doctor doctor = new Doctor();
            string query = "SELECT * from doctors where egn = @egn";
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
            string query = @"INSERT INTO patients (first_name, middle_name, last_name, egn, sex, birthday)
                            VALUES (@FName, @MName, @LName, @egn, @sex, @birthday)";

            using (SqlConnection conn = new SqlConnection(connStr))
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

        public List<Patient> GetPatients()
        {
            string query = "SELECT * FROM patients";

            List<Patient> patients = new List<Patient>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    patients.Add(new Patient());
                    patients[patients.Count - 1].id = reader.GetInt32(0);
                    patients[patients.Count - 1].firstName = reader.GetString(1);
                    patients[patients.Count - 1].middleName = reader.GetString(2);
                    patients[patients.Count - 1].lastName = reader.GetString(3);
                    patients[patients.Count - 1].egn = reader.GetString(4);
                    patients[patients.Count - 1].sex = reader.GetString(5);
                    patients[patients.Count - 1].birthday = reader.GetDateTime(6);

                }

            }
            return patients;
        }


        public Patient GetPatient(int id)
        {
            string query = @"SELECT * FROM patients
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

        public void NewApointment(Appointment appointment)
        {
            string query = @"INSERT INTO appointments (patient_id, doctor_id, date)
                    VALUES (@pID, @dID, @Date)";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pID", appointment.patientId);
                cmd.Parameters.AddWithValue("@dID", appointment.doctorId);
                cmd.Parameters.AddWithValue("@Date", appointment.date);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveAppointment(Appointment appointment)
        {
            string[] query = { "DELETE FROM appointment_medicine WHERE appointment_id = @id",
                                "DELETE FROM appointments WHERE appointment_id = @id" };
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd;
                conn.Open();
                for (int i = 0; i < 2; i++)
                {
                    cmd = new SqlCommand(query[i], conn);
                    cmd.Parameters.AddWithValue("@id", appointment.id);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public List<Appointment> GetAppointments(DateTime date, int doctorID)
        {
            string query = @"SELECT * FROM appointments
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
                    if (!reader.IsDBNull(4))
                        appointments[appointments.Count - 1].diagnosis = reader.GetString(4);
                    else
                        appointments[appointments.Count - 1].diagnosis = null;
                }
            }
            return appointments;
        }

        public List<Appointment> GetAppointementsInLast30Days(Patient patient)
        {
            string query = @"SELECT appointment_id, patient_id, doctor_id, date, diagnosis FROM appointments
                             WHERE DATEDIFF(day, appointments.date,GETDATE()) BETWEEN 0 AND 30 AND appointments.patient_id = @pId AND diagnosis IS NOT NULL;";
            List<Appointment> appointments = new List<Appointment>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pId", patient.id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    appointments.Add(new Appointment());
                    appointments[appointments.Count - 1].id = reader.GetInt32(0);
                    appointments[appointments.Count - 1].patientId = reader.GetInt32(1);
                    appointments[appointments.Count - 1].doctorId = reader.GetInt32(2);
                    appointments[appointments.Count - 1].date = reader.GetDateTime(3);
                    appointments[appointments.Count - 1].diagnosis = reader.GetString(4);

                }
            }
            return appointments;
        }

        public void ChangeAppointment(Appointment appointment)
        {
            string query = @"UPDATE appointments SET patient_Id = @pID, diagnosis = @diag
                           WHERE appointment_id = @aID";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@pID", appointment.patientId);
                cmd.Parameters.AddWithValue("@aID", appointment.id);
                if(appointment.diagnosis == null)
                    cmd.Parameters.AddWithValue("@diag", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@diag", appointment.diagnosis);
                conn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        //Medicine

        public List<Medicine> GetMedication()
        {
            string query = "SELECT * FROM medicines";
            List<Medicine> medicines = new List<Medicine>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    medicines.Add(new Medicine());

                    medicines[medicines.Count - 1].id = reader.GetInt32(0);
                    medicines[medicines.Count - 1].name = reader.GetString(1);
                }
            }

            return medicines;
            
        }

        public List<Medicine> GetMedicationByAppointment(int AppId)
        {
            string query = @"SELECT appointment_medicine.medicine_id, medicines.name FROM appointment_medicine
                            LEFT JOIN medicines ON medicines.medicine_id = appointment_medicine.medicine_id
                            WHERE appointment_medicine.appointment_id = @aID";
            List<Medicine> medicines = new List<Medicine>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@aID", AppId);


                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    medicines.Add(new Medicine());

                    medicines[medicines.Count - 1].id = reader.GetInt32(0);
                    medicines[medicines.Count - 1].name = reader.GetString(1);
                }
            }

            return medicines;

        }

        //Appointment-Medicine

        public void AddMedicine(Appointment appointment, Medicine medicine)
        {
            string query = @"INSERT INTO appointment_medicine (medicine_id, appointment_id)
                            VALUES (@mID, @aID)";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mID", medicine.id);
                cmd.Parameters.AddWithValue("@aID", appointment.id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveMedicine(Appointment appointment, Medicine medicine)
        {
            string query = @"DELETE FROM appointment_medicine
                            WHERE medicine_id = @mID AND appointment_id = @aID";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mID", medicine.id);
                cmd.Parameters.AddWithValue("@aID", appointment.id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}

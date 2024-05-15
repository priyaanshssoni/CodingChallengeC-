using System;
using System.Runtime.ConstrainedExecution;
using CareerHub.Model;
using Microsoft.Data.SqlClient;

namespace CareerHub.Repository
{
	public class JobListingRepo :iJobListingRepo
	{

        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;



        public JobListingRepo()
		{
            sqlConnection = new SqlConnection("Server=localhost;Database=CareerHub;User Id=sa;Password=reallyStrongPwd123;TrustServerCertificate=True");
           // sqlConnection = new SqlConnection(PropertyUtil.GetConnectionString());
            cmd = new SqlCommand();
        }




        public int Apply(JobApplication app)
        {
            //clearing paramateres
            //cmd.Parameters.Clear()
            cmd.CommandText = "INSERT INTO Applications VALUES(@jobid,@applicantid,@applicationdate,@coverletter)";
            cmd.Parameters.AddWithValue("@jobid", app.JobID);
            cmd.Parameters.AddWithValue("@applicantid", app.ApplicantID);
            cmd.Parameters.AddWithValue("@applicationdate", app.ApplicationDate);
            cmd.Parameters.AddWithValue("@coverletter",app.CoverLetter);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int jobstatus = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return jobstatus;

        }

        public List<Applicant> GetApplicants(JobApplication jobs)
        {

            List<Applicant> applicant = new List<Applicant>();
            cmd.CommandText = "SELECT * FROM Applications ap JOIN Applicants app ON  ap.ApplicantID=app.ApplicantID WHERE JobID = @jid";
            cmd.Parameters.AddWithValue("@jid",jobs.JobID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Applicant App = new Applicant();
                App.ApplicantID = (int)reader["ApplicantID"];
                App.FirstName = (string)reader["FirstName"];
                App.LastName = (string)reader["LastName"];

                applicant.Add(App);
            }
            sqlConnection.Close();
            return applicant;
        }
    }
}


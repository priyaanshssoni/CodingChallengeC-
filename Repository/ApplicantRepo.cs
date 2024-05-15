using System;
using CareerHub.Model;
using Microsoft.Data.SqlClient;

namespace CareerHub.Repository
{
	public class ApplicantRepo :iApplicantRepo
	{

        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;



    
            
            public ApplicantRepo()
		    {
                sqlConnection = new SqlConnection("Server=localhost;Database=CareerHub;User Id=sa;Password=reallyStrongPwd123;TrustServerCertificate=True");
                // sqlConnection = new SqlConnection(PropertyUtil.GetConnectionString());
                cmd = new SqlCommand();
            }

        public int ApplyForJob(Applicant app, JobListing job)
        {
            //clearing paramateres
            //cmd.Parameters.Clear()
            cmd.CommandText = "INSERT INTO Applications(JobID,ApplicantID,ApplicationDate,CoverLetter) VALUES(@jobid,@applicantid,@applicationdate,@coverletter)";
            cmd.Parameters.AddWithValue("@jobid", job.JobID);
            cmd.Parameters.AddWithValue("@applicantid", app.ApplicantID);
            cmd.Parameters.AddWithValue("@applicationdate",DateTime.Now);
            cmd.Parameters.AddWithValue("@coverletter", app.CoverLetter);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int appstatus = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return appstatus;
        }

        public int CreateProfile(string email, string firstName, string lastName, string phone)
        {
            cmd.CommandText = "INSERT INTO Applicants(FirstName,LastName,Email,Phone) VALUES(@FirstName,@LastName,@Email,@Phone)";
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int status = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return status;
        }
    }
}


using System;
using CareerHub.Model;
using Microsoft.Data.SqlClient;

namespace CareerHub.Repository
{
	public class CompanyRepo :iCompanyRepo
	{

        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;


            public CompanyRepo()
		    {
                sqlConnection = new SqlConnection("Server=localhost;Database=CareerHub;User Id=sa;Password=reallyStrongPwd123;TrustServerCertificate=True");
                // sqlConnection = new SqlConnection(PropertyUtil.GetConnectionString());
                cmd = new SqlCommand();
            }

        public List<JobListing> GetJobs(Company comp)
        {
            List<JobListing> Jobs = new List<JobListing>();
            cmd.CommandText = "SELECT * FROM Jobs WHERE CompanyID = @compid";
            cmd.Parameters.AddWithValue("@compid", comp.CompanyID);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                 JobListing newjobs = new JobListing();
                newjobs.JobTitle = (string)reader["JobTitle"];
                newjobs.JobDescription = (string)reader["JobDescription"];
                newjobs.JobType = (string)reader["JobType"];
                newjobs.JobLocation = (string)reader["JobLocation"];
                newjobs.Salary = (decimal)reader["Salary"];
                newjobs.PostedDate = (DateTime)reader["PostedDate"];

                Jobs.Add(newjobs);
            }
            sqlConnection.Close();
            return Jobs;
        }


        public int PostJob(JobListing job)
        {
            //clearing paramateres
            //cmd.Parameters.Clear()
            cmd.CommandText = "INSERT INTO Jobs VALUES(@CompanyID,@JobTitle,@JobDescription,@JobLocation,@Salary,@JobType,@PostedDate)";
            cmd.Parameters.AddWithValue("@CompanyID", job.CompanyID);
            cmd.Parameters.AddWithValue("@JobTitle", job.JobTitle);
            cmd.Parameters.AddWithValue("@JobDescription", job.JobDescription);
            cmd.Parameters.AddWithValue("@JobLocation", job.JobLocation);
            cmd.Parameters.AddWithValue("@Salary", job.Salary);
            cmd.Parameters.AddWithValue("@JobType", job.JobType);
            cmd.Parameters.AddWithValue("@PostedDate", job.PostedDate);

            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int post = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return post;
        }



    }
}


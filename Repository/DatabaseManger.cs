using System;
using CareerHub.Model;
using Microsoft.Data.SqlClient;

namespace CareerHub.Repository
{
	public class DatabaseManger : iDatabaseManager
	{

        SqlConnection sqlConnection = null;
        SqlCommand cmd = null;





        public DatabaseManger()
        {
            sqlConnection = new SqlConnection("Server=localhost;Database=CareerHub;User Id=sa;Password=reallyStrongPwd123;TrustServerCertificate=True");
            // sqlConnection = new SqlConnection(PropertyUtil.GetConnectionString());
            cmd = new SqlCommand();
        }



        public int InsertCompany(Company company)
        {
            cmd.CommandText = "INSERT INTO Company(CompanyName,Location) VALUES(@CName,@Loca)";
            cmd.Parameters.AddWithValue("@CName", company.CompanyName);
            cmd.Parameters.AddWithValue("@Loca", company.Location);
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int status = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return status;
        }

        public List<JobListing> GetJobs()
        {
            List<JobListing> Jobs = new List<JobListing>();
            cmd.CommandText = "SELECT * FROM Jobs ";
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
                newjobs.Salary = (int)reader["Salary"];
                newjobs.PostedDate = (DateTime)reader["PostedDate"];
                newjobs.CompanyID = (int)reader["CompanyID"];

                Jobs.Add(newjobs);
            }
            sqlConnection.Close();
            return Jobs;
        }

        public List<Company> GetCompany( )
        {
            List<Company> Comp = new List<Company>();
            cmd.CommandText = "SELECT * FROM Company ";
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Company cmopp = new Company();
                cmopp.CompanyID = (int)reader["CompanyID"];
                cmopp.CompanyName = (string)reader["CompanyName"];
                cmopp.Location = (string)reader["Location"];

                Comp.Add(cmopp);
            }
            sqlConnection.Close();
            return Comp;
        }

        public List<Applicant> GetApplicants()
        {
            List<Applicant> Appli = new List<Applicant>();
            cmd.CommandText = "SELECT * FROM Applicants ";
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Applicant app = new Applicant();
                app.ApplicantID = (int)reader["ApplicantID"];
                app.FirstName = (string)reader["FirstName"];
                app.LastName = (string)reader["LastName"];
                app.Phone = (string)reader["Phone"];


                Appli.Add(app);
            }
            sqlConnection.Close();
            return Appli;
        }

        public int SalaryCalc()
        {
            cmd.CommandText = "SELECT AVG(Salary) AS AverageSalary FROM Jobs WHERE Salary";
            cmd.Connection = sqlConnection;
            sqlConnection.Open();
            int avgsal = Convert.ToInt32(cmd.ExecuteScalar());
            sqlConnection.Close();

            return 1;
        }







    }
}


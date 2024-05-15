using System;
using System.Runtime.ConstrainedExecution;
using CareerHub.Model;
using CareerHub.Repository;

namespace CareerHub.Service
{
	public class CompanyRepoService : iCompanyRepoService
	{
		public CompanyRepoService()
		{
            _comprepo = new CompanyRepo();
		}

        readonly iCompanyRepo _comprepo;
        DatabaseManagerService data = new DatabaseManagerService();

        public void GetJobs()
        {
            
            Company cc = new Company();
            Console.WriteLine("Which Company You Would Like Get Jobs For?");
            
            Console.WriteLine("Write Company Id ?");
            cc.CompanyID = int.Parse(Console.ReadLine());

            List<JobListing> jlistings = _comprepo.GetJobs(cc);
            foreach (JobListing item in jlistings)
            {
                Console.WriteLine(item);
            }

        }

        public void PostJob()
        {
            JobListing job = new JobListing();
            Console.WriteLine("~Posting Job Console~ \t Please Fill below details to Add Car");
            Console.WriteLine("CompanyID");
            job.CompanyID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("JobTitle");
            job.JobTitle = Console.ReadLine();
            Console.WriteLine("JobDescription");
            job.JobDescription = Console.ReadLine();
            Console.WriteLine("Job Location");
            job.JobLocation = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Salary");
            job.Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("JobType");
            job.JobType = Convert.ToString(Console.ReadLine());
            Console.WriteLine("PostedDate");
            job.PostedDate = Convert.ToDateTime(Console.ReadLine());
            int getaddstatus = _comprepo.PostJob(job);
            Console.WriteLine("Job Post Sucessful");



        }
    }
}

/*
 * 
 * 
 * */

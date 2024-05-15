using System;
using CareerHub.Model;
using CareerHub.Repository;

namespace CareerHub.Service
{
	public class JobListingRepoService : iJobListingRepoService

    {
        iJobListingRepo _repo;
        public JobListingRepoService()
		{
            _repo = new JobListingRepo();
		}

        public void Apply()
        {
            JobApplication job = new JobApplication();
            Console.WriteLine("~Job Application Console~ \t Please Fill below details to Add Car");
            Console.WriteLine("Jobid");
            job.JobID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Applicantid");
            job.ApplicantID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Application Date");
            job.ApplicationDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Cover Letter");
            job.CoverLetter = Convert.ToString(Console.ReadLine());
            int getaddstatus = _repo.Apply(job);
            if(getaddstatus>0)
                Console.WriteLine("Application Sucessful");
        }

        public void GetApplicants()
        {
            JobApplication app = new JobApplication();
            Console.WriteLine("Which Jobs You Would Like Get Applicants For?");

            Console.WriteLine("Write Job Id ?");
            app.JobID = int.Parse(Console.ReadLine());

            List<Applicant> appls = _repo.GetApplicants(app);
            foreach (Applicant item in appls)
            {
                Console.WriteLine(item);
            }
        }
    }
}


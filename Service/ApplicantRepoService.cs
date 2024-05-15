using System;
using CareerHub.Model;
using CareerHub.Repository;

namespace CareerHub.Service
{
	public class ApplicantRepoService :iApplicantRepoService
	{
        iApplicantRepo _applrepo;
		public ApplicantRepoService()
		{
            _applrepo = new ApplicantRepo();
		}


        public void ApplyForJob()
        {
            JobListing job = new JobListing();
            Applicant appli = new Applicant();
            Console.WriteLine("~Job Application Console~ \t Please Fill below details to Add Car");
            Console.WriteLine("Job Id");
            job.JobID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Applicant id");
            appli.ApplicantID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cover Letter");
            appli.CoverLetter = Convert.ToString(Console.ReadLine());
            int getaddstatus = _applrepo.ApplyForJob(appli,job);
            if (getaddstatus > 0)
                Console.WriteLine(" Application Sucessful");
        }

        public void CreateProfile()
           
        {
            try
            {
                Console.WriteLine("~Applicant Profile Creation Console~ \n Please Fill below details to Add Car");
                Console.WriteLine("First Name");
                string firstName = (Console.ReadLine());
                Console.WriteLine("Last Name");
                string lastName = Console.ReadLine();
                Console.WriteLine("Phone Number");
                string phone = (Console.ReadLine());
                Console.WriteLine("Email");
                string email = Convert.ToString(Console.ReadLine());
                if (!email.Contains("@"))
                {
                    throw new FormatException("Invalid email format. Please use the format: abc@example.com");

                }

                int getaddstatus = _applrepo.CreateProfile(email, firstName, lastName, phone);
                if (getaddstatus > 0)
                    Console.WriteLine(" Profile Creation Sucessful");
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


using System;
using CareerHub.Model;

namespace CareerHub.Repository
{
	public interface iApplicantRepo
	{
        int CreateProfile(string email, string firstName, string lastName, string phone);

        int ApplyForJob(Applicant app, JobListing job);

    }
}


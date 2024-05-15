using System;
using CareerHub.Model;

namespace CareerHub.Repository
{
	public interface iCompanyRepo
	{
        int PostJob(JobListing job);
        List<JobListing> GetJobs(Company comp);

    }
}


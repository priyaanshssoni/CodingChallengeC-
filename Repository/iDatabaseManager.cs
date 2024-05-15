using System;
using CareerHub.Model;

namespace CareerHub.Repository
{
	public interface iDatabaseManager
	{
        int InsertCompany(Company company);
        List<JobListing> GetJobs();
        List<Company> GetCompany();
        List<Applicant> GetApplicants();
        int SalaryCalc();

    }
}


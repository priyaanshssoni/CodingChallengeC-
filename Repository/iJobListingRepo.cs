using System;
using CareerHub.Model;

namespace CareerHub.Repository
{
	public interface iJobListingRepo
	{

		int Apply(JobApplication app);
		List<Applicant> GetApplicants(JobApplication jobs);
			
	}


}


using System;
namespace CareerHub.Model
{
	public class JobListing
	{

        public int JobID { get; set; }
        public int CompanyID { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string JobLocation { get; set; }
        public decimal Salary { get; set; }
        public string JobType { get; set; }
        public DateTime PostedDate { get; set; }


        public override string ToString()
        {
            return $"Job ID :: {JobID} || Job ID :: {JobID} || Company Id : {CompanyID} || JobTitle : {JobTitle} || JobDescription : {JobDescription} || \n JobLocation :  {JobLocation} || Salary : {Salary} || JobType : {JobType} || Posted Date :{PostedDate}  ";
        }

        public JobListing()
		{
		}
	}
}


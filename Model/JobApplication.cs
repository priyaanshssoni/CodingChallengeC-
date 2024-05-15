using System;
using System.ComponentModel.Design;

namespace CareerHub.Model
{
	public class JobApplication
	{
        public int ApplicationID { get; set; }
        public int JobID { get; set; }
        public int ApplicantID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string CoverLetter { get; set; }

        public override string ToString()
        {
            return $"Application ID :: {ApplicationID} || Job ID :: {JobID} || Applicant Id : {ApplicantID} || Application Date : {ApplicationDate} || CoverLetter : {CoverLetter} ";
        }

	}
}


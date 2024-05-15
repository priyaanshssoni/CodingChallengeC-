using System;
namespace CareerHub.Model
{
	public class Applicant
	{
        public int ApplicantID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Resume { get; set; }
        public string CoverLetter { get; set; }

        public override string ToString()
        {
            return $"First Name :: {FirstName} || Last Name :: {LastName} || Email : {Email} || Phone :: {Phone}";
        }


      
        public Applicant()
		{
		}
	}
}


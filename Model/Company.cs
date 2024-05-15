using System;
using System.Numerics;

namespace CareerHub.Model
{
	public class Company
	{
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"Company ID :: {CompanyID} || Company Name :: {CompanyName} || Location : {Location}";
        }

        public Company()
		{
		}

	}
}


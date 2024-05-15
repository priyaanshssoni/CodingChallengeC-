using System;
using CareerHub.Model;
using CareerHub.Repository;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CareerHub.Service
{
	public class DatabaseManagerService
	{
		iDatabaseManager _data;
		public DatabaseManagerService()
		{
            _data = new DatabaseManger();


        }


        void List<JobListing> GetJobs()
            {

            Console.WriteLine("~List of All Jobs~");
            List<JobListing> veh = _data.GetJobs();
            foreach (JobListing item in veh)
            {
                Console.WriteLine(item);
            }
        }



    }
}



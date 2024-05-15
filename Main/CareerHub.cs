using System;
using CareerHub.Service;

namespace CareerHub.Main
{
	public class CareerHub
	{
        readonly iApplicantRepoService _apprepo;
        readonly iCompanyRepoService _comprepo;
        readonly DatabaseManagerService _datarepo;
        readonly iJobListingRepoService _jobrepo;

        public CareerHub()
		{
            _apprepo = new ApplicantRepoService();

            _comprepo = new CompanyRepoService();
            _datarepo = new DatabaseManagerService();
            _jobrepo = new JobListingRepoService();

        }

        public bool Run()
        {
            bool exit = false;
            while (!exit)
            {
            mainmenu:


                Console.WriteLine("    WELCOME TO CAREERHUB");
                Console.WriteLine("========================================");
                Console.WriteLine();
                Console.WriteLine("Please choose a service:");
                Console.WriteLine();
                Console.WriteLine("  1) JOB SERVICES");
                Console.WriteLine("  2) COMPANY SERVICES ");
                Console.WriteLine("  3) APPLICANT SERVICES");
                Console.WriteLine("  0) Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                Console.WriteLine();

                int userInput;
                if (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (userInput)
                {
                    case 1:


                        Console.WriteLine("           JOB SERVICE MENU");
                        Console.WriteLine("========================================");
                        Console.WriteLine();
                        Console.WriteLine("Please choose an option:");
                        Console.WriteLine();
                        Console.WriteLine("  1) APPLY FOR JOB");
                        Console.WriteLine("  2) GET APPLICANTS");
                        Console.WriteLine("  0) Go Back to Main Menu");
                        Console.WriteLine();
                        Console.Write("Enter your choice: ");


                        int u1;
                        if (!int.TryParse(Console.ReadLine(), out u1))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }

                        switch (u1)
                        {
                            case 1:
                                _jobrepo.Apply();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 2:
                                _jobrepo.GetApplicants();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 0:
                                goto mainmenu;
                            default:
                                Console.WriteLine("ENTER CORRECT DETAILS ");
                                break;
                        }

                        break;

                    case 2:


                        Console.WriteLine("          COMPANY SERVICES MENU");
                        Console.WriteLine("========================================");
                        Console.WriteLine();
                        Console.WriteLine("Please choose an option:");
                        Console.WriteLine();
                        Console.WriteLine("  1) POST NEW JOB ");
                        Console.WriteLine("  2) GET JOB LIST");
                        Console.WriteLine("  0) Go Back to Main Menu");
                        Console.WriteLine();
                        Console.Write("Enter your choice: ");


                        int u2;
                        if (!int.TryParse(Console.ReadLine(), out u2))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }

                        switch (u2)
                        {
                            case 1:

                                _comprepo.PostJob();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 2:
                                _comprepo.GetJobs();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 0:
                                goto mainmenu;

                            default:
                                Console.WriteLine("ENTER CORRECT DETAILS ");
                                Console.ReadLine();
                                break;
                        }

                        break;

                    case 3:


                        Console.WriteLine("         APPLICANT SERVICES MENU");
                        Console.WriteLine("========================================");
                        Console.WriteLine();
                        Console.WriteLine("Please choose an option:");
                        Console.WriteLine();
                        Console.WriteLine("  1) CREATE PROFILE");
                        Console.WriteLine("  2) APPLY FOR A JOB ");
                        Console.WriteLine("  0) Go Back to Main Menu");
                        Console.WriteLine();
                        Console.Write("Enter your choice: ");



                        int u3;
                        if (!int.TryParse(Console.ReadLine(), out u3))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            continue;
                        }

                        switch (u3)
                        {
                            case 1:
                                _apprepo.CreateProfile();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 2:
                                _apprepo.ApplyForJob();
                                Console.WriteLine("Press Any Key To Go Back To Main Menu");
                                Console.ReadLine();
                                break;
                            case 0:
                                goto mainmenu;


                            default:
                                Console.WriteLine("ENTER CORRECT DETAILS ");
                                Console.ReadLine();
                                break;
                        }
                        break;

                    

                  

                    case 0:
                        exit = true;
                        Console.WriteLine("Exited");
                        return false;
                    default:
                        Console.WriteLine("ENTER CORRECT INPUT ");
                        break;
                }







            }
            return true;
        }

    }
}


       

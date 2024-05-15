using CareerHub.Service;

namespace CareerHub;

class Program
{
    static void Main(string[] args)
    {
        iCompanyRepoService abc = new CompanyRepoService();

        abc.PostJob();

        Console.ReadLine();



    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class TestItemThree
    {
        public static void RunTestItemThree()
        {
            void InformationPrinter(Company company)
            {
                int SumNewHired = Sum(company.NewlyHiredMales, company.NewlyHiredFemales);
                Console.WriteLine("Total number of Newly Hired Employees |  " + SumNewHired);
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Males                                 |  " + Percentage(SumNewHired, company.NewlyHiredMales) + "%");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Females                               |  " + Percentage(SumNewHired, company.NewlyHiredFemales) + "%");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine();
                int SumPermanent = Sum(company.PermanentPositionMales, company.PermanentPositionFemales);
                Console.WriteLine("Total number of Permanent Employees   |  " + SumPermanent);
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Males                                 |  " + Percentage(SumPermanent, company.PermanentPositionMales) + "%");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Females                               |  " + Percentage(SumPermanent, company.PermanentPositionFemales) + "%");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine();
                int SumResigned = Sum(company.ResignedMales, company.ResignedFemales);
                Console.WriteLine("Total number of Permanent Employees   |  " + SumResigned);
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Males                                 |  " + Percentage(SumResigned, company.ResignedMales) + "%");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Females                               |  " + Percentage(SumResigned, company.ResignedFemales) + "%");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine();
            }
            int Sum(int a, int b)
            {
                return a + b;
            }
            decimal Percentage(int Total, int y)
            {
                decimal quotient = Decimal.Divide(y, Total);
                decimal percent = Math.Round(quotient * 100, 2);
                return percent;
            }
            Company CompanyName = new Company();
            Console.Write("Enter the number of newly hired males: ");
            CompanyName.NewlyHiredMales = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of newly hired females: ");
            CompanyName.NewlyHiredFemales = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of permanent position males: ");
            CompanyName.PermanentPositionMales = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of permanent position females: ");
            CompanyName.PermanentPositionFemales = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of resigned males: ");
            CompanyName.ResignedMales = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of resigned females: ");
            CompanyName.ResignedFemales = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=======================");
            Console.WriteLine("Thank you for the Information");
            Console.WriteLine("=======================");
            Console.WriteLine();
            Console.WriteLine("Here is the Summary!!!");
            Console.WriteLine();
            Console.WriteLine();
            InformationPrinter(CompanyName);

    }
        public class Company
        {
            public int NewlyHiredMales { get; set; }
            public int NewlyHiredFemales { get; set; }
            public int PermanentPositionMales { get; set; }
            public int PermanentPositionFemales { get; set; }
            public int ResignedMales { get; set; }
            public int ResignedFemales { get; set; }
        }
    }
}

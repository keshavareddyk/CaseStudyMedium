using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyMedium
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeePromotion employeePromotion = new EmployeePromotion();
            employeePromotion.PrintEmployeeById();
            employeePromotion.SortAndPrintEmployees();
            employeePromotion.PrintEmployee();
            employeePromotion.FindEmployeeByName();
            employeePromotion.FindEmployeeByAge();
            Console.ReadKey();
    }
    }
}

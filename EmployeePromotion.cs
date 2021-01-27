using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyMedium
{
    class EmployeePromotion
    {
        IDictionary<int, Employee> employees = new Dictionary<int, Employee>();
        List<Employee> employeesList = new List<Employee>();

        public EmployeePromotion()
        {
            do
            {
                Employee employee = new Employee();
                employee.TakeEmployeeDetailsFromUser();
                try
                {
                    employees.Add(employee.Id, employee);
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine("Employee with the given ID already exists");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception handled"+e);

                }
                employeesList.Add(employee);
                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
            }
            while (Convert.ToInt32(Console.ReadLine())==1) ;

        }
       
        public void PrintEmployeeById()
        {
           s1: Console.WriteLine("Please enter the Employee ID");
            try
            {
                Console.WriteLine(employees[Convert.ToInt32(Console.ReadLine())]);
            }
            catch (Exception ex)
            {
                switch (ex)
                {
                    case FormatException :Console.WriteLine("Invalid input format Please enter the correct format");
                        goto s1;
                        break;
                    case KeyNotFoundException: Console.WriteLine("No employee exists with the given Id");
                        //goto s1;
                        break;
                }
            }
            }

        public void PrintEmployee()
        {
            s1: Console.WriteLine("Please enter the Employee ID");
            try
            {
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Employee Details:");
                IEnumerable<Employee> emp = from employee in employeesList where employee.Id == id select employee;
                if (emp.Any())
                {
                    foreach (var em in emp)
                        Console.WriteLine(em);
                }
                else
                    Console.WriteLine("No employee exists with the given Id");
            }
            catch (Exception ex)
            {
                        Console.WriteLine("Invalid input format Please enter the correct format");
                        goto s1;
            }
        }
        public void FindEmployeeByName()
        {
            Console.WriteLine("Please enter the Employee Name");
            String name = Console.ReadLine();
            IEnumerable<Employee> emp = from employee in employeesList where employee.Name.Equals(name) select employee;
            if (emp.Any())
            {
                foreach (var em in emp)
                {
                    Console.WriteLine("No employee exists with the given name");
                    Console.WriteLine(em);
                }
            }
            else
                Console.WriteLine("No employee exists with the given name");

        }
        public void FindEmployeeByAge()
        {
            int age = 0, id;
           s1: Console.WriteLine("Please enter the Employee ID");
            try
            {
                id = Convert.ToInt32(Console.ReadLine());
                foreach (Employee employee1 in employeesList)
                {
                    if (employee1.Id == id)
                        age = employee1.Age;
                }
                if (age == 0)
                    Console.WriteLine("No employee exists with the given Id");
                else
                {
                    IEnumerable<Employee> emp = from employee in employeesList where employee.Age > age select employee;
                    if (emp.Any())
                    {
                        foreach (var em in emp)
                            Console.WriteLine(em);
                    }
                    else
                        Console.WriteLine("No employee is elder than the given employee");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input format Please enter the correct format");
                goto s1;
            }
        }


            public void SortAndPrintEmployees()
        {
            employeesList.Sort();
            Console.WriteLine("The sorted Employee list ");
            foreach (Employee employee1 in employeesList)
            {
                Console.WriteLine(employee1);
                Console.WriteLine("--------------------");

            }
        }
    }
}

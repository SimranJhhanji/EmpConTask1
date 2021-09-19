using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpConsoleApp
{
   

    class Program:EDetails
    {
        static void Main(string[] args)
        {
            //string Path = @"F:\data.txt";
            //if(File.Exists(Path))
            //{
            //    Console.WriteLine("File Exists");
            //}
            //else
            //{
            //    Console.WriteLine("Do not Exist");

            //}
            
            Employee customer1 = new Employee()
            {
                ID = 101,
                Emp_Type = "Temp",
                Salary = 5000
            };

            Employee customer2 = new Employee()
            {
                ID = 102,
                Emp_Type = "Per",
                Salary = 7000
            };

            Employee customer3 = new Employee()
            {
                ID = 103,
                Emp_Type = "Temp",
                Salary = 5500
            };

            Employee customer4 = new Employee()
            {
                ID = 104,
                Emp_Type = "Per",
                Salary = 1500
            };

            Employee customer5 = new Employee()
            {
                ID =105,
                Emp_Type ="Temp",
                Salary =500
            };
            List<Employee> listCustomers = new List<Employee>(2);
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);
            listCustomers.Add(customer4);
            listCustomers.Add(customer5);

            

            foreach (Employee c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Emp_Type, c.Salary);
            }
            Console.WriteLine("------------------------------------------------");
            
            try
            {
                
                StreamWriter sw = new StreamWriter(@"F:\data.txt");
                
                sw.Write(listCustomers);


                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("***The file is generated at data.txt***");
            }
            

            Console.WriteLine("------------------------------------------------");

            // This method returns true if the items exists, else false
            if (listCustomers.Exists(x => x.Emp_Type.StartsWith("T")))
            {
                Console.WriteLine("List contains temp and permanent Employees ");
                
                int noOfProperties = listCustomers.GetType().GetGenericArguments()[0].GetProperties().Length;
                Console.WriteLine("No of temp Employees=" + noOfProperties);
            }
            else if (listCustomers.Exists(x => x.Emp_Type.StartsWith("P")))
            {
                Console.WriteLine("List does not contain Temporary Employee");
                int noOfProperties1 = listCustomers.GetType().GetGenericArguments()[0].GetProperties().Length;
                Console.WriteLine("No of permanent Employees=" + noOfProperties1);
            }
            Console.WriteLine("------------------------------------------------------");

            //Console.WriteLine("Enter your ID:");
            //int ID = Convert.ToInt32(Console.ReadLine());
            
            //Console.Write("Enter a string Emp_Type- ");
            //String Emp_Type = Console.ReadLine();
            //Console.WriteLine("Enter your Salary");
            //int Salary = Convert.ToInt32(Console.ReadLine());

            //Program p = new Program();
            //p.getdetails();

            






            Console.ReadKey();
        }
    }


   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpConsoleApp

{
    public class Employee
    {
        public int ID { get; set; }
        public string Emp_Type { get; set; }
        public int Salary { get; set; }


    }


    class EDetails:Employee
    {
        public void getdetails()
        {
            Console.WriteLine("Your Id is: " + ID);
            Console.WriteLine("Emp_Type" + Emp_Type);
            Console.WriteLine("Salary" + Salary);
        }

    }
}

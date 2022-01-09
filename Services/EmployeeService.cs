using Crudapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crudapi.Services
{
    public class EmployeeService
    {

        //to initialize the list we have do that in ctor  ???

        static List<Employee> employeesList { get; }
        static int NextEmpId = 3;
        static EmployeeService()
        {
            employeesList = new List<Employee>()
            {
                new Employee{Id=1,Name="ziad",position="Manager",Salary=8800},
                new Employee{Id=1,Name="Ahmed",position="Ceo",Salary=14000},
            };
        }
        
        //Create my operations here not Controller for SOC

        public static List<Employee> GetEmployees()=> employeesList;  //fun ti get list od employees 

        public static Employee GetEmployee(int id) => employeesList.SingleOrDefault(e => e.Id == id);

        public static void Add(Employee employee)
        {
            employee.Id = NextEmpId++;     //id =3 then plus 
            employeesList.Add(employee);
        }
        public static  void Update(Employee employee)
        {

            var index = employeesList.FindIndex(e=>e.Id==employee.Id);        //LINQ and lambda exp
            if (index == -1)
                return;
            employeesList[index] = employee;
        }

        public static void Delete(int id)
        {
            var emp = GetEmployee(id);
            if (emp == null)
                return;
            employeesList.Remove(emp);
        }


    }
   
}

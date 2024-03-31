using HRadministrationnAPI;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Linq;

namespace SchoolHRAdministration
{

    public enum EmployeeType
    {
        Teacher, 
        HeadOfDepartment,
        DeputyHeadMaster,
        HeadMaster
    }

    class Program
    {
        static void Main(string[] args)
        {
            //decimal totalSalaries = 0;
            List<IEemployee> employees = new List<IEemployee>();

            SendData(employees);

            //foreach(IEemployee employee in employees)
            //{
            //    totalSalaries += employee.Salary;
            //}

            //Console.WriteLine($"Total Anually Salaries (including bonus): { totalSalaries}");

            Console.WriteLine($"Total Anually Salaries (including bonus): {employees.Sum(e=>e.Salary)}");

            Console.ReadKey();
        }

        public static void SendData(List<IEemployee> employees)
        {
            IEemployee teacher1 = EmployeeFactory.GetEemployeeInStance(EmployeeType.Teacher, 1, "Bob", "Monger", 40000);
            employees.Add(teacher1);

            IEemployee teacher2 = EmployeeFactory.GetEemployeeInStance(EmployeeType.Teacher, 2, "Bach", "Dam", 65000);
            employees.Add(teacher2);

            IEemployee teacher3 = EmployeeFactory.GetEemployeeInStance(EmployeeType.Teacher, 3, "Hiane", "Deli", 30000);
            employees.Add(teacher3);

            IEemployee teacher4 = EmployeeFactory.GetEemployeeInStance(EmployeeType.Teacher, 4, "Diane", "Chrone", 100000);
            employees.Add(teacher4);

            IEemployee teacher5 = EmployeeFactory.GetEemployeeInStance(EmployeeType.Teacher, 5, "Chiwa", "Powl", 50000);
            employees.Add(teacher5);

            IEemployee headOfDepartment = EmployeeFactory.GetEemployeeInStance(EmployeeType.HeadOfDepartment, 6, "Liema", "Crown", 70000);
            employees.Add(headOfDepartment);

            IEemployee deputyHeadMaster = EmployeeFactory.GetEemployeeInStance(EmployeeType.DeputyHeadMaster, 7, "Poine", "Ann", 75400);
            employees.Add(deputyHeadMaster);

            IEemployee headMaster = EmployeeFactory.GetEemployeeInStance(EmployeeType.HeadMaster, 8, "Prown", "Cine", 85400);
            employees.Add(headMaster);

        }
    }
  

    public class Teacher: EmployeeBase
    {
        public override decimal Salary { get => base.Salary +(base.Salary * 0.2m);}
    }

    public class DeputyHeadMaster: EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.3m); }
    }

    public class  HeadMaster:EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.6m); }
    }

    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.5m); }
    }

    public static class EmployeeFactory
    {
        public static IEemployee GetEemployeeInStance (EmployeeType employeeType, int id, string firstName, string lastName, decimal salary)
        {
            IEemployee employee = null;
            switch (employeeType)
            {
                case EmployeeType.Teacher:
                    employee = FactoryPattern<IEemployee, Teacher>.GetInstance();
                    break;

                case EmployeeType.HeadOfDepartment:
                    employee = FactoryPattern<IEemployee, HeadOfDepartment>.GetInstance();
                    break;

                case EmployeeType.DeputyHeadMaster:
                    employee = FactoryPattern<IEemployee, DeputyHeadMaster>.GetInstance();
                    break;

                case EmployeeType.HeadMaster:
                    employee = FactoryPattern<IEemployee, HeadMaster>.GetInstance();
                    break;

                default:
                    break;
            }

            if (employee != null)
            {
                employee.Id = id;
                employee.FirstName = firstName; 
                employee.LastName = lastName;
                employee.Salary = salary;
            }
            else
            {
                throw new NullReferenceException();
            }
            return employee;
        }
    }

}

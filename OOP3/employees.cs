using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public security securityLevel { get; set; }
        public int Salary { get; set; }
        public hiringDate hireDate { get; set; }
        public Gender Gender { get; set; }

        public employees() { }


        public employees(int id, string name, security securityLevel, int salary, hiringDate hireDate, Gender gender)
        {
                        ID = id;
            Name = name;
            this.securityLevel = securityLevel;
            Salary = salary;
            this.hireDate = hireDate;
            this.Gender = gender;
        }


        override public string ToString()
        {
            return $"ID: {ID}\nName: {Name}\nSecurity Level: {securityLevel}\n Salary: {Salary:c}\n Hire Date {hireDate} \nGender {Gender}";
        }
    }
}

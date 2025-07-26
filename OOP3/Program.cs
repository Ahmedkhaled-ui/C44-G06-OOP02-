namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region session03
            //car car1;
            /// declare for reference from type "car" , refering to null
            /// can refer to an object of type "car" or  an object from another class inheriting from "car"
            /// Clr will allocate  4 bytes for the Reference variable "car1" at stack memory
            /// Clr will allocate 0 bytes at Heap

            //car1 = new car(20, "BMW", 320);

            //car1 = new car(30, "Kie"); // calling the second constructor
            //car1 = new car(20); // calling the third constructor

            //new
            ///.1 Allocate Requaired number of bytes for Object at Heap memory [16 byte]
            ///.2 Initilaze thr Allocated Bytes  of the Object with default Value of its Data Types
            /// .3 Call user defined constructor if exists
            /// .4 Assign the Allocated Object  at Heap memory to the Reference variable "car1" at Stack memory


            //Console.WriteLine(car1.ToString());
            #endregion

            //hiringDate hireDate = new hiringDate(1, 10, 2023);
            //employees emp1 = new employees(1, "sara", security.Developer, 60000, hireDate, Gender.F);

            //Console.WriteLine(emp1);


            //employees[] employees02 = new employees[3];

            //employees02[0] = new employees
            //{
            //    ID = 2,
            //    Name = "ahmed khaled",
            //    securityLevel = security.DBA,
            //    Salary = 75000,
            //    hireDate = hireDate,
            //    Gender = Gender.M

            //};

            //employees02[1] = new employees
            //{
            //    ID = 3,
            //    Name = "Omar ",
            //    securityLevel = security.guest,
            //    Salary = 90000,
            //    hireDate = hireDate,
            //    Gender = Gender.
            //    M
            //};

            //employees02[2] = new employees
            //{
            //    ID = 4,
            //    Name = "Salma",
            //    securityLevel = security.secretary,
            //    Salary = 60000,
            //    hireDate = hireDate,
            //    Gender = Gender.F
            //};

            //foreach (var emp in employees02)
            //{
            //    Console.WriteLine(emp.ToString());
            //    Console.WriteLine("-----------------------------");
            //}
        }


        
    }
}

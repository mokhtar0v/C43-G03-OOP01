using Common;
namespace Sessrion5
{
    enum Gender
    {
        Male = 1, Female = 2, m = 1, f = 2
    }
    enum Grades
    {
        A, B, C, D, E, F
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AccessModifiers
            TypeA obj = new TypeA();
            obj.z = 10;
            #endregion
            #region Enum
            Grades grade = Grades.A;
            if (grade == Grades.A)
            {
                Console.WriteLine("Congrats A+");
            }
            else Console.WriteLine("Sorry");
            #endregion
            #region Struct
            Point p1 = new Point(4,2); // new just for constructor selection
            //clr will allocate 8bytes uninitialized at stack
            Console.WriteLine(p1);
            #endregion
            #region What is an OOP

            #endregion
            #region Encapsulation
            Employee emp = new Employee(10, "Omar", 500);
            emp.setter("Ali");
            Console.WriteLine(emp.getter());
            //emp.ID = 20;
            //Console.WriteLine(emp);
            emp.Salary = 100;
            Console.WriteLine(emp.Salary);
            #endregion
        }
    }
}

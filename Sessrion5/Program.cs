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
            #region What is an OOP

            #endregion
        }
    }
}

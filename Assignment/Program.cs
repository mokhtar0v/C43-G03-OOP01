namespace Assignment
{
    enum weekdays
    {
        Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday
    }
    enum seasons
    {
        Spring, Summer, Autumn, Winter
    }
    enum colors
    {
        Red, Green, Blue
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            weekdays day = weekdays.Sunday;
            while (day <= weekdays.Friday)
            {
                Console.WriteLine(day);
                day++;
            }
            #endregion

            #region Question2
            Person[] persons = new Person[3];
            persons[0] = new Person("Name1", 20);
            persons[1] = new Person("Name2", 20);
            persons[2] = new Person("Name3", 20);
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"The name of person number {i+1} is {persons[i].name}, and his age = {persons[i].age}");
            }
            #endregion

            #region Question3
            string s = Console.ReadLine();
            if (Enum.TryParse(s, out seasons season))
            {
                switch (season)
                {
                    case seasons.Summer:
                        Console.WriteLine("June to August");
                        break;
                    case seasons.Winter:
                        Console.WriteLine("December to February");
                        break;
                    case seasons.Spring:
                        Console.WriteLine("March to May");
                        break;
                    case seasons.Autumn:
                        Console.WriteLine("September to November");
                        break;
                }
            }
            else Console.WriteLine("Invalid season");
            #endregion

            #region Question4

            #endregion

            #region Question5
            string c = Console.ReadLine();
            if (Enum.TryParse(c, out colors color))
            {
                switch (color)
                {
                    case colors.Red:
                        Console.WriteLine("Primary");
                        break;
                    case colors.Green:
                        Console.WriteLine("Primary");
                        break;
                    case colors.Blue:
                        Console.WriteLine("Primary");
                        break;
                }
            }
            else Console.WriteLine("The input color is not primary");
            #endregion

            #region Question6
            int x1, x2, y1, y2;
            Console.WriteLine("Enter The Coordinates of the first point");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Coordinates of the second point");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            double distance = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
            Console.WriteLine($"The distance between the two point = {distance}");
            #endregion

            #region Question7
            Console.WriteLine("Enter the data of the first person");
            string name1 = Console.ReadLine();
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the date of the second person");
            string name2 = Console.ReadLine();
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the date of the third person");
            string name3 = Console.ReadLine();
            int age3 = Convert.ToInt32(Console.ReadLine());
            Person Q7Person1 = new Person(name1, age1);
            Person Q7Person2 = new Person(name2, age2);
            Person Q7Person3 = new Person(name3, age3);
            int maxage = Math.Max(Math.Max(age1, age2), age3);
            if(maxage == age1) Console.WriteLine($"The oldest person is {Q7Person1.name} and his age = {Q7Person1.age}");
            else if (maxage == age2) Console.WriteLine($"The oldest person is {Q7Person2.name} and his age = {Q7Person2.age}");
            else Console.WriteLine($"The oldest person is {Q7Person3.name} and his age = {Q7Person3.age}");

            #endregion
        }
    }
}

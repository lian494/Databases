using System;

namespace Databases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name!");
            string name = Console.ReadLine();
            Console.Write("Enter your age!");
            int age = Int32.Parse(Console.ReadLine());

            FileReader file = 
                     new FileReader(@"C:\Users\User\Documents\CSharpLecturesFall2019" +
                     @"\lecture17\Databases\names.age.txt");

                     file.WriteName(name,age);



            Console.WriteLine($"Hello {name} {age}");

        }
    }
}

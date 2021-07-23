using System;

namespace resume_project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] work_exp = new string[5];
            string[] education= new string[5];
            string[] skills = new string[5];
            int i;
            Console.Write("Name:"); 
            var name = Console.ReadLine();
            Console.Write("Address:");
            var address = Console.ReadLine();
            Console.Write("Telephone number:");
            var telenum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email Address");
            var email = Console.ReadLine();
            Console.WriteLine("Summary paragraph:");
            var summary = Console.ReadLine();

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Work Experience:");
                work_exp[i] = Console.ReadLine();
            }
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("Education:");
                education[i] = Console.ReadLine();
            }
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Skills:");
                skills[i] = Console.ReadLine();
            }
        }
    }
}

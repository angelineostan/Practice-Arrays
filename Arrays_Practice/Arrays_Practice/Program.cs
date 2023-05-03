using System;
namespace Arrays
{
    class Program
    {
        static void Main()
        {
            first();
            Console.WriteLine();
            second();
            Console.WriteLine();
            third();
            Console.WriteLine();
            fourth();
            Console.WriteLine();
            fifth();
            Console.WriteLine();
            sixth();
            Console.WriteLine();
            seventh();
            Console.WriteLine();
            eighth();
                Console.WriteLine();
        }
        // Declare w/ values.
        static void first()
        {
            string[] names = { "David", "Arlener", "Slear" };
            float[,,] grades = {{ 89.5f, 34.5f }, { 89.7f, 56.7f }, { 90.6f, 45.6f }};
        }
        // Declare w/o values.
        static void second()
        {
            string[] names = new string[5];
            
        }
        // Accessing array via Reading Array Element.
        static void third()
        {
            string[] names = { "David", "Arlener", "Slear" };
            Console.WriteLine(names[2]);
        }

        static void fourth()
        {
            string[] names = new string[5];
            names[0] = "Kevin";
            names[1] = "Stuart";
            names[2] = "Bob";
            names[3] = "Gru";
            names[4] = "The Scientist";

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            Console.WriteLine(names[4]);

            Console.WriteLine(names[3] + " " + names[4]);

        }
        // Assigning Array Element w/ User Input
        static void fifth()
        {
            string[] names = new string[5];
            Console.WriteLine("Enter Name: ");
            names[0] = Console.ReadLine();
            names[1] = Console.ReadLine();
            names[2] = Console.ReadLine();
            names[3] = Console.ReadLine();
            names[4] = Console.ReadLine();

            Console.WriteLine("I'm, " + names[0]);
        }

        static void sixth()
        {
            string[] email = { "angelineostan@gmail.com", "ostanangeline@sac.edu.ph", "ostanangelinedatinggaling@gmail.com" };
            string[] username = { "Angeline Ostan", "ANGELNE OSTAN", "Angeline2.0" };
            int[] password = { 123, 456, 789 };

            Console.Write("Enter an Index: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Email: ");
            Console.WriteLine(email[index]);
            Console.WriteLine();

            Console.Write("Enter your Username: ");
            Console.WriteLine(username[index]);
            Console.WriteLine();
            Console.Write("Enter you Password: ");
            Console.WriteLine(password[index]);
            Console.WriteLine();
        }

        static void seventh()
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write(num.Sum() / 10);

        }

        static void eighth()
        {
            string[] movies = new string[10];

            Console.WriteLine("Enter Names: ");

            for (int i = 0; i < movies.Length; i++)
            {
                int rank = i + 1;
                Console.Write(rank + ". " + movies[i]);
                movies[i] = Console.ReadLine();
            }
            Console.WriteLine();

            Console.WriteLine("Arranged in Alphabetical order: ");
            Array .Sort(movies);

            for (int i = 0; i < movies.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + ". " + movies[i]);
            }

        }
    }
}
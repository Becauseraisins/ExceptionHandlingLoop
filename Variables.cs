using System;

namespace intro_programming
{
    class Program
    {
        static void Main(string[] args)
        {  
            string word_1; 
            string word_2;
            string word_3;
            string word_4;
            string word_5;
            int num_1;
            int num_2;


            Console.WriteLine("Enter First Name");

            word_1 = Console.ReadLine();

            Console.WriteLine("Enter Last Name");

            word_2 = Console.ReadLine();
          
            //Handles Print of first and last names including space between words

            Console.WriteLine("Enter Student ID");

            word_5 = Console.ReadLine();

            Console.WriteLine("Enter Birth Year");

            word_3 = Console.ReadLine();
            
            Console.WriteLine("Enter Current Year");

            word_4 = Console.ReadLine();

            //these two lines convert word_1 and word_2 into ints and assign to num_1 and num_2 respectively
            num_1 = int.Parse(word_3);
            num_2 = int.Parse(word_4);
            Console.WriteLine("Welcome " +word_1+" " +word_2 + " student ID " + word_5);
            Console.WriteLine("Age");
            Console.WriteLine(num_2 - num_1);
        }
    }
}
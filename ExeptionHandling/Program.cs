using System;

namespace exeptionhandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean Location = false;
            int num = -1;
            while (Location == false)
            {
                Console.WriteLine("Enter Location");
                try
                {
                    string room = Console.ReadLine();

                    if (room.Length == 0)
                    {
                        throw new ArgumentNullException("Location");

                    }
                    else { Location = true; }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Please enter something");
                }
            }
            Location = false;
            while (Location == false)
            {
                Console.WriteLine("Enter name");
                try
                {
                    string name = Console.ReadLine();

                    if (name.Length == 0)
                    {
                        throw new ArgumentNullException("name");

                    }
                    else { Location = true; }
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Please enter something");
                }
                Location = false;
                while (Location == false)
                {
                    Console.WriteLine("Enter date");
                    try
                    {
                        string date = Console.ReadLine();

                        if (date.Length == 0)
                        {
                            throw new ArgumentNullException("date");

                        }
                        else { Location = true; }
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Please enter something");
                    }
                    Location = false;
                    while (Location == false)
                    {
                        Console.WriteLine("Enter time");
                        try
                        {
                            string time = Console.ReadLine();

                            if (time.Length == 0)
                            {
                                throw new ArgumentNullException("time");

                            }
                            else { Location = true; }
                        }
                        catch (ArgumentNullException)
                        {
                            Console.WriteLine("Please enter something");
                        }
                        Location = false;
                        while (Location == false)
                        {
                            Console.WriteLine("Enter minutes stayed");
                            try
                            {
                                string minutes = Console.ReadLine();

                                if (minutes.Length == 0)
                                {
                                    throw new ArgumentNullException("minutes");

                                }
                                else if (!int.TryParse(minutes, out num))
                                {
                                    throw new FormatException("number");

                                }
                                else { Location = true; }
                            }
                            catch (ArgumentNullException)
                            {
                                Console.WriteLine("Please enter something");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("please enter a number");
                            }
                        }

                    }
                }
            }
        }
    }
}

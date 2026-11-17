namespace Session10_task
{
      
using System;

namespace Session11_task
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                bool isRunning = true;

                while (isRunning)
                {
                    Console.WriteLine("\n===== Examination System =====");
                    Console.WriteLine("1. Doctor Mode");
                    Console.WriteLine("2. Student Mode");
                    Console.WriteLine("3. Exit");

                    Console.Write("Choose an option: ");

                    int choice;

                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                DoctorMode();
                                break;

                            case 2:
                                StudentMode();
                                break;

                            case 3:
                                isRunning = false;
                                Console.WriteLine("Goodbye!");
                                break;

                            default:
                                Console.WriteLine("Invalid choice!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number!");
                    }
                }
            }

            static void DoctorMode()
            {
                Console.WriteLine("\n===== Doctor Mode =====");
            }

            static void StudentMode()
            {
                Console.WriteLine("\n===== Student Mode =====");
            }
        }
    }

}
   
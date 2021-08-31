using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Guest> guests = new Queue<Guest>();
            guests.Enqueue(new Guest() { Age = 28, Name = "Emil" });
            guests.Enqueue(new Guest() { Age = 31, Name = "Hans" });
            guests.Enqueue(new Guest() { Age = 24, Name = "Camilla" });
            guests.Enqueue(new Guest() { Age = 25, Name = "Hanna" });
            guests.Enqueue(new Guest() { Age = 34, Name = "Jens" });
            guests.Enqueue(new Guest() { Age = 25, Name = "Silke" });

            for (; ; )
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("         H1 Queue Operations Menu");
                Console.WriteLine("--------------------------------------------\n");
                Console.WriteLine("1. Add a guest");
                Console.WriteLine("2. Delete a guest");
                Console.WriteLine("3. Show the number of guests");
                Console.WriteLine("4. Show last and first guest");
                Console.WriteLine("5. Print all guests");
                Console.WriteLine("6. Exit\n");
                Console.WriteLine("Type the number you want:");
                int menuNumber = Convert.ToInt32(Console.ReadLine());
                if (menuNumber == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Type the name of the guest:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Set the age for the guest:");
                    int age = Convert.ToInt32(Console.ReadLine());
                    guests.Enqueue(new Guest() { Age = age, Name = name });

                }
                else if (menuNumber == 2)
                {
                    Guest firstToLeave = guests.Dequeue();
                    Console.WriteLine("Removed the first person in the queue\n");
                }
                else if (menuNumber == 3)
                {
                    Console.WriteLine("There are " + guests.Count + " guests in the queue\n");
                }
                else if (menuNumber == 4)
                {
                    Guest firstPerson = guests.Peek();
                    Console.WriteLine("First guest in the queue is {0}\n", firstPerson.Name);
                    Guest[] lastGuest = guests.ToArray();
                    var lastGuestData = lastGuest[lastGuest.Length - 1];
                    Console.WriteLine("Last guest in the queue is {0}\n", lastGuestData.Name);
                }
                else if (menuNumber == 5)
                {
                    foreach (Guest guest in guests)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("{0}, {1}", guest.Name, guest.Age);
                    }
                }
                else if (menuNumber == 6)
                {
                    Environment.Exit(0);
                }
                Console.WriteLine("Type a key to reset menu:");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}


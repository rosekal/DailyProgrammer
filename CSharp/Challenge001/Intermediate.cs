using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge001{
    class Intermediate{
        static Dictionary<string, string> menu = new Dictionary<string, string>();

        public static void Run() {
            string hour = "", desc = "";

            do {
                Console.Write("\nPlease select an operation: (p)rint, (e)dit, (a)dd, (r)emove, (q)uit: ");

                switch (Console.ReadLine()) {
                    case "a":
                        Console.Write("\nEnter an hour: ");
                        hour = Console.ReadLine();

                        if (menu.ContainsKey(hour)) {
                            Console.Write("\nYou're about to overwrite an event.  Is this OK? (y/n)");

                            string confirmation = Console.ReadLine();

                            if (!confirmation.Equals("y") && !confirmation.Equals("Y")){
                                break;
                            }
                        }

                        Console.Write("\nEnter a description: ");
                        desc = Console.ReadLine();
                        
                        Add(desc, hour);
                        break;
                    case "e":
                        Print();
                        Console.Write("\nPlease an hour to edit: ");

                        hour = Console.ReadLine();

                        Console.Write("\nEnter a new description: ");
                        desc = Console.ReadLine();

                        Add(desc, hour);

                        break;
                    case "r":
                        Print();
                        Console.Write("\nPlease an hour to remove: ");

                        Delete(Console.ReadLine());
                        break;
                    case "p":
                        Print();
                        break;
                    case "q":
                        return;
                }
            } while (true);
        }

        public static void Print() {
            foreach (KeyValuePair<string, string> entry in menu) {
                Console.WriteLine($"{entry.Key} - {entry.Value}");
            }
        }

        public static void Add(string desc, string hour) {
            menu[hour] = desc;
        }

        public static void Delete(string hour) {
            menu.Remove(hour);
        }
    }
}
using System;
using System.IO;
using System.Security;
namespace Challenge001{
    class Easy{
        static void Main(string[] args){
            //Getting name
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            //Getting age
            bool badAge;
            int age = 0;
            do {
                badAge = false;
                Console.Write("\nPlease enter your age: ");

                try {
                    age = Int32.Parse(Console.ReadLine());
                } catch (Exception) {
                    Console.WriteLine("\nBad age.  Please try again.");
                    badAge = true;
                }
            } while (badAge);

            //Getting Reddit username
            Console.Write("\nPlease enter your Reddit username: ");
            string username = Console.ReadLine();

            string data = $"Your name is {name}, you are {age}, and your username is {username}";

            Console.WriteLine($"\n{data}");
            WriteToFile(data);
        }

        static void WriteToFile(string data) {
            //Change 'Kalen' to respective windows user
            string fileName = "C:\\Users\\Kalen\\listOfNames.txt";

            if (!File.Exists(fileName)) {
                File.Create(fileName);
            }
            using (StreamWriter sw = File.AppendText(fileName)) {
                sw.WriteLine(data);
            }
        }
    }
}

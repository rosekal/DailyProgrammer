using System;

namespace Challenge003
{
    class Program
    {
        static void Main(string[] args) {
            do {
                Console.Write("\nType 1 for easy, 2 for intermediate, 3 for hard: ");

                switch (Console.ReadLine()) {
                    case "1":
                    Easy.Run();
                    break;
                    case "2":
                    //Intermediate.Run();
                    break;
                    case "3":
                    //Hard.Run();
                    break;
                }

            } while (true);
        }
    }
}

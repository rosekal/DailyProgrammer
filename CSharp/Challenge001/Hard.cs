using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge001{
    class Hard{
        static int currentNumber = -1;
        static bool gameOver = false;

        public static void Run() {
            bool goHigher = false;
            int lowerRange = 0;
            int higherRange = 101;

            bool firstTime = true;
            do {
                if (firstTime) {
                    currentNumber = 50;

                    firstTime = false;
                } else {
                    if (goHigher) {
                        lowerRange = currentNumber;
                        currentNumber = lowerRange + ((higherRange - lowerRange) / 2);      
                    } else {
                        higherRange = currentNumber;
                        currentNumber = lowerRange + ((higherRange - lowerRange) / 2);
                    }

                    if (currentNumber == lowerRange || currentNumber == higherRange || higherRange == lowerRange) {
                        Console.WriteLine("Your lying.  Exiting.");
                        return;
                    }
                }

                Console.Write($"\nI'm guessing: {currentNumber}.  Is this the number? (y/n) ");

                if (!Console.ReadLine().Equals("y")) {

                    while (true) {
                        Console.Write($"\nDo I go higher (h) or lower (l)? ");
                        string answer = Console.ReadLine();

                        if (answer.Equals("h") || answer.Equals("l")) {
                            goHigher = answer.Equals("h");
                            break;
                        }
                    }
                } else {
                    Console.WriteLine("\nI win!");
                    gameOver = true;
                }

            } while (!gameOver);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge006 {
	class Program {
		static void Main(string[] args) {
			do {
				Console.Write("\nType 1 for easy, 2 for intermediate, 3 for hard: ");

				switch (Console.ReadLine()) {
				case "1":
					Console.WriteLine("Calculate pi accurately to at least 30 decimal places.\nDue to limitations of C#, only up to 15 digits");
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

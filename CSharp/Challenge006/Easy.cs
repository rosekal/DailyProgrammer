using System;

namespace Challenge006 {
	internal class Easy {
		static bool add = false;

		internal static void Run() {
			Console.WriteLine(Math.Round(CalcPi(),15));
		}

		internal static double CalcPi() {
			double num = 1.0;

			for(double i = 3; i < 10_000_000_000; i += 2) {
				if (add) {
					num += (1.0 / i);
					add = false;
				} else {
					num -= (1.0 / i);
					add = true;
				}
			}

			return num * 4;
		}
	}
}
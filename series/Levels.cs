using System;

namespace Series
{

	public class Levels
	{
		/// <summary>
		/// Levels
		/// </summary>
		static int[,] level_arrays = { 

			//
			// AS YOU SEE YOU CAN'T EVEN FIND THE
			// ANSWERS BY LOOKING AT THE SOURCE CODE!
			//

			{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
			{ 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 },
			{ 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 },       /* Here we teach x + p */
			{ 9, 19, 29, 39, 49, 59, 69, 79, 89, 99 },
			{ 5, 8, 11, 14, 17, 20, 23, 26, 29, 32 },
			{ 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 },
			{ 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 },
			{ 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
			{ 10, 20, 30, 10, 20, 30, 10, 20, 30, 10 },
			{ 1, 3, 7, 15, 35, 63, 127, 255, 511, 1023 },
			{ 1, 3, 7, 12, 18, 26, 35, 45, 56, 69 },
			{ 10, 20, 3, 15, 1000, 60, 16, 17, 18, 19 }

		};

		/// <summary>
		/// Returns the specific level
		/// </summary>
		/// <param name="level">Level.</param>
		public static int[] get (int level)
		{

			int[] r = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
		
			if (get_max_level () >= level) {

				for (int i = 0; i < 10; i++) {

					r [i] = level_arrays [level - 1, i];

				}
			} 

			return r;
		}


		/// <summary>
		/// Returns number of levels
		/// </summary>
		public static int get_max_level () {
		
			return level_arrays.Length / 10;

		}
	}
}


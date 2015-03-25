using System;

namespace Series
{

	public class Levels
	{

		static int[,] level_arrays = { 

			{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
			{ 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 },
			{ 1, 3, 6, 10, 15, 21, 28, 36, 45, 55},
			{ 5, 8, 11, 14, 17, 20, 23, 26, 29, 32 },
			{ 1, 3, 9, 27, 81, 243, 729, 2187, 6561, 19683 }

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


using System;

namespace Series
{
	public class ArrayTools
	{
		public static string FloatArrayToString (int[] array) {

			string result = "";

			for (int i = 0; i < array.Length - 1; i++) {

				result += array [i] + ", ";

			}

			return result + array [array.Length - 1];
		}
	}
}


using System;

namespace Series
{
	/* ------------------------------------- *
	 * :::::::::: U I   C L A S S :::::::::: *
	 * ------------------------------------- */

	public class UI
	{

		//    ┌┬────────┬─────────────────────────────────────────────────────┐
		//    ││  KARY  │                                                     │
		//    │└────────┘                                                     │
		//    │     ___       ___       ___       ___       ___       ___     │
		//    │    /\  \     /\  \     /\  \     /\  \     /\  \     /\  \    │
		//    │   /::\  \   /::\  \   /::\  \   _\:\  \   /::\  \   /::\  \   │
		//    │  /\:\:\__\ /::\:\__\ /::\:\__\ /\/::\__\ /::\:\__\ /\:\:\__\  │
		//    │  \:\:\/__/ \:\:\/  / \;:::/  / \::/\/__/ \:\:\/  / \:\:\/__/  │
		//    │   \::/  /   \:\/  /   |:\/__/   \:\__\    \:\/  /   \::/  /   │
		//    │    \/__/     \/__/     \|__|     \/__/     \/__/     \/__/    │
		//    │                                                               │
		//    ├───────────────────────────────────────────────────────────────┤
		//    │:::::::::::::::::  SEE HOW GOOD YOUR'E IN MATH  :::::::::::::::│
		//    ├───────────────────────────────────────────────────────────────┤
		//    └───────────────────────────────────────────────────────────────┘                                                                    

		public static void welcome () {

			Console.Clear ();
			Console.Title = "Kary Series";
			Console.WriteLine ("\n\n   ┌┬────────┬─────────────────────────────────────────────────────┐\n   ││  KARY  │                                                     │\n   │└────────┘                                                     │\n   │     ___       ___       ___       ___       ___       ___     │\n   │    /\\  \\     /\\  \\     /\\  \\     /\\  \\     /\\  \\     /\\  \\    │\n   │   /::\\  \\   /::\\  \\   /::\\  \\   _\\:\\  \\   /::\\  \\   /::\\  \\   │\n   │  /\\:\\:\\__\\ /::\\:\\__\\ /::\\:\\__\\ /\\/::\\__\\ /::\\:\\__\\ /\\:\\:\\__\\  │\n   │  \\:\\:\\/__/ \\:\\:\\/  / \\;:::/  / \\::/\\/__/ \\:\\:\\/  / \\:\\:\\/__/  │\n   │   \\::/  /   \\:\\/  /   |:\\/__/   \\:\\__\\    \\:\\/  /   \\::/  /   │\n   │    \\/__/     \\/__/     \\|__|     \\/__/     \\/__/     \\/__/    │\n   │                                                               │\n   ├───────────────────────────────────────────────────────────────┤\n   │:::::::::::::::::  SEE HOW GOOD YOU'RE IN MATH  :::::::::::::::│\n   ├───────────────────────────────────────────────────────────────┤\n   └───────────────────────────────────────────────────────────────┘\n");

		}



		//    ┌─────────────┬─────────────────────────────────────────────────┐
		//    │ KARY SERIES │::: Q U E S T I O N :::::::::::::::::::::::::::::│
		//    ├─────────────┴─────────────────────────────────────────────────┤
		//    │                                                               │
		//    │                                                               │
		//    │                                                               │
		//    │                                                               │
		//    │                                                               │
		//    │                                                               │
		//    └───────────────────────────────────────────────────────────────┘

		public static void question (string text) {

			//
			// UP
			//

			Console.WriteLine ("   ┌─────────────┬─────────────────────────────────────────────────┐\n   │ KARY SERIES │::: Q U E S T I O N :::::::::::::::::::::::::::::│\n   ├─────────────┴─────────────────────────────────────────────────┤\n   │                                                               │\n   │                                                               │");


			//
			// TEXT WRITELINE
			//


			UI.WriteLine (text);



			//
			// DOWN
			//

			Console.WriteLine ("   │                                                               │\n   │                                                               │\n   └───────────────────────────────────────────────────────────────┘");
		}




		// ┌───────────────────────────────────────────────────────────────┐
		// │  PRESS ANY KEY TO CONTINIUE                                   │
		// └───────────────────────────────────────────────────────────────┘

		public static void enter_to_continue (string text, int space) {

			Console.Write ("   ┌───────────────────────────────────────────────────────────────┐\n   │ " + text.ToUpper ());

			for (int i = 0; i < 60 - text.Length; i++) {

				Console.Write (" ");

			}

			int x = Console.CursorLeft, y = Console.CursorTop;

			Console.WriteLine ("  │\n   └───────────────────────────────────────────────────────────────┘");

			int newX = Console.CursorLeft, newY = Console.CursorTop;

			Console.SetCursorPosition (x , y-space);

			Console.ReadKey ();

			Console.SetCursorPosition (newX, newY);

			Console.WriteLine ();
		}



		public static void WriteLine (string text) {

			Console.Write ("   │ " + text );

			for (int i = 0; i < 62 - text.Length; i++) {

				Console.Write (" ");

			}

			Console.WriteLine ("│");
		}



		//   ┌─────────────┬─────────────────────────────────────────────────┐
		//   │ KARY SERIES │::: I N P U T :::::::::::::::::::::::::::::::::::│
		//   └─────────────┴─────────────────────────────────────────────────┘

		public static string input () {

			Console.Write ("   ┌─────────────┬─────────────────────────────────────────────────┐\n   │ KARY SERIES │::: I N P U T :::::::::::::::::::::::::::::::::::│\n   └─────────────┴─────────────────────────────────────────────────┘\n\n    >>> ");

			string the_input = Console.ReadLine ();

			Console.WriteLine ();

			return the_input;

		}


		public static void any_key () {

			UI.enter_to_continue ("press any key to continue",0);

		}

		//
		// FAILED PROFILE
		//

		public static void failed_profile (int[] inps, int[] expects) {

			Console.WriteLine ("\n\n   ┌─────────────┬─────────────────────────────────────────────────┐\n   │ KARY SERIES │::: F A I L E D :::::::::::::::::::::::::::::::::│\n   ├─────────────┴─────────────────────────────────────────────────┤\n   │                                                               │");

			UI.WriteLine ("Your formula is no match to our sequance. Here you can see");
			UI.WriteLine ("the first 10 index of your evaluated formula:");
			UI.WriteLine ("");
			UI.WriteLine (" #   │ Result                  │ Expectation ");
			UI.WriteLine ("─────┼─────────────────────────┼─────────────────────────────");

			for (int i = 1 ; i <= inps.Length ; i++) {

				UI.WriteLine (" " + i.ToString ().PadRight (3) + " │ " + inps [i - 1].ToString ().PadRight (24) + "│ "  + expects[i - 1 ]);

			}
				
			Console.WriteLine ("   │                                                               │\n   └───────────────────────────────────────────────────────────────┘\n");
		}


		//
		// SET TITLE
		// 

		public static void setTitle (int level) {

			Console.Title = "Kary Series | Level " + level;

		}
	}
}


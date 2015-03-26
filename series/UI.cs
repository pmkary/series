
using System;
using Panther.Text;

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
			UI.WriteLine (" #    │ Test Results            │ Expectations ");
			UI.WriteLine ("──────┼─────────────────────────┼────────────────────────────");

			for (int i = 1 ; i <= inps.Length ; i++) {

				var roman_i = Panther.Text.Numerics.Roman (i).PadRight (4);

				UI.WriteLine (" " + roman_i + " │ " + inps [i - 1].ToString ().PadRight (24) + "│ "  + expects[i - 1 ]);

			}
				
			Console.WriteLine ("   │                                                               │\n   └───────────────────────────────────────────────────────────────┘\n");
		}


		//
		// SET TITLE
		// 

		public static void setTitle (int level) {

			Console.Title = "Kary Series | Level " + level;

		}


		//    ┌┬────────┬─────────────────────────────────────────────────────┐
		//    ││  KARY  │                                                     │
		//    │└────────┘                                                     │
		//    │                                                               │
		//    │                                                               │
		//    │          __     __          __          __         _          │
		//    │          \ \   / /          \ \        / /        | |         │
		//    │           \ \_/ /__  _   _   \ \  /\  / /__  _ __ | |         │
		//    │            \   / _ \| | | |   \ \/  \/ / _ \| '_ \| |         │
		//    │             | | (_) | |_| |    \  /\  / (_) | | | |_|         │
		//    │             |_|\___/ \__,_|     \/  \/ \___/|_| |_(_)         │
		//    │                                                               │
		//    │         Congratulations! You proved to be a great mater       │
		//    │          in understanding sequences! Well done, Truly!        │
		//    │                                                               │
		//    │                                                               │
		//    │                                                               │
		//    │                                                               │
		//    └───────────────────────────────────────────────────────────────┘

		public static void you_won_screen () {

			Console.Clear ();

			Console.WriteLine ("\n\n   ┌┬────────┬─────────────────────────────────────────────────────┐\n   ││  KARY  │                                                     │\n   │└────────┘                                                     │\n   │                                                               │\n   │                                                               │\n   │          __     __          __          __         _          │\n   │          \\ \\   / /          \\ \\        / /        | |         │\n   │           \\ \\_/ /__  _   _   \\ \\  /\\  / /__  _ __ | |         │\n   │            \\   / _ \\| | | |   \\ \\/  \\/ / _ \\| '_ \\| |         │\n   │             | | (_) | |_| |    \\  /\\  / (_) | | | |_|         │\n   │             |_|\\___/ \\__,_|     \\/  \\/ \\___/|_| |_(_)         │\n   │                                                               │\n   │         Congratulations! You proved to be a great mater       │\n   │          in understanding sequences! Well done, Truly!        │\n   │                                                               │\n   │                                                               │\n   │                                                               │\n   │                                                               │\n   └───────────────────────────────────────────────────────────────┘");

			UI.enter_to_continue ("press any key to exist", 0);

			Console.Clear ();
		}




		public static void intro_screen () {

			Console.Clear ();
			Console.WriteLine ("\n\n   ┌─────────────┬─────────────────────────────────────────────────┐\n   │ KARY SERIES │::: I N T R O :::::::::::::::::::::::::::::::::::│\n   ├─────────────┴─────────────────────────────────────────────────┤\n   │                                                               │\n   │ Welcome to Kary Series. It's about fining the general formula │\n   │ of sequences. In each level you will get 10 first index of a  │\n   │ sequence and you have to find a formula for it. For example:  │\n   │                                                               │\n   │     [ 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 ]                     │\n   │                                                               │\n   │ And then you will see a prompt like >>> which you have to     │\n   │ your formula there. You have to use parameter `x` as your     │\n   │ index number so the formula will be something like this:      │\n   │                                                               │\n   │     >>> x * 2 - 1                                             │\n   │                                                               │\n   └───────────────────────────────────────────────────────────────┘");
			UI.enter_to_continue ("Press any key to say Got It!", 0);
		}




		public static void p_intro_screen () {

			Console.Clear ();
			Console.WriteLine ("\n\n   ┌─────────────┬─────────────────────────────────────────────────┐\n   │ KARY SERIES │::: I N T R O :::::::::::::::::::::::::::::::::::│\n   ├─────────────┴─────────────────────────────────────────────────┤\n   │                                                               │\n   │ You can get the previous index's value by using parameter     │\n   │ `p` for example look at this sequence:                        │\n   │                                                               │\n   │     [ 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 ]                   │\n   │                                                               │\n   │ Each index is the sum of it's previous index and it's         │\n   │ current index number so the formula will be:                  │\n   │                                                               │\n   │     >>> p + x                                                 │\n   │                                                               │\n   │ NOTE: for the very first index `p` returns zero.              │\n   │                                                               │\n   └───────────────────────────────────────────────────────────────┘");
			UI.enter_to_continue ("Press any key to say Got It!", 0);
		}
	}
}



using System;
using Kary.Foundation;
using Kary.Text;

namespace Series
{

	/* ─────────────────────────────────────────────────────────────────── *
	 * :::::::::: K A R Y   S E R I E S   U I   E L E M E N T S :::::::::: *
	 * ─────────────────────────────────────────────────────────────────── */

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

			Terminal.Clean ();
			Terminal.Title = "Kary Series";
			Terminal.PrintLn ("\n\n   ┌┬────────┬─────────────────────────────────────────────────────┐\n   ││  KARY  │                                                     │\n   │└────────┘                                                     │\n   │     ___       ___       ___       ___       ___       ___     │\n   │    /\\  \\     /\\  \\     /\\  \\     /\\  \\     /\\  \\     /\\  \\    │\n   │   /::\\  \\   /::\\  \\   /::\\  \\   _\\:\\  \\   /::\\  \\   /::\\  \\   │\n   │  /\\:\\:\\__\\ /::\\:\\__\\ /::\\:\\__\\ /\\/::\\__\\ /::\\:\\__\\ /\\:\\:\\__\\  │\n   │  \\:\\:\\/__/ \\:\\:\\/  / \\;:::/  / \\::/\\/__/ \\:\\:\\/  / \\:\\:\\/__/  │\n   │   \\::/  /   \\:\\/  /   |:\\/__/   \\:\\__\\    \\:\\/  /   \\::/  /   │\n   │    \\/__/     \\/__/     \\|__|     \\/__/     \\/__/     \\/__/    │\n   │                                                               │\n   ├───────────────────────────────────────────────────────────────┤\n   │:::::::::::::::::  SEE HOW GOOD YOU'RE IN MATH  :::::::::::::::│\n   ├───────────────────────────────────────────────────────────────┤\n   └───────────────────────────────────────────────────────────────┘\n");

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

			Terminal.PrintLn ("   │                                                               │\n   │                                                               │\n   └───────────────────────────────────────────────────────────────┘");
		}




		// ┌───────────────────────────────────────────────────────────────┐
		// │  PRESS ANY KEY TO CONTINIUE                                   │
		// └───────────────────────────────────────────────────────────────┘

		public static void enter_to_continue (string text, int space) {

			Terminal.Print ("   ┌───────────────────────────────────────────────────────────────┐\n   │ " + text.ToUpper ());

			for (int i = 0; i < 60 - text.Length; i++) {

				Terminal.Print (" ");

			}

			int x = Terminal.X, y = Terminal.Y;

			Terminal.PrintLn ("  │\n   └───────────────────────────────────────────────────────────────┘");

			int newX = Terminal.X, newY = Terminal.Y;

			Terminal.Locate (x , y-space);

			Terminal.AnyKey ();

			Terminal.Locate (newX, newY);

			Terminal.PrintLn ();
		}



		public static void WriteLine (string text) {

			Console.Write ("   │ " + text );

			for (int i = 0; i < 62 - text.Length; i++) {

				Console.Write (" ");

			}

			Console.WriteLine ("│");
		}



		// ┌─────────────┬─────────────────────────────────────────────────┐
		// │ KARY SERIES │::: I N P U T :::::::::::::::::::::::::::::::::::│
		// ├─────────────┴─────────────────────────────────────────────────┤
		// │                                                               │
		// │                                                               │
		// │                                                               │
		// └───────────────────────────────────────────────────────────────┘

		public static string input () {

			Terminal.PrintLn(Utilities.Perpend("┌─────────────┬─────────────────────────────────────────────────┐\n│ KARY SERIES │::: I N P U T :::::::::::::::::::::::::::::::::::│\n├─────────────┴─────────────────────────────────────────────────┤\n│                                                               │\n│ Answer =                                                      │\n│                                                               │\n└───────────────────────────────────────────────────────────────┘", "   "));

			Terminal.X += 14;
			Terminal.Y -= 3;

			string the_input = Terminal.TextBox (52,"", true);

			Terminal.Y++;

			Terminal.PrintLn ();


			return the_input;

		}


		public static void any_key () {

			UI.enter_to_continue ("press any key to continue",0);

		}

		//
		// FAILED PROFILE
		//

		public static void failed_profile (object[] inps, int[] expects) {

			Terminal.PrintLn ("\n\n   ┌─────────────┬─────────────────────────────────────────────────┐\n   │ KARY SERIES │::: F A I L E D :::::::::::::::::::::::::::::::::│\n   ├─────────────┴─────────────────────────────────────────────────┤\n   │                                                               │");

			UI.WriteLine ("Your formula is no match to our sequance. Here you can see");
			UI.WriteLine ("the first 10 index of your evaluated formula:");
			UI.WriteLine ("");
			UI.WriteLine (" #    │ Test Results            │ Expectations ");
			UI.WriteLine ("──────┼─────────────────────────┼────────────────────────────");

			for (int i = 1 ; i <= inps.Length ; i++) {

				var roman_i = Numerics.Roman (i).PadRight (4);

				UI.WriteLine (" " + roman_i + " │ " + inps [i - 1].ToString ().PadRight (24) + "│ "  + expects[i - 1 ]);

			}
				
			Terminal.PrintLn ("   │                                                               │\n   └───────────────────────────────────────────────────────────────┘\n");
		}


		//
		// SET TITLE
		// 

		public static void setTitle (int level) {

			Terminal.Title = "Kary Series | Level " + level;

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

			Terminal.Clean ();

			Terminal.PrintLn ("\n\n   ┌┬────────┬─────────────────────────────────────────────────────┐\n   ││  KARY  │                                                     │\n   │└────────┘                                                     │\n   │                                                               │\n   │                                                               │\n   │          __     __          __          __         _          │\n   │          \\ \\   / /          \\ \\        / /        | |         │\n   │           \\ \\_/ /__  _   _   \\ \\  /\\  / /__  _ __ | |         │\n   │            \\   / _ \\| | | |   \\ \\/  \\/ / _ \\| '_ \\| |         │\n   │             | | (_) | |_| |    \\  /\\  / (_) | | | |_|         │\n   │             |_|\\___/ \\__,_|     \\/  \\/ \\___/|_| |_(_)         │\n   │                                                               │\n   │         Congratulations! You proved to be a great mater       │\n   │          in understanding sequences! Well done, Truly!        │\n   │                                                               │\n   │                                                               │\n   │                                                               │\n   │                                                               │\n   └───────────────────────────────────────────────────────────────┘");

			UI.enter_to_continue ("press any key to exist", 0);

			Terminal.Clean ();
		}




		public static void intro_screen () {

			Terminal.Clean ();
			Terminal.PrintLn ("\n\n   ┌─────────────┬─────────────────────────────────────────────────┐\n   │ KARY SERIES │::: I N T R O :::::::::::::::::::::::::::::::::::│\n   ├─────────────┴─────────────────────────────────────────────────┤\n   │                                                               │\n   │ Welcome to Kary Series. It's about fining the general formula │\n   │ of sequences. In each level you will get 10 first index of a  │\n   │ sequence and you have to find a formula for it. For example:  │\n   │                                                               │\n   │     [ 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 ]                     │\n   │                                                               │\n   │ And then you will see a prompt like >>> which you have to     │\n   │ your formula there. You have to use parameter `x` as your     │\n   │ index number so the formula will be something like this:      │\n   │                                                               │\n   │     >>> x * 2 - 1                                             │\n   │                                                               │\n   └───────────────────────────────────────────────────────────────┘");
			UI.enter_to_continue ("Press any key to say Got It!", 0);
		}




		public static void p_intro_screen () {

			Console.Clear ();
			Console.WriteLine ("\n\n   ┌─────────────┬─────────────────────────────────────────────────┐\n   │ KARY SERIES │::: I N T R O :::::::::::::::::::::::::::::::::::│\n   ├─────────────┴─────────────────────────────────────────────────┤\n   │                                                               │\n   │ You can get the previous index's value by using parameter     │\n   │ `p` for example look at this sequence:                        │\n   │                                                               │\n   │     [ 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 ]                   │\n   │                                                               │\n   │ Each index is the sum of it's previous index and it's         │\n   │ current index number so the formula will be:                  │\n   │                                                               │\n   │     >>> p + x                                                 │\n   │                                                               │\n   │ NOTE: for the very first index `p` returns zero.              │\n   │                                                               │\n   └───────────────────────────────────────────────────────────────┘");
			UI.enter_to_continue ("Press any key to say Got It!", 0);
		}
	}
}


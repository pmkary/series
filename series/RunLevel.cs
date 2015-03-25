using System;
using NCalc;

namespace Series
{
	public class RunLevel
	{
		/// <summary>
		/// Runs a level
		/// </summary>
		/// <param name="level_number">Level_number.</param>
		public static void Init_Level (int level_number ) {

			Console.Clear ();

			//
			// GETTING THE LEVEL MAP
			//

			int[] level_array = Levels.get (level_number);

			//
			// DONE VAL
			//

			bool were_not_done_yet = true;



			//
			// GOING TILL USER IS RIGHT 
			//

			while (were_not_done_yet) {

				Console.WriteLine ("\n\n");

				//
				// SHOWING THE LEVEL TO THE USER
				//

				UI.question ("Level " + level_number + " = " + ArrayTools.FloatArrayToString (level_array));

				//
				// ASKING FOR FORMULA:
				//

				string formula = UI.input (); if (formula == "") { formula = "0"; };

				//
				// INIT NCALC
				//

				Expression exp = new Expression (formula.ToLower ());

				exp.EvaluateFunction += delegate(string name, FunctionArgs args) {

					if (name == "sgn") {

						if ((int)args.Parameters[0].Evaluate() == 0) {

							args.Result = 0;

						} else if ((int)args.Parameters[0].Evaluate() > 0 ) {

							args.Result = 1;

						} else {

							args.Result = -1;

						}
					}
				};


				//
				// TESTING THE 10 FIRST INDEX
				//

				int[] test_results = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

				bool evaluation_problems = false;

				for (int i = 0; i < 10; i++) {

					// index
					exp.Parameters ["x"] = i + 1;

					// previous index
					if ( i > 0 ) {
						exp.Parameters ["p"] = test_results [i - 1];
					} else {
						exp.Parameters ["p"] = 0;
					}
						
					int temp_result = 0;

					try {

						temp_result = (int)exp.Evaluate ();

					} catch  {

						temp_result = 0;
						evaluation_problems = true;

					}

					test_results [i] = temp_result;
				}


				//
				// Checking the results
				//

				if (!evaluation_problems) {

					bool equal = true;

					/* are they match? */

					for (int i = 0; i < 10; i++) {

						if (test_results[i] != level_array[i]) {

							equal = false;
						}
					}
						

					if (equal == true ) {

						were_not_done_yet = false;
						UI.enter_to_continue ("Great job!", 0);

					} else {

						Console.Clear ();
						UI.failed_profile (test_results, level_array);
						UI.enter_to_continue ("try again...", 0);
						Console.Clear ();

					}

				} else {

					UI.enter_to_continue ("Evaluation problems! Try again please...", 0);
					Console.Clear ();

				}

			} /* <-- end of done yet while */
		}
	}
}


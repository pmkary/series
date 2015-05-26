using System.Diagnostics;
using Kary.Foundation;
using Kary.Calculat;

namespace Series
{

	/* ───────────────────────────────────────────────────────────── *
	 * :::::::::: K A R Y   S E R I E S   R U N L E V E L :::::::::: *
	 * ───────────────────────────────────────────────────────────── */

	public class RunLevel
	{
		/// <summary>
		/// Runs a level
		/// </summary>
		/// <param name="level_number">Level_number.</param>
		public static void Init_Level (int level_number ) {



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

				if ( level_number == 3 ) {

					UI.p_intro_screen ();

				}


				Terminal.Clean ();
				Terminal.PrintLn ("\n\n");


				//
				// SHOWING THE LEVEL TO THE USER
				//

				UI.question ("Level " + level_number + " = ⟨ " + ArrayTools.FloatArrayToString (level_array) + " ⟩");

				//
				// ASKING FOR FORMULA:
				//

				string formula = UI.input (); if (formula == "") { formula = "0"; };

				//
				// INIT NCALC
				//

				Expression exp = new Expression (formula);


				//
				// TESTING THE 10 FIRST INDEX
				//

				object[] test_results = { null, null, null, null, null, null, null, null, null, null };

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
						
					object temp_result;

					try {
					
						temp_result = exp.Evaluate ();

					} catch  {

						temp_result = 0;
						Debug.WriteLine (exp.ParsedExpression.ToString ());
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

						if (test_results[i].ToString () != level_array[i].ToString ()) {

							equal = false;
						}
					}
						

					if (equal == true ) {

						were_not_done_yet = false;
						UI.enter_to_continue ("Great job!", 0);

					} else {

						Terminal.Clean ();
						UI.failed_profile (test_results, level_array);
						UI.enter_to_continue ("try again...", 0);
						Terminal.Clean ();

					}

				} else {

					UI.enter_to_continue ("Evaluation problems! Try again please...", 0);
					Terminal.Clean ();

				}

			} /* <-- end of done yet while */
		}
	}
}
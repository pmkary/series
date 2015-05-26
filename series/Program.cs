
using System;
using Kary.Foundation;
using Kary.Calculat;

namespace Series
{

	/* ───────────────────────────────────────────────────── *
	 * :::::::::: K A R Y   S E R I E S   M A I N :::::::::: *
	 * ───────────────────────────────────────────────────── */

	class MainClass
	{
		public static void Main (string[] args)
		{

			//
			// TERMINATING THE PROCESS IF THE SCREEN SIZE IS TOO SHORT
			//

			string title_before_init = Terminal.Title;

			if (Terminal.Width < 70) {

				Terminal.PrintLn ("\n   --> Screen size is too short. You need more then 70 column\n");
				Terminal.Title = title_before_init;
				Environment.Exit (exitCode:1);

			}


			//
			// WELCOME AND INIT OF NCALC
			//

			UI.welcome ();

			Expression load_lib_expression = new Expression ("2 * 3 + 1");
			load_lib_expression.Evaluate ();

			UI.enter_to_continue ("press any key to start...", 0);
			UI.intro_screen ();


			//
			// BODY
			//

			bool cont_1 = true;
			int  level  = 1;

			while (cont_1) {

				if (Levels.get_max_level () >= level ) {

					UI.setTitle (level);
					RunLevel.Init_Level (level);
					level++;

				} else {

					UI.you_won_screen ();
					cont_1 = false;
					Terminal.Title = title_before_init;

				}
			}


			//
			// AND WE'RE ALL DONE
			//
		}
	}
}
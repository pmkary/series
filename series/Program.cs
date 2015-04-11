using System;
using NCalc;

namespace Series
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			UI.welcome ();

			Expression load_lib_expression = new Expression ("2 * 3 + 1");
			load_lib_expression.Evaluate ();

			UI.enter_to_continue ("press any key to start...", 0);
			UI.intro_screen ();

			bool cont_1 = true;
			int level = 1;

			while (cont_1) {

				if (Levels.get_max_level () >= level ) {

					UI.setTitle (level);
					RunLevel.Init_Level (level);
					level++;

				} else {

					UI.you_won_screen ();
					cont_1 = false;
				}
			}
		}
	}
}

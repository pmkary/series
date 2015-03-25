using System;

namespace Series
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			UI.welcome ();
			UI.enter_to_continue ("press any key to start...", 0);


			bool cont_1 = true;
			int level = 1;

			while (cont_1) {

				UI.setTitle (level);

				RunLevel.Init_Level (level);

				cont_1 = false;
			}
		}
	}
}

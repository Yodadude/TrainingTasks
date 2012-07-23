using System;
using System.Collections.Generic;

namespace TrainingTasks3
{
    public class Menu
    {

		public static MenuConfig Config(Action<MenuConfig> func)
		{

            var config = new MenuConfig();

            func(config);

            return config;

        }

	}

}
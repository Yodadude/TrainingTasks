using System;

namespace TrainingTasks3
{
    public class Menu
    {
		public static MenuConfig Config(Action<IMenuConfigBuilder> action)
		{

			var config = new MenuConfig();
			var cfgbuilder = new MenuConfigBuilder(config);

			action(cfgbuilder);

            return config;

        }
	}

}
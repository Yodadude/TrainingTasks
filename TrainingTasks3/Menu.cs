using System;

namespace TrainingTasks3
{
    public class Menu
    {

		public static MenuConfig Config(Action<IMenuConfigBuilder> action)
		{

			var config = new MenuConfig();
			var builder = new MenuConfigBuilder(config);

			action(builder);

            return config;

        }

	}

}
using System;
using System.Collections.Generic;

namespace TrainingTasks3
{
	public class MenuConfigBuilder : IMenuConfigBuilder
	{
		private readonly MenuConfig _config;

		public MenuConfigBuilder(MenuConfig config)
		{
			_config = config;
		}

		public void AddStatic(string url, string label)
		{
			_config.MenuItems.Add(new MenuItem{Url = url, Label = label});
		}

		public void AddDynamic(Func<MenuContext, IEnumerable<MenuItem>> func)
		{
			_config.DynamicMenu = func;
		}

		public void Visible(Func<MenuContext, MenuItem, bool> func)
		{
			_config.IsVisible = func;
		}
	}
}

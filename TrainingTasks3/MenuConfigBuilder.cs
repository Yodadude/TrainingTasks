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
			_config.StaticMenuItems.Add(new MenuItem { Url = url, Text = label });
		}

		public void AddDynamic(Func<MenuContext, IEnumerable<MenuItem>> func)
		{
			_config.DynamicMenuItemsFunc = func;
		}

		public void Visible(Func<MenuContext, MenuItem, bool> func)
		{
			_config.IsVisibleFunc = func;
		}
	}
}

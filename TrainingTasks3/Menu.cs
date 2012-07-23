using System;
using System.Collections.Generic;

namespace TrainingTasks3
{
    public class Menu
    {

		public MenuConfig Config(Func<MenuConfigOptions, MenuConfig> func)
		{
			var config = new MenuConfigOptions();
			return func(config);

			//return new MenuConfig
			//        {
			//            MenuItem = func(config).MenuItem,
			//            DynamicMenu = func(config).DynamicMenu,
			//            IsVisible = func(config).IsVisible
			//        };
		}

	}


	public interface IMenuConfigOptions
	{
		MenuItem AddStatic(string url, string label);
		IEnumerable<MenuItem> AddDynamic(Func<MenuContext, IEnumerable<MenuItem>> func);
		bool Visible(Func<MenuContext, MenuItem, bool> func);
	}

	public class MenuConfigOptions : IMenuConfigOptions
	{
		public MenuItem AddStatic(string url, string label)
		{
			return new MenuItem {Url = url, Label = label};
		}

		public IEnumerable<MenuItem> AddDynamic(Func<MenuContext, IEnumerable<MenuItem>> func)
		{
			return new List<MenuItem>();
		}

		public bool Visible(Func<MenuContext, MenuItem, bool> func)
		{
			return func(new MenuContext(), new MenuItem());
		}
	}
}
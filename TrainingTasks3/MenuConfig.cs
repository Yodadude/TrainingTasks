using System;
using System.Collections.Generic;

namespace TrainingTasks3
{
	public class MenuConfig
	{
        public List<MenuItem> MenuItems;
		public Func<MenuContext, IEnumerable<MenuItem>> DynamicMenu { get; set; }
		public Func<MenuContext, MenuItem, bool> IsVisible { get; set; }
        public MenuContext MenuContext;

		public MenuConfig()
		{
			MenuItems = new List<MenuItem>();
            MenuContext = new MenuContext();
        }

	}
}
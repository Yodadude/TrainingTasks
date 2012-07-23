using System;
using System.Collections.Generic;

namespace TrainingTasks3
{
	public class MenuConfig : IMenuConfig
	{
        public MenuItem MenuItem;
        public IEnumerable<MenuItem> DynamicMenu { get; set; }
        public bool IsVisible { get; set; }
        public MenuContext MenuContext;

        public MenuConfig()
        {
            MenuItem = new MenuItem();
            MenuContext = new MenuContext();
        }

        public void AddStatic(string url, string label)
        {
            this.MenuItem.Url = url;
            this.MenuItem.Label = label;
        }

        public void AddDynamic(Func<MenuContext, IEnumerable<MenuItem>> func)
        {
           this.DynamicMenu = func(MenuContext);
        }

        public void Visible(Func<MenuContext, MenuItem, bool> func)
        {
            this.IsVisible = func(this.MenuContext, this.MenuItem);
        }
	}
}
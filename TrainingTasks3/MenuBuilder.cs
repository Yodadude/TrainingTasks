using System.Collections.Generic;

namespace TrainingTasks3
{
    public class MenuBuilder
    {
        private readonly MenuContext _context;
        private readonly MenuConfig _config;

        public MenuBuilder(MenuContext context, MenuConfig config)
        {
            _context = context;
            _config = config;
        }

        public List<MenuItem> Build()
        {
        	var menuItems1 = _config.StaticMenuItems;
			var menuItems2 = _config.DynamicMenuItemsFunc(_context);

			menuItems1.AddRange(menuItems2);

        	foreach (var menuItem in menuItems1)
        	{
        		if (_config.IsVisibleFunc(_context, menuItem))
        		{
        			menuItem.Text = "";
        		}
        	}

			return menuItems1;
        }
    }
}
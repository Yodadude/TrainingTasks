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
        	var menuItems = new List<MenuItem>();

			if (_config.StaticMenuItems != null)
			{
				menuItems.AddRange(_config.StaticMenuItems);
			}

        	if (_config.DynamicMenuItemsFunc != null)
			{
				var menuItems2 = _config.DynamicMenuItemsFunc(_context);
				menuItems.AddRange(menuItems2);
			}

			foreach (var menuItem in menuItems)
        	{
        		if (_config.IsVisibleFunc(_context, menuItem))
        		{
        			menuItem.Text = "";
        		}
        	}

			return menuItems;
        }
    }
}
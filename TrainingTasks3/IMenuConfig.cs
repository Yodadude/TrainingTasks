using System;
using System.Collections.Generic;

namespace TrainingTasks3
{
    interface IMenuConfig
    {
		void AddStatic(string url, string label);
        void AddDynamic(Func<MenuContext, IEnumerable<MenuItem>> func);
        void Visible(Func<MenuContext, MenuItem, bool> func);
    }
}

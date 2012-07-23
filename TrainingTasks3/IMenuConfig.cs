using System;
using System.Collections.Generic;

namespace TrainingTasks3
{
    interface IMenuConfig
    {
        void AddDynamic(Func<MenuContext, IEnumerable<MenuItem>> func);
        void AddStatic(string url, string label);
        void Visible(Func<MenuContext, MenuItem, bool> func);
    }
}

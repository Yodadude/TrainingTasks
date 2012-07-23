using System;
using System.Collections.Generic;

namespace TrainingTasks3
{
	public class MenuConfig
	{
		public MenuItem MenuItem { get; set; }
		public IEnumerable<MenuItem> DynamicMenu { get; set; }
		public bool IsVisible { get; set; }
	}
}
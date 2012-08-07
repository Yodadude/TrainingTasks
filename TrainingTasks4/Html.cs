using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingTasks4
{
	public class Html
	{
		private string _tagName = "";
		private IDictionary<string, string> _attributes = new Dictionary<string, string>();
		private List<string> _classes = new List<string>();

		public Html(string tag)
		{
			_tagName = tag;
			_attributes = new Dictionary<string, string>();
			_classes = new List<string>();
		}
		public static Html Tag(string tag)
		{
			return new Html(tag);
		}
		public Html Attr(string name, string value)
		{
			 //name + "=\"" + value + "\" ";
			_attributes.Add(name, value);
			return this;
		}
		public Html AddClass(string classname)
		{
			//if (classname.Contains("class="))
			//{
			//    return classname.Substring(0, classname.LastIndexOf("\"")) + classname +"\"";	
			//}
			//else
			//{
			//    return "class=\"" + classname + "\"";
			//}
			_classes.Add(classname);
			return this;
		}

		public Html Modify(Action<Html> action)
		{
			action(this);
			return this;
		}

		public string ToString()
		{
			string tagClass = "";
			string tagAttr = "";

			if (_classes.Any())
			{
				tagClass = "class=\"" + String.Join(" ", _classes) + "\"";
			}

			if (_attributes.Any())
			{
				foreach (var item in _attributes)
				{
					tagAttr += item.Key + "=\"" + item.Value + "\"";
				}
			}

			//return "<" + _tagName + " " + String.Join(" ", tagAttr) +" "+ tagClass + "></" + _tagName + ">";
			return "<" + _tagName + " " + String.Join(" ", tagAttr) + tagClass + "></" + _tagName + ">";
		}

		public static implicit operator string(Html html)
		{
			return html.ToString();
		}
	}
}

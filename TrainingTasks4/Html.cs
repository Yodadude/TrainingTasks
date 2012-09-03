using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace TrainingTasks4
{
	public class Html
	{
		protected string _tagName = "";
		protected IDictionary<string, string> _attributes = new Dictionary<string, string>();
		protected List<string> _classes = new List<string>();
        private Boolean _selfClosing;

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

		public Html Attr(string key, object value)
		{
            if (!String.IsNullOrWhiteSpace(key) && value != null)
            {
                _attributes.Add(key, value.ToString());
            }
			return this;
		}

		public Html AddClass(string classname)
		{
			_classes.Add(classname);
			return this;
		}

		public Html Modify(Action<Html> action)
		{
			action(this);
			return this;
		}

        public Html SelfClosing()
        {
            this._selfClosing = true;
            return this;
        }

		public override string ToString()
		{
			string tagClass = "";
			string tagAttr = "";

			if (_classes.Any())
			{
				tagClass = " class=\"" + String.Join(" ", _classes) + "\"";
			}

			if (_attributes.Any())
			{
				foreach (var item in _attributes)
				{
					tagAttr += " "+item.Key + "=\"" + item.Value + "\"";
				}
			}

			return "<" + _tagName + tagAttr + tagClass + (_selfClosing ? "/>" : "></" + _tagName + ">");
		}

		public static implicit operator string(Html html)
		{
			return html.ToString();
		}
	}
	
	public class UserDetails
	{
		public string Location	{ get; set; }
	}

}

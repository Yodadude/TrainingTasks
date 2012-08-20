﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace TrainingTasks4
{
	public class Html
	{
		private readonly string _tagName = "";
		private readonly IDictionary<string, string> _attributes = new Dictionary<string, string>();
		private readonly List<string> _classes = new List<string>();

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
			_attributes.Add(name, value);
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

		public new string ToString()
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

			return "<" + _tagName +  tagAttr + tagClass + "></" + _tagName + ">";
		}

		public static implicit operator string(Html html)
		{
			return html.ToString();
		}
	}


	public class Html<T>
	{
		private string _tagName = "";
		private readonly IDictionary<string, string> _attributes = new Dictionary<string, string>();
		private readonly List<string> _classes = new List<string>();
		private readonly T _obj;

		public Html(T obj)
		{
			_obj = obj;
		}

		public Html<T> InputFor(Expression<Func<T, object>> expr)
		{

			this._tagName = "input";
			Attr("type", "text");

			var body = ((LambdaExpression)expr).Body;
			var memberExpression = body as MemberExpression;
			if (memberExpression != null)
			{
				var objectValue = expr.Compile().Invoke(_obj).ToString();
				Attr("name", memberExpression.Member.Name).Attr("value", objectValue);
			}

			return this;
		}

		public Html<T> Attr(string name, string value)
		{
			_attributes.Add(name, value);
			return this;
		}

		public Html<T> AddClass(string classname)
		{
			_classes.Add(classname);
			return this;
		}

		public Html<T> Modify(Action<Html<T>> action)
		{
			action(this);
			return this;
		}

		public new string ToString()
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
					tagAttr += " " + item.Key + "=\"" + item.Value + "\"";
				}
			}

			return "<" + _tagName + tagAttr + tagClass + "></" + _tagName + ">";
		}

		public static implicit operator string(Html<T> html)
		{
			return html.ToString();
		}
	}


	public class UserDetails
	{
		public string Location	{ get; set; }
	}
}

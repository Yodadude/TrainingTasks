using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace TrainingTasks4
{
    public class HtmlHelper<T>
    {
        private readonly T _model;

        public HtmlHelper(T model)
        {
            _model = model;
        }

        public string InputFor(Expression<Func<T, object>> expr)
        {
            var html = new Html("input").Attr("type", "text");

            var body = expr.Body;
            var memberExpression = body as MemberExpression;
            if (memberExpression != null)
            {
                var objectValue = expr.Compile().Invoke(_model).ToString();
                html.Attr("name", memberExpression.Member.Name).Attr("value", objectValue).SelfClosing();
            }

            return html.ToString();
        }

    }
}

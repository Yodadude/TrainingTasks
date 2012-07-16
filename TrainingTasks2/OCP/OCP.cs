using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainingTasks2.OCP
{
	public abstract class ShoppingCartBase
	{
		public List<CartItem> _items;

		protected ShoppingCartBase()
        {
            _items = new List<CartItem>();
        }

		public virtual void Add(CartItem product)
		{
			_items.Add(product);
		}

		public virtual void Delete(CartItem product)
		{
			_items.Remove(product);
		}

		public virtual decimal GetDiscountPercentage()
		{
			return 0;
		}
	}


	public class ShoppingCart : ShoppingCartBase
    {
        public override decimal GetDiscountPercentage()
        {
            decimal ammount = base.GetDiscountPercentage();

            if (_items.Count >= 5 && _items.Count < 10)
            {
                ammount = 10;
            }
            else if (_items.Count >= 10 && _items.Count < 15)
            {
                ammount = 15;
            }
            else if (_items.Count >= 15)
            {
                ammount = 25;
            }

            return ammount;
        }
    }
}

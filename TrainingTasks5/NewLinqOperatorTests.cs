using System.Collections;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TrainingTasks5
{
    [TestFixture]
    public class NewLinqOperatorTests
    {
        // Implement WhereIf linq operator which takes a boolean condition and a predicate and only evaluates the predicate if the condition is true.
        // eg. list.WhereIf(true, x=>x.IsActive);

        // Implement Alternate which when given an additional list will return the 1 element from the first list then 1 from the second and so on.
        // eg. list.Alternate(list2);

        [Test]
        public void WhereIf_Test1()
        {

			var products = Data.GetProducts().WhereIf(true, x => x.Category.Equals("Condiments"));

			Assert.AreEqual(12, products.Count());

        }


		[Test]
		public void Alternate_Test1()
		{
			var meat = Data.GetProducts().WhereIf(true, x => x.Category.Equals("Meat/Poultry"));
			var seafood = Data.GetProducts().WhereIf(true, x => x.Category.Equals("Seafood"));
			var allmeat = meat.Alternate(seafood).ToList();

            Assert.AreEqual("Meat/Poultry", allmeat[0].Category);
			Assert.AreEqual("Seafood", allmeat[1].Category);
			Assert.AreEqual("Meat/Poultry", allmeat[2].Category);
			Assert.AreEqual("Seafood", allmeat[3].Category);

		}

    }
}

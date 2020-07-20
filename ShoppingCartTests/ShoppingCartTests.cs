using NUnit.Framework;
using ShoppingCart.Service;

namespace ShoppingCartTests
{
    [TestFixture]
    public class Tests
    {
        
        [TestCase("ABCDABAA", ExpectedResult = 32.40)]
        [TestCase("CCCCCCC", ExpectedResult = 7.25)]
        [TestCase("ABCD", ExpectedResult = 15.40)]
        public decimal ShoppingCartTotalTest(string cartItems)
        {
            PointOfSaleService pointOfSaleService = new PointOfSaleService();

            foreach(char c in cartItems)
            {
                pointOfSaleService.Scan(c.ToString());
            }

            return pointOfSaleService.Total();
        }
    }
}
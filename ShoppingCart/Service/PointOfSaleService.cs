using ShoppingCart.Interface;
using ShoppingCart.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCart.Service
{
    public class PointOfSaleService : ITerminal
    {
        private ShoppingCartModel _shoppingCart;
        public PointOfSaleService() {
            _shoppingCart = new ShoppingCartModel();
            _shoppingCart.ProductCode = new List<string>();
        }
         
        public void Scan(string item)
        {
            _shoppingCart.ProductCode.Add(item);
        }

        public decimal Total()
        {
            decimal total = 0;
            var productGroups = _shoppingCart.ProductCode.GroupBy(p => p).ToList();

            foreach(var product in productGroups)
            {
                int prodCount = product.Count();
                while (prodCount > 0)
                {
                    switch (product.Key)
                    {
                        case "A":
                            if(prodCount/4 >= 1)
                            {
                                total = total + 7;
                                prodCount = prodCount - 4;
                            }
                            else
                            {
                                total = total + 2;
                                prodCount--;
                            }
                            break;
                        case "B":
                            total = total + (prodCount * 12);
                            prodCount = 0;
                            break;
                        case "C":
                            if (prodCount/6 >= 1)
                            {
                                total = total + 6;
                                prodCount = prodCount - 6;
                            }
                            else
                            {
                                total = total + 1.25m;
                                prodCount--;
                            }
                            break;
                            
                        case "D":
                            total = total + (prodCount * .15m);
                            prodCount = 0;
                            break;


                    }
                }
                

            }



            return total;
            
        }
    }
}

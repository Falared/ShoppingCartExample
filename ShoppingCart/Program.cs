using ShoppingCart.Interface;
using ShoppingCart.Service;
using System;

namespace ShoppingCart
{
    public class ShoppingCart 
    {
        static void Main(string[] args)
        {
            PointOfSaleService pointOfSaleService = new PointOfSaleService();
            pointOfSaleService.Scan("A");
            pointOfSaleService.Scan("A");
            pointOfSaleService.Scan("B");
            Console.WriteLine(pointOfSaleService.Total().ToString());

        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContractsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //#####################################################################################
                // sunny day add / remove some stock
                //#####################################################################################
                var product = new Product { Name = "Apple" };
                product.AddStock(5);
                product.AddStock(1);
                Console.WriteLine(product.Stock);
                product.Pick(2);
                Console.WriteLine(product.Stock);
                //#####################################################################################

                //#####################################################################################
                // rainy day add / remove some stock
                //#####################################################################################
                var product2 = new Product { Name = "Apple" };
                product2.AddStock(5);
                product2.AddStock(-1);
                product2.AddStock(1);
                Console.WriteLine(product2.Stock);
                product2.Pick(100);
                Console.WriteLine(product2.Stock);
                //#####################################################################################

                //#####################################################################################
                // rainy day add / remove some stock (DEFENSIVE)
                //#####################################################################################
                var product3 = new ProductDefensive() { Name = "Apple" };
                product3.AddStock(5);
                product3.AddStock(-1);
                Console.WriteLine(product3.Stock);
                //#####################################################################################

                //#####################################################################################
                // rainy day add / remove some stock (CONTRACTS)
                //#####################################################################################
                var product4 = new ProductWithContracts() { Name = "Apple" };
                product4.AddStock(5);
                product4.AddStock(-1);
                Console.WriteLine(product4.Stock);
                //#####################################################################################

                //#####################################################################################
                // rainy day add / remove some stock (CONTRACTS2)
                //#####################################################################################
                var product5 = new ProductWithContracts() { Name = "Apple" };
                product5.AddStock(5);
                Console.WriteLine(product5.Stock);
                product5.Pick(100);
                //#####################################################################################
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}

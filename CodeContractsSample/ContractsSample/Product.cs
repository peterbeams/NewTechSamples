using System;

namespace ContractsSample
{
    public class Product
    {
        public int Stock { get; private set; }
        public string Name { get; set; }

        public void AddStock(int value)
        {
            Stock += value;
            Console.WriteLine(string.Concat("Adding ", value));
        }

        public void Pick(int value)
        {
            Stock -= value;
            Console.WriteLine(string.Concat("Picking ", value));
        }
    }
}
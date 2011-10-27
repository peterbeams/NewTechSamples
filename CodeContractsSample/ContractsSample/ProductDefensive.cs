using System;

namespace ContractsSample
{
    public class ProductDefensive
    {
        public int Stock { get; private set; }
        public string Name { get; set; }

        public void AddStock(int value)
        {
            if (value < 1)
            {
                throw new ArgumentException("value must be greater than 1", "value");
            }

            Stock += value;
            Console.WriteLine(string.Concat("Adding ", value));
        }

        public void Pick(int value)
        {
            if (value < 1)
            {
                throw new ArgumentException("value must be greater than 1", "value");
            }

            if (Stock - value < 0)
            {
                throw new InvalidOperationException("Cannot have negative stock values.");
            }

            Stock -= value;
            Console.WriteLine(string.Concat("Picking ", value));
        }
    }
}
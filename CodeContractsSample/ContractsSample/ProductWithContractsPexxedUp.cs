using System;
using System.Diagnostics.Contracts;

namespace ContractsSample
{
    public class ProductWithContractsPexxedUp
    {
        public int Stock { get; private set; }
        public string Name { get; set; }

        public void AddStock(int value)
        {
            Contract.Requires(value > 0);
            Contract.Requires((long)value + (long)Stock < int.MaxValue);
            Stock += value;
            Console.WriteLine(string.Concat("Adding ", value));
        }

        public void Pick(int value)
        {
            Contract.Requires(value <= Stock);
            Contract.Requires(value > 0);
            Stock -= value;
            Console.WriteLine(string.Concat("Picking ", value));
        }

        [ContractInvariantMethod]
        private void Invariant()
        {
            Contract.Invariant(Stock >= 0);
        }
    }
}
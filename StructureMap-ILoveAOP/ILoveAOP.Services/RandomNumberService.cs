using System;
using System.Threading;

namespace ILoveAOP.Services
{
    public class RandomNumberService : IRandomNumberService
    {
        private readonly Random random = new Random();

        [RequiresRole("Admin")]
        public int Get()
        {
            Thread.Sleep(random.Next(1000, 3000));

            return random.Next();
        }
    }
}
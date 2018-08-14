namespace _05.RandomList
{
    using System;
    using System.Collections.Generic;

    public class RandomList 
    {
        private Random random;

        public List<string> RandomString(List<string> input)
        {
            this.random = new Random();
            int element = random.Next(-1, input.Count -1);
            input.RemoveAt(element);

            return input;
        }
    }
}

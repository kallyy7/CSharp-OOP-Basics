namespace _05.StackOfStrings
{
    using System.Collections.Generic;

    public class StackOfStrings
    {
        private Stack<string> data;

        public Stack<string> Data
        {
            get => this.data;
            set => data = value;
        }

        public StackOfStrings(Stack<string> data)
        {
            this.Data = data;
        }

        public void Push(string inputData)
        {
            this.data.Push(inputData);
        }

        public string Pop()
        {
            return this.data.Pop();
        }

        public string Peek()
        {
            return this.data.Peek();
        }

        public bool IsEmpty()
        {
            return this.data.Count < 0 ? true : false;
        }
    }
}

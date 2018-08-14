namespace _05.StackOfStrings
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var currentStack = new Stack<string>();

            StackAdd(currentStack);

            var stack = new StackOfStrings(currentStack);

            while (true)
            {
                var input = Console.ReadLine()
                    .ToLower()
                    .Split()
                    .ToArray();
                string command = input[0];

                if (command.Equals("end"))
                {
                    Environment.Exit(0);
                }
                dynamic result = string.Empty;

                switch (command)
                {
                    case "push":
                        string inputData = input[1];
                        stack.Push(inputData);
                        break;
                    case "pop":
                        result = stack.Pop();
                        break;
                    case "peek":
                        result = stack.Peek();
                        break;
                    case "isempty":
                        result = stack.IsEmpty();
                        break;
                    default:
                        result = "unrecognized command";
                        break;
                }

                Console.WriteLine(result);
            }
        }

        private static void StackAdd(Stack<string> currentStack)
        {
            while (true)
            {
                Console.Write("Add: ");
                string inputForAdd = Console.ReadLine();

                if (inputForAdd.Equals("end"))
                {
                    break;
                }

                currentStack.Push(inputForAdd);
            }
        }
    }
}

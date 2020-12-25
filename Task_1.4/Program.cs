using System;
using System.Collections.Generic;

namespace Task_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task 1.4 Pairing brackets check\n Voronova Emilia");
            Console.WriteLine(" Enter an expression using (), {}, [], <> brackets. The program willcheck if your expression is correct.");
            Dictionary<char, char> brackets = new Dictionary<char, char> { { ')', '(' } , { '}', '{'}, { ']', '[' }, { '>', '<' } };
            var expression = Console.ReadLine();
            while (expression == "")
            {
                Console.WriteLine("You must enter an expression. Try again : ");
                expression = Console.ReadLine();
            }
            var stack = new Stack<char>();
            var indices = new Stack<int>();
            bool isValid = true;
            for (int i = 0; i < expression.Length; i++)
            {
                var character = expression[i];
                if (character.Equals('(') || character.Equals('{') || character.Equals('[') || character.Equals('<'))
                {
                    stack.Push(character);
                    indices.Push(i);
                }
                else if (character.Equals(')') || character.Equals('}') || character.Equals(']') || character.Equals('>'))
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine(" Error on index : " + i);
                        isValid = false;
                        break;
                    }
                    else if (brackets.GetValueOrDefault(character) != stack.Peek())
                    {
                        Console.WriteLine(indices.Peek());
                        isValid = false;
                        break;
                    }
                    else
                    {
                        stack.Pop();
                        indices.Pop();
                    }
                }
            }
            if (isValid)
            {
                if (stack.Count != 0)
                {
                    Console.WriteLine(" Error at index : " + indices.Peek());
                }
                else
                {
                    Console.WriteLine(" Expression is correct.");
                }
            }
        }
    }
}

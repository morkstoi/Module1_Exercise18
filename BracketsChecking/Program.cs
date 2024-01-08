using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketsChecking
{
    public class BracketChecker
    {
        private Dictionary<char, char> bracketPairs = new Dictionary<char, char>()
    {
        { '(', ')' },
        { '[', ']' },
        { '{', '}' }
    };

        public bool CheckBrackets(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (bracketPairs.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (bracketPairs.ContainsValue(c))
                {
                    if (stack.Count == 0 || bracketPairs[stack.Peek()] != c)
                    {
                        return false;
                    }

                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            BracketChecker bracketChecker = new BracketChecker();

            string input = Console.ReadLine();
            Console.WriteLine(bracketChecker.CheckBrackets(input));
            Console.ReadKey();

        }
    }
}

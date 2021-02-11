using System;
using System.Collections.Generic;
using System.Linq;

namespace Youtube_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            IsValid("()[]{}");
        }

        public static bool IsValid(string s)
        {
            Dictionary<char, char> bracketsLookUp = new Dictionary<char, char>();

            bracketsLookUp.Add('(', ')');
            bracketsLookUp.Add('[', ']');
            bracketsLookUp.Add('{', '}');

            Stack<char> openBrackets = new Stack<char>();

            foreach (char c in s)
            {
                if (bracketsLookUp.ContainsKey(c))
                {
                    openBrackets.Push(c);
                }
                else
                {
                    if (!openBrackets.Any())
                    {
                        return false;
                    }

                    char lastOpen = openBrackets.Pop();

                    char closingBracket = bracketsLookUp[lastOpen];

                    if (closingBracket != c)
                    {
                        return false;
                    }
                }
            }

            return !openBrackets.Any();

        }
    }
}

using System;
using System.Collections.Generic;

namespace StackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string[] exp = new string[] { "(", "{", "[", "]", "}", ")" };
            int n = exp.Length;

            bool isOrdered = true;

            for (int i = 0; i < n; i++)
            {
                char bracket = exp[i][0]; // Convert string to char

                if (bracket == '(' || bracket == '{' || bracket == '[') //checking for opening brackets and pushes them onto the stack
                {
                    stack.Push(bracket);
                }
                else if (bracket == ')' || bracket == '}' || bracket == ']') // checking for clossing brackets to see if it has a matchig opening bracket on stack
                {
                    if (stack.Count == 0) //checks if stack is empty
                    {
                        isOrdered = false;
                        break;
                    }

                    char top = stack.Pop(); // top element should be the most recent unmatched opening bracket, checked if it matches the closing bracket

                    if ((bracket == ')' && top != '(') ||
                        (bracket == '}' && top != '{') ||
                        (bracket == ']' && top != '['))
                    {
                        isOrdered = false; //if no match then they are not correctly ordered
                        break;
                    }
                }
            }

            // Check if stack is empty
            if (stack.Count != 0)
            {
                isOrdered = false;
            }

            if (isOrdered) //output if it is ordered or not
            {
                Console.WriteLine("ordered.");
            }
            else
            {
                Console.WriteLine("not ordered.");
            }

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EvaluatePostfix
{
    internal class InfixToPostfix
    {
        public int precedence(char op)
        {
            if (op == '*' || op == '/' || op == '%')
                return 2;
            else if (op == '+' || op == '-')
                return 1;
            else if (op == '^')
                return 3;
            else return -1;
        }

        public string Infix_To_Postfix(ref string expn)
        {
            Stack<char> stk = new Stack<char>();
            string output = "";
            char _out;

            for (int i = 0; i < expn.Length; i++)
            {
                char ch = expn[i];
                bool isAlphaBet = Regex.IsMatch(ch.ToString(), "[a-z]", RegexOptions.IgnoreCase);

                if (Char.IsDigit(ch) || isAlphaBet)
                {
                    while (i < expn.Length && (Char.IsDigit(expn[i]) || Regex.IsMatch(expn[i].ToString(), "[a-z]", RegexOptions.IgnoreCase)))
                    {
                        output += expn[i];
                        i++;
                    }
                    output += " ";
                    i--;
                }
                else
                {
                    switch (ch)
                    {
                        case '+':
                        case '-':
                        case '*':
                        case '/':
                        case '%':
                        case '^':
                            while (stk.Count > 0 && precedence(ch) <= precedence(stk.Peek()))
                            {
                                _out = stk.Peek();
                                stk.Pop();
                                output += _out + " ";
                            }
                            stk.Push(ch);
                            break;
                        case '(':
                            stk.Push(ch);
                            break;
                        case ')':
                            while (stk.Count > 0 && (_out = stk.Peek()) != '(')
                            {
                                stk.Pop();
                                output += _out + " ";
                            }
                            if (stk.Count > 0 && (_out = stk.Peek()) == '(')
                                stk.Pop();
                            break;
                    }
                }
            }

            while (stk.Count > 0)
            {
                _out = stk.Peek();
                stk.Pop();
                output += _out + " ";
            }
            return output.Trim();
        }
    }
}
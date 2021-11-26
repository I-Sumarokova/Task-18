using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Stack<char> stack = new Stack<char>();
            char[] array = new char[6] { '(', '[', ']', ')', '{', '}' };
            foreach (char s in array)
            {
                Console.Write(s);
            }

            foreach (char s in array)
            {
                if (s == '(' || s == '{' || s == '[')
                {
                    stack.Push(s);
                }

                if ((s == ')' || s == '}' || s == ']') )
                {
                    char c = stack.Peek();

                    switch (s)
                    {
                        case ')':
                            if (c == '(')
                            {
                                stack.Pop();
                            }
                            break;

                        case '}':
                            if (c == '{')
                            {
                                stack.Pop();
                            }
                            break;

                        case ']':
                            if (c == '[')
                            {
                                stack.Pop();
                            }
                            break;
                    }


                }


            }

            Console.WriteLine();
            if (stack.Count==0)
            {
                Console.WriteLine("Скобки расставлены корректно");
            }
            else
            {
                Console.WriteLine("! Скобки расставлены не корректно");
            }
            Console.ReadKey();
        }
    }
}

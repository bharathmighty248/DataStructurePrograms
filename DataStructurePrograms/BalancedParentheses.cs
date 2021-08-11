using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    public class BalancedParentheses<T>
    {
        StackOperations<T> stack = new StackOperations<T>();
        public void CheckParentheses()
        {
            string Expression = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";
            char[] charArray = Expression.ToCharArray();

            foreach (char i in charArray)
            {
                Console.WriteLine(i);
                if (i == '(')
                {
                    T x = (T)Convert.ChangeType(i, typeof(T));
                    stack.Push(x);
                }
                else if (i == ')')
                {
                    stack.Pop();
                }
            }
            if (stack.Size() > 0)
            {
                Console.WriteLine("\nNot a Balanced Expression...");
            }
            else
            {
                Console.WriteLine("\nBalanced Expression...");
            }

        }
    }
}

using System.Collections;

namespace CodeWars.Test.Task12
{
    public class Parentheses
    {
        public static bool ValidParentheses(string input)
        {
            Hashtable map = new Hashtable(){
                {'{','}'},
                {'(',')'},
                {'[',']'}
            };

            Stack stack = new Stack();

            foreach (char c in input)
            {
                if (map.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else if (map.ContainsValue(c))
                {
                    if (stack.Count > 0 && (char)map[(char)stack.Peek()] == c)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return (stack.Count == 0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode75Solutions.ClassLibrary.Stack
{
    public class AstroidCollision735
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();
            foreach (int asteroid in asteroids)
            {
                bool destroyed = false;
                while (stack.Count > 0 && asteroid < 0 && stack.Peek() > 0)
                {
                    int top = stack.Peek();
                    if (top < -asteroid)
                    {
                        stack.Pop();
                        continue;
                    }
                    else if (top == -asteroid)
                    {
                        stack.Pop();
                    }
                    destroyed = true;
                    break;
                }
                if (!destroyed)
                {
                    stack.Push(asteroid);
                }
            }

            int[] result = stack.ToArray();
            Array.Reverse(result);
            return result;
        }
    }
}

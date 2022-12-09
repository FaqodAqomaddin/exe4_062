using System;
using System.Collections;

namespace Exercise_4
{
    class Exercise_4
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push('w');
            st.Push('x');
            st.Push('y');
            Console.WriteLine("Count of elements in the current Stack: " + st.Count);
            Console.WriteLine("Stack = ");
            foreach (char ch in st)
            {
                Console.WriteLine(ch + " ");
            }
        }
    }
}
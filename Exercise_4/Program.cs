﻿using System;
using System.Collections;

namespace Exercise_4
{
    class Exercise_4
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push('e');
            st.Push('f');
            st.Push('g');
            Console.WriteLine("Count of elements in the current Stack: " + st.Count);
            Console.WriteLine("Stack = ");
            foreach (char ch in st)
            {
                Console.WriteLine(ch + " ");
            }
            Console.WriteLine();
            st.Push('a');
            st.Push('b');
            st.Push('c');
            st.Push('d');
            Console.WriteLine("Stack after adding two elements");
            foreach (char ch in st)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine("\nCount of elements in the current stack: " + st.Count);
            Console.WriteLine();
            Console.WriteLine("Pop a value!");
            st.Pop();
            Console.WriteLine("Current stack:");
            foreach (char ch in st)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine("\nCount of elements in the Current Stack: " + st.Count);
        }
    }
}
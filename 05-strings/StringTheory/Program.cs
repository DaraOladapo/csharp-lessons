using System;

namespace StringTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            string Theory = "The theory of strings states that strings are strings";
            Console.WriteLine(Theory);
            string NewLineTheory = "The theory starting on a \nnew line\n uses an escape sequence \\n";
            Console.WriteLine(NewLineTheory);
            string TabTheory = "Oh yes!, I want to use a \ttab so I use the \\t";
            Console.WriteLine(TabTheory);
            string DoubleQuoteTheory="I am in a \"double quote\" using \\\" \\\"";
            Console.WriteLine(DoubleQuoteTheory);
        }

    }
}

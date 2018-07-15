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
            //replacing content...
            string ReplacedTheory = Theory.Replace("states that", "kinda states that");
            Console.WriteLine(ReplacedTheory);
            int someValue = 1952;
            //concats and literal strings
            Console.WriteLine(Theory+ " came to life in " + someValue);
            Console.WriteLine("{0} came to life in {1}", Theory, someValue);
            Console.WriteLine($"{Theory} came to life in {someValue}");

            //formatiing strings
        }

    }
}

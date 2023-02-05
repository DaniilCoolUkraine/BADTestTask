using System;

namespace TestTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string _textToAnalyze = "C makes it easy for you to shoot yourself in the foot. C++ makes that harder, but when you do, it blows away your whole leg. (с) Bjarne Stroustrup";

            var uniqueCharFinder = new UniqueCharFinder();

            Console.WriteLine(uniqueCharFinder.FindFirstUniqueCharInText(_textToAnalyze));
        }
    }
}
using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to the line comparison");
            Line line = new Line(1,3,2,4);
            line.calculate();

        }
    }
}

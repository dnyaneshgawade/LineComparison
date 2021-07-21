using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to the line comparison");
            Line line = new Line(1,3,2,4);
            Line line2 = new Line(2,3,4,5);

            line.calculate();
            line2.calculate();
            if (line.Equals(line2))
                Console.WriteLine("both lines are same size");
            else
                Console.WriteLine("both lines are different sizes");

        }
    }
}

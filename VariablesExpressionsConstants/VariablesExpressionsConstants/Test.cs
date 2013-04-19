namespace VariablesExpressionsConstants
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;
    using System.Threading;

    public class Test
    {
        public static void PrintFigureWidthAndHeight(Figure figure)
        {
            Console.WriteLine("Figure width:{0,6:F2}", figure.Width);
            Console.WriteLine("Figure height:{0,5:F2}", figure.Heigth);
        }

        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Figure original = new Figure(2, 5);
            PrintFigureWidthAndHeight(original);          

            Figure rotated = Figure.GetRotatedFigure(original, 90);
            PrintFigureWidthAndHeight(rotated);
        }
    }
}
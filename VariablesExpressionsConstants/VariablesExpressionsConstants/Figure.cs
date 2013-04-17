using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Figure
{
    public Figure(double width, double height)
    {
        this.Width = width;
        this.Heigth = height;
    }

    public double Width { get; set; }

    public double Heigth { get; set; }

    public static Figure GetRotatedFigure(Figure figure, double angleOfRotation)
    {
        double rotatedSizeWidth = (Math.Abs(Math.Cos(angleOfRotation)) * figure.Width) +
            (Math.Abs(Math.Sin(angleOfRotation)) * figure.Heigth);
        double rotatedSizeHeight = (Math.Abs(Math.Sin(angleOfRotation)) * figure.Width) + 
            (Math.Abs(Math.Cos(angleOfRotation)) * figure.Heigth);

        Figure rotatedFigure = new Figure(rotatedSizeWidth, rotatedSizeHeight);

        return rotatedFigure;
    }
}
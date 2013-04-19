using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Figure
{
    private double width;
    private double height;

    public Figure(double width, double height)
    {
        if (width <= 0 || height <= 0)
        {
            throw new ArgumentOutOfRangeException("Width and height should be positive!");
        }

        this.Width = width;
        this.Heigth = height;
    }

    public double Width
    {
        get
        {
            return this.width;
        }

        set
        {
            if (value > 0)
            {
                this.width = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Width should be positive!");
            }
        }
    }

    public double Heigth
    {
        get
        {
            return this.height;
        }

        set
        {
            if (value > 0)
            {
                this.height = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Height should be positive!");
            }
        }
    }

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
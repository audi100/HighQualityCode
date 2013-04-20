using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Contains refactored if statement. The part for the potato is in the first task, in PotatoTest,
/// because it is logically connected with Potato class.
/// </summary>
public class TestIf
{
    public static void Main()
    {
        const int MIN_X = 0;
        const int MAX_X = 5;

        const int MIN_Y = 10;
        const int MAX_Y = 15;

        int x = 1;
        int y = 11;

        bool shouldVisitCell = true;
        bool xIsInRange = MAX_X >= x && x >= MIN_X;
        bool yIsInRange = MAX_Y >= y && y >= MIN_Y;

        // tests if x and y are in range and if the cell should be visited, and if these conditions 
        // are met, the cell will be visited
        if (shouldVisitCell && xIsInRange && yIsInRange)
        {
            VisitCell();
        }
    }

    private static void VisitCell()
    {
        Console.WriteLine("The cell has been visited.");
    }
}
using System;
using System.Collections.Generic;
using System.Text;

public class RefactorLoop
{
    public static void Main()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 50 };
        int expectedValue = 50;
        bool isFound = false;
        int len = array.Length;
        int divider = 10;

        // the goal is not to have magic numbers
        // 666 is replaced with bool value, otherwise we have variable
        // with hidden meaning, which is not a good practice
        for (int i = 0; i < len; i++)
        {
            if (i % divider == 0)
            {
                if (array[i] == expectedValue)
                {
                    isFound = true;
                }
            }

            Console.WriteLine(array[i]);
        }

        // More code here
        if (isFound)
        {
            Console.WriteLine("Value Found");
        }
    }
}
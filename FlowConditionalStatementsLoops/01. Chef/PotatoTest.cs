using System;
using System.Collections.Generic;
using System.Text;

public class PotatoTest
{
    public static void Main()
    {
        Chef chef = new Chef();

        Potato potato = new Potato();
        potato.IsRotten = false;

        if (potato != null)
        {
            // Potato will be peeled during Cook process, so this check is not necessary
            if (!potato.IsRotten)
            {
                chef.Cook(potato);
                Console.WriteLine("Potato is cooked!");
            }
            else
            {
                throw new ArgumentOutOfRangeException("Cannot cook rotten potato!");
            }
        }
        else
        {
            throw new ArgumentNullException("There is no potato!");
        }
    }
}
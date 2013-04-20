using System;
using System.Collections.Generic;
using System.Text;

public class Bowl
{
    private List<Vegetable> bowlList = new List<Vegetable>();

    public List<Vegetable> BowlList
    {
        get
        {
            return this.bowlList;
        }

        set
        {
            value = this.bowlList;
        }
    }
}
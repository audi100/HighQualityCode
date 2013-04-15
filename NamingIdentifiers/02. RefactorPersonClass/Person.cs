using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Person
{
    public GenderType PersonGender { get; set; }

    public string PersonName { get; set; }

    public int Age { get; set; }

    public static Person CreatePerson(int magicNumber)
    {
        Person newPerson = new Person();
        newPerson.Age = magicNumber;
        if (magicNumber % 2 == 0)
        {
            newPerson.PersonName = "Brother";
            newPerson.PersonGender = GenderType.Male;
        }
        else
        {
            newPerson.PersonName = "Sister";
            newPerson.PersonGender = GenderType.Female;
        }

        return newPerson;
    }
}
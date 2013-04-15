using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PersonTest
{
    // other classes are in new files
    public static void Main(string[] args)
    {
        Person newPerson = Person.CreatePerson(80);
        Console.WriteLine("Name: {0}, Age: {1}, Gender {2}", newPerson.PersonName, newPerson.Age, newPerson.PersonGender);
    }
}

using System;


/*
 *  yield : allows us to call a method multiple times and run for a little bit and then pause and wait for the next call
 * */

namespace Yield
{
    public class PersonModel
    {
        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine($"Initialized user {FirstName} {LastName}");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}

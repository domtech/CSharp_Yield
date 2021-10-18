using System.Collections.Generic;


/*
 *  yield : allows us to call a method multiple times and run for a little bit and then pause and wait for the next call
 * */

namespace Yield
{
    public class DataAccess
    {
        public static IEnumerable<PersonModel> GetPepole()
        {
            //List<PersonModel> output = new List<PersonModel>();

            //output.Add(new PersonModel("Tim", "Corey"));
            //output.Add(new PersonModel("Sue", "Storm"));
            //output.Add(new PersonModel("Jane", "Smith"));

            //return output;
            System.Console.WriteLine("IEnumerable : 1");
            yield return new PersonModel("Tim", "Corey");

            System.Console.WriteLine("IEnumerable : 2");
            yield return new PersonModel("Sue", "Storm");

            System.Console.WriteLine("IEnumerable : 3");
            yield return new PersonModel("Jane", "Smith");
        }
    }
}

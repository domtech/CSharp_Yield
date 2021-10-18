using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *  yield : allows us to call a method multiple times and run for a little bit and then pause and wait for the next call
 * */

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            //var people = DataAccess.GetPepole();
            //var enumerator = people.GetEnumerator();
            //System.Console.WriteLine("Before MoveNext");
            //var next = enumerator.MoveNext();
            //System.Console.WriteLine("After MoveNext");

            //while (next)
            //{
            //    var cur = enumerator.Current;
            //    System.Console.WriteLine($"Read {cur.FirstName}, {cur.LastName}");

            //    System.Console.WriteLine("Before MoveNext");
            //    next = enumerator.MoveNext();
            //    System.Console.WriteLine("After MoveNext");
            //}

            var generator = Generators.GetPrimeNumbers();

            var enumerator = generator.GetEnumerator();

            if (enumerator.MoveNext())
            {
                System.Console.WriteLine($"cur prime num: {enumerator.Current}");
            }
        }


        public class Generators
        {
            public static IEnumerable<int> GetPrimeNumbers()
            {
                int counter = 1;
                while(true)
                {
                    if(IsPrimeNumber(counter))
                    {
                        yield return counter;//I will return the value, and wait to see if I 'm called again
                    }
                    counter++;
                }
            }

            private static bool IsPrimeNumber(int value)
            {
                for (int i = 2; i < value / 2; i++)
                {
                    if (value % 2 == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

    }
}

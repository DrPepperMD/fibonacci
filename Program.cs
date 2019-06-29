using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            // some ints that will be useful later

            Console.WriteLine("Fibonacci Sequence Calculator!");
            Console.WriteLine("May be buggy :(");
            Console.WriteLine("------------------------------");
            Console.Write("choose an amount of calculations (each calculation prints 2 numbers): ");
            // some text for the user
            
            int usernumber = Convert.ToInt32(Console.ReadLine());
            // takes you input

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            // prints ints from earlier

            
            for (int lööp = 0; lööp < usernumber; lööp++)
            // puts you input in this bad boi
            // lööp
            // I know im Bobo the clown.
            // bruh sound effect #3
            // kill me

            {
                // everything below here calculates

                int numresult = num1 + num2;
                // puts int 1 and int 2 together

                num1 = numresult;
                // changes the first int 1 to 1

                Console.WriteLine(numresult);
                // prints result

                int numresult2 = num1 + num2;
                // puts int 1 and 2 together... again

                num2 = numresult2;
                // changes value, AGAIN!

                Console.WriteLine(numresult2);
                // prints result
            }

            Console.ReadKey();
            _ = Environment.ExitCode;
            // 13 11 14 Lifeline Australia...

        }
    }
}

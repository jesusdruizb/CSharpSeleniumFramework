using System;

namespace Helloworld
{
    public class ControlFlowExercises
    {
        public void DivisibleByThree()
        {
            var divisibleNumber = 1;
            for (var i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void AddEnteredNumbers()
        {
            var accum = 0;
            while (true)
            {
                int intValue = 0;
                
                Console.Write("Enter a number or 'ok' to exit: ");
                var value = Console.ReadLine();

                if (int.TryParse(value, out intValue))
                {
                    accum += intValue;
                }
                else
                {
                    Console.WriteLine("sum of all numbers: {0}",accum);
                    break;
                }
            }
            
        }

        public void CalculateFactorial()
        {
            var number = 1;
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                var initialNumber = number;
                var accum = 1;
                for (var i = 1; i <= number; i++)
                {
                    accum *= i;
                }
                Console.WriteLine("Factorial of {0} is {1}",initialNumber,accum);

            }
            
        }

        public void FindMaxNumber()
        {
            Console.Write("input numbers separated by , :");
            var inputArray = Console.ReadLine();
            double maxNumber = 0;
            foreach (var caracter in inputArray)
            {
                double number = Char.GetNumericValue(caracter);
                Console.WriteLine(caracter);
                if (number >= 0)
                {
                    Console.WriteLine(number.GetType());
                    maxNumber = maxNumber < number ? number : maxNumber;
                }
            }
            Console.WriteLine("max number is {0}", maxNumber);
        ;
    }
    }
}
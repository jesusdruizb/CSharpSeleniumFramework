
using System;
using Helloworld.Math;


namespace Helloworld
{
    public class Program
    {
        static void Main(string[] args)
        {/*
            byte number = 1;
            int count = 10;
            float totalPrice = 10.20f;
            char character = 'A';
            string firstName = "AAROn";
            bool isWorking = false;
            Calculator calc = new Calculator();
            var numbers = new int[3] {1, 2, 3};
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(number);
            Console.WriteLine("Hello World");
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
*/
            Exercises exercises = new Exercises();
           // exercises.ValidateInput();
           // exercises.DisplayMax(5,6);
           // exercises.ImageTypeClassifier(400,300);
            exercises.SpeedCamera();
        }
    }
}
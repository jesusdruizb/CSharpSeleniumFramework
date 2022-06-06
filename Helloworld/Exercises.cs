using System;

namespace Helloworld
{
    public class Exercises
    {
        public void ValidateInput()
        {
            Console.WriteLine("please enter a number between 1 and 10");
            var inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber > 0 && inputNumber < 11)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public void DisplayMax(int input1, int input2)
        {
            int[] array = new [] { input1, input2 };
            Array.Reverse(array);
            Console.WriteLine(array[0]);
        }

        public void ImageTypeClassifier(int width, int height)
        {
            string imageType = width <= height ? "Portrait" : "Landscape";
            Console.WriteLine(imageType);
        }

        public void SpeedCamera()
        {
            int demeritPoints = 0;
            Console.WriteLine("Input Speed Limit");
            var speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input car speed");           
            var carSpeed = Convert.ToInt32(Console.ReadLine());
            
            if (carSpeed > speedLimit)
            {
                demeritPoints = (carSpeed - speedLimit) / 5;
            }

            Console.WriteLine("demerit points to assign: {0}", demeritPoints);
            
            if (demeritPoints >= 12) Console.WriteLine("LICENSE SUSPENDED");
        }
    }
}
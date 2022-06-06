using System;

namespace Helloworld.Math
{
    public class Calculator
    {
        public Calculator()
        {

        }

        public int Operate(int operan1, int operand2, string operatr)
        {
            int result = 0;
            switch (operatr)
            {
                case "+": result = operan1 + operand2;
                    break;
                case "-": result = operan1 - operand2;
                    break;
                case "*": result = operan1 * operand2;
                    break;
                case "/": result = operan1 / operand2;
                    break;
                case "%": result = operan1 % operand2;
                    break;
                default: Console.WriteLine("unknown operator {0}",operatr);
                    break;
            }
            return result;
        }
    }
}
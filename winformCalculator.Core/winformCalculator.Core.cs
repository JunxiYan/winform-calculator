using System.Collections.Generic;
using System;
namespace winformCalculator.Core
{
    public class CalculatorCore
    {   string plus = "+";
        string minus = "-";
        string multiply = "*";
        string divide = "/";

        private double Plus(double x, double y) => x + y;
        private double Minus(double x, double y) => x - y;

        private double Multiply(double x, double y) => x * y;
        private double Divide(double x, double y) => x / y;

        public string Calculate(string expression)
        {
            var Numberstack = new Stack<string>();
            var Operatorstack = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    Operatorstack.Push(expression[i]);
                }
                else if (expression[i] == ')')
                {
                    while (Operatorstack.Peek() != '(')
                    {
                        Numberstack.Push(Operatorstack.Pop().ToString());
                    }
                    Operatorstack.Pop();
                }
                else if (expression[i] == '+' || expression[i] == '-')
                {
                    while (Operatorstack.Count > 0 && Operatorstack.Peek() != '(')
                    {
                        Numberstack.Push(Operatorstack.Pop().ToString());
                    }
                    Operatorstack.Push(expression[i]);
                }
                else if (expression[i] == '*' || expression[i] == '/')
                {
                    while (Operatorstack.Count > 0 && (Operatorstack.Peek() == '*' || Operatorstack.Peek() == '/'))
                    {
                        Numberstack.Push(Operatorstack.Pop().ToString());
                    }
                    Operatorstack.Push(expression[i]);
                }

                else
                {
                    int length = 0;
                    while (i + length < expression.Length
                            && (expression[i + length] >= '0'
                            && expression[i + length] <= '9'
                            || expression[i + length] == '.'))
                    { length++; }
                    Numberstack.Push(expression.Substring(i, length));
                    i += length - 1;
                }

            }
            while (Operatorstack.Count > 0)
            {
                Numberstack.Push(Operatorstack.Pop().ToString());
            }

            var resultStack = new Stack<string>();
 
            for (int i =0;i<=Numberstack.Count;i++)
            {   var item = Numberstack.Pop().ToString();
                
                if (item == plus || item == minus || item == multiply || item == divide)
                {
                    double x = double.Parse(Numberstack.Pop());
                    double y = double.Parse(Numberstack.Pop());
                    
                    if (item == plus)
                    {
                       resultStack.Push(Plus(x, y).ToString());
                    }
                    else if (item == minus)
                    {
                        resultStack.Push(Minus(x, y).ToString());
                    }
                    else if (item == multiply)
                    {
                        resultStack.Push(Multiply(x, y).ToString());
                    }
                    else if (item == divide)
                    {
                        resultStack.Push(Divide(x, y).ToString());
                    }
                    
                }
                else
                {
                    Numberstack.Push(item);
                }
            }

            return resultStack.Pop();


        }


    }
}

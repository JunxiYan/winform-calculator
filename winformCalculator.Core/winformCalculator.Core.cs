namespace winformCalculator.Core
{
    public class CalculatorCore
    {
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        public string Expression { get; set; }
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        public string Result { get; set; }
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。

        private double Plus(double x, double y) => x + y;
        private double Minus(double x, double y) => x - y;

        private double Multiply(double x, double y) => x * y;
        private double Divide(double x, double y) => x / y;

        public string Calculate(string expression)
        {
            Stack<char> Numberstack = new Stack<char>();
            Stack<char> Operatorstack = new Stack<char>();

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
                        Numberstack.Push(Operatorstack.Pop());
                    }
                    Operatorstack.Pop();
                }
                else if (expression[i] == '+' || expression[i] == '-')
                {
                    while (Operatorstack.Count > 0 && Operatorstack.Peek() != '(')
                    {
                        Numberstack.Push(Operatorstack.Pop());
                    }
                    Operatorstack.Push(expression[i]);
                }
                else if (expression[i] == '*' || expression[i] == '/')
                {
                    while (Operatorstack.Count > 0 && (Operatorstack.Peek() == '*' || Operatorstack.Peek() == '/'))
                    {
                        Numberstack.Push(Operatorstack.Pop());
                    }
                    Operatorstack.Push(expression[i]);
                }
                else
                {
                    Numberstack.Push(expression[i]);
                }
            }
            while (Operatorstack.Count > 0)
            {
                Numberstack.Push(Operatorstack.Pop());
            }


            char[] array = Numberstack.ToArray();
            Array.Reverse(array);

            var resultStack = new Stack<char>();
            foreach (var item in array)
            {
                if (item == '+' || item == '-' || item == '*' || item == '/')
                {
                    double x = double.Parse(resultStack.Pop().ToString());
                    double y = double.Parse(resultStack.Pop().ToString());
                    double result = 0;
                    if (item == '+')
                    {
                        result = Plus(x, y);
                    }
                    else if (item == '-')
                    {
                        result = Minus(x, y);
                    }
                    else if (item == '*')
                    {
                        result = Multiply(x, y);
                    }
                    else if (item == '/')
                    {
                        result = Divide(x, y);
                    }
                    resultStack.Push(result.ToString()[0]);
                }
                else
                {
                    resultStack.Push(item);
                }
            }

            return resultStack.Pop().ToString();


        }


    }
}

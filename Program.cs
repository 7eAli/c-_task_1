namespace Hw_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] actions = ["+", "-", "*", "/"];
            if (args.Length == 3) {
                int a = 0; int b = 0;
                if (int.TryParse(args[0], out a) && int.TryParse(args[2], out b) && actions.Contains(args[1]))
                {
                    Calculate(args[1], a, b);
                }
                else Console.WriteLine($"Для вычисления введите выражение в формате: число_1 действие число_2 {args.Length}");
            }
            else Console.WriteLine($"Для вычисления введите выражение в формате: число_1 действие число_2 {args.Length}");
        }
        static void Calculate(string action, int num1, int num2)
        {
            switch (action)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    if (num2 != 0) { Console.WriteLine(Math.Round(Convert.ToDouble(num1) / Convert.ToDouble(num2), 3)); }
                    else { Console.WriteLine("На ноль делить нельзя"); };
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}

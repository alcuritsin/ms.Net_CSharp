using System;

namespace Task_02
{
    class Program
    {
        static void Main()
        {
            var operation = new Operation();
            var function = new Functions();
            var show = new Show();
            function.Info = show.Info;
            function.Error = show.Error;
            try
            {
                var result = operation.Calc(5, 4, function.Add);
                Console.WriteLine($"sum = {result}");
                result = operation.Calc(5, 4, function.Max);
                Console.WriteLine($"max = {result}");

                result = operation.Calc(5, 0, function.Div);
                Console.WriteLine($"sum = {result}");
            }
            catch (Exception e)
            {
                // ignored
            }
        }
    }
}

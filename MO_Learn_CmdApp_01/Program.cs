namespace MO_Learn_CmdApp_01
{
    using System;

    class Calculator
    {
        static void Main(string[] args)
        {
            string key = "y";

            while (key == "y")
            {
                try
                { 
                    Calculator.runCalculator();
                }
                catch (DivideByZeroException dbze)
                {
                    Console.WriteLine("Divide by zero exception");
                    Console.WriteLine($"Method: {dbze.TargetSite}", dbze.TargetSite);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine($"Method: {e.TargetSite}",e.TargetSite);
                    //Console.WriteLine($"Trace: {e.StackTrace}", e.StackTrace);
                }
                finally
                { 
                    Console.WriteLine("Repeat procedure ? [Y/n]: ");
                    key = Console.ReadLine();
                }
            }
        }

        public static void runCalculator ()
        {
            Console.Clear();

            Console.WriteLine("============================ Calculator ============================ ");

            float   num1    = 0,
                    num2    = 0,
                    result  = 0;

            Console.WriteLine("Number one: ");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Number two: ");
            num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Select operation: ");
            Console.WriteLine("1 - add");
            Console.WriteLine("2 - substract");
            Console.WriteLine("3 - multiply");
            Console.WriteLine("4 - divide\n");

            switch (Console.ReadLine())
            {
                case "1":
                    result = num1 + num2;
                    break;

                case "2":
                    result = num1 - num2;
                    break;

                case "3":
                    result = num1 * num2;
                    break;

                case "4":
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    result = num1 / num2;
                    break;
                default:
                    throw new Exception("There is no such operation in the list !");
            }

            Console.WriteLine($"\nResult: {result}", result); 
        }
    }
}

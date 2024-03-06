namespace MO_Learn_CmdApp_01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Calculator
    {
        static void Main(string[] args)
        {
            string key;
            
            key = "y";

            while (key == "y")
            {
                Calculator.run();
                
                Console.WriteLine("Repeat procedure ? [Y/n]: ");
                key = Console.ReadLine();
            }
        }

        public static void run ()
        {
            Console.Clear();

            Console.WriteLine("============================ MO Calculator ============================ ");

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
            Console.WriteLine("4 - divide");

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
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine($"\nResult: {result}", result); 
        }
    }
}

using System.Xml.Linq;

namespace HelloWorld
{
    internal class Program
    {
        static int variable = 10;

        static void Main(string[] args)
        {
            int value1 = 2_147_483_000;
            int value2 = 9999;

            if (value2 <= int.MaxValue - value1)
            {
                int result = value1 + value2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Overflow!");
            }
            

            /*
            string text = null;
            if ((text != null) && (text.Length > 3))
            {
                Console.WriteLine("Text is not null and size > 3");
            }
            else
            {
                Console.WriteLine("Text is null OR size < 3");
            }

            bool condition = BooleanOperatorsTest.ReturnBool(false) && BooleanOperatorsTest.ReturnBool(true);
            Console.WriteLine("condition=" + condition);
            */

            /*
            Console.WriteLine("variable=" + TestClass.variable);
            TestClass.ChangeVariableValue();
            // Console.WriteLine("variable after ChangeVariableValue =" + TestClass.variable);
            TestClass.PrintVariableValue();
            */

            /*
            Console.Write("Please enter your name:");
            string name = Console.ReadLine();

            int age = ReadNumberFromKeyboard("Please enter your age:");
            Console.WriteLine("Hello, " + name + ", your age is: " + age);


            int currentYear = ReadNumberFromKeyboard("Please enter current year:");
            Console.WriteLine("current year is : " + currentYear);
            */
        }

        static int ReadNumberFromKeyboard(string label)
        {
            bool canConvert = false;

            variable = 100;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            while (!canConvert)
            {
                Console.Write(label);
                string textRead = Console.ReadLine();

                canConvert = int.TryParse(textRead, out int result);
                if (canConvert)
                {
                    
                    return result;
                }
                else
                {
                    Console.WriteLine("The text '" + textRead + "' doesn't represent a number ");
                }
            }

            return 0;
        }
    }
}
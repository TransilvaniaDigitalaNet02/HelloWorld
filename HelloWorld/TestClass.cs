namespace HelloWorld
{
    internal static class TestClass
    {
        public static int variable = 10;

        public static void ChangeVariableValue()
        {
            int variable = 100;
            Console.WriteLine("Variable inside ChangeVariableValue =" + variable);
        }

        public static void PrintVariableValue()
        {
            Console.WriteLine("Variable=" + variable);
        }
    }
}

namespace GenericsProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics problem");
            string stringoutput = MaximumProblem.FindMaxString("Apple", "Peach", "Banana");
            Console.WriteLine(stringoutput);
        }
    }
}

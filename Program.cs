namespace GenericsProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics problem");
            int[] intarray = { 41, 43, 53, 25, 76 };
            GenericMaximumArray<int> genericInt = new GenericMaximumArray<int>(intarray);
            Console.WriteLine("The maximum No is " + genericInt.MaxMethod());
            float[] floatarray = { 23.7f, 36.8f, 83.3f, 15.5f, 96.9f };
            GenericMaximumArray<float> genericFloat = new GenericMaximumArray<float>(floatarray);
            Console.WriteLine("The maximum No is " + genericFloat.MaxMethod());
            string[] stringarray = { "Apple", "Peach", "Orange", "Pineapple" };
            GenericMaximumArray<string> genericString = new GenericMaximumArray<string>(stringarray);
            Console.WriteLine("The maximum No is " + genericString.MaxMethod());
        }
    }
}

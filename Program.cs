namespace genericreview3
{
    class program
    {
        public static void Main(string[] args)
        {
            bool isequal = calculator.areequal(40, 40);
            if(isequal)
            {
                Console.WriteLine("both are equal");
            }
            else
            {
                Console.WriteLine("both are not equal");
            }
            Console.ReadKey();
        }
    }
    public class calculator
    {
       public static bool areequal(int value1, int value2)
        {
           return value1 == value2;
        }

        public static bool areequal<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
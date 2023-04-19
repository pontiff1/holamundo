namespace Lab2Git
{
    class Program
    {
        static void Main(string[] args)
        {
            void plus(double? x, double? y)
            {
                Console.WriteLine(x + y);
            }
            void minus(double? x, double? y)
            {
                Console.WriteLine(x - y);
            }
            void multiply(double? x, double? y)
            {
                Console.WriteLine(x * y);
            }
            void divide(double? x, double? y)
            {
                Console.WriteLine(x / y);
            }
        }
    }
}
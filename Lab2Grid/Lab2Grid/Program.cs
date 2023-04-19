namespace Lab2Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Результат: ");
            switch (c)
            {
                case 1: plus(a, b); break;
                case 2: minus(a, b); break;
                case 3: multiply(a, b); break;
                case 4: divide(a, b); break;
            }
        }
    }
}
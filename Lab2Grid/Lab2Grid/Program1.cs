namespace Lab2Git
{
    class Program
    {
        static void Main(string[] args)
        {
            int? c = Convert.ToInt16(Console.ReadLine());

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
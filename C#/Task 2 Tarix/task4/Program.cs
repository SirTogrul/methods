namespace task4
{
    internal class Program
    {
        static void siyahi(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Gosterilen eded 0-dan boyuk olmalidir.");
                return;
            }

            int a = 0, b = 1;
            Console.Write("Fibonacci reqemleri: "+a);
            while (b <= n)
            {
                Console.Write(b);
                int temp = a;
                a = b;
                b = temp + b;
            }
        }
        static void Main(string[] args)
        {
            int a = 10;

            siyahi(a);
        }
    }
}
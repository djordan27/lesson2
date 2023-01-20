internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        void Run(int run)
        {
            string run1 = Convert.ToString(run);
            Console.WriteLine(run1);

        }

    Run(10);
    }
}
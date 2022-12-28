namespace _2_ci_suall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            if (n > 9999 && n < 100000)
            {
                Console.Write($"{4}{n}{2}");
            }
            else
            {
                Console.WriteLine("5 reqemli eded deyil");

            }
        }    
    }
}
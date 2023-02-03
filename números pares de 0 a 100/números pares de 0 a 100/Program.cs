namespace números_pares_de_0_a_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
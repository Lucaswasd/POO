namespace Soma_de_números
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Informe 2 números para somar.");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.WriteLine("");
        }
    }
}
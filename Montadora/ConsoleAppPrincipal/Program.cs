using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu1 = new Pneu(16, "Carro de passeio", "Firestone", false, 150);
            
            pneu1.Girar(5);
            //Exibindo informações do pneu
            pneu1.Exibir();
            Console.WriteLine();
            Console.WriteLine("Informação do segund pneu.");
            Pneu pneu2 = new Pneu(16, "Carro de passeio", "Firestone", true, 150);
            pneu2.Girar(60);
            pneu2.Exibir();
            pneu2.Girar(60);
            pneu2.Exibir();
            pneu2.Girar(60);
            pneu2.Exibir();
            pneu2.Girar(60);
            pneu2.Exibir();
            pneu2.Girar(60);
            pneu2.Exibir();
        }
    }
}
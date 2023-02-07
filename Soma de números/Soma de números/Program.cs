int a;
int b;
char alternativa = 'n';
do
{
    Console.WriteLine("Informe 2 números para somar.");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Soma de " + a  + " mais " + b + " é: " + (a+b));
    Console.WriteLine("Dejsa Continuar? [S]-Sim ou [N]-Não.");
    alternativa = Convert.ToChar(Console.ReadLine());
    Console.ReadLine();
    Console.Clear();
} while (alternativa == 's');

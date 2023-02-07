namespace Models
{
    public class Pneu
    {
        private int _reducao;

        public int Aro { get; set; }
        public bool TWI { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }
        public bool Estepe { get; set; }
        public bool Estourado { get; set; }
        public bool Furado { get; set; }
        public string Tipo { get; set; }
        public int PercentualBorracha { get; set; }

        //ctor, criação de objetos
        public Pneu(int _Aro, string _tipo, bool _espete, int _velocidadeMaxima)
        {
            Aro = _Aro;
            Tipo = _tipo;
            VelocidadeMaxima = _velocidadeMaxima;
            Estepe = _espete;

            Cor = "Preto";
            Furado = false;
            Estourado = false;
            VelocidadeAtual = 0;
            PercentualBorracha = 100;
            TWI = false;
        }
        //Adicionando métodos(Funções)
        public void Girar(int _velocidade)
        {
            if (Estourado == true)//(Estourado)
            {
                Console.WriteLine("O pneu está estourado.");
                return;//sai do public void
            }
            if (Furado)//(Furado == true)
            {
                Console.WriteLine("O pneu está furado.");
                return;
            }

            VelocidadeAtual = VelocidadeAtual + _velocidade;
            //VelocidadeAtual += _velocidade;mesma forma de escrever
            PercentualBorracha = PercentualBorracha - 3;
            //PercentualBorracha -= 3; 

            if (VelocidadeAtual > VelocidadeMaxima || PercentualBorracha <= 30)
            {
                EstourarPneu();
            }
        }
        public void Frear(int _reducao)
        {
            VelocidadeAtual = VelocidadeAtual - _reducao;
            PercentualBorracha = PercentualBorracha - 5;


            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }
            if (PercentualBorracha < 0)
            {
                PercentualBorracha = 0;
            }
            if (PercentualBorracha <=30)
            {
                EstourarPneu();
                
            }
        }
        private void EstourarPneu()
        {
            Estourado = true;
            VelocidadeAtual = 0;
        }

        public void Exibir()
        {
            if (Estourado)
                return;

            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Aro: " + Aro);
            Console.WriteLine("Furado: " + Furado);
            Console.WriteLine("Estourado: " + Estourado);
            Console.WriteLine("Estepe: " + Estepe);
            Console.WriteLine("VelocidadeAtual: " + VelocidadeAtual);
            Console.WriteLine("VelocidadeMaxima: " + VelocidadeMaxima);
            Console.WriteLine("PercetualBorracha: " + PercentualBorracha);
            Console.WriteLine("TWI: " + TWI);
        }
    }
}
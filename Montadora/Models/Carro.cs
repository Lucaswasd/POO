namespace Models
{
    public class Carro
    {
        //prop, atalho para criar atributos
        public int Odometro { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }
        public bool Ligado { get; set; }
        public int PercentualCombustivel { get; set; }
        //criando propiedade pneu
        public Pneu PneuDianteiroEsquerdo { get; set; }
        public Pneu PneuDianteiroDireito { get; set; }
        public Pneu PneuTraseiroEsquerdo { get; set; }
        public Pneu PneuTraseiroDireito { get; set; }
        public Pneu PneuEstepe { get; set; }


        public Carro(string _marca, string _modelo, int _ano, int _VelocidadeMaxima, string _Placa)
        {
            VelocidadeAtual = 0;
            //iniciando os pnus do carro
            PneuDianteiroEsquerdo = new Pneu(16, "Carro de Passeio", false, 150);
            PneuDianteiroDireito = new Pneu(16, "Carro de Passeio", false, 150);
            PneuTraseiroEsquerdo = new Pneu(16, "Carro de Passeio", false, 150);
            PneuTraseiroDireito = new Pneu(16, "Carro de Passeio", false, 150);
            PneuEstepe = new Pneu(16, "Carro de passeio", true, 150);
            Odometro = 0;
            Marca = _marca;
            Modelo = _modelo;
            Ano = _ano;
            Placa = _Placa;
            VelocidadeMaxima = _VelocidadeMaxima;
            PneuEstepe = new Pneu(16, "Carro de passeio", true, 150);
        }

        public void Ligar()
        {
            if (PercentualCombustivel > 0)
            {
                PercentualCombustivel = PercentualCombustivel - 3;
                Ligado = true;
                if (PercentualCombustivel <= 0)
                {
                    PercentualCombustivel = 0;
                    Desligar();
                }
            }
        }
        public void Desligar()
        {
            Ligado = false;
            Parar();
        }
        public void Acelerar(int _impulso)
        {
            if (Ligado == true && _impulso > 0)
            {
                Odometro += 18;
                PercentualCombustivel = PercentualCombustivel - 8;
                if (PercentualCombustivel <= 0)
                {
                    PercentualCombustivel = 0;
                    Desligar();
                    return;
                }
                VelocidadeAtual = VelocidadeAtual + _impulso;
                PneuDianteiroDireito.Girar(_impulso);
                PneuDianteiroEsquerdo.Girar(_impulso);
                PneuTraseiroDireito.Girar(_impulso);
                PneuTraseiroEsquerdo.Girar(_impulso);
            }
        }
        public void Frear(int _reduzir)
        {
            VelocidadeAtual = VelocidadeAtual - _reduzir;

            if (VelocidadeAtual < 0)
                VelocidadeAtual = 0;
        }
        /// <summary>
        /// Este método vai abastecer o carro;
        /// </summary>
        /// <param name="_quantidadeCombustivel">Informe o percentual de combustível que deseja abastecer, caso informe 0 o método 
        /// irá completar o tanque.
        /// O valor não pode ser inferior a 1000</param>

        public void Abastecer(int _quantidadeCombustivel = 0)
        {
            if (_quantidadeCombustivel == 0)
                _quantidadeCombustivel = 100 - PercentualCombustivel;

            if (PercentualCombustivel + _quantidadeCombustivel > 100)
            {
                Console.WriteLine("A quantidade de combustível ultrapassa o limite do tanque");
                return;
            }
                if (PercentualCombustivel < 100)
                    PercentualCombustivel = PercentualCombustivel + _quantidadeCombustivel;
        }
        public void Parar()
        {
            VelocidadeAtual = 0;
            PneuDianteiroDireito.VelocidadeAtual = 0;
            PneuDianteiroEsquerdo.VelocidadeAtual = 0;
            PneuTraseiroDireito.VelocidadeAtual = 0;
            PneuTraseiroEsquerdo.VelocidadeAtual = 0;
        }
        public void Exibir()
        {
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Ano: " + Ano);
            Console.WriteLine("Placa: " + Placa);
            Console.WriteLine("VelocidadeMaxima: " + VelocidadeMaxima);
            Console.WriteLine("VelocidadeAtual: " + VelocidadeAtual);
            Console.WriteLine("Odometro: " + Odometro);
            Console.WriteLine("Ligado: " + Ligado);
            Console.WriteLine("PercentualCombustivel: " + PercentualCombustivel);

            Console.WriteLine("\nPneuDianteiroEsquerdo");
            PneuDianteiroEsquerdo.Exibir();
            Console.WriteLine("\nPneuDianteiroDireito");
            PneuDianteiroDireito.Exibir();
            Console.WriteLine("\nPneuTraseiroEsquerdo");
            PneuTraseiroEsquerdo.Exibir();
            Console.WriteLine("\nPneuTraseiroDireito");
            PneuTraseiroDireito.Exibir();
            Console.WriteLine("\nPneuEstepe");
            PneuEstepe.Exibir();
            











        }
    }
}

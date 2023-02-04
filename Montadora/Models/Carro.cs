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


        public Carro(string _modelo, int ano, int _VelocidadeMaxima, string _Placa)
        {
            VelocidadeAtual = 0;
            //iniciando os pnus do carro
            PneuDianteiroEsquerdo = new Pneu(16, "Carro de Passeio", "Firestone", false, 150);
            PneuDianteiroDireito = new Pneu(16, "Carro de Passeio", "Firestone", false, 150);
            PneuTraseiroEsquerdo = new Pneu(16, "Carro de Passeio", "Firestone", false, 150);
            PneuTraseiroDireito = new Pneu(16, "Carro de Passeio", "Firestone", false, 150);
            PneuEstepe = new Pneu(16, "Carro de passeio", "Firestone", true, 150);
            Odometro = 0;
            Marca = "Ford";
            Modelo = "Corsel";
            Placa = _Placa;
            VelocidadeMaxima = 143;
            PneuEstepe = new Pneu(16, "Carro de passeio", "Firestone", true, 150);
        }

        public void Ligar()
        {
            if (Ligado == true)
            {
                Console.WriteLine("O Carro está ligado");
                return;
            }
            else
            {
                if (PercentualCombustivel > 0)
                {
                    Ligado = true;
                }

            }
        }
        public void Desligar()
        {
            Ligado = false;
            VelocidadeAtual = 0;
            PneuDianteiroDireito.VelocidadeAtual = 0;
            PneuDianteiroEsquerdo.VelocidadeAtual = 0;
            PneuTraseiroDireito.VelocidadeAtual = 0;
            PneuTraseiroEsquerdo.VelocidadeAtual = 0;
        }
        public void Acelerar()
        {

        }
        public void Frear()
        {

        }
        public void Abastecer()
        {

        }
    }
}

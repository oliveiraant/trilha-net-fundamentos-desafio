namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal _precoInicial = 0;
        private decimal _precoPorHora = 0;
        private List<string> _veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            _precoInicial = precoInicial;
            _precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {

            string opcao;
            do
            {

                Console.Write("Digite a placa do veículo para estacionar: ");
                _veiculos.Add(Console.ReadLine());
                Console.Write("Deseja informar mais um veículo? Sim ou Não? (S/N): ");
                opcao = Console.ReadLine();

            }
            while
             (opcao == "s" || opcao == "S");

        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo para remover:");

            string placa = "";
            Console.Write("Informe a placa do veículo que deseja remover: ");
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (_veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                int horas = 0;
                decimal valorTotal = 0;
                Console.Write("Informe a quantidade de horas que o veículo permaneceu estacionado: ");
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = _precoInicial + (_precoPorHora * horas);

                _veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (_veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                int contador = 1;
                foreach (string veiculo in _veiculos)
                {
                    Console.WriteLine($"{contador}- {veiculo}");
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }


}

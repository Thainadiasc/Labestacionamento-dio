using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");

        Console.Write("Digite o preço inicial: ");
        decimal precoInicial = decimal.Parse(Console.ReadLine());

        Console.Write("Digite o preço por hora: ");
        decimal precoPorHora = decimal.Parse(Console.ReadLine());

        Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

        string opcao = string.Empty;
        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite a sua opção:");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    estacionamento.AdicionarVeiculo();
                    break;

                case "2":
                    estacionamento.RemoverVeiculo();
                    break;

                case "3":
                    estacionamento.ListarVeiculos();
                    break;

                case "4":
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            Console.WriteLine("\nPressione uma tecla para continuar");
            Console.ReadLine();
        }
    }
}

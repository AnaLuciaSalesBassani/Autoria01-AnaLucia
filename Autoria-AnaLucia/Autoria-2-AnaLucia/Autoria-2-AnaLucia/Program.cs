// See https://aka.ms/new-console-template for more information
namespace SistemaLanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configura a codificação do console para suportar acentos em português
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Variáveis para armazenar o pedido
            int quantidadePastel = 0;
            int quantidadeCaldoCana = 0;
            const double precoPastel = 5.00;
            const double precoCaldoCana = 3.00;
            bool continuarPedido = true;

            // Exibe o menu inicial
            Console.WriteLine("Bem-vindo à Lanchonete! Aqui vendemos Pastel (R$ 5,00) e Caldo de Cana (R$ 3,00).");

            // Loop para adicionar itens ao pedido
            while (continuarPedido)
            {
                // Exibe opções do menu
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Adicionar Pastel");
                Console.WriteLine("2 - Adicionar Caldo de Cana");
                Console.WriteLine("3 - Finalizar pedido");
                string opcao = Console.ReadLine();

                // Estrutura de decisão para processar a escolha
                if (opcao == "1")
                {
                    // Adiciona um pastel
                    quantidadePastel++;
                    Console.WriteLine("Pastel adicionado ao pedido.");
                }
                else if (opcao == "2")
                {
                    // Adiciona um caldo de cana
                    quantidadeCaldoCana++;
                    Console.WriteLine("Caldo de Cana adicionado ao pedido.");
                }
                else if (opcao == "3")
                {
                    // Finaliza o pedido
                    continuarPedido = false;
                }
                else
                {
                    // Opção inválida
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }

            // Calcula o total do pedido
            double total = (quantidadePastel * precoPastel) + (quantidadeCaldoCana * precoCaldoCana);

            // Exibe o resumo do pedido
            Console.WriteLine("\nResumo do Pedido:");
            Console.WriteLine($"Pastéis: {quantidadePastel} x R$ {precoPastel:F2} = R$ {quantidadePastel * precoPastel:F2}");
            Console.WriteLine($"Caldo de Cana: {quantidadeCaldoCana} x R$ {precoCaldoCana:F2} = R$ {quantidadeCaldoCana * precoCaldoCana:F2}");
            Console.WriteLine($"Total a pagar: R$ {total:F2}");

            // Verifica se o total é maior que zero
            if (total > 0)
            {
                Console.WriteLine("Obrigado pela compra!");
            }
            else
            {
                Console.WriteLine("Nenhum item foi pedido.");
            }
        }
    }
}

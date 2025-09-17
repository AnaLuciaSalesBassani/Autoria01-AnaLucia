// See https://aka.ms/new-console-template for more information
//um pet shop necessita de um programa para mostrar seu catálogo para o cliente e gerar o preço de cada serviço
Console.WriteLine("Pet Shop");
Console.WriteLine("1. Banho Simples - R$ 30");
Console.WriteLine("2. Banho Completo - R$ 50");
Console.WriteLine("3. Tosa higienica - R$ 40");


Console.WriteLine("Escolha o banho (1, 2 ou 3): ");
string entrada = Console.ReadLine();
int banho;
bool valido = int.TryParse(entrada, out banho);

if (valido == false)
{
    Console.WriteLine("Erro: Digite 1, 2 ou 3.");
}
else
{
    double preco = 0;
    string nome = "";
    if (banho == 1)
    {
        preco = 30;
        nome = "Banho Simples";
    }
     if (banho == 2)
    {
        preco = 50;
        nome = "Banho Completo";
    }
     if (banho == 3)
    {
        preco = 40;
        nome = "Tosa";
    }
    else
    {
        Console.WriteLine("Erro: Escolha 1, 2 ou 3.");
        Console.WriteLine("Pressione uma tecla...");
        Console.ReadKey();
        return;
    }

    Console.WriteLine("Serviço: " + nome);
    Console.WriteLine("Preço: R$ " + preco);
}

Console.WriteLine("Pressione uma tecla...");
Console.ReadKey();
    


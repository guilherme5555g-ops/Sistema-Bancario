using System.Runtime.InteropServices;

Cliente cliente1 = new Cliente("Guilherme","123-456-789-01",15);
ContaBancaria conta1 = new ContaBancaria(1001,0001,1500.75m,cliente1);
int opcao = 0;
string? resposta;
do
{
    MostrarMenu();
    try
    {
        Console.WriteLine("Escolha uma opcao:");
         opcao = int.Parse(Console.ReadLine()!);
        switch (opcao)
        {
            case 1:
        {
            conta1.Depositar();
            break;
        }
        case 2:
                {
                    conta1.Sacar();
                    break;
                }
        case 3:
                {
                    conta1.ConsultarSaldo();
                    break;
                }
        case 4:
                {
                    conta1.MostrarDados();
                    break;
                }
        case 5:
                {
                    Console.WriteLine("Encerrando Programa..");
                    break;
                }
                default:
                {
                    Console.WriteLine("Opção Invalida");
                    break;
                }
        }
    }
    catch
    {
        Console.WriteLine("Operação Invalida");
    }
    Console.WriteLine("Deseja realizar outra operação?");
     resposta = Console.ReadLine();
}
while (resposta == "sim");
void MostrarMenu()
{
    Console.WriteLine("============================");
    Console.WriteLine("      BANCO DIGITAL");
    Console.WriteLine("============================");
    Console.WriteLine("Bem-vindo Ao Banco Digital!");
    Console.WriteLine("1- Depositar");
    Console.WriteLine("2- Sacar");
    Console.WriteLine("3- Consultar saldo");
    Console.WriteLine("4- Dados da conta");
    Console.WriteLine("5- Sair");
}

 public class ContaBancaria
{
    public int NumeroDaConta {get; set;}
    public int Agencia {get; set;}
    public decimal Saldo {get; set;}
    public Cliente Cliente {get; set;}
    public ContaBancaria(int numerodaconta, int agencia, decimal saldo, Cliente cliente)
    {
        NumeroDaConta = numerodaconta;
        Agencia = agencia;
        Saldo = saldo;
        Cliente = cliente;
    }
    public void ConsultarSaldo()
    {
        Console.WriteLine($"Saldo: {Saldo}");
    }
    decimal valor;
    public void Depositar()
    {
        Console.WriteLine("Quanto voce quer depositar?");
         valor = decimal.Parse(Console.ReadLine()!);
        Saldo = Saldo + valor;
        Console.WriteLine($"Seu saldo agora é: {Saldo}");
    }
    public void Sacar()
    {
        Console.WriteLine("Quanto voce quer sacar?");
        valor = decimal.Parse(Console.ReadLine()!);
        if (valor > Saldo)
        {
            Console.WriteLine("Saldo insuficiente");
        }
        else
        {
            Saldo = Saldo - valor;
        }
        Console.WriteLine($"Seu saldo agora é: {Saldo}");

    }
    public void MostrarDados()
    {
    Console.WriteLine($"Numero da conta: {NumeroDaConta}");
    Console.WriteLine($"Agencia: {Agencia}");
    Console.WriteLine($"Saldo: {Saldo}");
    Console.WriteLine($"Nome do cliente: {Cliente.Nome}");
    Console.WriteLine($"CPF: {Cliente.CPF}");
    Console.WriteLine($"Idade: {Cliente.Idade}");
    }
}
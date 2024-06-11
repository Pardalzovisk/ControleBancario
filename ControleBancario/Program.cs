// See https://aka.ms/new-console-template for more information
using ControleBancario.Model.ControleBancario.Model;
using ControleBancario.Model;

Cliente cliente1 = new Cliente("João Silva", "12345678901", 1985, "joao@silva.com");
Cliente cliente2 = new Cliente("Maria Souza", "09876543210", 1990, "maria@souza.com");

// Criação das contas
Conta conta1 = new Conta(123456, 1000.00, cliente1);
ContaCaixinha conta2 = new ContaCaixinha(654321, 2341.42, cliente2);

// Saldo inicial total geral
double saldoInicialTotalGeral = conta1.Saldo + conta2.Saldo;

// Mostrar saldos iniciais
Console.WriteLine($"Saldo inicial conta 1: {conta1.Saldo}");
Console.WriteLine($"Saldo inicial conta 2: {conta2.Saldo}");
Console.WriteLine($"Saldo inicial total geral: {saldoInicialTotalGeral}");

// Realizar um depósito de 1000 na conta 1
conta1.Depositar(1000.00);

// Mostrar saldo total antes e depois do depósito
double saldoTotalAntes = conta1.Saldo + conta2.Saldo;
Console.WriteLine($"\nSaldo total antes do depósito na conta 1: {saldoInicialTotalGeral}");
Console.WriteLine($"Saldo total depois do depósito na conta 1: {saldoTotalAntes}");

// Realizar um saque na conta 2
conta2.Sacar(100.00);

// Mostrar saldo total após saque
double saldoTotalDepoisSaque = conta1.Saldo + conta2.Saldo;
Console.WriteLine($"\nSaldo total após saque na conta 2: {saldoTotalDepoisSaque}");

// Transferência entre contas
    try
    {
     conta1.Transferir(conta2, 500.00);
    }
    catch (Exception e)
    {
     Console.WriteLine(e.Message);
    }

// Mostrar saldo total após transferência
double saldoTotalDepoisTransferencia = conta1.Saldo + conta2.Saldo;
Console.WriteLine($"\nSaldo total após transferência da conta 1 para conta 2: {saldoTotalDepoisTransferencia}");

// Informar saldo total das duas contas
Console.WriteLine($"\nSaldo total das duas contas: {saldoTotalDepoisTransferencia}");

// Informar o número da conta que possui o maior saldo
string contaMaiorSaldo = conta1.Saldo > conta2.Saldo ? conta1.Numero.ToString() : conta2.Numero.ToString();
Console.WriteLine($"Número da conta que possui o maior saldo: {contaMaiorSaldo}");

// Informar o saldo inicial total geral
Console.WriteLine($"Saldo inicial total geral: {saldoInicialTotalGeral}");

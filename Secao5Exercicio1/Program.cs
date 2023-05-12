using System;
using System.Globalization;

namespace Exercicio1 {
    /*Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do 
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito 
inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua 
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já 
o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por 
exemplo). 
Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger 
isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque 
realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for 
suficiente para realizar o saque e/ou pagar a taxa.
Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não 
informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre 
mostrando os dados da conta após cada operação.*/
    class Program {

        static void Main(string[] args) {


            Console.Write("Entre com o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular: ");
            string nomeTitular = Console.ReadLine();
            ContaBancaria contaBancaria = new ContaBancaria(conta, nomeTitular);

            Console.Write("Haverá depósito inicial (s/n)? ");
            char respostaDeposito = char.Parse(Console.ReadLine());
            if (respostaDeposito == 's' || respostaDeposito == 'S') {
                Console.Write("Entre o valor de depósito inicial: $");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria.Deposito(deposito);
            }       

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: $");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Deposito(valorDeposito);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre com o valor para saque: $");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Saque(saque);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria);
        }
    }
}
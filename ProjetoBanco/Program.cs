using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco
{
    internal class Program
    {
        
        static void deposito(double saldo, double valordeposito)
        {
            
            Console.WriteLine("Informe o valor do deposito: ");
            valordeposito = double.Parse(Console.ReadLine());
            double totaldeposito = saldo + valordeposito;
            Console.WriteLine("Deposito efetuado." + totaldeposito);
        }
        static void saque(double saldo, double valorsaque)
        {
            
            Console.WriteLine("Informe o valor do saque: ");
            valorsaque = double.Parse(Console.ReadLine());
                if (saldo >= valorsaque)
            {
                double totalsaque = saldo - valorsaque;
                Console.WriteLine("Saque efetuado" + totalsaque);
            }
                else
            {
                Console.WriteLine("Saldo Insuficiente.");
            }
            
        }
        static void pagamento(double saldo, double valorpagamento)
        {
            
            Console.WriteLine("Informe o valor do pagamento: ");
            valorpagamento = double.Parse(Console.ReadLine());
            if (saldo >= valorpagamento)
            {
                double totalpagamento = saldo - valorpagamento;
                Console.WriteLine("Pagamento efetuado.", + valorpagamento);
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente.");
            }
            
        }
        static void Main(string[] args)
        {
            string resp;
            double saldo = 0;
            double valorpagamento = 0;
            double valorsaque = 0;
            double valordeposito = 0;

           

                Console.WriteLine("Informe seu saldo: ");
                saldo += double.Parse(Console.ReadLine());

             

                Console.WriteLine("O que gostaria de efetuar?");
                Console.WriteLine("Digite 1 para Depósito.");
                Console.WriteLine("Digite 2 para Saque.");
                Console.WriteLine("Digite 3 para Pagamento.");
                Console.WriteLine("Digite 4 para Consultar o Saque");
                int escolha = int.Parse(Console.ReadLine());

                
            do {
                Console.WriteLine("Deseja efetuar mais alguma ação?[S/N]");
                resp = Console.ReadLine();

                switch (escolha)
                {
                    case 1:
                        deposito(saldo, valordeposito);
                        break;
                    case 2:
                        saque(saldo, valorsaque);
                        break;
                    case 3:
                        pagamento(saldo, valorpagamento);
                        break;
                    case 4:
                        Console.WriteLine("Seu saldo é de: ", saldo); 
                        break;
                    default:
                        Console.WriteLine("Opção Inválida.");
                        break;
                }
            }
            while (resp == "S");
            Console.ReadLine();

















        }
    }
}

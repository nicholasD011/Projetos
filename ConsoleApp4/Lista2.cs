using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Lista2
    {
        internal void Exercicio01()
        {
            int num1 = 0;

            Console.WriteLine("Escreva um número: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 >20) 
            {
                Console.WriteLine("O número "+num1+" é maior que 20");
                Console.ReadLine();
            }
        }

        internal void Exercicio02()
        {
            int num1 = 0;

            Console.WriteLine("Insira um número: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 >=11) 
            {
                Console.WriteLine("O número " + num1 + " é maior que 10");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("O número " + num1 + " é menor que 10");
                Console.ReadLine();
            }
        }

        internal void Exercicio03()
        {
            int a, b, c, soma = 0;

            Console.WriteLine("Entre com os valor de a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de c:");
            c = int.Parse(Console.ReadLine());

            soma = a + b - c;

            Console.WriteLine("O valor da soma é igual a "+soma);
            Console.ReadLine();
        }

        internal void Exercicio04()
        {
            int num1, num2, soma = 0;

            Console.WriteLine("Informe o valor do número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do segundo número:");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            if (soma > 10) 
            {
                Console.WriteLine("A soma dos dois números é igual a " + soma);
                Console.ReadLine();
            }
        }

        internal void Exercicio05()
        {
            
        }

        internal void Exercicio06()
        {
            throw new NotImplementedException();
        }

        internal void Exercicio07()
        {
            throw new NotImplementedException();
        }

        internal void Exercicio08()
        {
            throw new NotImplementedException();
        }

        internal void Exercicio09()
        {
            throw new NotImplementedException();
        }

        internal void Exercicio10()
        {
            throw new NotImplementedException();
        }

        internal void Exercicio11()
        {
            throw new NotImplementedException();
        }
    }
}

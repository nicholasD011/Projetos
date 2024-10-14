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
            string nome, sexo, estadoCivil, tempoCasada;

            Console.WriteLine("Qual é seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe seu sexo (M)asculino ou (F)eminino: ");
            sexo = Console.ReadLine();
            Console.WriteLine("Insira seu estado civil (C)asado ou (S)oltero: ");
            estadoCivil = Console.ReadLine();

            if (sexo == "F" && estadoCivil == "CASADA")
            {
                Console.WriteLine("Há quantos você está casada? ");
                tempoCasada = Console.ReadLine();
                Console.WriteLine("Você está casada a " + tempoCasada + " anos");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Seus dados estão devidamente guardados");
                Console.ReadLine();
            }
        }

        internal void Exercicio06()
        {
            int num1 = 0;

            Console.WriteLine("Informe um número: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("Este número " + num1 + " é par");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Este número " + num1 + " é impar");
                Console.ReadLine();
            }
        }

        internal void Exercicio07()
        {
            int a, b, c;

            Console.WriteLine("Insira um valor para a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira um valor para b:");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                c = a + b;
                Console.WriteLine("A soma dos dois números é: "+c);
                Console.ReadLine();
            }
            else 
            {
                c = a * b;
                Console.WriteLine("A multiplicação dos dois números é: " + c);
                Console.ReadLine();
            }
            Console.WriteLine("O resultado é: " + c);
            Console.ReadLine();
        }

        internal void Exercicio08()
        {
            int num1, num2;

            Console.WriteLine("Insira o número desejado: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 >= 1)
            {
                num2 = num1 * 2;
                Console.WriteLine("Este número " + num2 + " é positivo");
                Console.ReadLine();
            }
            else 
            {
                num2 = num1 * 3;
                Console.WriteLine("Este número " + num2 + " é negativo");
                Console.ReadLine();
            }
            Console.WriteLine("O Resultado é " + num2);
            Console.ReadLine();
        }

        internal void Exercicio09()
        {
            int valor1,valor2,valor3;
            int maior, meio, menor;

            Console.Write("Digite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            valor3 = int.Parse(Console.ReadLine());

            if (valor1 >= valor2 && valor1 >= valor3) 
            {
                maior = valor1;
                if (valor2 >= valor3)
                {
                    meio = valor2;
                    menor = valor3;
                }
                else
                {
                    meio = valor3;
                    menor = valor2;
                }
            }
            else if (valor2 >= valor1 && valor2 >= valor3) 
            {
                maior = valor2;
                if (valor1 >= valor3)
                {
                    meio = valor1;
                    menor = valor3;
                }
                else 
                {
                    meio = valor3;
                    menor = valor1;
                }
            }
            else 
            {
                maior = valor3;
                if (valor1 >= valor2) 
                {
                    meio = valor1;
                    menor = valor2;
                }
                else 
                {
                    meio = valor2;
                    menor = valor1;
                }
            }
            Console.WriteLine($"Valores ordenados: {maior},{meio},{menor}");
            Console.ReadLine();
        }

        internal void Exercicio10()
        {
            int valor1, valor2, valor3;
            int maior, meio, menor;

            Console.Write("Digite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            valor3 = int.Parse(Console.ReadLine());

            if (valor1 <= valor2 && valor1 <= valor3)
            {
                menor = valor1;
                if (valor2 <= valor3)
                {
                    meio = valor2;
                    maior = valor3;
                }
                else
                {
                    meio = valor3;
                    maior = valor2;
                }
            }
            else if (valor2 <= valor1 && valor2 <= valor3)
            {
                menor = valor2;
                if (valor1 <= valor3)
                {
                    meio = valor1;
                    maior = valor3;
                }
                else
                {
                    meio = valor3;
                    maior = valor1;
                }
            }
            else
            {
                menor = valor3;
                if (valor1 <= valor2)
                {
                    meio = valor1;
                    maior = valor2;
                }
                else
                {
                    meio = valor2;
                    maior = valor1;
                }
            }
            Console.WriteLine($"Valores ordenados: {menor},{meio},{maior}");
            Console.ReadLine();
        }

        internal void Exercicio11()
        {
            int horaInicio, horaFim, duracao, horasRestantes, horasExcedentes;
            int maximaDuracao = 24;

            Console.Write("Digite a hora de início do jogo (0-23): ");
            horaInicio = int.Parse( Console.ReadLine() );
            Console.Write("Digite a hora do término de jogo (0-23): ");
            horaFim = int.Parse( Console.ReadLine() );

            if (horaFim >= horaInicio)
            {
                duracao = horaFim - horaInicio;
            }
            else 
            {
                duracao = (24 - horaInicio)+horaFim;
            }

            Console.WriteLine($"O jogo durou {duracao} horas.");

            if (duracao < maximaDuracao)
            {
                horasRestantes = maximaDuracao - duracao;
                Console.WriteLine($"Restam {horasRestantes} horas para atingir o tempo máximo de 24 horas");
            }
            else if (duracao > maximaDuracao)
            {
                horasExcedentes = duracao - maximaDuracao;
                Console.WriteLine($"O jogo excedeu o tempo máximo de 24 horas em {horasExcedentes} horas.");
            }
            else 
            {
                Console.WriteLine("O jogo durou exatamente 24 horas.");
            }
            Console.ReadLine();
        }
    }
}

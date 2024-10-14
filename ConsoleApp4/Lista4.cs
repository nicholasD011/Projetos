using System;

namespace ConsoleApp4
{
    internal class Lista4
    {
        internal void Exercicio01()
        {
            int numero;

            Console.Write("Escreva um número: ");
            numero= int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.Write($"O número {numero} é par.");
                Console.ReadLine();
            }
            else 
            {
                Console.Write($"O número {numero} é impar.");
                Console.ReadLine();
            }
        }

        internal void Exercicio02()
        {
            int numero = 0;

            Console.Write("Insira sua idade: ");
            numero = int.Parse(Console.ReadLine());

            if (numero <= 12)
            {
                Console.WriteLine("Sou uma criança birrenta");
                Console.ReadLine();
            }
            else if (numero <= 17)
            {
                Console.WriteLine("Sou um aborrecente");
                Console.ReadLine();
            }
            else if (numero <= 64)
            {
                Console.WriteLine("Sou um adulto :(");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Sou um véio jogador de cacheta");
                Console.ReadLine();
            }
        }

        internal void Exercicio03()
        {
            double nota = 0;

            Console.Write("Informe a nota do aluno: ");
            nota = double.Parse(Console.ReadLine());

            if (nota >= 6 ) 
            {
                Console.WriteLine("Parabéns você passou de ano");
                Console.ReadLine();
            }
            else if (nota >= 4) 
            {
                Console.WriteLine("Vai perder as férias na recuperação");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Vai apanhar por reprovar");
                Console.ReadLine();
            }
        }

        internal void Exercicio04()
        {
            double peso, altura, imc;

            Console.Write("Insira seu peso: ");
            peso = double.Parse(Console.ReadLine());
            Console.Write("Insira sua altura: ");
            altura = double.Parse(Console.ReadLine());
            imc = peso / (altura *  altura);

            if (imc < 18.5) 
            {
                Console.WriteLine("Abaixo do peso");
                Console.ReadLine();
            }
            else if (imc <= 24.9) 
            {
                Console.WriteLine("Peso normal");
                Console.ReadLine();
            }
            else if (imc <= 29.9) 
            {
                Console.WriteLine("Sobrepeso");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Obesidade");
                Console.ReadLine();
            }
        }

        internal void Exercicio05()
        {
            int num1, num2;

            Console.Write("Escreva o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Escreva o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"O maior número é {num1}");
                Console.ReadLine();
            }
            else if (num2 > num1) 
            {
                Console.WriteLine($"O maior número é {num2}");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Os números são iguais");
                Console.ReadLine();
            }
        }

        internal void Exercicio06()
        {
            int idade = 0;

            Console.Write("Informe a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 71)
            {
                Console.WriteLine("Voto facultativo");
                Console.ReadLine();
            }
            else if (idade >= 18)
            {
                Console.WriteLine("Obrigado a votar por lei");
                Console.ReadLine();
            }
            else if (idade >= 16) 
            {
                Console.WriteLine("Voto facultativo");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Não pode votar");
                Console.ReadLine();
            }
        }

        internal void Exercicio07()
        {
            decimal valorCompra, desconto;

            Console.Write("Digite o valor da compra: ");
            valorCompra = decimal.Parse(Console.ReadLine());
            desconto = valorCompra * 0.10m;

            if (valorCompra > 100) 
            {
                valorCompra -= desconto;
                Console.WriteLine($"Você recebeu um desconto de 10%. O valor final da compra foi de ${valorCompra:F2}");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine($"O valor da compra é {valorCompra:F2}");
                Console.ReadLine();
            }
        }

        internal void Exercicio08()
        {
            double grausCelcius = 0;

            Console.Write("Informe a temperatura em Graus Celcius: ");
            grausCelcius = double.Parse(Console.ReadLine());

            if (grausCelcius > 25 ) 
            {
                Console.WriteLine("Quente");
                Console.ReadLine();
            }
            else if (grausCelcius >= 15) 
            {
                Console.WriteLine("Agradável");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Frio");
                Console.ReadLine();
            }
        }

        internal void Exercicio09()
        {
            int num1, num2, num3, media;

            Console.Write("Informe o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Informe o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            media = (num1 + num2 + num3)/3;

            if (media > 7)
            {
                Console.WriteLine("Aprovado");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Reprovado");
                Console.ReadLine();
            }
        }

        internal void Exercicio10()
        {
            int ano;

            Console.Write("O ano informado é bissexto: ");
            ano = int.Parse(Console.ReadLine());

            if (ano % 4 == 0) 
            {
                Console.WriteLine("Estamos em um ano bissexto!!!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Este ano não é bissexto :(");
            }
        }
    }
}
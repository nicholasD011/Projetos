using System;

namespace ConsoleApp4
{
    internal class Lista3
    {
        internal void Exercicio01()
        {
            int valor1, valor2, valor3, soma = 0;

            Console.Write("Entre com o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o terceiro valor: ");
            valor3 = int.Parse(Console.ReadLine());

            soma = valor1 + valor2 + valor3;

            Console.WriteLine($"A soma entre dos valores é {soma}");
            Console.ReadLine();

        }

        internal void Exercicio02()
        {
            int nota1,nota2,nota3,nota4,media = 0;

            Console.Write("Informe a primeira nota: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.Write("Informe a segunda nota: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.Write("Informe a terceira nota: ");
            nota3 = int.Parse(Console.ReadLine());
            Console.Write("Informe a quarta nota: ");
            nota4 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.Write($"A média das quatro notas é {media}");
            Console.ReadLine() ;

        }
        internal void Exercicio03()
        {
            string nome;
            do 
            {
                Console.Write("Qual é seu nome: ");
                nome = Console.ReadLine();
                Console.Clear();
            }
            while (nome != "João");
        }

        internal void Exercicio04()
        {
            int inicio = 35;
            int fim = 98111;
            int contadorPar = 0;

            for (int i = inicio;i <= fim; i++) 
            {
                if (i % 2 == 0) 
                {
                    contadorPar++;
                }
            }
            Console.WriteLine($"A quantidade de números pares entre {inicio} e {fim} é: {contadorPar}");
            Console.ReadLine();
        }

        internal void Exercicio05()
        {
            int inicio = 1;
            int fim = 5000;
            int contadorImpar = 0;

            for(int i = inicio; i <= fim; i++) 
            {
                if (i % 2 != 0) 
                {
                    contadorImpar++;
                }
            }
            Console.WriteLine($"A quantidade de números impares entre {inicio} e {fim} é: {contadorImpar}");
            Console.ReadLine();
        }

        internal void Exercicio06()
        {
            int numero,tabuada = 0;

            Console.Write("Digite um número para calcular a tabuada: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tabuada do {numero}:");
            
            for (int i = 1; i <= 10; i++) 
            {
                tabuada = numero * i;
                Console.WriteLine($"{numero} x {i} = {tabuada}");
            }
            Console.ReadLine();
        }
    }
}
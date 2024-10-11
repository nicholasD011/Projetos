using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Lista1
    {
        public void Exercicio01()
        {
            Console.WriteLine("Hello, World!!! ");
            Console.ReadLine();

        }
        public void Exercicio02()
        {
            string nome;

            Console.WriteLine("Insira seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Seja bem-vindo " + nome);
            Console.ReadLine();

        }
        public void Exercicio03()
        {
            string nome;
            string valor;

            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe seu salário: ");
            valor = Console.ReadLine();

            Console.WriteLine("O funcionário(a) " + nome + " tem o salário mensal de : " + valor);
            Console.ReadLine();

        }
        public void Exercicio04()
        {
            int Num1 = 0;
            int Num2 = 0;
            int Soma = 0;

            Console.WriteLine("Digite os números desejados: ");
            Num1 = int.Parse(Console.ReadLine());
            Num2 = int.Parse(Console.ReadLine());
            Soma = Num1 + Num2;

            Console.WriteLine("A soma dos números " + Num1 + " e " + Num2 + " é : " + Soma);
            Console.ReadLine();

        }
        public void Exercicio05()
        {
            double nota1 = 0;
            double nota2 = 0;
            double media = 0;

            Console.WriteLine("Insira suas notas: ");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2) / 2;

            Console.WriteLine("A média entre " + nota1 + " e " + nota2 + " é igual a : " + media);
            Console.ReadLine();

        }
        public void Exercicio06()
        {
            int numero = 0;
            int antecessor = 0;
            int sucessor = 0;

            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            antecessor = numero - 1;
            sucessor = numero + 1;

            Console.WriteLine("O número digitado é: " + numero);
            Console.WriteLine("O antecessor de " + numero + " é: " + antecessor);
            Console.WriteLine("O sucessor de " + numero + " é: " + sucessor);
            Console.ReadLine();
        }
        public void Exercicio07()
        {
            double numero = 0;
            double dobro = 0;
            double terceiraParte = 0;

            Console.WriteLine("Informe o número: ");
            numero = double.Parse(Console.ReadLine());
            dobro = numero * 2;
            terceiraParte = numero / 3;

            Console.WriteLine("O numero digitado é " + numero);
            Console.WriteLine("O dobro de " + numero + " é " + dobro);
            Console.WriteLine("A terça parte de " + numero + " é " + terceiraParte);
            Console.ReadLine();

        }
        public void Exercicio08()
        {
            double metros, km, hm, dam, dm, cm, mn = 0;

            Console.WriteLine("Informe a distância em métros e transforme em outras medidas de comprimento: ");
            metros = double.Parse(Console.ReadLine());
            km = metros / 1000;
            hm = metros / 100;
            dam = metros / 10;
            dm = metros * 10;
            cm = metros * 100;
            mn = metros * 1000;

            Console.WriteLine("O valor digitado em métros é " + metros);
            Console.WriteLine("A distância de " + metros + "m correspode a: ");
            Console.WriteLine(km);
            Console.WriteLine(hm);
            Console.WriteLine(dm);
            Console.WriteLine(cm);
            Console.WriteLine(mn);

            Console.ReadLine();

        }
        public void Exercicio09()
        {
            double real = 0;
            double dollar = 0;
            string nome;

            Console.WriteLine("Informe a quantidade de dinheiro há na carteira: ");
            real = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é seu nome: ");
            nome = string.Format(Console.ReadLine());
            dollar = real * 5.54;

            Console.WriteLine(nome + " tem " + real + " real e se fosse convertido em Dólar americano teria o valor de: " + dollar);
            Console.ReadLine();

        }
        public void Exercicio10()
        {
            double largura, altura, area, litroTinta = 2, tinta = 0;

            Console.WriteLine("Informe a largura: ");
            largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura: ");
            altura = double.Parse(Console.ReadLine());

            area = largura * altura;
            tinta = area / litroTinta;

            Console.WriteLine("A área a ser pintada tem como metragem: " + area + "m e necessita de " + tinta + "L de tinta ");
            Console.ReadLine();
        }
    }
}

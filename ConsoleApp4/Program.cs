using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menuOpcao;
            do 
            {
                MenuOpcao();


                Console.WriteLine("Deseja continuar ?");
                Console.WriteLine("Digite Sim para continuar");
                menuOpcao = Console.ReadLine();
                Console.Clear();
            } 
            while (menuOpcao == "Sim");
        }

        private static void MenuOpcao()
        {
            Lista1 lista1 = new Lista1();
            Lista2 lista2 = new Lista2();
            Lista3 lista3 = new Lista3();
            Lista4 lista4 = new Lista4();

            int escolha = 0;

            Console.WriteLine("Menu");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Escolha uma lista: ");
            Console.WriteLine("1 - Lista01");
            Console.WriteLine("2 - Lista02");
            Console.WriteLine("3 - Lista03");
            Console.WriteLine("4 - Lista04"); 
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    int escolhaLista01 = 0;

                    Console.Clear();
                    Console.WriteLine("Digite o exercício desejado:\n ");
                    Console.WriteLine("1 - Escreva um programa que mostre na tela a mensagem: Olá, Mundo!\n");
                    Console.WriteLine("2 - Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boasvindas para ela:\n");
                    Console.WriteLine("3 - Crie um programa que leia o nome e o salário de um funcionário, mostrando no final uma mensagem.\n");
                    Console.WriteLine("4 - Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório entre eles.\n");
                    Console.WriteLine("5 - Faça um programa que leia as duas notas de um aluno em uma matéria e mostre na tela a sua média na disciplina.\n");
                    Console.WriteLine("6 - Faça um programa que leia um número inteiro e mostre o seu antecessor e seu sucessor.\n");
                    Console.WriteLine("7 - Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a sua terça parte.\n");
                    Console.WriteLine("8 - Desenvolva um programa que leia uma distância em metros e mostre os valores relativos em outras medidas.\n");
                    Console.WriteLine("9 - Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$) e mostre quantos dólares ela pode comprar.\n");
                    Console.WriteLine("10 - Faça um algoritmo que leia a largura e altura de uma parede, calcule e mostre a área a ser pintada e a quantidade de tinta necessária para o serviço,sabendo que cada litro de tinta pinta uma área de 2metros quadrados.\n");
                    escolhaLista01 = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (escolhaLista01)
                    {
                        case 1:
                            lista1.Exercicio01();
                            break;

                        case 2:
                            lista1.Exercicio02();
                            break;

                        case 3:
                            lista1.Exercicio03();
                            break;

                        case 4:
                            lista1.Exercicio04();
                            break;

                        case 5:
                            lista1.Exercicio05();
                            break;

                        case 6:
                            lista1.Exercicio06();
                            break;

                        case 7:
                            lista1.Exercicio07();
                            break;

                        case 8:
                            lista1.Exercicio08();
                            break;

                        case 9:
                            lista1.Exercicio09();
                            break;

                        case 10:
                            lista1.Exercicio10();
                            break;

                        default:
                            Console.WriteLine("Tente novamente");
                            break;


                    }

                    break;

                

                case 2:
                    int escolhaLista02 = 0;


                    Console.Clear();
                    Console.WriteLine("Digite o exercício desejado:\n");
                    Console.WriteLine("1 - Escreva um algoritmo que leia um número e o imprima caso ele seja maior que 20.\n");
                    Console.WriteLine("2 - Ler um valor e escrever a mensagem É MAIOR QUE 10! se o valor lido for maior que 10, caso contrário escrever NÃO É MAIOR QUE 10!\n");
                    Console.WriteLine("3 - Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.\n");
                    Console.WriteLine("4 - Construa um algoritmo que leia dois valores numéricos inteiros e efetue a adição; caso o resultado seja maior que 10, apresentá-lo.\n");
                    Console.WriteLine("5 - Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa. Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o tempo de casada (anos).\n");
                    Console.WriteLine("6 - Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.\n");
                    Console.WriteLine("7 - Faça um algoritmo que leia dois valores inteiros A e B se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.\n");
                    Console.WriteLine("8 - Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso seja negativo, imprimindo o resultado.\n");
                    Console.WriteLine("9 - Faça um algoritmo que leia 3 valores retorno do maior para o menor ordenados.\n");
                    Console.WriteLine("10 - Faça um algoritmo que leia 3 valores retorne do menor para o maior ordenados.\n");
                    Console.WriteLine("11 - Ler a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os minutos) e calcule a duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é de 24 horas e que o jogo pode iniciar em um dia e terminar no dia seguinte retornar quantas horas estão jogando e quantidade de horas restante ou quantidade de horas excedente.\n");
                    escolhaLista02 = int.Parse(Console.ReadLine());
                    Console.Clear();


                    switch (escolhaLista02) 
                    {
                        case 1:
                            lista2.Exercicio01();
                            break;
                        case 2:
                            lista2.Exercicio02();
                            break;
                        case 3:
                            lista2.Exercicio03();
                            break;
                        case 4:
                            lista2.Exercicio04();
                            break;
                        case 5:
                            lista2.Exercicio05();
                            break;
                        case 6:
                            lista2.Exercicio06();
                            break;
                        case 7:
                            lista2.Exercicio07();
                            break;
                        case 8:
                            lista2.Exercicio08();
                            break;
                        case 9:
                            lista2.Exercicio09();
                            break;
                        case 10:
                            lista2.Exercicio10();
                            break;
                        case 11:
                            lista2.Exercicio11();
                            break;

                        default:
                            Console.WriteLine("Tente novaamente");
                            break;
                    }
                    break;

                case 3:
                    int escolhaLista03 = 0;

                    Console.Clear ();
                    Console.WriteLine("Digite o exercício desejado: \n");
                    Console.WriteLine("1 - Faça um programa que receba 3 valores e retorne a soma deles.\n");
                    Console.WriteLine("2 - Faça um programa que receba quatro notas e retorne a média.\n");
                    Console.WriteLine("3 - Faça um programa que receba um nome enquanto o nome for diferente de João continuar pedindo o nome.\n");
                    Console.WriteLine("4 - Faça um programa que retorne à quantidade de números pares existente entre 35 e 98111.\n");
                    Console.WriteLine("5 - FaÇa um programa que some todos os números ímpares de 1 até 5000.\n");
                    Console.WriteLine("6 - Faça um programa que receba um número e usando laços de repetição calcule e mostre a tabuada desse número.\n");
                    escolhaLista03 = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (escolhaLista03) 
                    {
                        case 1:
                            lista3.Exercicio01();
                            break;
                        case 2:
                            lista3.Exercicio02();
                            break;
                        case 3:
                            lista3.Exercicio03();
                            break;
                        case 4:
                            lista3.Exercicio04();
                            break;
                        case 5:
                            lista3.Exercicio05();
                            break;
                        case 6:
                            lista3.Exercicio06();
                            break;
                        default:
                            Console.WriteLine("Tente novamente");
                            break;
                    }
                    break;
                case 4:
                    int escolhaLista04 = 0;

                    Console.Clear ();
                    Console.WriteLine("Digite o exercício desejado: \n");
                    Console.WriteLine("1 - Verificação de Número Par ou Ímpar: \n");
                    Console.WriteLine("2 - Classificação de Idade: \n");
                    Console.WriteLine("3 - Verificação de Notas: \n");
                    Console.WriteLine("4 - Cálculo de IMC: \n");
                    Console.WriteLine("5 - Maior de Dois Números: \n");
                    Console.WriteLine("6 - Verificação de Voto: \n");
                    Console.WriteLine("7 - Cálculo de Desconto: \n");
                    Console.WriteLine("8 - Classificação de Temperatura: \n");
                    Console.WriteLine("9 - Cálculo de Média de Três Números: \n");
                    Console.WriteLine("10 - Verificação de Ano Bissexto: \n");
                    escolhaLista04 = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (escolhaLista04) 
                    {
                        case 1:
                            lista4.Exercicio01();
                        break;
                        case 2:
                            lista4.Exercicio02();
                        break;
                        case 3:
                            lista4.Exercicio03();
                        break;
                        case 4:
                            lista4.Exercicio04();
                        break;
                        case 5:
                            lista4.Exercicio05();
                        break;
                        case 6:
                            lista4.Exercicio06();
                        break;
                        case 7:
                            lista4.Exercicio07();
                        break;
                        case 8:
                            lista4.Exercicio08();
                        break;
                        case 9:
                            lista4.Exercicio09();
                        break;
                        case 10:
                            lista4.Exercicio10();
                        break;
                        default:
                            Console.WriteLine("Tente novamente");
                        break;
                    }
                    break;
                default:
                    Console.WriteLine("Tente novamente");
                    break;


            }
        }
    }
}

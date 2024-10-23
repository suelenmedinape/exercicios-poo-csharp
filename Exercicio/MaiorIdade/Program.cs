using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Exercício Maior Idade
            Implemente um programa no qual o usuário deverá informar o nome e a idade de três pessoas. O programa deverá informar o nome da pessoa que 
                possuir a maior idade.

            Regras que deverão ser seguidas para a implementação do algoritmo:

            - É obrigatório o uso de classe para representar uma pessoa e a mesma deverá possuir como propriedades (características) um nome e uma idade.
            - A classe também deverá possuir um método chamado ExibirDados. Esse método deverá exibir o nome e a idade da pessoa em questão.
            - Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga), um que não recebe parâmetro algum e outro que irá receber 
                o nome e a idade de uma pessoa.
             
             */

            Pessoa[] pessoas = new Pessoa[3];

            for (int i = 0; i < 3; i++)
            {
                pessoas[i] = new Pessoa();
                Console.WriteLine("Pessoa " + i);
                Console.Write("Informe o nome: ");
                pessoas[i].Nome = Console.ReadLine();
                Console.Write("Informe a idade: ");
                pessoas[i].Idade = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Pessoa pessoaMaisVelha = pessoas[0];
            for (int i = 1; i < pessoas.Length; i++)
            {
                if (pessoas[i].Idade > pessoaMaisVelha.Idade)
                {
                    pessoaMaisVelha = pessoas[i];
                }
            }

            Console.WriteLine("A pessoa mais velha é a(o): ");
            pessoaMaisVelha.ExibirDados(pessoaMaisVelha.Nome, pessoaMaisVelha.Idade);

            Console.ReadKey();
        }
    }
}

/*
            Pessoa p1 = new Pessoa;
            Pessoa p2 = new Pessoa;
            Pessoa p3 = new Pessoa;
            Pessoa exibe = new Pessoa();

            Console.WriteLine("Pessoa 1");
            Console.Write("Informe o nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Informe a idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Pessoa 2");
            Console.Write("Informe o nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Informe a idade: ");
            p2.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Pessoa 3");
            Console.Write("Informe o nome: ");
            p3.Nome = Console.ReadLine();
            Console.Write("Informe a idade: ");
            p3.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();*/

/*if (pessoas[0].Idade > pessoas[1].Idade)
{
    if (pessoas[0].Idade > pessoas[2].Idade)
    {
        exibe.ExibirDados(pessoas[0].Nome, pessoas[0].Idade);
    }
    else
    {
        exibe.ExibirDados(pessoas[2].Nome, pessoas[2].Idade);
    }
} else
{
    if (pessoas[1].Idade > pessoas[2].Idade)
    {
        exibe.ExibirDados(pessoas[1].Nome, pessoas[1].Idade);
    }
    else
    {
        exibe.ExibirDados(pessoas[2].Nome, pessoas[2].Idade);
    }
}*/
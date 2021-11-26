using System;
using System.Collections.Generic;
using System.Linq;

namespace dotnetcore
{
    class Program
    {
        // Exercício 1:
        // - Fazer a média de notas dos dois alunos (Zuqui, Bronza) e imprimir no Console.WriteLine();
        // - Imprimir no console para cada aluno
        //      - Nome do aluno
        //      - Caso média maior ou igual 7:
        //          - Passou no ano letivo
        //          - Não passou no ano letivo
        // Requisítos:
        // - Criar um método "CalcularMedia", onde a entrada de parâmetros seja as notas e o retorno seja a média em float
        // - Utilizar For ou Foreach


        // Exercício 2:
        // - Fazer um programa que cadastre pessoas, contendo nome e idade;
        // - Imprimir a media de idade das pessoas
        // - Imprimir o nome e idade da pessoa mais velha
        // - Imprimir o nome e idade da pessoa mais nova
        // - Imprimir a quantidade de pessoas com maior idade
        // Requisítos:
        // - Utilizar List (Avg, Max, Min, Where)
        // - Utilizar Classe Pessoa
        static void Main(string[] args)
        {
        //     var xNomeAluno1 = "Zuqui";
        //     var xNotasAluno1 = new List<int>() {6, 5, 6};

        //     var xNomeAluno2 = "Bronza";
        //     var xNotasAluno2 = new List<int>() {5, 7, 8};

            
        //     var xMediaAluno1 = CalcularMedia(xNotasAluno1);
        //     var xMediaAluno2 = CalcularMedia(xNotasAluno2);            
            
        //     if (xMediaAluno1 >= 7)
        //         Console.WriteLine(xNomeAluno1 + " Passou!");
        //     else
        //         Console.WriteLine(xNomeAluno1 + " Não Passou!");

        //     if (xMediaAluno2 >= 7)
        //         Console.WriteLine(xNomeAluno2 + " Passou!");
        //     else
        //         Console.WriteLine(xNomeAluno2 + " Não Passou!");

            Console.WriteLine("Iniciando programa de cadastro de pessoa - Exercício 2");
            Console.WriteLine("------------------------------------------------------");


            var xPessoas = new List<Pessoa>();

            var xPessoa1 = new Pessoa
            {
                Nome = "Zuqui",
                Idade = 31
            };
            
            var xPessoa2 = new Pessoa
            {
                Nome = "Bronza",
                Idade = 28
            };

            xPessoas.Add(xPessoa1);
            xPessoas.Add(xPessoa2);

            var xMediaIdade = xPessoas.Select(p => p.Idade).Average();
            Console.WriteLine("Media de idade das pessoas: " + xMediaIdade);

            var xPessoaMaisVelha = xPessoas.OrderByDescending(p => p.Idade).FirstOrDefault();
            Console.WriteLine("Pessoa mais velha: " + xPessoaMaisVelha.Nome + " " + xPessoaMaisVelha.Idade);

            var xPessoaMaisNova = xPessoas.OrderBy(p => p.Idade).FirstOrDefault();
            Console.WriteLine("Pessoa mais nova: " + xPessoaMaisNova.Nome + " " + xPessoaMaisNova.Idade);

            var xQtdadePessoasMaiores = xPessoas.Where(p => p.Idade > 18).Count();
            Console.WriteLine("Quantidade de pessoas maiores: " + xQtdadePessoasMaiores);

        }

        public static float CalcularMedia(List<int> pNotas)
        {
            float xMedia = 0;
            foreach (var xNota in pNotas)
            {
                xMedia = xMedia + xNota;
            }

            return xMedia;
        }

        public class Pessoa
        {
            public string Nome {get; set;}
            public int Idade {get; set;}            
        }
    }
}

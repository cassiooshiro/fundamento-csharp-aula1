﻿using System;
using System.Collections.Generic;

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
            var xNomeAluno1 = "Zuqui";
            var xNotasAluno1 = new List<int>() {6, 5, 6};

            var xNomeAluno2 = "Bronza";
            var xNotasAluno2 = new List<int>() {5, 7, 8};

            
            var xMediaAluno1 = CalcularMedia(xNotasAluno1);
            var xMediaAluno2 = CalcularMedia(xNotasAluno2);            
            
            if (xMediaAluno1 > 7)
                Console.WriteLine(xNomeAluno1 + " Passou!");
            else
                Console.WriteLine(xNomeAluno1 + " Não Passou!");

            if (xMediaAluno2 > 7)
                Console.WriteLine(xNomeAluno2 + " Passou!");
            else
                Console.WriteLine(xNomeAluno2 + " Não Passou!");
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
    }
}

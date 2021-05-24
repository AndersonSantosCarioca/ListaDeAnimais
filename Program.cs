using System;
using System.Collections.Generic;
using System.Linq;
using ListaDeAnimais.Classes;

namespace ListaDeAnimais
{
    class Program
    {
        /*
            Escrever um programa <Ok>
            que recebe um nome de animal vertebrado <OK>
            De acordo com o filtro,
            identificar a qual grupo pertence (Mamífero, réptil, Ave e Peixe),
            Exibir os dados genéricos e exclusivos de cada grupo de animal.
        */
        static void Main(string[] argumentos)
        {
            Console.WriteLine("Favor digitar o nome do animal para consultar na lista de animais da base de dados:");
            var nomeAnimal = Console.ReadLine();
            if(string.IsNullOrEmpty(nomeAnimal) || string.IsNullOrWhiteSpace(nomeAnimal))
            {
                Console.WriteLine("Favor passar um nome de animal vertebrado válido");
                return;
            }
            var listaDeAnimais = new List<Animal>();
            listaDeAnimais.Add(new Mamifero() {Nome = "Vaca", QuantidaDeDeMamas = 4 });
            listaDeAnimais.Add(new Reptil() {Nome = "cobra"});
            listaDeAnimais.Add(new Ave() {Nome = "Gavião"});
            listaDeAnimais.Add(new Peixe() {Nome = "tubarao",QuantidadeDeNadadeiras = 2});

            var animalSelecionado = listaDeAnimais.FirstOrDefault(animal => animal.Nome.ToUpper() == nomeAnimal.ToUpper());

            if(animalSelecionado == null)
            {
                Console.WriteLine( " O animal não esta na nossa lista");
                return;
            }

            if(animalSelecionado is Mamifero)
            {
                Console.WriteLine($"O animal encontrado é um mamífero com nome " + $"{animalSelecionado.Nome} e quantidade de mamas = {((Mamifero)animalSelecionado).QuantidaDeDeMamas}");
            }else if(animalSelecionado is Reptil)
            {
                Console.WriteLine($"O animal encontrado é um réptil com nome " + $"{animalSelecionado.Nome} e não contola a temperatura do corpo= {((Reptil)animalSelecionado).ControlaTemperaturaDoCorpo }");
                
            }else if ( animalSelecionado is Ave)
            {
                Console.WriteLine($"O animal encontrado é uma ave com nome " + $"{animalSelecionado.Nome} e tem pena= {((Ave)animalSelecionado).TemPena }");
                
            }else if(animalSelecionado is Peixe)
            {
                Console.WriteLine($"O animal encontrado é um peixe com nome " + $"{animalSelecionado.Nome} e tem = {((Peixe)animalSelecionado).QuantidadeDeNadadeiras } nadadeiras");

            }
            else
            {
                Console.WriteLine($"O animal encontrado é um animal e tem nome" + $"{animalSelecionado.Nome} ");

            }



        }
    }
}

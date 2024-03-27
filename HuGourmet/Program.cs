// See https://aka.ms/new-console-template for more information

using HuGourmet;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

var listaPratos = new List<Pratos> {
            new Pratos { Nome="Bolo de Chocolate", Adjetivo = ""}
};
var listaPratosMassa = new List<Pratos>{
    new Pratos { Nome ="Lasanha", Adjetivo = ""}
};


int pratoAtual;
bool acerto; //quando existe acerto pelo programa

void functionMain(List<Pratos> pratos)
{
    if (pratos.Count > 1)
    {
        int qtdePratos = pratos.Count;
        while (qtdePratos > 1)
        {
            pratoAtual++;
            Console.Clear();
            Console.WriteLine($"O prato que pensou é {pratos[pratoAtual].Adjetivo}?");
            Console.Write("Sim[S] ou Não[N]? ");
            if (Console.ReadLine() == "S")
            {
                Console.WriteLine($"O prato que pensou é {pratos[pratoAtual].Nome}");
                Console.Write("Sim[S] ou Não[N]? ");
                if (Console.ReadLine() == "S")
                {
                    Console.WriteLine("Ótimo! Acertei!");
                    Console.ReadKey();
                    pratoAtual = 0;
                    qtdePratos = 1;
                    acerto = true;
                }
                else { qtdePratos--; }
                
            }
            else { qtdePratos--; }
        }

        if (!acerto)
        {
            pratoAtual = 0;
            Console.Clear();
            Console.WriteLine("O prato que pensou é " + pratos[pratoAtual].Nome + "?");
            Console.Write("Sim[S] ou Não[N]? ");

            if (Console.ReadLine() == "S")
            {
                Console.WriteLine("Ótimo! Acertei!");
                Console.ReadKey();
                pratoAtual = 0;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Qual prato você pensou?");
                string novoPrato = Console.ReadLine();
                if (!string.IsNullOrEmpty(novoPrato))
                {
                    Console.WriteLine("Complete");
                    Console.WriteLine($"{novoPrato} é _________ mas {pratos[pratoAtual].Nome} não.");
                    string adjetivoNovoPrato = Console.ReadLine();

                    if (!string.IsNullOrEmpty(adjetivoNovoPrato))
                    {
                        Pratos itemPrato = new Pratos()
                        {
                            Nome = novoPrato,
                            Adjetivo = adjetivoNovoPrato
                        };
                        pratos.Add(itemPrato);
                    }
                }
                pratoAtual = 0;
            }
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("O prato que pensou é " + pratos[pratoAtual].Nome + "?");
        Console.Write("Sim[S] ou Não[N]? ");

        if (Console.ReadLine() == "S")
        {
            Console.WriteLine("Ótimo! Acertei!");
            pratoAtual = 0;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Qual prato você pensou?");
            string novoPrato = Console.ReadLine();
            if (!string.IsNullOrEmpty(novoPrato))
            {
                Console.WriteLine("Complete");
                Console.WriteLine($"{novoPrato} é _________ mas {pratos[pratoAtual].Nome} não.");
                string adjetivoNovoPrato = Console.ReadLine();

                if (!string.IsNullOrEmpty(adjetivoNovoPrato))
                {
                    Pratos itemPrato = new Pratos()
                    {
                        Nome = novoPrato,
                        Adjetivo = adjetivoNovoPrato
                    };
                    pratos.Add(itemPrato);
                }
            }
            pratoAtual = 0;
        }
    }
}

while (true)
{
    pratoAtual = 0;
    acerto = false;

    Console.Clear();
    Console.WriteLine("JOGO GOURMET");
    Console.WriteLine("Pense em um prato de que gosta");
    Console.WriteLine("Aperte qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
    
    Console.WriteLine("O prato que pensou é massa?");
    Console.Write("Sim[S] ou Não[N]? ");

    if (Console.ReadLine() == "S")
    {
        //se o prato for Massa
        functionMain(listaPratosMassa);
    }
    else
    {  
        functionMain(listaPratos);
    }
}


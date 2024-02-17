﻿using System;
class Program
{
    static void Main()
    {
        int tempo = 0;
        char escolha;

    inicio:

        Console.Clear();

        Console.WriteLine("Blumenau/Sao Paulo");
        Console.WriteLine("Escolha o transporte:[a]viao | [c]arro | [o]nibus");

        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
                tempo = 50;
                break;
            case 'c':
                tempo = 480;
                break;
            case 'o':
                tempo = 660;
                break;
            default:
                tempo = -1;
                break;
        }

        if (tempo < 0)
        {
            Console.WriteLine("[ERROR] Passagem de Dados Invalida");
        }
        else
        {
            Console.WriteLine($"O tempo da viagem será de {tempo} minutos");
        }

        Console.WriteLine("\nCalcular Outro Transporte?[s/n]");
        escolha = char.Parse(Console.ReadLine());
        if (escolha == 's' || escolha == 'S')
        {
            goto inicio;
        }
        else
        {
            Console.Clear();
            Console.Write("Fim de Programa!");
        }
    }
}
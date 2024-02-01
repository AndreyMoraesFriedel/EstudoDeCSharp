using System;

class Program{
    static void Main(){

        //Exemplo de Conversão Implicita
        int n1 = 10;
        float n2 = n1;

        Console.WriteLine(n2);

        //Exemplo de Conversão Explícita
        float n3 = 10.5f;
        int n4 = (int) n3;

        Console.WriteLine(n4);

    }
}
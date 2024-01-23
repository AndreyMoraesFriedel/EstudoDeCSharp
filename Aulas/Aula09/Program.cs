using System;

class Program{
    static void Main(){
        //Operadores Bitwise
        int num=10;
        int num2=50;

        num=num<<1; //Dobrando 10 = 20
        num2=num2>>1; //Metade de 50 = 25

        Console.WriteLine("O Valor do numero: {0}", num);
        Console.WriteLine("O Valor do numero 2: {0}", num2);
    }
}
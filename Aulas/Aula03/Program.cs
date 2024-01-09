using System;

public class Program{
    
    static void Main(){
        byte byt = 10; //0..255
        int inteiro = 77777;
        char cha = 'c';
        float valorFloat = 9.50f;
        string aprendendo = "Isto é uma String em C#";

        var varDin = 10; //Em C# existe variavel dinamica var
    
        Console.WriteLine($"Byte: {byt}, Int: {inteiro}, Char: {cha}, Float: {valorFloat}, String: {aprendendo}, Var: {varDin}");
    }

}
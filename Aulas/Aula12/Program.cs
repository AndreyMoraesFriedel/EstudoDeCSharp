using System;

class Program{
    static void Main(){

        const int QUANTIDADE_NOTAS = 4;
        float[] notasDoEstudante = new float[QUANTIDADE_NOTAS];
        float media, somadorDeNotas;
        media = somadorDeNotas = 0f;
        string resultado = "";

        for(int i = 0;i<QUANTIDADE_NOTAS;i++){
            Console.Write($"Nota {i + 1}: ");
            notasDoEstudante[i] = float.Parse(Console.ReadLine());
            somadorDeNotas += notasDoEstudante[i];
        }

        media = somadorDeNotas / QUANTIDADE_NOTAS;
        
        if(media>=7.0){
            resultado = "Passou";
        }

        Console.WriteLine($"Média: {media.ToString("F2")} | Status do Aluno: {resultado}");

    }
}
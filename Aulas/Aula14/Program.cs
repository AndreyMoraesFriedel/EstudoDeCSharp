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
            if(media>9){
                resultado = "SUPER - APROVADO";
            }
            else{
                resultado = "Passou";
            }
        }
        else{
            if(media>=5.5 && media<7){
                resultado = "Recuperação";
            }
            else{
                resultado = "Reprovado";
            }
        }

        Console.WriteLine($"Média: {media.ToString("F2")} | Status do Aluno: {resultado}");

    }
}
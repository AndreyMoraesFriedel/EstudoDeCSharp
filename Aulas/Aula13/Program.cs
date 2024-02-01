using System;

class Program{
    static void Main(){
        const int QUANTIDADE_NOTAS = 4;
        int[] notasDoEstudante = new int[QUANTIDADE_NOTAS];
        float media = 0f, somadorDeNotas = 0f;
        string resultado = "";

        for(int i = 0;i<QUANTIDADE_NOTAS;i++){
            Console.Write($"Nota {i + 1}: ");
            notasDoEstudante[i] = int.Parse(Console.ReadLine());
            somadorDeNotas += notasDoEstudante[i];
        }

        media = somadorDeNotas / QUANTIDADE_NOTAS;
        
        if(media>=7.0){
            resultado = "Passou";
        }

        else if(media>=5.5 && media<7){
            resultado = "Recuperação";
        }
        
        else{
            resultado = "Reprovado";
        }

        Console.WriteLine($"Média: {media.ToString("F2")} | Status do Aluno: {resultado}");

    }
}
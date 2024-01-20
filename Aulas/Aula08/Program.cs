using System;

class Program{
    static void Main(){
        int primeiraNota; int segundaNota; 
        double media;
        string nomeEstudante;
        
        Console.Write("Digite nome do estudante: ");
        nomeEstudante = Console.ReadLine();

        Console.Write("Nota 1: ");
        primeiraNota = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nota 2: ");
        segundaNota = Convert.ToInt32(Console.ReadLine());

        media = (primeiraNota + segundaNota) / 2;

        Console.WriteLine($"A media do estudante é {media}");
        if(media>=7){
            Console.WriteLine($"O aluno {nomeEstudante} esta Aprovado");
        }else if (media>=5 && media <=6)
        {
            Console.WriteLine($"O aluno {nomeEstudante} esta de Recuperacao");
        }else{
            Console.WriteLine($"O aluno {nomeEstudante} esta Reprovado");
        }

    }
}
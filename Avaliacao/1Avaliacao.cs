using System;

namespace _1Avaliacao
{
    class Avaliacao
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            string[] lines = File.ReadAllLines("C:/Users/eduardo.furlaneto/OneDrive - SENAC-SC/DOTNET/Prova1/Prova1/naoordenado.txt", Encoding.UTF8);
            string leitura = File.ReadAllText("C:/Users/eduardo.furlaneto/OneDrive - SENAC-SC/DOTNET/Prova1/Prova1/naoordenado.txt", Encoding.UTF8);
            while (true){value = leitura.readLine();
            if(value != null){// Enquanto a linha nao for vazia, continua o programa
            linhas++; // Contando o tamanho
            }else
            break;
            }
            leitura.close(); 

            Console.WriteLine("Leitura");
            Console.WriteLine(leitura);
            Console.WriteLine("lines");
            Console.WriteLine(lines);
            foreach (string item in lines)
            {
                Console.WriteLine(item);
            }

                Array.ForEach(lines, item => {Console.WriteLine(item);});

        }
    }
}
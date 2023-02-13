using System;
using System.Text;


namespace _1Avaliacao
{
    class Avaliacao
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("C:/Users/mariane.costa/Documents/C#/1AvaliavaoC#/entrada.txt", Encoding.UTF8);
            string value = "";
            string leitura = "";

            while (true)
            {value = leitura.readLine();

            if(value != null)
            {// Enquanto a linha nao for vazia, continua o programa
            linhas++; // Contando o tamanho
            }else

            break;
            }
            
            leitura.close(); 

            Console.WriteLine("lines");
            Console.WriteLine(lines);
            foreach (string item in lines)
            {
                Console.WriteLine(item);
            }

               // Array.ForEach(lines, item => {Console.WriteLine(item);});

        }
    }
}
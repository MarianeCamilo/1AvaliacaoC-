using System;
using System.Text;

namespace _1Avaliacao
{
    class Avaliacao
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("C:/Users/mariane.costa/Documents/C#/1AvaliavaoC#/entrada.txt", Encoding.UTF8); // abrindo o arquivo de texto

            Console.WriteLine("lines"); 
            Console.WriteLine(lines); // imprimindo o arquivo de texto
            foreach (string item in lines)
            {
                Console.WriteLine(item);
            }

            int[] IntArray = lines.Select(int.Parse).ToArray();    // convertendo o array de string para array de int
            insertionSort(IntArray);
            
            List<int> Collection = IntArray.ToList<int>();
            
            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "C:/Users/mariane.costa/Documents/C#/1AvaliavaoC#/saida.txt")))
            {
            foreach (string s in lines)
                outputFile.WriteLine(s);
            }

        }


            public static void insertionSort(int[] IntArray) 
            { // Ordenação dos valores        
            int j, key, i;
            Console.WriteLine("\nPassos para ordenação: ");
            for (j = 1; j < IntArray.Length; j++) // for com o tamanho maximo
            {
                key = IntArray[j];
            
            for (i = j - 1; (i >= 0) && (IntArray[i] > key); i--)
            {
                IntArray[i + 1] = IntArray[i];
            }
             IntArray[i + 1] = key;
             Console.WriteLine("Passo para ordenação");
             foreach(var s in IntArray)
             {
                Console.WriteLine(s);
             }
        }

    }
}
}
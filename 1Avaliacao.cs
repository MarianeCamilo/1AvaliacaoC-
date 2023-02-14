using System;
using System.Text;


namespace _1Avaliacao
{
    class Avaliacao
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("C:/Users/mariane.costa/Documents/C#/1AvaliavaoC#/entrada.txt", Encoding.UTF8);

            Console.WriteLine("lines");
            Console.WriteLine(lines);
            foreach (string item in lines)
            {
                Console.WriteLine(item);
            }

               // Array.ForEach(lines, item => {Console.WriteLine(item);});
        }

        
    }






    class WriteAllLines
{
    public static async Task ExampleAsync()
    {
        string[] lines =
        {
            "1", "5", "8" 
        };

        await File.WriteAllLinesAsync("entrada.txt", lines);
    }
}


}
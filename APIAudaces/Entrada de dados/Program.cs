using System;
using System.Collections.Generic;
using APIAudaces;

namespace Entrada_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = new List<int>();
            Console.WriteLine("Insira sua sequencia primeiro numero");
            var num1 = Console.ReadLine();
            int result1 = Int32.Parse(num1);
            sequence.Add(result1);
            Console.WriteLine("Insira sua sequencia segundo numero");
            var num2 = Console.ReadLine();
            int result2 = Int32.Parse(num2);
            sequence.Add(result2);
            
            Console.WriteLine("Insira sua sequencia terceiro numero");
            var num3 = Console.ReadLine();
            int result3 = Int32.Parse(num3);
            sequence.Add(result3);
            Console.WriteLine("Insira sua sequencia quarto numero");
            var num4 = Console.ReadLine();
            int result4 = Int32.Parse(num4);
            sequence.Add(result4);
            Console.WriteLine("Insira seu numero alvo");
            var targetReceive = Console.ReadLine();
            int target = Int32.Parse(targetReceive);
            var currentDate = DateTime.Now;
            var Endpoint = new APIAudaces.Controllers.APISequenceController();
            Endpoint.EndPointSequence(sequence, target);
                
            Console.WriteLine(Endpoint.EndPointSequence(sequence, target));
            Console.WriteLine("Executando o Endpoint");
            Console.WriteLine("Json Retornado");


            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}

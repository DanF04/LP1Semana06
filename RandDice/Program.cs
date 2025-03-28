using System;
 
 namespace RandDice
 {
     public class Program
     {
         private static void Main(string[] args)
         {
             if (args.Length != 2)
             {
                 Console.WriteLine("Uso: dotnet run --project RandDice -- <n> <s>");
                 Console.WriteLine("n: número de dados");
                 Console.WriteLine("s: seed para o gerador aleatório");
                 return;
             }
 

         }
     }
 }
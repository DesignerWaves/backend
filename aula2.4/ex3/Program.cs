using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1, var2;

            Console.Write("Escreva o primeiro valor: ");
            var1 = int.Parse(Console.ReadLine());
            
            Console.Write("Escreva o primeiro valor: ");
            var2 = int.Parse(Console.ReadLine());

            if( var1 > var2){
                Console.Write($"O maior numero é {var1}");
            }else {
                Console.Write($"O maior numero é {var2}");
            }
        
        }
    }
}

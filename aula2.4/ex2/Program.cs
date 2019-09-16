using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double var1, total1;

            Console.Write("Quantos você gastou: ");
            var1 = Double.Parse(Console.ReadLine());

            if( var1 < 100) {
                total1 = var1 - 20;
                Console.Write($"O valor com desconto será: {total1} ");
            }else{
                Console.Write("Não terá desconto pois o valor foi muito alto");
            }
        }
    }
}

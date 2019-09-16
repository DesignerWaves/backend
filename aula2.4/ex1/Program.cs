using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal, desptotal, var1;
            
            Console.Write("Digite seu salário: ");
            sal = double.Parse(Console.ReadLine());

            Console.Write("Digite suas despesas mensais: ");
            desptotal = double.Parse(Console.ReadLine());

            var1 = sal - desptotal;

            if( var1 > 0 ) {
                Console.WriteLine("Seu saldo é positivo");
            }else{
                Console.WriteLine("Seu saldo é negativo");
            }
            
        }
    }
}

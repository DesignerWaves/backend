using System;

namespace aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            //laço contato - for - incremento (+)
            for(int cont= 0 ; cont <= 100 ; cont++){
                
                // verificamos se o numero é diferente de :
                // cont % tem como fnalidade pegar verificar o resto da divisão e juntamente com o != (diferente) faz com que o pegue todos os numeros que nao tenham um valor exato como resultado e os exiba na tela

                if(cont % 2 != 0){
                    Console.WriteLine(cont);

                }
            }
            //Lçao contado - for - decremetno (-)
            for (int cont = 100 ; cont >= 0 ; cont--){
                if(cont % 2 != 0){
                    Console.WriteLine("For 100 - 0 " + cont);
                }
            }
        }
    }
}
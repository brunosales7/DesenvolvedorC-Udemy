using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosIterativos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laços interativos => estruturas que repetem um bloco de código, determinado numero de 

            // Laço for
            for(int i=0; i<=5; i++) // i++ significa que i será incrementado de 1 em 1
            {
                Console.WriteLine("Valor de i é " + i);
            }
            //While
            int contador = 3;
            while(contador < 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            //Do ... while
            //Execução garantida pelo menos uma vez! (executa o bloco primeiro e depois faz o teste de condição)
            double j = 10;
            do
            {
                Console.WriteLine(j);
                j = j * 1.5;
            } while (j < 100);
    
            //Foreach
            //Percorre todos os elementos de um conjunto


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laços Condicionais => execução mediante determinada condição/situação satisfeita
            int hora = 18;
            //Laço if , else if e else


            //if (hora <= 15)// if = SE. Se a hora for maior ou igual a 15, será impressa a mensagem no console
            //    Console.WriteLine("Já são menos 15!");

            //else if (hora <= 13) // else if = Se não.
            //    Console.WriteLine("Já sao 13 horas ou mais");

            /* else //o else garante a execução d bloco de código seguinte a ele
             {
                 Console.WriteLine("Ja passou das 17 h!");
             }*/

            //Da pra colocar outro if/else dentro do else , exemplo a seguir

            //else
            //{
            //    if (hora == 18)
            //        Console.WriteLine("São 18h!");

            //    else
            //        Console.WriteLine("Já passou das 18h!");
            //}

            //SWITCH ... CASE
            //Geralmente a expressão avaliada é uma constante
            //Em nenhuma hipotese serão executados 2 casos simultaneamente
            //switch(hora)
            //{

            //    case 15: // O teste condicional aqui é exato
            //        Console.WriteLine("São 15h!");
            //        break;
            //    case 18: //O teste condicional qui é exato
            //        Console.WriteLine("São 18!");
            //        break;

            //}

            PrimeiroSemestre mes = PrimeiroSemestre.Abril;
            switch(mes)
            {
                case PrimeiroSemestre.Janeiro:
                    Console.WriteLine("Estamos em janeiro!");
                    break;
                case PrimeiroSemestre.Fevereiro:
                    Console.WriteLine("Estamos em Fevereiro!");
                    break;
                case PrimeiroSemestre.Marco:
                    Console.WriteLine("Estamos em Marco!");
                    break;
                case PrimeiroSemestre.Abril:
                    Console.WriteLine("Estamos em Abril!");
                    break;
                case PrimeiroSemestre.Maio:
                    Console.WriteLine("Estamos em Maio!");
                    break;
                case PrimeiroSemestre.Junho:
                    Console.WriteLine("Estamos em Junho!");
                    break;
                default: // Será executado se nenhum dos outros foi satisfeito!
                    Console.WriteLine("O mês atual não é nem Janeiro, Fevereiro ou Março! É " + mes);
                    break;
            }




        }
    }


    public enum PrimeiroSemestre
    {
        Janeiro, Fevereiro, Marco, Abril, Maio, Junho

    }

}

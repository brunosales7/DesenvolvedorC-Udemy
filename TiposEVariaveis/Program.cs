using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposEVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10; //declara uma variavel inteira e armazena o valor 10 nela
            int numero2 = 20;
            var soma = numero1 + numero2;//o var define dinâmicamente o tipo da variável
            Console.WriteLine("10 + 20 = " + soma);

            int copiaDeNumero1 = numero1;//copia o valor da variável "numero1"
            copiaDeNumero1 = 11; //Será que o valor de 'numero1' foi alterado?
            Console.WriteLine(numero1);
            Console.WriteLine(copiaDeNumero1);


            var quadrado1 = new Quadrado();//Crie um quadrado.Para criar um objeto de uma classe (new)
            quadrado1.lado = 10;//Quadrado1 terá valor de lado = 10
            var quadrado2 = quadrado1;//será que a cópia do quadrado foi completa? Ou copiamos apenas a referência?
            quadrado2.lado = 11;
            Console.WriteLine(quadrado1.lado);//quadrado1 deveria ter o lado igual a 10
            Console.WriteLine(quadrado2.lado);//quadrado2 deveria ter o lado iual a 11
        }
        class Quadrado // define uma classe chamada Quadrado
        {
           public int lado;//Define um atributo inteiro chamado lado, na classe Quadrado
        }
    }
}

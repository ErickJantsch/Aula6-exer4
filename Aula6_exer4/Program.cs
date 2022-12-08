using System;

namespace Aula6_exer4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4) Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que\n" +
                                     "serão lidos em seguida.Mostre quantos destes valores X estão dentro do intervalo\n" +
                                    " [10, 20] e quantos estão fora do intervalo, mostrando essas informações conforme\n" +
                                    "exemplo(use a palavra in  para dentro do intervalo, e out  para fora do\n" +
                                    "intervalo)");
            Console.WriteLine();
            int N = 0;
            int _in = 0;
            int _out = 0;

            Console.WriteLine("Insira o numerode valores  a ser insiridos");
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input >= 10 && input <= 20)
                {
                    _in++;
                }
                else
                {
                    _out++;
                }
            }
            Console.WriteLine("In " + _in + "\n Out" + _out);


        }
    }
}

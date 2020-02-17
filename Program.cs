using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            class Program
        {
            public class VendasTrufa
            {
                public double valorUnitario;
                public int quantidade;

                public double calcularValorTotal()
                {
                    return valorUnitario * quantidade;

                }

                public double calcularQtdeReajustada()
                {

                    if (quantidade >= 10)
                    {
                        quantidade = quantidade + 1;
                    }

                    return quantidade;

                }

            }

            static void Main(string[] args)
            {
                VendasTrufa V = new VendasTrufa();

                Console.WriteLine("Por favor, informe o valor unitário das trufas");
                V.valorUnitario = double.Parse(Console.ReadLine());

                Console.WriteLine("Por faor, informe a quantidade de trufas compradas");
                V.quantidade = int.Parse(Console.ReadLine());



                Console.WriteLine("O valor total a ser pago é: " + (V.calcularValorTotal()));

                Console.WriteLine("A quantidade de trufas a serem levadas é: " + V.calcularQtdeReajustada());

                Console.ReadKey();

            }



        }
    }

}
    }
}

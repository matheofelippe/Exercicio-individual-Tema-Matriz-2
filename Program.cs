using System;

namespace Exercicio_individual_Tema_Matriz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um numero para ser o numero de LINHAS na matriz: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Agora, insira um numero para ser o numero de COLUNAS na matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n]; //Cria a matriz e seu tamanho com os numeros pedidos

            for (int l = 0; l < m; l++) 
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("Insira o [" + l + ", " + c + "]: ");  //Preenche a matriz com numeros
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("Insira um numero que pertença a matriz: "); // Pede um numero x para vericar seus lados na matriz
            int x = int.Parse(Console.ReadLine());

            for (int l = 0; l < m; l++)  
            {
                for (int c = 0; c < n; c++)
                {
                    if (matriz[l, c] == x) //Acha o numero pedido na matriz
                    {
                        if ((c - 1) >= 0) //Verifica se ha um numero a esquerda de x
                        {
                            Console.WriteLine("O número a esquerda é: " + matriz[l, c - 1]);
                        }
                        else
                        {
                            Console.WriteLine("Não há número a esquerda de " + x);
                        }
                        if ((c + 1) < n) //Verifica se ha um numero a direita de x
                        {
                            Console.WriteLine("O número a direita é: " + matriz[l, c + 1]);
                        }
                        else
                        {
                            Console.WriteLine("Não há número a direita de " + x);
                        }
                        if ((l - 1) >= 0) //Verifica se ha um numero acima de x
                        {
                            Console.WriteLine("O número acima é: " + matriz[l - 1, c]);
                        }
                        else
                        {
                            Console.WriteLine("Não há número acima de " + x);
                        }
                        if ((l + 1) <  m) //Verifica se ha um numero abaixo de x
                        {
                            Console.WriteLine("O número a abaixo é: " + matriz[l+1, c]);
                        }
                        else
                        {
                            Console.WriteLine("Não há número abaixo de " + x);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

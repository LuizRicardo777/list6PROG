using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace list6PROG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ESCOLHA UM EXERCICIO:");
            Console.WriteLine("1 EXERCICIO:");
            Console.WriteLine("2 EXERCICIO:");
            Console.WriteLine("3 EXERCICIO:");
            Console.WriteLine("4 EXERCICIO:");
            Console.WriteLine("5 EXERCICIO:");
            Console.WriteLine("6 EXERCICIO:");
            Console.WriteLine("7 EXERCICIO:");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    double soma = 0, nu = 1;
                    for (; nu > 0;)
                    {
                        Console.WriteLine("entre com um numero");
                        nu = double.Parse(Console.ReadLine());

                        if (nu > 0)
                        {
                            soma += nu;
                            Console.WriteLine("preço do produto " + nu +
                                              " valor da soma atual " + soma);
                        }
                        else
                        {
                            Console.WriteLine("valor final é " + soma);
                        }
                    }
                    Console.ReadKey();
                    break;

                    case 2:
                    

                         string nome, nomeMENOR = "", nomeMAIOR = "";
                        int numIT,parada =  1;
                        float valor,maiorValor,menorValor;
                         maiorValor = float.MinValue;
                         menorValor = float.MaxValue;

                    for (;parada != 1;)
                    {
                        Console.WriteLine("digite o nome do produto:");
                        nome = Console.ReadLine();

                        Console.WriteLine("qual a quantidade de produtos:");
                        numIT = int.Parse(Console.ReadLine());

                        Console.WriteLine("qual o proço do produto:");
                        valor = int.Parse(Console.ReadLine());

                        float total = numIT * valor;

                        if (total > maiorValor)
                        {
                            maiorValor = total;
                            menorValor = nome;
                        }
                        else if(total > menorValor)
                        {
                            menorValor = total;
                            menorValor = nome;
                        }

                        Console.WriteLine("você quer adicionar digite : 1 "); 
                        Console.WriteLine("você quer parar digite : 0 "); 
                        parada = int.Parse(Console.ReadLine());

                    }
                    Console.WriteLine("Nomedo produtoe maior quantia total investida em um único produto em estoque" +);
                    break;

                default:
                    break;
            }




        }
    }
}

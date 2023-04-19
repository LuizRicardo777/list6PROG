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


                //     string nome1, nomeMENOR = "", nomeMAIOR = "";
                //    int numIT,parada =  1;
                //    float valor,maiorValor,menorValor;
                //     maiorValor = float.MinValue;
                //     menorValor = float.MaxValue;

                //for (;parada != 1;)
                //{
                //    Console.WriteLine("digite o nome do produto:");
                //    nome1 = Console.ReadLine();

                //    Console.WriteLine("qual a quantidade de produtos:");
                //    numIT = int.Parse(Console.ReadLine());

                //    Console.WriteLine("qual o proço do produto:");
                //    valor = int.Parse(Console.ReadLine());

                //    float total = numIT * valor;

                //    if (total > maiorValor)
                //    {
                //        maiorValor = total;
                //        menorValor = nome1;
                //    }
                //    else if(total > menorValor)
                //    {
                //        menorValor = total;
                //        menorValor = nome1;
                //    }

                //    Console.WriteLine("você quer adicionar digite : 1 "); 
                //    Console.WriteLine("você quer parar digite : 0 "); 
                //    parada = int.Parse(Console.ReadLine());

                //}
                //Console.WriteLine("Nomedo produtoe maior quantia total investida em um único produto em estoque" +);
                //break;
                //Console.ReadKey();
                case 3:

                    int ava, NumAva, resultado = 0, i = 0;



                    Console.WriteLine("quantas avaliaçoes você deseja realizar");
                    NumAva = int.Parse(Console.ReadLine());

                    for (; i < NumAva;)
                    {
                        Console.WriteLine("qual o peso dessa avaliação?");
                        ava = int.Parse(Console.ReadLine());

                        resultado += ava;

                        i++;


                    }
                    if (resultado < 100)
                    {
                        Console.WriteLine("você está abaixo do esperado (insuficiente )");
                    }
                    else if (resultado > 100)
                    {
                        Console.WriteLine("você está acima do esperado (excedente )");
                    }
                    else
                    {
                        Console.WriteLine("você está no esperado(excedente)");
                    }
                    Console.ReadKey();

                    break;

                case 4:


                    Console.WriteLine("quantas vezes deseja repetir?");
                    int rep = int.Parse(Console.ReadLine());

                    for (int m = 1; m <= rep; m++)
                    {
                        Console.Write("Informe a sigla do estado: ");
                        string sigla = Console.ReadLine().ToUpper();

                        string nomeEstado;

                        switch (sigla)
                        {
                            case "AC":
                                nomeEstado = "Acre";
                                break;
                            case "AL":
                                nomeEstado = "Alagoas";
                                break;
                            case "AP":
                                nomeEstado = "Amapá";
                                break;
                            case "AM":
                                nomeEstado = "Amazonas";
                                break;
                            case "BA":
                                nomeEstado = "Bahia";
                                break;
                            case "CE":
                                nomeEstado = "Ceará";
                                break;
                            case "DF":
                                nomeEstado = "Distrito Federal";
                                break;
                            case "ES":
                                nomeEstado = "Espírito Santo";
                                break;
                            case "GO":
                                nomeEstado = "Goiás";
                                break;
                            case "MA":
                                nomeEstado = "Maranhão";
                                break;
                            case "MT":
                                nomeEstado = "Mato Grosso";
                                break;
                            case "MS":
                                nomeEstado = "Mato Grosso do Sul";
                                break;
                            case "MG":
                                nomeEstado = "Minas Gerais";
                                break;
                            case "PA":
                                nomeEstado = "Pará";
                                break;
                            case "PB":
                                nomeEstado = "Paraíba";
                                break;
                            case "PR":
                                nomeEstado = "Paraná";
                                break;
                            case "PE":
                                nomeEstado = "Pernambuco";
                                break;
                            case "PI":
                                nomeEstado = "Piauí";
                                break;
                            case "RJ":
                                nomeEstado = "Rio de Janeiro";
                                break;
                            case "RN":
                                nomeEstado = "Rio Grande do Norte";
                                break;
                            case "RS":
                                nomeEstado = "Rio Grande do Sul";
                                break;
                            case "RO":
                                nomeEstado = "Rondônia";
                                break;
                            case "RR":
                                nomeEstado = "Roraima";
                                break;
                            case "SC":
                                nomeEstado = "Santa Catarina";
                                break;
                            case "SP":
                                nomeEstado = "São Paulo";
                                break;
                            case "SE":
                                nomeEstado = "Sergipe";
                                break;
                            case "TO":
                                nomeEstado = "Tocantins";
                                break;
                            default:
                                nomeEstado = null;
                                break;
                        }

                        if (nomeEstado != null)
                        {
                            Console.WriteLine("O estado correspondente à sigla {0} é {1}.", sigla, nomeEstado);
                        }
                        else
                        {
                            Console.WriteLine("Sigla inválida.");
                        }
                    }
                    Console.ReadKey();


                    break;

                case 5:

                    Console.Write("Digite um número inteiro entre 1 e 12: ");
                    int mes = int.Parse(Console.ReadLine());

                    string estacao;

                    switch (mes)
                    {
                        case 12:
                            estacao = "verao";
                            break;
                        case 1:
                            estacao = "verao";
                            break;
                        case 2:
                            estacao = "verao";
                            break;

                        case 3:
                            estacao = "outono";
                            break;
                        case 4:
                            estacao = "outono";
                            break;
                        case 5:
                            estacao = "outono";
                            break;


                        case 6:
                            estacao = "inverno";
                            break;
                        case 7:
                            estacao = "inverno";
                            break;
                        case 8:
                            estacao = "inverno";
                            break;


                        case 9:
                            estacao = "primavera";
                            break;

                        case 10:
                            estacao = "primavera";
                            break;
                        case 11:
                            estacao = "primavera";
                            break;
                        default:
                            Console.WriteLine("Mês inválido.");
                            break;

                    }
                    Console.ReadKey();
                    break;

                case 6:

                    double kg, altura, imc;
                    Console.WriteLine("qual sua altura?");
                    altura = double.Parse(Console.ReadLine());

                    Console.WriteLine("qual seu peso?");
                    kg = double.Parse(Console.ReadLine());

                    imc = kg / (altura * altura);

                    if (imc < 18.5)
                    {
                        Console.WriteLine("Abaixo de 18,5: abaixo do peso");
                    }
                    else if (imc > 18.5 || imc <= 24.9)
                    {
                        Console.WriteLine("Entre 18,5 e 24,9: peso normal");
                    }
                    else if (imc > 25 || imc <= 29.9)
                    {
                        Console.WriteLine("Entre 25,0 e 29,9: sobrepeso");
                    }
                    else if (imc > 30 || imc <= 34.9)
                    {
                        Console.WriteLine("Entre 30,0 e 34,9: obesidade grau 1");

                    }
                    else if (imc > 35 || imc <= 39.9)
                    {
                        Console.WriteLine("Entre 35,0 e 39,9: obesidade grau 2");
                    }
                    else if (imc > 40)
                    {
                        Console.WriteLine("Acima de40: obesidade grau 3 (mórbida).");
                    }
                    Console.ReadKey();
                    break;

                case 7:

                    Console.Write("Digite um número inteiro positivo: ");
                    int n = int.Parse(Console.ReadLine());

                    Console.Write("Divisores de " + n + ": ");

                    for (int N = 1; N <= n; N++)
                    {
                        if (n % N == 0)
                        {
                            Console.Write(N + " ");
                        }
                    }

                    Console.ReadKey ();
                    break;


                default:
                    Console.WriteLine("esse exercicio não existe");
                    break;
            }




        }
    }
}

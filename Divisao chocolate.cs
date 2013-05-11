using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarefa

            //Dada uma sequência de divisões realizadas por Juliana em uma barra de chocolate, 
            //determinar quantos pedaços serão armazenados em estoque para uso futuro.
            

            short num_div = 0;/*declarado variável como short pois há um limite de divisões e o tipo da variavél comporta até mais que o limite*/
            /*nesta variavel será definido o numero de divisoes a serem feitas na barra de chocolate original*/

            short num_pedaco = 0;/*variavel utilizada para informar o numero de pedaços que será dividido o pedaço atual*/

            short quant_estoq = 0;/*definirá no final do programa a quantidade de pedaços da barra que sobraram no estoque*/

            Boolean regra = false;/*esta variavel será utilizada para um loop,caso o usuario digitar algo fora do parametro desejado no 1º e 2º enunciado*/

            String resposta = "S";/*variavel utilizada no final da execução para o caso do usuario querer fazer novar partições*/

            /*titulo*/
            Console.WriteLine("\t\t\t\t Estoque de chocolate");


            while (resposta == "S" || resposta == "s")
            {//inicio while 1

                /*primeiro enunciado*/
                Console.WriteLine("Quantas vezes deseja dividir a barra de chocolate?");

                regra = false;/*utilizado para o caso do usuario querer fazer uma nova divisao*/

                /*caso o usuario digitar abaixo de 0 ou acima de 1000 a pergunta retornará novamente*/
                while (regra == false)
                {//inicio do while 2

                    try/*utilizado o try e catch para diminuir chance de parar o programa por erro de digitação do usuário*/
                    {
                        num_div = Convert.ToInt16(Console.ReadLine());/*a variavel recebe a resposta do usuário*/

                        if (num_div > 0 && num_div < 1001)
                            regra = true;/*no caso do usuario nao digitar errado, o catch nao será utilizado,por isso a variavel declarada como true(encerrando a condição do loop)*/

                        else
                        {
                            Console.WriteLine("O mínimo de divisões é 1 e o máximo é 1000.Escreva novamente: ");
                            regra = false;
                        }
                    }

                    catch/*para o caso de erro de digitação*/
                    {
                        Console.WriteLine("O mínimo de divisões é 1 e o máximo é 1000.Escreva novamente: ");
                        regra = false;/*mantem a condição do loop*/
                    }

                }//fim do while 2


                /*segundo enunciado*/
                Console.WriteLine("Quantos pedaços deseja dividir o pedaço atual?");

                regra = false;//utilizado a variavel novamente para o caso de erro de digitação do usuario

                while (num_div > 0)
                {//inicio while 3

                    while (regra == false)
                    {//inicio while 4
                        try
                        {
                            num_pedaco = Convert.ToInt16(Console.ReadLine());

                            if (num_pedaco > 1 && num_pedaco < 11)
                                regra = true;
                            else
                                Console.WriteLine("Os pedaços podem ser divididos de 2 a 10 pedaços\nEscreva nomamente: ");

                        }

                        catch
                        {
                            Console.WriteLine("Os pedaços podem ser divididos de 2 a 10 pedaços/nEscreva nomamente: ");
                        }

                    }//fim while 4

                    /*cada vez que dividimos o chocolate, 1 pedaço será utilizado para dividir mais vezes e outro ja será reservado para o estoque.*/
                    /*entao a cada divisao podemos subtrair um pedaço que sempre será dividido e somar os pedaços restantes na variavel quant_estoq*/

                    num_div--;//variavel contadora

                    quant_estoq = Convert.ToInt16(quant_estoq + (num_pedaco - 1));

                    regra = false;//A cada iteração o while 3 precisa ser utilizado para evitar erros de digitação
                    //E na condição do while 3 a variavel regra precisa estar como false 

                }//fim while 3



                /*saída informando o número de chocolates que serão armazenados no estoque*/
                Console.WriteLine("\nForam armazenados no estoque " + quant_estoq + " pedaços");

                Console.WriteLine("Iniciar nova divisão ?(Sim = S; Não = N)");

                regra = false;//usando novamente a variavel para casos de erro de digitação
                
                while(regra == false)//inicio while 5

                    try
                    {//inicio do try

                        resposta = Console.ReadLine();

                        switch(resposta)

                        {//inicio do switch
                            case "N":
                                regra = true;
                                break;
                            case "n":
                                regra = true;
                                break;
                            case "S":
                                regra = true;
                                break;
                            case "s":
                                regra = true;
                                break;
                            default:
                                break;
                                                        
                        }//fim do switch

                    }//fim do try

                    catch
                    {
                        Console.WriteLine("Responda S = Sim ou N = Não.");
                    }//fim do catch

            }//fim while 1

        }//fim do metodo main
        
            
        }
    }


/*Gabriel Oliveira Paes de Andrade
 * Estou criando uma calculadora com alguns atributos a mais
 * alem de contas ela apresenta a tabuada para estudos
 * vc pode visualizar as tabuadas e depois fazer um exercicio
 */

// Converti 1x1 e 10 x 10 para byte - converter os outros tbm

using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Qual seu nome? ");
        string? nome = Convert.ToString(Console.ReadLine());
        Console.WriteLine("OK " + nome + " vamos começar?!");

        bool sair = false;

        while (!sair)
        {

            Console.WriteLine("Gostaria de fazer uma conta ou estudar tabuada? ");
            Console.WriteLine("1 = CONTA");
            Console.WriteLine("2 = TABUADA");

    int escolha = Convert.ToInt32(Console.ReadLine());
    if (escolha == 1)
{
    Console.WriteLine("CONTA");



    Console.Write("Escolha um numero: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Escolha o segundo numero: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Escolha a operação: ");


    Console.WriteLine("Escolha a operação:");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.Write("Opção: ");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Resultado {num1} + {num2} = {Adicao(num1, num2)}");
            break;
        case 2:
            Console.WriteLine($"Resultado {num1} - {num2} = {Subtracao(num1, num2)}");
            break;
        case 3:
            Console.WriteLine($"Resultado {num1} * {num2} = {Multiplicacao(num1, num2)}");
            break;
        case 4:
            Console.WriteLine($"Resultado {num1} / {num2} = {Divisao(num1, num2)}");
            break;
        default:
            Console.WriteLine("Esta opção não existe!");
            break;

    }
    static double Adicao(double a, double b)
    {
        return a + b;
    }
    static double Subtracao(double a, double b)
    {
        return a - b;
    }
    static double Multiplicacao(double a, double b)
    {
        return a * b;
    }
    static double Divisao(double a, double b)
    {
        return a / b;
    }
}
if (escolha == 2)
{
    Console.WriteLine("TABUADA");
    Console.WriteLine("OK, qual tabuada gostaria de vizualizar primeiro");
    Console.WriteLine("1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10");
    int tabuada = Convert.ToInt32(Console.ReadLine());


    switch (tabuada)
    {
        case 1:
            Console.WriteLine("1 x 1 = 1");
            Console.WriteLine("1 x 2 = 2");
            Console.WriteLine("1 x 3 = 3");
            Console.WriteLine("1 x 4 = 4");
            Console.WriteLine("1 x 5 = 5");
            Console.WriteLine("1 x 6 = 6");
            Console.WriteLine("1 x 7 = 7");
            Console.WriteLine("1 x 8 = 8");
            Console.WriteLine("1 x 9 = 9");
            Console.WriteLine("1 x 10 = 10");


            Console.WriteLine("Preparado para o exercício?!");
            Console.Write("Vamos lá: 1 x 1 =  ");
                        byte num11 = Convert.ToByte(Console.ReadLine());
                        if (num11 == 1)
                        {
                            Console.WriteLine("Parabéns");
                            Console.WriteLine("");


                        }
                        else Console.WriteLine("Errado! A resposta correta é 1");
                        Console.WriteLine("");

                        Console.Write("1 x 2 =  ");
                        int num12 = Convert.ToInt16(Console.ReadLine());
                        if (num12 ==2)
                        {
                            Console.WriteLine("Parabéns");
                            Console.WriteLine("");

                        }
                        else Console.WriteLine("Errado! A resposta correta é 2");
                        Console.WriteLine("");


                        Console.Write("1 x 3 =  ");
                        int num13 = Convert.ToInt16(Console.ReadLine());
                        if (num13 == 3)
                        {
                            Console.WriteLine("Parabéns");
                            Console.WriteLine("");

                        }
                        else Console.WriteLine("Errado! A resposta correta é 3");
                        Console.WriteLine("");


                        Console.Write("1 x 4 =  ");
                        int num14 = Convert.ToInt16(Console.ReadLine());
                        if (num14 == 4)
                        {
                            Console.WriteLine("Parabéns");
                            Console.WriteLine("");

                        }
                        else Console.WriteLine("Errado! A resposta correta é 4");
                        Console.WriteLine("");


                        Console.Write("1 x 5 =  ");
                        int num15 = Convert.ToInt16(Console.ReadLine());
                        if (num15 == 5)
                        {
                            Console.WriteLine("Parabéns");
                            Console.WriteLine("");

                        }
                        else Console.WriteLine("Errado! A resposta correta é 5");
                        Console.WriteLine("");


                        Console.Write("1 x 6 =  ");
                        int num16 = Convert.ToInt16(Console.ReadLine());
                        if (num16 == 6)
                        {
                            Console.WriteLine("Parabéns");
                            Console.WriteLine("");

                        }
                        else Console.WriteLine("Errado! A resposta correta é 6");
                        Console.WriteLine("");


                        Console.Write("1 x 7 =  ");
                        int num17 = Convert.ToInt16(Console.ReadLine());
                        if (num17 == 7)
                        {
                            Console.WriteLine("Parabéns");
                            Console.WriteLine("");

                        }
                        else Console.WriteLine("Errado! A resposta correta é 7");
                        Console.WriteLine("");


                        Console.Write("1 x 8 =  ");
                        int num18 = Convert.ToInt16(Console.ReadLine());
                        if (num18 == 8)
                        {
                            Console.WriteLine("Parabéns");
                            Console.WriteLine("");

                        }
                        else Console.WriteLine("Errado! A resposta correta é 8");
                        Console.WriteLine("");


                        Console.Write("1 x 9 =  ");
                        int num19 = Convert.ToInt16(Console.ReadLine());
                        if (num19 == 9)
                        {
                            Console.WriteLine("Parabéns");
                            Console.WriteLine("");

                        }
                        else Console.WriteLine("Errado! A resposta correta é 9");
                        Console.WriteLine("");


                        Console.Write("1 x 10 =  ");
                        int num110 = Convert.ToInt16(Console.ReadLine());
                        if (num110 == 10)
                        {
                            Console.WriteLine("Parabéns");
                            Console.WriteLine("");


                        }
                        else Console.WriteLine("Errado! A resposta correta é 10");
                        Console.WriteLine("");


                        break;

        case 2:
            Console.WriteLine("2 x 1 = 2");
            Console.WriteLine("2 x 2 = 4");
            Console.WriteLine("2 x 3 = 6");
            Console.WriteLine("2 x 4 = 8");
            Console.WriteLine("2 x 5 = 10");
            Console.WriteLine("2 x 6 = 12");
            Console.WriteLine("2 x 7 = 14");
            Console.WriteLine("2 x 8 = 16");
            Console.WriteLine("2 x 9 = 18");
            Console.WriteLine("2 x 10 = 20");

            Console.WriteLine("Preparado para o exercício?!");
            Console.Write("Vamos lá: 2 x 1 =  ");
            int num21 = Convert.ToInt16(Console.ReadLine());
            if (num21 == 2)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");


            }
            else Console.WriteLine("Errado! A resposta correta é 2");

            Console.Write("2 x 2 =  ");
            int num22 = Convert.ToInt16(Console.ReadLine());
            if (num22 == 4)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");


            }
            else Console.WriteLine("Errado! A resposta correta é 4");
            Console.WriteLine("");

            Console.Write("2 x 3 =  ");
            int num23 = Convert.ToInt16(Console.ReadLine());
            if (num23 == 6)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 6");
            Console.WriteLine("");

            Console.Write("2 x 4 =  ");
            int num24 = Convert.ToInt16(Console.ReadLine());
            if (num24 == 8)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 8");
                        Console.WriteLine("");


            Console.Write("2 x 5 =  ");
            int num25 = Convert.ToInt16(Console.ReadLine());
            if (num25 == 10)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 10");
                        Console.WriteLine("");


            Console.Write("2 x 6 =  ");
            int num26 = Convert.ToInt16(Console.ReadLine());
            if (num26 == 12)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 6");
                        Console.WriteLine("");

            Console.Write("2 x 7 =  ");
            int num27 = Convert.ToInt16(Console.ReadLine());
            if (num27 == 14)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 14");
                        Console.WriteLine("");

            Console.Write("2 x 8 =  ");
            int num28 = Convert.ToInt16(Console.ReadLine());
            if (num28 == 16)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 16");
                        Console.WriteLine("");

            Console.Write("2 x 9 =  ");
            int num29 = Convert.ToInt32(Console.ReadLine());
            if (num29 == 18)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 18");
                        Console.WriteLine("");

            Console.Write("2 x 10 =  ");
            int num210 = Convert.ToInt16(Console.ReadLine());
            if (num210 == 20)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");

            }
            else Console.WriteLine("Errado! A resposta correta é 20");

            break;

        case 3:
            Console.WriteLine("3 x 1 = 3");
            Console.WriteLine("3 x 2 = 6");
            Console.WriteLine("3 x 3 = 9");
            Console.WriteLine("3 x 4 = 12");
            Console.WriteLine("3 x 5 = 15");
            Console.WriteLine("3 x 6 = 18");
            Console.WriteLine("3 x 7 = 21");
            Console.WriteLine("3 x 8 = 24");
            Console.WriteLine("3 x 9 = 27");
            Console.WriteLine("3 x 10 = 30");

            Console.WriteLine("Preparado para o exercício?!");
            Console.Write("Vamos lá: 3 x 1 =  ");
            int num31 = Convert.ToInt16(Console.ReadLine());
            if (num31 == 3)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("Parabéns");

            }
            else Console.WriteLine("Errado! A resposta correta é 3");

            Console.Write("3 x 2 =  ");
            int num32 = Convert.ToInt16(Console.ReadLine());
            if (num32 == 6)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 6");
            Console.WriteLine("");

            Console.Write("3 x 3 =  ");
            int num33 = Convert.ToInt16(Console.ReadLine());
            if (num33 == 9)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 9");
            Console.WriteLine("");

            Console.Write("3 x 4 =  ");
            int num34 = Convert.ToInt16(Console.ReadLine());
            if (num34 == 12)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 12");
            Console.WriteLine("");


            Console.Write("3 x 5 =  ");
            int num35 = Convert.ToInt16(Console.ReadLine());
            if (num35 == 15)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 15");
            Console.WriteLine("");


            Console.Write("3 x 6 =  ");
            int num36 = Convert.ToInt16(Console.ReadLine());
            if (num36 == 18)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 18");
            Console.WriteLine("");


            Console.Write("3 x 7 =  ");
            int num37 = Convert.ToInt16(Console.ReadLine());
            if (num37 == 21)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 21");
            Console.WriteLine("");


            Console.Write("3 x 8 =  ");
            int num38 = Convert.ToInt16(Console.ReadLine());
            if (num38 == 24)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 24");
            Console.WriteLine("");


            Console.Write("3 x 9 =  ");
            int num39 = Convert.ToInt16(Console.ReadLine());
            if (num39 == 27)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 18");
            Console.WriteLine("");


            Console.Write("3 x 10 =  ");
            int num310 = Convert.ToInt16(Console.ReadLine());
            if (num310 == 30)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");

            }
            else Console.WriteLine("Errado! A resposta correta é 30");
                        Console.WriteLine("");

                        break;

        case 4:
            Console.WriteLine("4 x 1 = 4");
            Console.WriteLine("4 x 2 = 8");
            Console.WriteLine("4 x 3 = 12");
            Console.WriteLine("4 x 4 = 16");
            Console.WriteLine("4 x 5 = 20");
            Console.WriteLine("4 x 6 = 24");
            Console.WriteLine("4 x 7 = 28");
            Console.WriteLine("4 x 8 = 32");
            Console.WriteLine("4 x 9 = 36");
            Console.WriteLine("4 x 10 = 40");

            Console.WriteLine("Preparado para o exercício?!");
            Console.Write("Vamos lá: 4 x 1 =  ");
            int num41 = Convert.ToInt16(Console.ReadLine());
            if (num41 == 4)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");

            }
            else Console.WriteLine("Errado! A resposta correta é 4");
            Console.WriteLine("");


            Console.Write("4 x 2 =  ");
            int num42 = Convert.ToInt16(Console.ReadLine());
            if (num42 == 8)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 8");
            Console.WriteLine("");


            Console.Write("4 x 3 =  ");
            int num43 = Convert.ToInt16(Console.ReadLine());
            if (num43 == 12)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 12");
            Console.WriteLine("");


            Console.Write("4 x 4 =  ");
            int num44 = Convert.ToInt16(Console.ReadLine());
            if (num44 == 16)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 16");
            Console.WriteLine("");


            Console.Write("4 x 5 =  ");
            int num45 = Convert.ToInt16(Console.ReadLine());
            if (num45 == 20)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 20");
            Console.WriteLine("");


            Console.Write("4 x 6 =  ");
            int num46 = Convert.ToInt16(Console.ReadLine());
            if (num46 == 24)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 24");
            Console.WriteLine("");


            Console.Write("4 x 7 =  ");
            int num47 = Convert.ToInt16(Console.ReadLine());
            if (num47 == 28)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 28");
            Console.WriteLine("");


            Console.Write("4 x 8 =  ");
            int num48 = Convert.ToInt16(Console.ReadLine());
            if (num48 == 32)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 32");
            Console.WriteLine("");


            Console.Write("4 x 9 =  ");
            int num49 = Convert.ToInt16(Console.ReadLine());
            if (num49 == 36)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 36");
            Console.WriteLine("");


            Console.Write("4 x 10 =  ");
            int num410 = Convert.ToInt16(Console.ReadLine());
            if (num410 == 40)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");

            }
            else Console.WriteLine("Errado! A resposta correta é 40");
            Console.WriteLine("");

            break;

        case 5:
            Console.WriteLine("5 x 1 = 5");
            Console.WriteLine("5 x 2 = 10");
            Console.WriteLine("5 x 3 = 15");
            Console.WriteLine("5 x 4 = 20");
            Console.WriteLine("5 x 5 = 25");
            Console.WriteLine("5 x 6 = 30");
            Console.WriteLine("5 x 7 = 35");
            Console.WriteLine("5 x 8 = 40");
            Console.WriteLine("5 x 9 = 45");
            Console.WriteLine("5 x 10 = 50");

            Console.WriteLine("Preparado para o exercício?!");
            Console.Write("Vamos lá: 5 x 1 =  ");
            int num51 = Convert.ToInt16(Console.ReadLine());
            if (num51 == 5)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");

            }
            else Console.WriteLine("Errado! A resposta correta é 5");
            Console.WriteLine("");


            Console.Write("5 x 2 =  ");
            int num52 = Convert.ToInt16(Console.ReadLine());
            if (num52 == 10)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 10");
            Console.WriteLine("");


            Console.Write("5 x 3 =  ");
            int num53 = Convert.ToInt16(Console.ReadLine());
            if (num53 == 15)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 15");
            Console.WriteLine("");


            Console.Write("5 x 4 =  ");
            int num54 = Convert.ToInt16(Console.ReadLine());
            if (num54 == 20)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 20");
            Console.WriteLine("");


            Console.Write("5 x 5 =  ");
            int num55 = Convert.ToInt16(Console.ReadLine());
            if (num55 == 25)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 25");
            Console.WriteLine("");


            Console.Write("5 x 6 =  ");
            int num56 = Convert.ToInt16(Console.ReadLine());
            if (num56 == 30)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 30");
            Console.WriteLine("");


            Console.Write("5 x 7 =  ");
            int num57 = Convert.ToInt16(Console.ReadLine());
            if (num57 == 35)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine("");
            }
            else Console.WriteLine("Errado! A resposta correta é 35");
            Console.WriteLine("");


            Console.Write("5 x 8 =  ");
            int num58 = Convert.ToInt16(Console.ReadLine());
            if (num58 == 40)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 40");
            Console.WriteLine("");


            Console.Write("5 x 9 =  ");
            int num59 = Convert.ToInt32(Console.ReadLine());
            if (num59 == 45)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 45");
            Console.WriteLine("");


            Console.Write("5 x 10 =  ");
            int num510 = Convert.ToInt16(Console.ReadLine());
            if (num510 == 50)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");

            }
            else Console.WriteLine("Errado! A resposta correta é 50");

            break;

        case 6:
            Console.WriteLine("6 x 1 = 6");
            Console.WriteLine("6 x 2 = 12");
            Console.WriteLine("6 x 3 = 18");
            Console.WriteLine("6 x 4 = 24");
            Console.WriteLine("6 x 5 = 30");
            Console.WriteLine("6 x 6 = 36");
            Console.WriteLine("6 x 7 = 42");
            Console.WriteLine("6 x 8 = 48");
            Console.WriteLine("6 x 9 = 54");
            Console.WriteLine("6 x 10 = 60");


            Console.WriteLine("Preparado para o exercício?!");
            Console.Write("Vamos lá: 6 x 1 =  ");
            int num61 = Convert.ToInt16(Console.ReadLine());
            if (num61 == 6)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");

            }
            else Console.WriteLine("Errado! A resposta correta é 6");
            Console.WriteLine(" ");


            Console.Write("6 x 2 =  ");
            int num62 = Convert.ToInt16(Console.ReadLine());
            if (num62 == 12)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 12");
            Console.WriteLine(" ");


            Console.Write("6 x 3 =  ");
            int num63 = Convert.ToInt16(Console.ReadLine());
            if (num63 == 18)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 18");
            Console.WriteLine(" ");


            Console.Write("6 x 4 =  ");
            int num64 = Convert.ToInt16(Console.ReadLine());
            if (num64 == 24)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 24");
            Console.WriteLine(" ");


            Console.Write("6 x 5 =  ");
            int num65 = Convert.ToInt16(Console.ReadLine());
            if (num65 == 30)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 30");
            Console.WriteLine(" ");


            Console.Write("6 x 6 =  ");
            int num66 = Convert.ToInt16(Console.ReadLine());
            if (num66 == 36)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 36");
            Console.WriteLine(" ");


            Console.Write("6 x 7 =  ");
            int num67 = Convert.ToInt16(Console.ReadLine());
            if (num67 == 42)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 42");
            Console.WriteLine(" ");


            Console.Write("6 x 8 =  ");
            int num68 = Convert.ToInt16(Console.ReadLine());
            if (num68 == 48)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 48");
            Console.WriteLine(" ");


            Console.Write("6 x 9 =  ");
            int num69 = Convert.ToInt16(Console.ReadLine());
            if (num69 == 54)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 54");
            Console.WriteLine(" ");


            Console.Write("6 x 10 =  ");
            int num610 = Convert.ToInt16(Console.ReadLine());
            if (num610 == 60)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");

            }
            else Console.WriteLine("Errado! A resposta correta é 60");
                        break;

        case 7:
            Console.WriteLine("7 x 1 = 7");
            Console.WriteLine("7 x 2 = 14");
            Console.WriteLine("7 x 3 = 21");
            Console.WriteLine("7 x 4 = 28");
            Console.WriteLine("7 x 5 = 35");
            Console.WriteLine("7 x 6 = 42");
            Console.WriteLine("7 x 7 = 49");
            Console.WriteLine("7 x 8 = 56");
            Console.WriteLine("7 x 9 = 63");
            Console.WriteLine("7 x 10 = 70");

            Console.WriteLine("Preparado para o exercício?!");
            Console.Write("Vamos lá: 7 x 1 =  ");
            int num71 = Convert.ToInt16(Console.ReadLine());
            if (num71 == 7)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");

            }
            else Console.WriteLine("Errado! A resposta correta é 7");
            Console.WriteLine(" ");


            Console.Write("7 x 2 =  ");
            int num72 = Convert.ToInt16(Console.ReadLine());
            if (num72 == 14)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 14");
            Console.WriteLine(" ");


            Console.Write("7 x 3 =  ");
            int num73 = Convert.ToInt16(Console.ReadLine());
            if (num73 == 21)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 21");
            Console.WriteLine(" ");


            Console.Write("7 x 4 =  ");
            int num74 = Convert.ToInt16(Console.ReadLine());
            if (num74 == 28)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 28");
            Console.WriteLine(" ");

            Console.Write("7 x 5 =  ");
            int num75 = Convert.ToInt16(Console.ReadLine());
            if (num75 == 35)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 35");

            Console.WriteLine(" ");

            Console.Write("7 x 6 =  ");
            int num76 = Convert.ToInt16(Console.ReadLine());
            if (num76 == 42)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 42");

            Console.WriteLine(" ");


            Console.Write("7 x 7 =  ");
            int num77 = Convert.ToInt16(Console.ReadLine());
            if (num77 == 49)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 49");

            Console.WriteLine(" ");

            Console.Write("7 x 8 =  ");
            int num78 = Convert.ToInt16(Console.ReadLine());
            if (num78 == 56)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 56");

            Console.WriteLine(" ");


            Console.Write("7 x 9 =  ");
            int num79 = Convert.ToInt16(Console.ReadLine());
            if (num79 == 63)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 63");

            Console.WriteLine(" ");


            Console.Write("7 x 10 =  ");
            int num710 = Convert.ToInt16(Console.ReadLine());
            if (num710 == 70)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");

            }
            else Console.WriteLine("Errado! A resposta correta é 70");
                        break;

        case 8:
            Console.WriteLine("8 x 1 = 8");
            Console.WriteLine("8 x 2 = 16");
            Console.WriteLine("8 x 3 = 24");
            Console.WriteLine("8 x 4 = 32");
            Console.WriteLine("8 x 5 = 40");
            Console.WriteLine("8 x 6 = 48");
            Console.WriteLine("8 x 7 = 56");
            Console.WriteLine("8 x 8 = 64");
            Console.WriteLine("8 x 9 = 72");
            Console.WriteLine("8 x 10 = 80");

            Console.WriteLine("Preparado para o exercício?!");
            Console.Write("Vamos lá: 8 x 1 =  ");
            int num81 = Convert.ToInt16(Console.ReadLine());
            if (num81 == 8)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");

            }
            else Console.WriteLine("Errado! A resposta correta é 8");

            Console.WriteLine(" ");


            Console.Write("8 x 2 =  ");
            int num82 = Convert.ToInt16(Console.ReadLine());
            if (num82 == 16)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 16");

            Console.WriteLine(" ");


            Console.Write("8 x 3 =  ");
            int num83 = Convert.ToInt16(Console.ReadLine());
            if (num83 == 24)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 24");

            Console.WriteLine(" ");


            Console.Write("8 x 4 =  ");
            int num84 = Convert.ToInt16(Console.ReadLine());
            if (num84 == 32)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 32");

            Console.WriteLine(" ");

            Console.Write("8 x 5 =  ");
            int num85 = Convert.ToInt16(Console.ReadLine());
            if (num85 == 40)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 40");

            Console.WriteLine(" ");

            Console.Write("8 x 6 =  ");
            int num86 = Convert.ToInt16(Console.ReadLine());
            if (num86 == 48)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 48");

            Console.WriteLine(" ");

            Console.Write("8 x 7 =  ");
            int num87 = Convert.ToInt16(Console.ReadLine());
            if (num87 == 56)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 56");

            Console.WriteLine(" ");

            Console.Write("8 x 8 =  ");
            int num88 = Convert.ToInt16(Console.ReadLine());
            if (num88 == 64)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 64");

            Console.WriteLine(" ");

            Console.Write("8 x 9 =  ");
            int num89 = Convert.ToInt16(Console.ReadLine());
            if (num89 == 72)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 72");

            Console.WriteLine(" ");

            Console.Write("8 x 10 =  ");
            int num810 = Convert.ToInt16(Console.ReadLine());
            if (num810 == 80)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");

            }
            else Console.WriteLine("Errado! A resposta correta é 80");
                        break;

        case 9:
            Console.WriteLine("9 x 1 = 9");
            Console.WriteLine("9 x 2 = 18");
            Console.WriteLine("9 x 3 = 27");
            Console.WriteLine("9 x 4 = 36");
            Console.WriteLine("9 x 5 = 45");
            Console.WriteLine("9 x 6 = 54");
            Console.WriteLine("9 x 7 = 63");
            Console.WriteLine("9 x 8 = 72");
            Console.WriteLine("9 x 9 = 81");
            Console.WriteLine("9 x 10 = 90");

            Console.WriteLine("Preparado para o exercício?!");
            Console.Write("Vamos lá: 9 x 1 =  ");
            int num91 = Convert.ToInt16(Console.ReadLine());
            if (num91 == 9)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");

            }
            else Console.WriteLine("Errado! A resposta correta é 9");

            Console.WriteLine(" ");


            Console.Write("9 x 2 =  ");
            int num92 = Convert.ToInt16(Console.ReadLine());
            if (num92 == 18)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 18");

            Console.WriteLine(" ");


            Console.Write("9 x 3 =  ");
            int num93 = Convert.ToInt16(Console.ReadLine());
            if (num93 == 27)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 27");

            Console.WriteLine(" ");

            Console.Write("9 x 4 =  ");
            int num94 = Convert.ToInt16(Console.ReadLine());
            if (num94 == 36)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 36");

            Console.WriteLine(" ");

            Console.Write("9 x 5 =  ");
            int num95 = Convert.ToInt16(Console.ReadLine());
            if (num95 == 45)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 45");

            Console.WriteLine(" ");

            Console.Write("9 x 6 =  ");
            int num96 = Convert.ToInt32(Console.ReadLine());
            if (num96 == 54)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 54");

            Console.WriteLine(" ");

            Console.Write("9 x 7 =  ");
            int num97 = Convert.ToInt16(Console.ReadLine());
            if (num97 == 63)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 63");

            Console.WriteLine(" ");

            Console.Write("9 x 8 =  ");
            int num98 = Convert.ToInt16(Console.ReadLine());
            if (num98 == 72)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 72");

            Console.WriteLine(" ");

            Console.Write("9 x 9 =  ");
            int num99 = Convert.ToInt16(Console.ReadLine());
            if (num99 == 81)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 81");

            Console.WriteLine(" ");

            Console.WriteLine("9 x 10 =  ");
            int num910 = Convert.ToInt32(Console.ReadLine());
            if (num910 == 90)
            {
                Console.WriteLine("Parabéns");

            }
            else Console.WriteLine("Errado! A resposta correta é 90");
                        break;

        case 10:
            Console.WriteLine("10 x 1 = 10");
            Console.WriteLine("10 x 2 = 20");
            Console.WriteLine("10 x 3 = 30");
            Console.WriteLine("10 x 4 = 40");
            Console.WriteLine("10 x 5 = 50");
            Console.WriteLine("10 x 6 = 60");
            Console.WriteLine("10 x 7 = 70");
            Console.WriteLine("10 x 8 = 80");
            Console.WriteLine("10 x 9 = 90");
            Console.WriteLine("10 x 10 = 100");

            Console.WriteLine("Preparado para o exercício?!");

            Console.Write("Vamos lá: 10 x 1 =  ");
            int num101 = Convert.ToInt16(Console.ReadLine());
            if (num101 == 10)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");

            }
            else Console.WriteLine("Errado! A resposta correta é 10");
            Console.WriteLine(" ");


            Console.Write("10 x 2 =  ");
            int num102 = Convert.ToInt16(Console.ReadLine());
            if (num102 == 20)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 20");
            Console.WriteLine(" ");


            Console.Write("10 x 3 =  ");
            int num103 = Convert.ToInt16(Console.ReadLine());
            if (num103 == 27)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 30");
            Console.WriteLine(" ");


            Console.Write("10 x 4 =  ");
            int num104 = Convert.ToInt16(Console.ReadLine());
            if (num104 == 40)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 40");
            Console.WriteLine(" ");


            Console.Write("10 x 5 =  ");
            int num105 = Convert.ToInt16(Console.ReadLine());
            if (num105 == 50)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 50");
            Console.WriteLine(" ");


            Console.Write("10 x 6 =  ");
            int num106 = Convert.ToInt16(Console.ReadLine());
            if (num106 == 60)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 60");
            Console.WriteLine(" ");


            Console.Write("10 x 7 =  ");
            int num107 = Convert.ToInt16(Console.ReadLine());
            if (num107 == 70)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 70");
            Console.WriteLine(" ");


            Console.Write("10 x 8 =  ");
            int num108 = Convert.ToInt16(Console.ReadLine());
            if (num108 == 80)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 80");
            Console.WriteLine(" ");


            Console.Write("10 x 9 =  ");
            int num109 = Convert.ToInt16(Console.ReadLine());
            if (num109 == 90)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");
            }
            else Console.WriteLine("Errado! A resposta correta é 90");
            Console.WriteLine(" ");


            Console.Write("10 x 10 =  ");
            byte num1010 = Convert.ToByte(Console.ReadLine());
            if (num1010 == 100)
            {
                Console.WriteLine("Parabéns");
                Console.WriteLine(" ");

            }
            else Console.WriteLine("Errado! A resposta correta é 100");
                        break;

        default:
            Console.WriteLine("Esta opção não existe!");
            break;


    }

}


    Console.WriteLine("Gostaria de continuar?");
    Console.WriteLine("1 = SIM | 2 = NÃO");

    int continuar = Convert.ToInt32(Console.ReadLine());

    switch (continuar) {

        case 1:
            Console.WriteLine("Ok, vamos continuar");
            break;

        case 2 :
            sair = true;
            Console.WriteLine("Tchau, Tchau!");
            break ;

        default:
            Console.WriteLine("Esta opção não existe!");
                    sair = true ;
            break;
    }

        }
    }
}
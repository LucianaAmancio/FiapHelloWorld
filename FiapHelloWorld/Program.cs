using System;


namespace FiapHelloWorld
{

    //Capítulo 01 - Introdução à plataforma .NET

    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Fiap - Ola C#");
    //        // trecho para manter a janela aberta
    //        Console.Read();

    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Models.HelloModel model = new Models.HelloModel();
    //        Console.WriteLine(model.Mensagem);
    //        Console.Read();
    //    }
    //}


    //Capítulo 2 - C# - Tipos de variáveis
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int valorInt = 100;
    //        // convertendo inteiro para long
    //        long valorLong = valorInt;
    //        // convertendo long para double
    //        double valorDouble = valorLong;
    //        // Imprimindo conteúdo das variável
    //        Console.WriteLine("Valor Inteiro:" + valorInt);
    //        Console.WriteLine("Valor Long:" + valorLong);
    //        Console.WriteLine("Valor Double:" + valorDouble);
    //        // Para a execução até o usuário teclar Enter.
    //        Console.Read();
    //    }
    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int valorInt = 100;
    //        long valorLong = valorInt;
    //        double valorDouble = valorLong;
    //        // declaração de conversação (Parse)
    //        valorInt = (int)valorLong;
    //        Console.WriteLine(valorInt);
    //        Console.WriteLine(valorLong);
    //        Console.WriteLine(valorDouble);
    //        Console.Read();
    //    }
    //}


    //Capítulo 2 - C# -  Operadores
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Operadores para Cálculos 
    //        int soma = 10 + 15 + 3;
    //        int subtracao = soma - 10;
    //        int multiplicacao = soma * subtracao;
    //        double divisao = multiplicacao / subtracao;
    //        Console.WriteLine(soma);
    //        Console.WriteLine(subtracao);
    //        Console.WriteLine(multiplicacao);
    //        Console.WriteLine(divisao);
    //        Console.Read();
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Atribuição 
    //        int soma = 10;
    //        soma += 1; // Valor final 11
    //        int subtracao = soma;
    //        subtracao -= 10; // Valor final 1
    //        int multiplicacao = soma * subtracao;
    //        multiplicacao *= 3; // Valor final 33
    //        double divisao = multiplicacao;
    //        divisao /= soma; // Valor final 3

    //        Console.WriteLine(soma);
    //        Console.WriteLine(subtracao);
    //        Console.WriteLine(multiplicacao);
    //        Console.WriteLine(divisao);
    //        Console.Read();
    //    }
    //}

    //Capítulo 2 - C# - Controle de fluxo
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int idade = 17;
    //        if (idade >= 18)
    //        {
    //            Console.WriteLine("É maior de idade");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Ação não permitida para menores de 18 anos");
    //      }
    //        Console.Read();
    //    }
    //}
   
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int idade = 17;
    //        if (idade >= 18 && idade < 21)
    //        {
    //            Console.WriteLine("Você pode jogar na categoria SUB20");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Você NÃO pode jogar na categoria SUB - 20");
    //      }
    //        Console.Read();
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int idade = 20;
    //        if (idade > 15 && idade < 18)
    //        {
    //            Console.WriteLine("SUB-17");
    //        }
    //        else if (idade > 17 && idade < 21)
    //        {
    //            Console.WriteLine("SUB-20");
    //        }
    //        else if (idade > 21 && idade < 24)
    //        {
    //            Console.WriteLine("SUB-23");
    //        }
    //        Console.Read();
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int idade = 16;
    //        switch (idade)
    //        {
    //            case 15:
    //                Console.WriteLine("SUB-15");
    //                break;
    //            case 16:
    //                Console.WriteLine("SUB-17");
    //                break;
    //            case 17:
    //                Console.WriteLine("SUB-17");
    //                break;
    //            case 18:
    //                Console.WriteLine("SUB-20");
    //                break;
    //            default:
    //                Console.WriteLine("Categoria não definida");
    //                break;
    //        }
    //        Console.Read();
    //    }
    //}

    //Capítulo 2 - C# - Estruturas de repetições - for
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Contando de 0 a 100
    //        for (int i = 0; i < 101; i += 1)
    //        {
    //            Console.WriteLine(i);
    //        }
    //        Console.Read();
    //    }
    //}

    //Capítulo 2 - C# - Estruturas de repetições - while
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Contando de 0 a 100
    //        int i = 0;
    //        while (i < 101)
    //        {
    //            Console.WriteLine(i);
    //            i += 1;
    //        }
    //        Console.Read();
    //    }
    //}

    //Capítulo 2 - C# - Estruturas de repetições - do... while
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Contando de 0 a 100
    //        int i = 0;
    //        do
    //        {
    //            Console.WriteLine(i);
    //            i += 1;
    //        } while (i < 101);
    //        Console.Read();
    //    }
    //}

    //Capítulo 2 - C# - Estruturas de repetições -

    class Program
    {
        static void Main(string[] args)
        {
            string[] lista = { "Fiap", "Fiap On", "Fiap School" };
            foreach (string nome in lista)
            {
                Console.WriteLine(nome);
            }
            Console.Read();
        }

    }


}

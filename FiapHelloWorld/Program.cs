using System;
using System.Collections.Generic;

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

    //Capítulo 2 - C# - Estruturas de repetições - foreach

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] lista = { "Fiap", "Fiap On", "Fiap School" };
    //        foreach (string nome in lista)
    //        {
    //            Console.WriteLine(nome);
    //        }
    //        Console.Read();
    //    }

    //}


    //Capítulo 2 - C# - Orientação a objeto
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Construtor padrão
    //        Curso cursoXamarin = new Curso();
    //        cursoXamarin.CriarCurso("Xamarin", "Flavio Moreni");
    //        // Definindo nome do curso e instrutor
    //        Curso cursoIonic = new Curso("Ionic", "Antonio Coutinho");
    //        // Definindo nome do curso e capacidade mínima e máxima
    //        Curso cursoNode = new Curso("Node.js", 5, 40);
    //    }
    //}

    //Capítulo 2 - C# - Orientação a objeto - Herança, validando métodos
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ClasseBase a = new ClasseBase();
    //        a.Metodo();
    //        Derivada b = new Derivada();
    //        b.Metodo();
    //        ClasseBase c = new Derivada();
    //        c.Metodo();
    //        Console.Read();
    //    }
    //}

    //Capítulo 2 - C# - Orientação a objeto - Herança, virtual e override
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ClasseBase a = new ClasseBase();
    //        a.Metodo();
    //        Derivada b = new Derivada();
    //        b.Metodo();
    //        ClasseBase c = new Derivada();
    //        c.Metodo();
    //        Console.Read();
    //    }
    //}

    //Capítulo 2 - C# - Orientação a objeto – Uso de classe e método abstract
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Derivada b = new Derivada();
    //        b.Metodo();
    //        ClasseBase c = new Derivada();
    //        c.Metodo();
    //        c.MetodoAbstrato();
    //        Console.Read();
    //    }
    //}


    //Capítulo 2 - C# - Orientação a objeto – Tratamento de exception
    //public class Program 
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            string nome = null;
    //            Console.WriteLine(nome.Substring(2));
    //            new Curso().CriarAluno(nome);
    //        }
    //        // Capturando uma exceção de referência nula.
    //        // Similar ao NullPointerExceptio do Java
    //        catch (NullReferenceException)
    //        {
    //            Console.WriteLine("Nome do aluno incorreto");
    //        }
    //        catch (Exception)
    //        {
    //            Console.WriteLine("Problema na execução a operação");

    //            throw new Exception("Problema na execução a operação");
    //        }
    //    }
    //}


    //Capítulo 2 - C# - Orientação a objeto – Tratando a exceção personalizada
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            string nome = null;
    //            new Curso().CriarAluno(nome);
    //            Console.WriteLine(nome.Substring(2));
    //        }
    //        catch (PersonalizadaException p)
    //        {
    //            Console.WriteLine(p.Message);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Problema na execução a  operação");
    //            throw new Exception("Problema na execução a operação");
    //        }
    //    }
    //}


    //Capítulo 2 - C# - Orientação a objeto – Criando arrays
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Exemplo 1
    //        string[] nomes1 = { "João", "Maria", "José" };
    //        // Exemplo 2
    //        string[] nomes2 = new string[3];
    //        nomes1[0] = "João";
    //        nomes2[1] = "Maria";
    //        nomes2[3] = "José";
    //    }
    //}

    //Capítulo 2 - C# - Orientação a objeto – Acessando conteúdo do array
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Criando um array de curuso
    //        Curso[] listaCursos = new Curso[3];
    //        // Criando os items do array
    //        listaCursos[0] = new Curso(1, "Curso 1");
    //        listaCursos[1] = new Curso(2, "Curso 2");
    //        listaCursos[2] = new Curso(3, "Curso 3");
    //        // Navegando pelo array e imprimindo o conteúdo
    //        foreach (Curso curso in listaCursos)
    //        {
    //            Console.WriteLine(curso.NomeCurso);
    //        }
    //        Console.Read();
    //    }
    //}

    //Capítulo 2 - C# - Orientação a objeto – Criando uma lista de Cursos
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Criando uma lista de Cursos
    //        // Exemplo 1
    //        string[] nomes1 = { "João", "Maria", "José" };
    //        // Exemplo 2
    //        string[] nomes2 = new string[3];
    //        nomes1[0] = "João";
    //        nomes2[1] = "Maria";
    //        nomes2[3] = "José";

    //        //Importando o namespace Generic
    //        List<Curso> lista = new List<Curso>();

    //        //Adicionando elementos na lista
    //        // Criando a lista dos objetos curso
    //        List<Curso> lista = new List<Curso>();
    //        // Adicionando cursos na lista 
    //        lista.Add(new Curso(1, "Curso 1"));
    //        lista.Add(new Curso(2, "Curso 2"));
    //        lista.Add(new Curso(4, "Curso 4"));
    //        // Inserindo um curso em uma posição específica.
    //        lista.Insert(2, new Curso(3, "Curso 3"));
    //        foreach (var curso in lista)
    //        {
    //            Console.WriteLine(curso.NomeCurso);
    //        }
    //        Console.Read();

    //        //Removendo elementos da lista
    //        List<Curso> lista = new List<Curso>();
    //        Curso c1 = new Curso(1, "Curso 1");
    //        lista.Add(c1);
    //        lista.Add(new Curso(2, "Curso 2"));
    //        lista.Add(new Curso(4, "Curso 4"));
    //        lista.Insert(2, new Curso(3, "Curso 3"));
    //        // Removendo um objeto de uma determinada posição
    //        lista.RemoveAt(3);
    //        // Removendo o objeto pela referência de c1
    //        lista.Remove(c1);
    //        foreach (var curso in lista)
    //        {
    //            Console.WriteLine(curso.NomeCurso);
    //        }
    //        Console.Read();

    //        //Conjuntos
    //        // Criando uma lista ordenada
    //        SortedSet<string> alunos = new SortedSet<string>();
    //        // Adicionando elementos na lista
    //        alunos.Add("Alberto");
    //        alunos.Add("Giovanna");
    //        alunos.Add("Fabio");
    //        alunos.Add("Victor");
    //        alunos.Add("Carlos");
    //        Console.Write("Encontrou o aluno Carlos: ");
    //        // Procurando na lista um determinado elemento
    //        Console.WriteLine(alunos.Contains("Carlos"));
    //        Console.WriteLine("");
    //        foreach (string aluno in alunos)
    //        {
    //            Console.WriteLine(aluno);
    //        }
    //        Console.Read();
    //    }
    //}

    //Capítulo 2 - C# - Orientação a objeto – Coleção do tipo Dictionary
    public class Program
    {
        static void Main(string[] args)
        {
            Curso c1 = new Curso(1, "Curso 1");
            Curso c2 = new Curso(2, "Curso 2");
            Curso c3 = new Curso(3, "Curso 3");
            // Criando um lista de objeto na estrutura chave + 
            valor
        Dictionary<string, Curso> dicionario = new
        Dictionary<String, Curso>();
            dicionario.Add(c1.NomeCurso, c1);
            dicionario.Add(c2.NomeCurso, c2);
            dicionario.Add(c3.NomeCurso, c3);
            // procurando um determinado elemento
            Console.Write("Encontrou o Curso 2: ");
            Console.WriteLine(dicionario["Curso 4s"] == null ?
            false : true);
            Console.WriteLine("");
            // Navegando pela coleção e imprimindo os objetos.
            foreach (KeyValuePair<string, Curso> itemCurso in
            dicionario)
            {
                string chave = itemCurso.Key;
                Curso c = dicionario[chave];
                Console.WriteLine(c.NomeCurso);
            }
            Console.Read();
        }
    }







}

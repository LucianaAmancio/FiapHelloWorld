using System;


namespace FiapHelloWorld
{
    
    //Primeira classe criada no curso
    //class Program
    //{
       
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Fiap - Ola C#");
    //        // trecho para manter a janela aberta
    //        Console.Read();
                  
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Models.HelloModel model = new Models.HelloModel();
            Console.WriteLine(model.Mensagem);
            Console.Read();
        }
    }

}
 
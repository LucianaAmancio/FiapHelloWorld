using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapHelloWorld
{
    //Capítulo 2 - C# - Orientação a objeto – Herança
    public class CursoFerias : Curso
    {
    }

    ////Capítulo 2 - C# - Orientação a objeto – 
    //public class ClasseBase
    //{
    //    public void Metodo()
    //    {
    //        Console.WriteLine("Método ClasseBase");
    //    }
    //}
    //public class Derivada : ClasseBase
    //{
    //    public void Metodo()
    //    {
    //        Console.WriteLine("Método Derivada");
    //    }
    //}

    //public class ClasseBase
    //{
    //    public virtual void Metodo()
    //    {
    //        Console.WriteLine("Método ClasseBase");
    //    }
    //}
    //public class Derivada : ClasseBase
    //{
    //    public override void Metodo()
    //    {
    //        Console.WriteLine("Método Derivada");
    //    }

    //}

    //Capítulo 2 - C# - Orientação a objeto – Uso de classe e método abstract
    public abstract class ClasseBase
    {
        public virtual void Metodo()
        {
            Console.WriteLine("Método ClasseBase");
        }
        public abstract void MetodoAbstrato();
    }
    public class Derivada : ClasseBase
    {
        public override void Metodo()
        {
            Console.WriteLine("Método Derivada");
        }
        public override void MetodoAbstrato()
        {
            Console.WriteLine("Método MetodoAbstrato");
        }
    }





}

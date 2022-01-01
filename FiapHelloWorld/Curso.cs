using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapHelloWorld
{

    //Capítulo 2 - C# - Orientação a objeto
    //public class Curso
    //{
    //    int Codigo;
    //    string NomeCurso;
    //    string NomeInstrutor;
    //    int cargaHorario;
    //    int minimoAlunos;
    //    int maximoAlunos;

    //    public void CriarCurso(string nome, string instrutor)
    //    {
    //        this.NomeCurso = nome;
    //        this.NomeInstrutor = instrutor;
    //    }

    //    public bool MatricularAluno(string nomeAluno)
    //    {
    //        // Verificar a quantidade de alunos
    //        return true;
    //    }
    //    public int ConsultarMaximoAlunos()
    //    {
    //        // Retorno o valor do atributo
    //        return this.maximoAlunos;
    //    }
    //}

    //Capítulo 2 - C# - Orientação a objeto – Modificadores de acesso
    //public class Curso
    //{
    //    #region atributos
    //    int Codigo;
    //    internal string NomeCurso;
    //    public string NomeInstrutor;
    //    private int CargaHorario;
    //    protected int MinimoAlunos;
    //    protected internal int MaximoAlunos;
    //    #endregion
    //    public Curso()
    //    {
    //        // Construtor padrão.
    //    }
    //    protected internal Curso(string nome, string  instrutor)
    //    {
    //        this.NomeCurso = nome;
    //        this.NomeInstrutor = instrutor;
    //    }
    //    private Curso(string nome, int minimo, int maximo)
    //    {
    //        this.NomeCurso = nome;
    //        this.MaximoAlunos = maximo;
    //        this.MinimoAlunos = minimo;
    //    }
    //    public void CriarCurso(string nome, string instrutor)
    //    {
    //        this.NomeCurso = nome;
    //        this.NomeInstrutor = instrutor;
    //    }
    //    private bool MatricularAluno(string nomeAluno)
    //    {
    //        // Verificar a quantidade de alunos
    //        return true;
    //    }
    //    private int ConsultarMaximoAlunos()
    //    {
    //        // Retorno o valor do atributo
    //        return this.MaximoAlunos;
    //    }

    //Capítulo 2 - C# - Orientação a objeto – Criando e usando interfaces
    //public class Curso : IAluno, IInstrutor
    //{
    //    public void CriarAluno()
    //    {
    //        Console.WriteLine("Criando Aluno");
    //    }
    //    public void CriarInstrutor()
    //    {
    //        Console.WriteLine("Criando Instrutor");
    //    }
    //}


    //Capítulo 2 - C# - Orientação a objeto – Lançamento de exception
    //public void CriarAluno(string nome)
    //{
    //    if (nome == null)
    //    {
    //        // Lançando uma exceção
    //        throw new Exception("Nome do aluno inválido");
    //    }
    //}

    //Capítulo 2 - C# - Orientação a objeto – Personalizando exceptions
    //public class PersonalizadaException : Exception
    //{
    //    public PersonalizadaException() : base() { }
    //    public PersonalizadaException(string message) :
    //    base(message)
    //    { }
    //    public PersonalizadaException(string message,
    //    System.Exception inner) : base(message, inner) { }
    //    protected PersonalizadaException(
    //    System.Runtime.Serialization.SerializationInfo
    //    info,
    //    System.Runtime.Serialization.StreamingContext
    //    context)
    //    { }
    //}

    //public void CriarAluno(string nome)
    //{
    //    if (nome == null)
    //    {
    //        throw new PersonalizadaException("Nome do aluno inválido");
    //    }
    //}


    //Capítulo 2 - C# - Orientação a objeto – Acessando conteúdo do array
    //public class Curso
    //{
    //    public int Codigo;
    //    public string NomeCurso;
    //    public Curso(int cod, string nome)
    //    {
    //        this.Codigo = cod;
    //        this.NomeCurso = nome;
    //    }
    //}

    //Capítulo 2 - C# - Orientação a objeto – Coleção do tipo Dictionary
    public class Curso
    {
        public int Codigo;
        public string NomeCurso;
        public Curso(int cod, string nome)
        {
            this.Codigo = cod;
            this.NomeCurso = nome;
        }
    }
}






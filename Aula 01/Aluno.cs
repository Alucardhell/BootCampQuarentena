using System;
namespace Aula_1
{
    public class Aluno
    {
        public string nome {get; set;}

        public int matricula {get; set;}

        public string cpf  {get; set;}

        public int periodo {get; set;}

        public Aluno(string nome, int matricula, string cpf, int periodo){
            this.nome = nome;
            this.matricula = matricula;
            this.cpf = cpf;
            this.periodo = periodo;
        }


        public void teste(){
            Console.WriteLine("Teste Class");
        }
    }
}
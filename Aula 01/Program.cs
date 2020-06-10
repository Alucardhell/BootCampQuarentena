using System;
using System.Collections.Generic;


namespace Aula_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();

            int i = Menu();
            while (i > 0 && i < 5)
            {
                Console.WriteLine("Opção escolhida " + i);

                switch (i)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Vamos Cadastrar Aluno:");
                        Console.WriteLine("Digite o Nome do Aluno: ");
                        string addNome = Console.ReadLine();
                        Console.WriteLine("Digite a Matricula: ");
                        int addMatricula = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o CPF: ");
                        string addCpf = Console.ReadLine();
                        Console.WriteLine("Digite o Periodo: ");
                        int addPeriodo = int.Parse(Console.ReadLine());
                        alunos.Add(new Aluno(addNome, addMatricula, addCpf, addPeriodo));
                        Console.WriteLine("Cadastro efetuado com sucesso!!");
                        i = noMenu();
                        if (i == 1)
                        {
                            i = Menu();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Vamos Listar Alunos");

                        foreach (Aluno a in alunos)
                        {
                            Console.WriteLine("==================================");
                            Console.WriteLine("Digite o Nome: " + a.nome);
                            Console.WriteLine("Matricula: " + a.matricula);
                            Console.WriteLine("CPF: " + a.cpf);
                            Console.WriteLine("Periodo: " + a.periodo);
                            Console.WriteLine("==================================\n");
                        }
                        i = noMenu();
                        if (i == 1)
                        {
                            i = Menu();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Vamos Excluir Aluno:");
                        Console.WriteLine("Digite a Matricula do Aluno, para EXCLUIR o Aluno: ");
                        int removeMatricula = int.Parse(Console.ReadLine());
                        alunos.RemoveAll(a => a.matricula == removeMatricula);
                        i = noMenu();
                        if (i == 1)
                        {
                            i = Menu();
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Vamos Editar Aluno:");
                        Console.Write("Digite a Matricula para Editar Aluno: ");
                        int editAluno = int.Parse(Console.ReadLine());

                        foreach (Aluno a in alunos)
                        {
                            if (a.matricula == editAluno)
                            {
                                Console.WriteLine("==================================");
                                Console.WriteLine("Digite o Nome: ");
                                string editNome = Console.ReadLine();
                                Console.WriteLine("CPF: ");
                                string editCPF = Console.ReadLine();
                                Console.WriteLine("Periodo: ");
                                int editPeriodo = int.Parse(Console.ReadLine());
                                a.nome = editNome;
                                a.cpf = editCPF;
                                a.periodo = editPeriodo;
                                Console.WriteLine("==================================\n");
                            }
                        }

                        i = noMenu();
                        if (i == 1)
                        {
                            i = Menu();
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("SAINDO DO PROGRAMA");
                        break;
                }

            }

            Console.WriteLine("FIM DE EXECUÇÃO.");
            Console.ReadKey();
        }
        private static int Menu()
        {
            bool confirm = true;
            int opcao = 0;
            while (confirm)
            {
                Console.Clear();
                Console.WriteLine(" _____________________________________________");
                Console.WriteLine("|   SISTEMA ESCOLAR DA TURMA DO PROF° KAIN.   |");
                Console.WriteLine("|                Menu:                        |");
                Console.WriteLine("|       1) Cadastrar Aluno:                   |");
                Console.WriteLine("|       2) Listar Alunos:                     |");
                Console.WriteLine("|       3) Excluir Alunos:                    |");
                Console.WriteLine("|       4) Editar Aluno:                      |");
                Console.WriteLine("|       0) Sair:                              |");
                Console.WriteLine("|_____________________________________________|");
                Console.WriteLine("|       Digite uma opção acima:               |");
                Console.WriteLine("|_____________________________________________|");
                opcao = int.Parse(Console.ReadLine());

                if (opcao >= 0 && opcao < 5)
                {
                    Console.WriteLine("CONFIRM");
                    confirm = false;
                }
                else
                {
                    Console.WriteLine("Opção Invalida !!!");
                    Console.WriteLine("Tente Novamente.");
                }
            }
            return opcao;
        }

        private static int noMenu()
        {
            int a = 99;
            while (a == 99)
            {
                Console.Clear();
                Console.WriteLine("Deseja voltar ao Menu?");
                Console.WriteLine("Digite 1 para voltar.");
                Console.WriteLine("Digite 0 para SAIR!!!");
                a = int.Parse(Console.ReadLine());
                if (a != 0 && a != 1)
                {
                    a = 99;
                }
            }
            return a;
        }
    }

}

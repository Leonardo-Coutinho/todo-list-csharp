using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_To_Do_List_em_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo ao program To Do List!");
            List<string> TaskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("O que você gostaria de fazer?");
                Console.WriteLine("Digite 1 para adicionar uma tarefa à lista.");
                Console.WriteLine("Digite 2 para remover uma tarefa da lista.");
                Console.WriteLine("Digite 3 para ver a lista.");
                Console.WriteLine("Digite e para sair do programa.");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Porfavor digite o nome da tarefa a ser adicionada a lista.");
                    string task = Console.ReadLine();
                    TaskList.Add(task);
                    Console.WriteLine("Tarefa adicionada a lista.");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < TaskList.Count; i++)
                    {
                        Console.WriteLine(i + ":" + TaskList[i]);
                    }

                    Console.WriteLine("Porfavor digite o número da tarefa a ser removida da lista.");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    TaskList.RemoveAt(taskNumber);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Tarefas atuais na lista :");
                    for (int i = 0; i < TaskList.Count; i++)
                    {
                        Console.WriteLine(TaskList[i]);
                    }
                }

                else if (option == "e")
                {
                    Console.WriteLine("Fechando Programa.");
                }
                else
                {
                    Console.WriteLine("Opção inválida, porfavor tente novamente.");
                }
                Console.WriteLine("Obrigado por usar o programa!");
            }
        }
    }
}
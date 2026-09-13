using System.Security.AccessControl;

GerenciadorDeTarefas gerenciadorDeTarefas = new GerenciadorDeTarefas();

int ValidarInteiro(string frase)
{
    
    while(true)
    {
        Console.Write(frase);

        if(int.TryParse(Console.ReadLine(), out int result) && result > 0)
        {
            return result;
        }

        Console.WriteLine("O número precisa ser maior que zero");
    }  
}

string StringValida(string frase)
{

    while(true)
    {
        Console.Write(frase);
        string caracteristica = Console.ReadLine();

        caracteristica = caracteristica.Trim();

        if(!string.IsNullOrEmpty(caracteristica))
        {
            return caracteristica;
        }

        Console.WriteLine("A string não poder ser nula ou vazia!");
    }

    
}

bool AlistaEstaVazia()
{
    return gerenciadorDeTarefas.tarefas.Count <= 0;
    
}

while(true)
{
   gerenciadorDeTarefas.ExibirMenu();

   Console.WriteLine("--------------------------------------");
   int? opcaoConvertida = ValidarInteiro("Digite a opção que deseja: ");
   
    switch(opcaoConvertida)
    {
        case 1:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║          ➕ ADD TASK                 ║");
            Console.WriteLine("╚══════════════════════════════════════╝");


            int id = ValidarInteiro("Id: ");
            string titulo = StringValida("Titulo: ");
            string descricao = StringValida("Descrição: ");

            Tarefa tarefa = new Tarefa(id, titulo, descricao);

            gerenciadorDeTarefas.AdicionarTarefa(tarefa);
            Console.WriteLine("​​✅​ Tarefa registrada com sucesso!");
            break;
        case 2:

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║          ✅ COMPLETE TASK                 ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝");

            if(AlistaEstaVazia())
            {
                Console.WriteLine("Lista de tarefas vazia!");
                break;
            }

            gerenciadorDeTarefas.ListarTarefas();

            Console.WriteLine("_______________________________________________");
            int id1 = ValidarInteiro("ID: ");
            Console.WriteLine("_______________________________________________");
            
            Console.Clear();
            gerenciadorDeTarefas.ConcluirTarefaPorId(id1);
            break;
        case 3:

            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║          ​​❌​ REMOVE TASK                   ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝");

            if(AlistaEstaVazia())
            {
                Console.WriteLine("Lista de tarefas vazia!");
                break;
            }

            gerenciadorDeTarefas.ListarTarefas();

            Console.WriteLine("_______________________________________________");
            int id2 = ValidarInteiro("ID: ");
            Console.WriteLine("_______________________________________________");

            Console.Clear();
            Console.WriteLine(gerenciadorDeTarefas.RemoverTarefaPorId(id2));
            break;
        case 4:

            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║          ​​📋 SHOW TASKS                    ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝");

            gerenciadorDeTarefas.ListarTarefas();
            Console.WriteLine("_______________________________________________");
            break;
        case 5:

            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════════════════╗");
            Console.WriteLine("║          ​​🔎 SEARCH TASKS                  ║");
            Console.WriteLine("╚═══════════════════════════════════════════╝");


            if(AlistaEstaVazia())
            {
                Console.WriteLine("Lista de tarefas vazia!");
                break;
            }

            gerenciadorDeTarefas.ListarTarefas();

            Console.WriteLine("_______________________________________________");
            int id3 = ValidarInteiro("ID: ");
            Console.WriteLine("_______________________________________________");

            Console.Clear();
            Console.WriteLine(gerenciadorDeTarefas.BuscarTarefaPorId(id3));
            break;
        case 6:
            Console.Clear();
            Console.WriteLine("ADEUS!");
            return;
        default:
            break;  
    }
}










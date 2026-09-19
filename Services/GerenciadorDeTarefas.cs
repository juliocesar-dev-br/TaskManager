public class GerenciadorDeTarefas
{
    public List<Tarefa> tarefas {get; private set;} = new();


    public Tarefa? AdicionarTarefa(Tarefa tarefa)
    {
        for(int i = 0; i < tarefas.Count; i++)
        {
            if(tarefas[i].Id == tarefa.Id)
            {
                return null;
            }
        }

        tarefas.Add(tarefa);
        return tarefa;
    }

    public void ListarTarefas()
    {

        if(tarefas.Count > 0)
        {
            for(int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine(tarefas[i]);
            }
        }
        else
        {
            Console.WriteLine("Não há tarefas na lista!");
            return;
        }
    }

    public Tarefa? BuscarTarefaPorId(int id)
    {
        for(int i = 0; i < tarefas.Count; i++)
        {
            if(tarefas[i].Id == id)
            {
                return tarefas[i];
            }
        }

        return null;
    }

    public Tarefa? ConcluirTarefaPorId(int id)
    {
        
        for(int i = 0; i < tarefas.Count; i++)
        {
            if(tarefas[i].Id == id)
            {
                Console.WriteLine(tarefas[i].ConcluirTarefa());
                return tarefas[i];
            }
        }
        

        return null;
    }


    public Tarefa? AtualizarTarefa(int id, Tarefa tarefa)
    {
        for(int i = 0; i < tarefas.Count; i++)
        {
            if(id == tarefas[i].Id)
            {
                tarefas[i].Titulo = tarefa.Titulo;
                tarefas[i].Descricao = tarefa.Descricao;
                return tarefas[i];
            }
        }


        return null;
    }
    public string RemoverTarefaPorId(int id)
    {
        for(int i = 0; i < tarefas.Count; i++)
        {
            if(tarefas[i].Id == id)
            {
                tarefas.Remove(tarefas[i]);
                return $"​​❌​ Tarefa {id} foi removida com sucesso!";
            }
        }

        return "Id inexistente!";
    }

    public void ExibirMenu()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╔══════════════════════════════════════╗");
        Console.WriteLine("║          📋 TASK MANAGER             ║");
        Console.WriteLine("╚══════════════════════════════════════╝");


        Console.WriteLine("1️⃣​ - Adicionar tarefa");
        Console.WriteLine("2️⃣ - Conclúir tarefa");
        Console.WriteLine("3️⃣​ - Remover tarefa");
        Console.WriteLine("​4️⃣​ - Listar tarefas");
        Console.WriteLine("​5️⃣​ - Buscar tarefa");
        Console.WriteLine("​6️⃣​ - Sair");
    }


}
public class GerenciadorDeTarefas
{
    public List<Tarefa> tarefas {get; private set;} = new();


    public string AdicionarTarefa(Tarefa tarefa)
    {
        for(int i = 0; i < tarefas.Count; i++)
        {
            if(tarefas[i].Id == tarefa.Id)
            {
                return "Erro! Tarefas com Ids repetidos não pode ser inserido na lista!";
            }
        }

        tarefas.Add(tarefa);
        return $"Tarefa: {tarefa.Titulo} adicionada com sucesso na lista de tarefas!";
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

    public string RemoverTarefaPorId(int id)
    {
        for(int i = 0; i < tarefas.Count; i++)
        {
            if(tarefas[i].Id == id)
            {
                tarefas.Remove(tarefas[i]);
                return $"Tarefa {id} foi removida com sucesso!";
            }
        }

        return "Id inexistente!";
    }

    public void ExibirMenu()
    {
        Console.WriteLine("1 - Adicionar tarefa");
        Console.WriteLine("2 - Conclúir tarefa");
        Console.WriteLine("3 - Remover tarefa");
        Console.WriteLine("4 - Listar tarefas");
        Console.WriteLine("5 - Buscar tarefa");
        Console.WriteLine("6 - Sair");
    }


}
public class GerenciadorDeTarefas
{
    private List<Tarefa> tarefas {get; set;} = new();


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


}
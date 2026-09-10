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
}
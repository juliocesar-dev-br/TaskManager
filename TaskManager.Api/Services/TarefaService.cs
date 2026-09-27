using Microsoft.EntityFrameworkCore;

public class TarefaService
{
    private readonly TaskManagerContext context;

    public TarefaService(TaskManagerContext context)
    {
        this.context = context;
    }

    public async Task<List<Tarefa>> ObterTarefas()
    {
        return await context.Tarefas.ToListAsync();
    }

    public async Task<Tarefa?> BuscarTarefaPorId(int id)
    {
        var resultado = await context.Tarefas.FirstOrDefaultAsync(t => t.Id == id);
        
        if(resultado == null)
        {
            return null;
        }

        return resultado;
        
    }

    public async Task<Tarefa?> AdicionarTarefa(Tarefa tarefa)
    {
        var resultado =  await context.Tarefas.AnyAsync(t => t.Id == tarefa.Id);

        if(resultado)
        {
            return null;
        }

        context.Tarefas.Add(tarefa); // Entidade sendo inserida
        await context.SaveChangesAsync(); // Enviar alteração para o banco
        return tarefa; // Retornar

    }

    public async Task<Tarefa?> AtualizarTarefa(int id, Tarefa tarefa)
    {
        var tarefaExistente = await context.Tarefas.FirstOrDefaultAsync(t => t.Id == id);

        if(tarefaExistente == null)
        {
            return null;
        }

        tarefaExistente.Titulo = tarefa.Titulo;
        tarefaExistente.Descricao = tarefa.Descricao;

        await context.SaveChangesAsync();
        return tarefaExistente;
    }

    public async Task<Tarefa?> RemoverTarefa(int id)
    {
        var tarefaExistente = await context.Tarefas.FirstOrDefaultAsync(t => t.Id == id);

        if(tarefaExistente == null)
        {
            return null;
        }

        context.Tarefas.Remove(tarefaExistente);
        await context.SaveChangesAsync();
        return tarefaExistente;
    }
}
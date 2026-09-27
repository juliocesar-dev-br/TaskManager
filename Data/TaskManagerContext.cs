using Microsoft.EntityFrameworkCore;

public class TaskManagerContext : DbContext
{
    public TaskManagerContext(DbContextOptions<TaskManagerContext> options) : base(options)
    {
        
    }

    public DbSet<Tarefa> Tarefas {get; set;}
}
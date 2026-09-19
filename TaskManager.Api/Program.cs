var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

GerenciadorDeTarefas gerenciadorDeTarefas = new GerenciadorDeTarefas();

gerenciadorDeTarefas.AdicionarTarefa(new Tarefa(1, "Estudar ASP.NET Core", "Aprender a criar APIs em C#"));

app.MapGet("/tarefas", () =>
{
    return gerenciadorDeTarefas.tarefas;
});

app.MapGet("/tarefas/{id}", (int id) =>
{
    var tarefa = gerenciadorDeTarefas.BuscarTarefaPorId(id);

    if(tarefa == null)
    {
        return Results.BadRequest();
    }

    return Results.Ok();
});

app.MapPost("/tarefas", (Tarefa tarefa) =>
{
    if(tarefa == null)
    {
        return Results.BadRequest();
    }

    for(int i = 0; i < gerenciadorDeTarefas.tarefas.Count; i++)
    {
        if(tarefa.Id == gerenciadorDeTarefas.tarefas[i].Id)
        {
            return Results.Conflict();
        }
    }

    var resultado = gerenciadorDeTarefas.AdicionarTarefa(tarefa);
    return Results.Created($"/tarefas/{resultado.Id}", resultado);

});

app.MapPut("/tarefas/{id}", (int id, Tarefa tarefa) =>
{
    var resultado = gerenciadorDeTarefas.AtualizarTarefa(id, tarefa);

    if(resultado == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(resultado);

});

app.MapDelete("/tarefas/{id}", (int id) =>
{
    var resultado = gerenciadorDeTarefas.RemoverTarefaPorId(id);

    if(resultado == "Id inexistente!")
    {
        return Results.NotFound();
    }

    return Results.NoContent();

});

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

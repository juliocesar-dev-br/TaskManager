using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("tarefas")]
public class TarefasController : ControllerBase
{
    private readonly GerenciadorDeTarefas gerenciadorDeTarefas;

    public TarefasController(GerenciadorDeTarefas gerenciadorDeTarefas)
    {
        this.gerenciadorDeTarefas = gerenciadorDeTarefas;
    }

    [HttpGet]
    public IActionResult ListarTarefas()
    {
        return Ok(gerenciadorDeTarefas.tarefas);
    }
    
    [HttpGet("{id}")]
    public IActionResult BuscarTarefa(int id)
    {
        var tarefa = gerenciadorDeTarefas.BuscarTarefaPorId(id);

        if(tarefa == null)
        {
            return NotFound();
        }

        return Ok(tarefa);
    }
   
    [HttpPost]
    public IActionResult AdicionarTarefa(Tarefa tarefa)
    {
        var resultado = gerenciadorDeTarefas.AdicionarTarefa(tarefa);

        if(resultado == null)
        {
            return Conflict();
        }

        return Created($"/tarefas/{resultado.Id}", resultado);
    }

    [HttpPut("{id}")]
    public IActionResult AtualizarTarefa(int id, Tarefa tarefa)
    {
        var resultado = gerenciadorDeTarefas.AtualizarTarefa(id, tarefa);

        if(resultado == null)
        {
            return NotFound();
        }

        return Ok(resultado);
    }

    [HttpDelete("{id}")]
    public IActionResult RemoverTarefa(int id)
    {
        var resultado = gerenciadorDeTarefas.RemoverTarefaPorId(id);

        if(resultado == "Id inexistente!")
        {
            return NotFound();
        }

        return NoContent();
    }

}
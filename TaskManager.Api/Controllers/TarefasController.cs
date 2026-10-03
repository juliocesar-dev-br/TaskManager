using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("tarefas")]
public class TarefasController : ControllerBase
{
    private readonly GerenciadorDeTarefas gerenciadorDeTarefas;
    private readonly TarefaService tarefaService;

    public TarefasController(GerenciadorDeTarefas gerenciadorDeTarefas, TarefaService tarefaService)
    {
        this.gerenciadorDeTarefas = gerenciadorDeTarefas;
        this.tarefaService = tarefaService;
    }

    [HttpGet]
    public async Task<IActionResult> ListarTarefas()
    {
        var tarefas = await tarefaService.ObterTarefas();

        return Ok(tarefas);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> BuscarTarefa(int id)
    {
        var tarefa = await tarefaService.BuscarTarefaPorId(id);

        if(tarefa == null)
        {
            return NotFound();
        }

        return Ok(tarefa);
    }
   
    [HttpPost]
    public async Task<IActionResult> AdicionarTarefa(Tarefa tarefa)
    {
        var resultado = await tarefaService.AdicionarTarefa(tarefa);

        if(resultado == null)
        {
            return Conflict();
        }

        return Created($"/tarefas/{resultado.Id}", resultado);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> AtualizarTarefa(int id, Tarefa tarefa)
    {
        var resultado = await tarefaService.AtualizarTarefa(id, tarefa);

        if(resultado == null)
        {
            return NotFound();
        }

        return Ok(resultado);
    }

    [HttpPut("{id}/Concluir")]
    public async Task<ActionResult> ConcluirTarefa(int id)
    {
        var resultado = await tarefaService.ConcluirTarefa(id);

        if(resultado == null)
        {
            return NotFound();
        }

        return Ok(resultado);
    }



    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoverTarefa(int id)
    {
        var resultado = await tarefaService.RemoverTarefa(id);

        if(resultado == null)
        {
            return NotFound();
        }

        return NoContent();
    }

}
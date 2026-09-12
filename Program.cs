
/* Seguro contra alterações no projeto(excluir quando o menu estiver pronto)
GerenciadorDeTarefas gerenciadorDeTarefas = new GerenciadorDeTarefas();
Tarefa tarefaTeste = new(1, "Alistamento no exercito", "Fazer o alistamento obrigatório no exercito pois eu acabei de completar 18 anos.");

// Teste: concluir a tarefa e tentar concluir novamente

Console.WriteLine(tarefaTeste);

Console.WriteLine(tarefaTeste.ConcluirTarefa());

Console.WriteLine(tarefaTeste);

Console.WriteLine(tarefaTeste.ConcluirTarefa());

Console.WriteLine("-----------------------------------------------------");

// Teste do método AdicionarTarefa()

Tarefa tarefaTeste1 = new(1, "Alistamento no exercito", "Fazer o alistamento obrigatório no exercito pois eu acabei de completar 18 anos.");

Console.WriteLine(gerenciadorDeTarefas.AdicionarTarefa(tarefaTeste1));

System.Console.WriteLine("-----------------------------------------------------");

// Teste do método AdicionarTarefa() <- Tentativa de adicionar um Id repetido

Console.WriteLine(gerenciadorDeTarefas.AdicionarTarefa(tarefaTeste));


System.Console.WriteLine("-----------------------------------------------------");

// Teste do método ListarTarefas() <- Tentativa de listar as tarefas

Tarefa tarefaTeste2 = new(2, "Reformar quarto", "Por conta do som externo que interfere nos meus estudos, tenho que adicionar uma espuma absorvedora de som");
Console.WriteLine(gerenciadorDeTarefas.AdicionarTarefa(tarefaTeste2));

Console.WriteLine("------LISTAGEM TAREFAS------------");

gerenciadorDeTarefas.ListarTarefas();

// Teste do método BuscarTarefaPorId() <- Tentativa de retornar a tarefa, com id inexistente e existente.

Tarefa? outputTarefa = gerenciadorDeTarefas.BuscarTarefaPorId(3);

if(outputTarefa != null)
{
    Console.WriteLine(outputTarefa);
}
else
{
    Console.WriteLine("Tarefa não encontrada!");
}


Tarefa? outputTarefa1 = gerenciadorDeTarefas.BuscarTarefaPorId(2);

if(outputTarefa1 != null)
{
    Console.WriteLine(outputTarefa1);
}
else
{
    Console.WriteLine("Tarefa não encontrada!");
}

// Teste do método ConcluirTarefaPorId() <- Tentativa de concluir uma tarefa e tentar concluir novamente

Tarefa? outputTarefa2 = gerenciadorDeTarefas.ConcluirTarefaPorId(2);

if(outputTarefa2 != null)
{
    Console.WriteLine(outputTarefa2);
}
else
{
    Console.WriteLine("Tarefa não encontrada!");
}

outputTarefa2 = gerenciadorDeTarefas.ConcluirTarefaPorId(2);

// Teste do método RemoverTarefaPorId() <- Tentativa de remover uma tarefa(casos de erro: id inexistente)

Console.WriteLine(gerenciadorDeTarefas.RemoverTarefaPorId(1));
Console.WriteLine("------LISTAGEM TAREFAS------------");
gerenciadorDeTarefas.ListarTarefas();
*/


using System.Security.AccessControl;

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

GerenciadorDeTarefas gerenciadorDeTarefas = new GerenciadorDeTarefas();

while(true)
{
    
   gerenciadorDeTarefas.ExibirMenu();

   Console.WriteLine("--------------------------------------");
   int? opcaoConvertida = ValidarInteiro("Digite a opção que deseja: ");
   
    switch(opcaoConvertida)
    {
        case 1:
            
            int id = ValidarInteiro("Id: ");
            string titulo = StringValida("Titulo: ");
            string descricao = StringValida("Descrição: ");

            Tarefa tarefa = new Tarefa(id, titulo, descricao);

            gerenciadorDeTarefas.AdicionarTarefa(tarefa);
            Console.WriteLine("Tarefa registrada com sucesso!");
            return;
        case 2:
            
        default:
            break;


            
    }

  



}










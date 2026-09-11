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








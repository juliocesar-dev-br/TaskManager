GerenciadorDeTarefas gerenciadorDeTarefas = new GerenciadorDeTarefas();
Tarefa tarefaTeste = new(1, "Alistamento no exercito", "Fazer o alistamento obrigatório no exercito pois eu acabei de completar 18 anos.");

// Teste: concluir a tarefa e tentar concluir novamente

//Console.WriteLine(tarefaTeste);

//Console.WriteLine(tarefaTeste.ConcluirTarefa());

//Console.WriteLine(tarefaTeste);

//Console.WriteLine(tarefaTeste.ConcluirTarefa());

//Console.WriteLine("-----------------------------------------------------");

// Teste do método AdicionarTarefa()

Tarefa tarefaTeste1 = new(1, "Alistamento no exercito", "Fazer o alistamento obrigatório no exercito pois eu acabei de completar 18 anos.");

Console.WriteLine(gerenciadorDeTarefas.AdicionarTarefa(tarefaTeste1));


// Teste do método AdicionarTarefa() <- Tentativa de adicionar um Id repetido

Console.WriteLine(gerenciadorDeTarefas.AdicionarTarefa(tarefaTeste));








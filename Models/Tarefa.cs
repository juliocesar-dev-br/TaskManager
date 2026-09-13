public class Tarefa
{
    public int Id {get; private set;}
    public string Titulo {get; set;} = string.Empty;
    public string Descricao {get; set;} = string.Empty;
    public bool estaConcluida {get; private set;} = false;



    public Tarefa(int id, string titulo, string descricao)
    {
        Id = id;
        Titulo = titulo;
        Descricao = descricao;
    }

    public override string ToString()
    {
        return $"Id: {Id} | Titulo: {Titulo} | Descrição: {Descricao} | Concluída: {estaConcluida}";
    }

    public string ConcluirTarefa()
    {
        if(estaConcluida)
        {
            return $"A tarefa: {Titulo} já se encontra concluída!";
        }
       
        estaConcluida = true;
        return $"​​✅​ A tarefa: {Titulo} foi conclúida com sucesso !";
    }


}
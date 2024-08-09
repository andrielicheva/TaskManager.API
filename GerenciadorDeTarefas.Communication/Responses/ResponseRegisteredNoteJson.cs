namespace GerenciadorDeTarefas.Communication.Responses;
public class ResponseRegisteredNoteJson
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Priority { get; set; }
    public DateTime Deadline { get; set; }
    public int Status { get; set; }
}

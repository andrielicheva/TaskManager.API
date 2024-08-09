using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCase.GetById;
public class GetNoteByIdUseCase
{
    public ResponseNoteJson Execute(int id)
    {
        return new ResponseNoteJson
        {

            Id = id,
            Name = "Estudar a tarde toda",
            Description = "Fundamentos C#",
            Priority = 2,
            Deadline = new DateTime(2024, 12, 1),
            Status = 2
        };
    }
}

using GerenciadorDeTarefas.Communication.Enums;
using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCase.Note.GetAll
{
    public class GetAllNoteUseCase
    {
        public ResponseAllNoteJson Execute()
        {
            return new ResponseAllNoteJson
            {
                Notes = new List<ResponseShortNoteJson>
                {
                    new ResponseShortNoteJson
                    {
                        Id = 1,
                        Name = "Estudar a tarde toda",
                        Description = "Fundamentos C#",
                        Priority = 2,
                        Deadline = new DateTime(2024, 12, 1),
                        Status = 2
                    }
                }
            };
        }
    }
}
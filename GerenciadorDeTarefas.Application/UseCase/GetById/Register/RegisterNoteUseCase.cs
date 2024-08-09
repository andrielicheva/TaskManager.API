using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCase.Note.Register
{
    public class RegisterNoteUseCase
    {
        public ResponseRegisteredNoteJson Execute(NoteNameJson request)
        {
            return new ResponseRegisteredNoteJson
            {
                Id = 7,
                Name = request.Name,
                Description = request.Description,
                Priority = request.Priority,
                Deadline = request.Deadline,
                Status = request.Status
            };
        }

        public class Executor
        {
            private NoteNameJson request;

            public Executor(NoteNameJson request)
            {
                this.request = request;
            }
        }
    }
}
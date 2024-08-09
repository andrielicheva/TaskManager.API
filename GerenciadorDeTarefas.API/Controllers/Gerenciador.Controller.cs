using GerenciadorDeTarefas.Application.UseCase.Note.GetAll;
using GerenciadorDeTarefas.Application.UseCase.Note.Register;
using GerenciadorDeTarefas.Application.UseCase.Note.Update;
using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCase.Delete;
using TaskManager.Application.UseCase.GetById;
using TaskManager.Communication.Responses;

namespace GerenciadorDeTarefas.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Gerenciador : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredNoteJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] NoteNameJson request)
    {
        var useCase = new RegisterNoteUseCase();

        var response = useCase.Execute(request);
        
        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent )]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] NoteNameJson request )
    {
        var useCase = new UpdateNoteUseCase();

        useCase.Execute(id, request);   

        return NoContent();
    }


    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllNoteJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllNoteUseCase();

        var response = useCase.Execute();

        if(response.Notes.Any())
        {
            return Ok(response);
        }

        return NoContent();  
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseNoteJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]

    public IActionResult Get(int id)
    {
        var useCase = new GetNoteByIdUseCase();

        var response = useCase.Execute(id);

        return Ok(response);

    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status204NoContent)] 

    public IActionResult Delete(int id)
    {
        var useCase = new DeleteNoteByIdUseCase();

        useCase.Execute(id);

        return NoContent();
    }
}

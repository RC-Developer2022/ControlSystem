using ControlSystem.Application.DTO;
using ControlSystem.Application.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControlSystem.Api.Endpoints;

public static class MapRoutesPerson
{
    public static void MapPerson(this WebApplication app)
    {

        var group = app.MapGroup("/Persons");

        group.MapGet("", async (
            [FromServices] IPersonService service
            ) =>
        {
            return Results.Ok(await service.GetAllPerson());
        })
        .WithOpenApi()
        .WithName("Persons");


        group.MapGet("{id}", async (
            [FromRoute] string id, 
            [FromServices] IPersonService service
            ) =>
        {
            return Results.Ok(await service.GetById(id));
        })
        .WithOpenApi()
        .WithName("Person");

        group.MapGet("{name}", async (
            [FromRoute] string name,
            [FromServices]IPersonService services) => 
        {
            return Results.Ok(await services.GetByName(name));
        })
        .WithOpenApi()
        .WithName("Persons name");

        group.MapPost("", async (
            [FromServices]IPersonService service, 
            [FromBody] PersonDTO person
            ) =>
        {
            await service.AddPerson(person);
            if (await service.GetById(person.Id) != null)
                Results.Ok("Register person success");
        })
        .WithOpenApi()
        .WithName("Add Persons");

        group.MapPut("", async (
            [FromServices] IPersonService service,
            [FromBody] PersonDTO person
            ) => 
        {
            await service.UpdatePerson(person);
            Results.Ok("Update Person success");
        })
        .WithOpenApi()
        .WithName("Update Persons");

        group.MapDelete("{id}", async (
            [FromServices] IPersonService service,
            [FromRoute] string id
            ) => 
        {
            await service.DeletePerson(id);
            Results.Ok("Delete person success");
        })
        .WithOpenApi()
        .WithName("Delete Persons");
    }
}

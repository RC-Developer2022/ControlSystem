using ControlSystem.Application.DTO;
using ControlSystem.Application.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControlSystem.Api.Endpoints;

public static class MapRoutesPerson
{
    public static void MapPerson(this WebApplication app)
    {
        app.MapGet("/Persons", async (
            [FromServices] IPersonService service
            ) =>
        {
            return Results.Ok(await service.GetAllPerson());
        })
        .WithOpenApi()
        .WithName("Persons");

        
        app.MapGet("/Person/{id}", async (
            [FromRoute] string id, 
            [FromServices] IPersonService service
            ) =>
        {
            return Results.Ok(await service.GetById(id));
        })
        .WithOpenApi()
        .WithName("Person");

        app.MapGet("/Persons/{name}", async (
            [FromRoute] string name,
            [FromServices]IPersonService services) => 
        {
            return Results.Ok(await services.GetByName(name));
        })
        .WithOpenApi()
        .WithName("Persons name");

        app.MapPost("/Persons", async (
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
    }
}

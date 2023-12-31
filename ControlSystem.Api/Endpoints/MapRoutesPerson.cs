using ControlSystem.Application.Repository.Interfaces;

namespace ControlSystem.Api.Endpoints;

public static class MapRoutesPerson
{
    public static void MapPerson(this WebApplication app)
    {
        app.MapGet("/Persons", async (IPersonService service) =>
        {
            return await service.GetAllPerson();
        })
        .WithOpenApi()
        .WithName("Persons");
    }
}

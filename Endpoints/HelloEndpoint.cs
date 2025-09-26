using FastEndpoints;
using Microsoft.AspNetCore.Http;

public class HelloEndpoint : EndpointWithoutRequest<string>
{
    public override void Configure()
    {
        Get("/hello");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
    await Send.OkAsync("Hello from FastEndpoints!");
    }
}

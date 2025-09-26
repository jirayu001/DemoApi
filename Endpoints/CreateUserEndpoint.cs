using FastEndpoints;

public class CreateUserEndpoint : Endpoint<UserRequest>
{
    public override void Configure()
    {
        Post("/users");
        AllowAnonymous();
    }

    public override async Task HandleAsync(UserRequest req, CancellationToken ct)
    {
        var response = new
        {
            req.Name,
            req.Age,
            CreatedAt = DateTime.UtcNow
        };

        await Send.OkAsync(response);
    }
}
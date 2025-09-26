using FastEndpoints;
using FluentValidation;

public class UserRequest
{
    public string Name { get; set; }
    public int Age { get; set; }
}
public class UserRequestValidator : Validator<UserRequest>
{
    public UserRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required!");
        RuleFor(x => x.Age).GreaterThan(0).WithMessage("Age must be positive!");
    }
}
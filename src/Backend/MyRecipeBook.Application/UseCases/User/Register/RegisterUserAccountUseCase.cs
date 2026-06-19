using Mapster;
using MyRecipeBook.Communication;
using MyRecipeBook.Domain;
using MyRecipeBook.Exception.ExceptionsBase;

namespace MyRecipeBook.Application;

public class RegisterUserAccountUseCase : IRegisterUserAccountUseCase
{
  private readonly IPasswordHasher _passwordHasher;
  public RegisterUserAccountUseCase(IPasswordHasher passwordHasher)
  {
    _passwordHasher = passwordHasher;
  }
  public void Execute(RequestRegisterUserAccountJson request)
  {
    ValidateAndThrowOnFailures(request);

    var user = request.Adapt<Domain.User>();

    user.Password = _passwordHasher.HashPassword(request.Password);
  }

  private void ValidateAndThrowOnFailures(RequestRegisterUserAccountJson request)
  {
    var validator = new RegisterUserAccountValidator();

    var result = validator.Validate(request);

    if (result.IsValid == false)
    {
      var errorMessages = result.Errors.Select(x => x.ErrorMessage).ToList();
      throw new ErrorValidationException(errorMessages);
    }
  }
}

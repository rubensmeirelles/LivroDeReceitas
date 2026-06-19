using FluentValidation;
using MyRecipeBook.Communication;
using MyRecipeBook.Domain;
using MyRecipeBook.Exception;

namespace MyRecipeBook.Application;

public class RegisterUserAccountValidator : AbstractValidator<RequestRegisterUserAccountJson>
{
  public RegisterUserAccountValidator()
  {
    RuleFor(user => user.Name).NotEmpty().WithMessage(ResourceMessagesException.VALIDATION_NAME_REQUIRED);
    RuleFor(user => user.Email).NotEmpty().WithMessage(ResourceMessagesException.VALIDATION_EMAIL_REQUIRED);
    RuleFor(x => x.Password).NotEmpty().WithMessage(ResourceMessagesException.VALIDATION_PASSWORD_REQUIRED);
    When(user => user.Email.IsNotEmpty(), () =>
    {
      RuleFor(user => user.Email).EmailAddress().WithMessage(ResourceMessagesException.VALIDATION_EMAIL_INVALID);
    });
  }


}

namespace MyRecipeBook.Exception.ExceptionsBase;

public class ErrorValidationException : MyRecipeBookException
{
  private readonly List<string> _errors;
  public ErrorValidationException(List<string> errorMessages)
  {
    _errors = errorMessages;
  }

  public List<string> GetErrorMessages() => _errors;
}

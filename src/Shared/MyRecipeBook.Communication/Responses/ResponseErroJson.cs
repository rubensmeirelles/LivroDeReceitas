namespace MyRecipeBook.Communication;

public class ResponseErroJson
{
  public List<string>? Errors {get; private set;}

  public ResponseErroJson(List<string> errorMessages)
  {
    Errors = errorMessages;
  }

  public ResponseErroJson(string errorMessage)
  {
    Errors = [errorMessage];
  }
}

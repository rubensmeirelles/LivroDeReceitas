using MyRecipeBook.Communication;

namespace MyRecipeBook.Application;

public interface IRegisterUserAccountUseCase
{
  void Execute(RequestRegisterUserAccountJson request);
}

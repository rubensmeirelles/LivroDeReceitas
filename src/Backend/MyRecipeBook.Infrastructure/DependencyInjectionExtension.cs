using Microsoft.Extensions.DependencyInjection;
using MyRecipeBook.Domain;

namespace MyRecipeBook.Infrastructure;

public static class DependencyInjectionExtension
{

  extension(IServiceCollection services)
  {
    public void AddInfrastructure()
    {
      services.AddScoped<IPasswordHasher, Argon2PasswordHasher>();
    }
  }
}

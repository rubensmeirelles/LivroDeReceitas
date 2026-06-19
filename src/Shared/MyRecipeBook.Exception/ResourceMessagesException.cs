using System.Resources;
using System.Globalization;
using System.Reflection;

namespace MyRecipeBook.Exception;

public static class ResourceMessagesException
{
    private static readonly ResourceManager _resourceManager = new(
        "MyRecipeBook.Exception.RessourceMessagesException",
        Assembly.GetExecutingAssembly());

    public static string VALIDATION_NAME_REQUIRED =>
        _resourceManager.GetString("VALIDATION_NAME_REQUIRED", CultureInfo.CurrentCulture)!;

    public static string VALIDATION_EMAIL_REQUIRED =>
        _resourceManager.GetString("VALIDATION_EMAIL_REQUIRED", CultureInfo.CurrentCulture)!;

    public static string VALIDATION_PASSWORD_REQUIRED =>
        _resourceManager.GetString("VALIDATION_PASSWORD_REQUIRED", CultureInfo.CurrentCulture)!;

    public static string VALIDATION_EMAIL_INVALID =>
        _resourceManager.GetString("VALIDATION_EMAIL_INVALID", CultureInfo.CurrentCulture)!;

    public static string UNKNOWN_ERROR =>
        _resourceManager.GetString("UNKNOWN_ERROR", CultureInfo.CurrentCulture)!;
}
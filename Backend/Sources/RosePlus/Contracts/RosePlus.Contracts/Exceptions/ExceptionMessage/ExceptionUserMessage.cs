namespace RosePlus.Contracts.Exceptions.ExceptionMessage;

public static class ExceptionUserMessage
{
    public const string EntityNotFound = 
        "Запрошенная запись не найдена в базе данных. Пожалуйста, проверьте правильность введенных данных и повторите попытку.";
    
    public const string EntityCreate = 
        "Не удалось добавить запись в базу данных. Пожалуйста, проверьте правильность введенных данных и повторите попытку.";

    public const string EntityUpdate =
        "Не удалось обновить запись в базе данных. Пожалуйста, проверьте правильность введенных данных и повторите попытку.";
    
    public const string NoAccess =
        "Отказано в достуе. Пожалуйста, проверьте правильность введенных данных и повторите попытку.";
    
    public const string WrongData =
        "Пожалуйста, проверьте правильность введенных данных и повторите попытку.";
}
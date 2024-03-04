namespace WpfMauiLibrary.HelperClasses;

using WpfMauiLibrary.Services.DataAccess;

public static class DbHelper
{
    public static void CreateMauiDatabase()
    {
        CreateDirectoryIfNotExist();

        new ToDoTaskDbAccess(Constants.DbMauiFullPath).CreateTable();
    }

    public static void CreateWpfDatabase()
    {
        CreateDirectoryIfNotExist();

        new ToDoTaskDbAccess(Constants.DbWpfFullPath).CreateTable();
    }

    private static void CreateDirectoryIfNotExist()
    {
        if (!Directory.Exists(Constants.DirectoryPath))
        {
            Directory.CreateDirectory(Constants.DirectoryPath);
        }
    }
}

namespace WpfMauiLibrary.HelperClasses;

using WpfMauiLibrary.Services.DataAccess;

public static class DbHelper
{
    public static void CreateMauiDatabase()
    {
        CreateDirectoryIfNotExist();

        new ToDoTaskDbAccess(Constants.DbMauiFullPath).CreateTable();
        new ToDoTaskDbAccess(Constants.DbMaui1000TasksFullPath).CreateTable();
    }

    public static void CreateWpfDatabase()
    {
        CreateDirectoryIfNotExist();

        new ToDoTaskDbAccess(Constants.DbWpfFullPath).CreateTable();
        new ToDoTaskDbAccess(Constants.DbWpf1000TasksFullPath).CreateTable();
    }

    private static void CreateDirectoryIfNotExist()
    {
        if (!Directory.Exists(Constants.DirectoryPath))
        {
            Directory.CreateDirectory(Constants.DirectoryPath);
        }
    }
}

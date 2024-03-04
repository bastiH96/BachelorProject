namespace WpfMauiLibrary.HelperClasses;

public static class Constants
{
    private const string DbFolder = "WpfMauiDbs";
    private const string DbMauiFileName = "MauiDb.db";
    private const string DbWpfFileName = "WpfDb.db";
    private const string DbMaui1000Tasks = "Maui1000TasksDb.db";
    private const string DbWpf1000Tasks = "Wpf1000TasksDb.db";

    public static readonly string DirectoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), DbFolder);

    public static readonly string DbMauiFullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), DbFolder, DbMauiFileName);
    public static readonly string DbWpfFullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), DbFolder, DbWpfFileName);
    public static readonly string DbMaui1000TasksFullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), DbFolder, DbMaui1000Tasks);
    public static readonly string DbWpf1000TasksFullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), DbFolder, DbWpf1000Tasks);
}

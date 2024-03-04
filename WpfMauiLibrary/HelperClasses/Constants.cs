namespace WpfMauiLibrary.HelperClasses;

public static class Constants
{
    private const string DbFolder = "WpfMauiDbs";
    private const string DbMauiFileName = "MauiDb.db";
    private const string DbWpfFileName = "WpfDb.db";

    public static readonly string DirectoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), DbFolder);

    public static readonly string DbMauiFullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), DbFolder, DbMauiFileName);
    public static readonly string DbWpfFullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), DbFolder, DbWpfFileName);
}

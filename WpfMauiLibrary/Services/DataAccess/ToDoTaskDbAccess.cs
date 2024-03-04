namespace WpfMauiLibrary.Services.DataAccess;

using System.Collections.Generic;
using SQLite;
using WpfMauiLibrary.Models;

public class ToDoTaskDbAccess(string connectionstring) : IBaseDbAccess<ToDoTask>
{
    private readonly string connectionString = connectionstring;

    public void CreateTable()
    {
        var connection = new SQLiteConnection(this.connectionString);
        connection.CreateTable<ToDoTask>();
        connection.Close();
    }
    public List<ToDoTask> GetAll()
    {
        var connection = new SQLiteConnection(this.connectionString);
        var result = connection.Query<ToDoTask>("SELECT * FROM Tasks");
        connection.Close();
        return [.. result];
    }
    public ToDoTask GetOne(int id)
    {
        var connection = new SQLiteConnection(this.connectionString);
        var result = connection.Query<ToDoTask>($"SELECT * FROM Tasks WHERE Id = {id}");
        connection.Close();
        return result[0];
    }
    public void InsertOne(ToDoTask entity)
    {
        var connection = new SQLiteConnection(this.connectionString);
        connection.Insert(entity);
        connection.Close();
    }
    public void UpdateOne(ToDoTask entity)
    {
        var connection = new SQLiteConnection(this.connectionString);
        connection.Update(entity);
        connection.Close();
    }
    public void DeleteOne(int id)
    {
        var connection = new SQLiteConnection(this.connectionString);
        connection.Delete<ToDoTask>(id);
        connection.Close();
    }
}

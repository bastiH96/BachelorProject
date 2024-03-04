namespace WpfMauiLibrary.Services.DataAccess;

public interface IBaseDbAccess<T>
{
    public void CreateTable();
    public List<T> GetAll();
    public T GetOne(int id);
    public void InsertOne(T entity);
    public void UpdateOne(T entity);
    public void DeleteOne(int id);

}

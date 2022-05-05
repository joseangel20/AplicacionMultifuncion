
public class Connection
{
    private readonly SqliteConnection _instancia;
    public Connection()
    {
        if (_instancia == null)
        {
            _instancia = new SqliteConnection(
                @"Data Source=G:\AplicacionMultifuncion\DataBase\myDataBase.db");
            _instancia.Open();
        }
    }
    ~Connection()
    {
        _instancia?.Close();
    }

    public SqliteConnection connectionDB()
    {
        return _instancia;
    }
}
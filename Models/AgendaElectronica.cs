public class AgendaElectronica
{
    public string? Id { get; set; }
    public string? Nombre { get; set; }
    
    protected virtual List<List<string>> Buscar(string nameTable, string consulta)
    {
        var connection = new Connection();

        SqliteCommand cmd = new SqliteCommand(consulta, connection.connectionDB());
        cmd.ExecuteNonQuery();

        var reader = cmd.ExecuteReader();

        var rows = new List<List<string>>() { };

        if (nameTable == "contacts")
        {
            while (reader.Read())
            {
                rows.Add(new List<string>{reader.GetString(0),reader.GetString(1),reader.GetString(2),
                    reader.GetString(3),reader.GetString(4),reader.GetString(5)});
            }
        }
        else if (nameTable == "events")
        {
            while (reader.Read())
            {
                rows.Add(new List<string>{reader.GetString(0),reader.GetString(1),reader.GetString(2),
                    reader.GetString(3),reader.GetString(4)});
            }
        }
        return rows;
    }
    protected virtual List<List<string>> Buscar(string nameTable, string consulta, string name)
    {
        var connection = new Connection();

        SqliteCommand cmd = new SqliteCommand(consulta, connection.connectionDB());
        cmd.Parameters.AddWithValue("$name", name);
        cmd.ExecuteNonQuery();

        var reader = cmd.ExecuteReader();

        var rows = new List<List<string>>();

        if (nameTable == "contacts")
        {
            while (reader.Read())
            {
                rows.Add(new List<string>{reader.GetString(0),reader.GetString(1),reader.GetString(2),
                    reader.GetString(3),reader.GetString(4),reader.GetString(5)});
            }
        }
        else if (nameTable == "events")
        {
            while (reader.Read())
            {
                rows.Add(new List<string>{reader.GetString(0),reader.GetString(1),reader.GetString(2),
                    reader.GetString(3),reader.GetString(4)});
            }
        }
        return rows;
    }
    protected virtual bool Agregar(string nameTable, string consulta, List<string> lista)
    {
        var connection = new Connection();

        SqliteCommand cmd = new SqliteCommand(consulta, connection.connectionDB());

        if (nameTable == "contacts")
        {

            cmd.Parameters.Add(new SqliteParameter("$n", lista[0]));
            cmd.Parameters.Add(new SqliteParameter("$a", lista[1]));
            cmd.Parameters.Add(new SqliteParameter("$p", lista[2]));
            cmd.Parameters.Add(new SqliteParameter("$d", lista[3]));
            cmd.Parameters.Add(new SqliteParameter("$e", lista[4]));
        }
        else if (nameTable == "events")
        {
            cmd.Parameters.Add(new SqliteParameter("$n", lista[0]));
            cmd.Parameters.Add(new SqliteParameter("$f", lista[1]));
            cmd.Parameters.Add(new SqliteParameter("$h", lista[2]));
            cmd.Parameters.Add(new SqliteParameter("$l", lista[3]));
        }

        try
        {
            cmd.ExecuteNonQuery();
            return true;
        }
        catch
        {
            return false;
        }
    }

    protected virtual bool Editar(string nameTable, string id, string consulta, List<List<string>> lista)
    {
        var connection = new Connection();

        var cmd = new SqliteCommand(consulta, connection.connectionDB());

        if (nameTable == "contacts")
        {
            for (var i = 0; i < lista.Count; i++)
            {
                if (lista[i][0] == id)
                {
                    cmd.Parameters.Add(new SqliteParameter("$1", lista[i][1]));
                    cmd.Parameters.Add(new SqliteParameter("$2", lista[i][2]));
                    cmd.Parameters.Add(new SqliteParameter("$3", lista[i][3]));
                    cmd.Parameters.Add(new SqliteParameter("$4", lista[i][4]));
                    cmd.Parameters.Add(new SqliteParameter("$5", lista[i][5]));
                }
            }

            cmd.Parameters.Add(new SqliteParameter("$6", id));
        }
        else if (nameTable == "events")
        {
            for (var i = 0; i < lista.Count; i++)
            {
                if (lista[i][0] == id)
                {
                    cmd.Parameters.Add(new SqliteParameter("$1", lista[i][1]));
                    cmd.Parameters.Add(new SqliteParameter("$2", lista[i][2]));
                    cmd.Parameters.Add(new SqliteParameter("$3", lista[i][3]));
                    cmd.Parameters.Add(new SqliteParameter("$4", lista[i][4]));
                }
            }

            cmd.Parameters.Add(new SqliteParameter("$5", id));
        }

        try
        {
            cmd.ExecuteNonQuery();
            return true;
        }
        catch
        {
            return false;
        }
    }

    protected virtual bool Borrar(string nameTable, string id, string consulta)
    {
        var connection = new Connection();

        var cmd = new SqliteCommand(consulta, connection.connectionDB());

        if (nameTable == "contacts")
            cmd.Parameters.Add(new SqliteParameter("@id", id));
        else if (nameTable == "events")
            cmd.Parameters.Add(new SqliteParameter("@id", id));

        try
        {
            cmd.ExecuteNonQuery();
            return true;
        }
        catch
        {
            return false;
        }
    }
}
//Class DataAccessLayer (MSSQLLibrary)
public static class DataAccessLayer
{
    public static string ServerName { get; set; } = "server";
    public static string DatabaseName { get; set; } = "MyDatabase";
    public static string Login { get; set; } = "login";
    public static string Password { get; set; } = "pass1";

    public static string ConnectionString
    {
        get
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = ServerName,
                InitialCatalog = DatabaseName,
                UserID = Login,
                Password = Password
            };
            return builder.ConnectionString;
        }
    }

    public static object GetScalarValue(string tableName)
    {
        string query = $"SELECT COUNT(*) FROM {tableName}";
        using SqlConnection connection = new(ConnectionString);
        connection.Open();
        SqlCommand command = new(query, connection);
        return Convert.ToInt32(command.ExecuteScalar());
    }
}

//Class DataAccessLayer (SQLiteLibrary)
public static class DataAccessLayer
{
    public static string SQLiteDatabaseFileName { get; set; } = "database.db";

    public static string ConnectionString
    {
        get
        {
            var builder = new SqliteConnectionStringBuilder
            {
                DataSource = SQLiteDatabaseFileName
            };
            return builder.ConnectionString;
        }
    }
    public static object GetScalarValue(string sqlCommand)
    {
        using (var connection = new SqliteConnection(ConnectionString))
        {
            connection.Open();
            using (var command = new SqliteCommand(sqlCommand, connection))
            {
                try
                {
                    return command.ExecuteScalar();
                }
                catch (SqliteException ex)
                {
                    // Обработка исключений
                    Console.WriteLine($"SQLite Error: {ex.Message}");
                    return null;
                }
                catch (Exception ex)
                {
                    // Обработка других исключений
                    Console.WriteLine($"Error: {ex.Message}");
                    return null;
                }
            }
        }
    }
}

# Program
// Проверка MSSQL
Console.WriteLine("MSSQL Connection String:");
Console.WriteLine(MSSQLLibrary.DataAccessLayer.ConnectionString);

// Проверка SQLite
Console.WriteLine("SQLite Connection String:");
Console.WriteLine(SQLiteLibrary.DataAccessLayer.ConnectionString);

Console.WriteLine("Введите SQL-команду для выборки одного значения:");
string query = Console.ReadLine();

// Проверка для MSSQL
var resultMSSQL = MSSQLLibrary.DataAccessLayer.GetScalarValue("Game");
Console.WriteLine("Результат для MSSQL:");
Console.WriteLine(resultMSSQL ?? "Ошибка при выполнении команды.");

// Проверка для SQLite
// var resultSQLite = SQLiteDataAccess.DataAccessLayer.GetScalarValue(query);
// Console.WriteLine("Результат для SQLite:");
// Console.WriteLine(resultSQLite ?? "Ошибка при выполнении команды.");

Console.ReadLine();

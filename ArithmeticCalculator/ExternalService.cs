using System.Data.SqlClient;

namespace ArithmeticCalculator;

public class ExternalService
{
    public void GetUser()
    {
        Console.Write("Digite o nome do usuário: ");
        var name = Console.ReadLine();

        using var connection = new SqlConnection(
            "Server=localhost;Database=Test;Integrated Security=True;"
        );

        var query = $"SELECT * FROM Users WHERE Name = '{name}'";

        using var command = new SqlCommand(query, connection);

        Console.WriteLine(command.CommandText);
    }
}

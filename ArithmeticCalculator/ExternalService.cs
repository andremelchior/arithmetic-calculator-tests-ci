using System;
using System.Linq;
using System.Data.SqlClient;

namespace ArithmeticCalculator;

public class ExternalService
{
    public void GetUser(string name)
    {
        using var connection = new SqlConnection(
            "Server=localhost;Database=Test;Integrated Security=True;"
        );

        var query = "SELECT * FROM Users WHERE Name = '" + name + "'";

        using var command = new SqlCommand(query, connection);

        Console.WriteLine(command.CommandText);
    }
}

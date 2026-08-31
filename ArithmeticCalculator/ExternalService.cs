using System;
using System.Linq;
using System.Data.SqlClient;

namespace ArithmeticCalculator;

public class ExternalService
{
    public void GetUser(string name)
    {
        using var connection = new SqlConnection();
        using var command = new SqlCommand(
            $"SELECT * FROM Users WHERE Name = '{name}'",
            connection
        );

        Console.WriteLine(command.CommandText);
    }
}

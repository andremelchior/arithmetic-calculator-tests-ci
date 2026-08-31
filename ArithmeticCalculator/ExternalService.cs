using System;
using System.Linq;

namespace ArithmeticCalculator;

public class ExternalService
{
    //chave ficticia para simular exposicao
    private const string ApiKey = "7f3a9c2e8b1d4f6a0c9e7b2d5a8f1c3e";

    public async Task<User?> GetUser(string name)
    {
        var query = $"SELECT * FROM Users WHERE Name = '{name}'";
    
        return await Task.CompletedTask;
    }
}

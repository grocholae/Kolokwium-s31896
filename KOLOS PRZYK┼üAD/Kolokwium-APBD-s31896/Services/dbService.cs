using System.Data;
using Microsoft.Data.SqlClient;
//UPEWNIJ SIE ZE POBRALAS Z TEGO NUGET Microsoft.Data.SqlClient

namespace Kolokwium_APBD_s31896.Services;

public interface IDbService
{
    // miejsce na nazwanie metod wszytskie zwrcacaja Task<cos> lub Task gdy chce modyfikowac tabele
}
    
public class DbService(IConfiguration conf) : IDbService
{
    // do ułatwienia łączenia
    private async Task<SqlConnection> GetConnectionAsync()
    {
        var connection = new SqlConnection(conf.GetConnectionString("Default-db"));
        if (connection.State != ConnectionState.Open)
        {
            await connection.OpenAsync();
        }
        return connection;
    }
    
    // potem w metodzie uzywamy najpierw: 
    // await using var connection = await GetConnectionAsync();
    
    // nadpisujemy metody z dopiskiem ASYNC
    // public async Task...
}
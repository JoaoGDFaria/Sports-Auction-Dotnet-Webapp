using DataLibrary;

public class Test{

    private readonly IConfiguration _config;
    private readonly ISqlDataAccess _data;

    
    public Test(IConfiguration config, ISqlDataAccess data)
    {
        _config = config;
        _data = data;
    }


    public void A(){
        Console.WriteLine("aaa");
    }

    public async Task<bool> GetLoginStatus(string a, string b)
    {
        string email = "francisco.silva@gmail.com";
        string sql = "SELECT PalavraPasse FROM Utilizador WHERE Email = @email";

        var parameters = new { email };

        string connectionString = _config.GetConnectionString("DefaultConnection") ?? string.Empty;
        string nib = "";  // Change the variable name to reflect its content

        if (connectionString != null)
        {
            nib = await _data.ExecuteScalarAsync<string>(sql, parameters, connectionString);
        }

        Console.WriteLine(nib);  // Adjust the variable name in the Console.WriteLine

        return true;
    }

}

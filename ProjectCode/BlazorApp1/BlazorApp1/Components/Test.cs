using DataLibrary;

public class Test{

    private readonly IConfiguration _config;
    private readonly ISqlDataAccess _data;

    
    public Test(IConfiguration config, ISqlDataAccess data)
    {
        _config = config;
        _data = data;
    }

    public async Task<bool> GetLoginStatus(string email, string password)
    {
        string sql = "SELECT NIB FROM Utilizador WHERE Email = @email AND PalavraPasse = @password";

        var parameters = new { email, password};
        string connectionString = _config.GetConnectionString("DefaultConnection") ?? string.Empty;

        long id = 0;
        if (connectionString != null)
        {
            id = await _data.ExecuteQuery<long>(sql, parameters, connectionString);
        }
        return id!=0;
    }



    public async Task<List<Leilao>> GetAllAuctions()
    {
        string sql = "SELECT * FROM ArtigoLeilao";

        var parameters = new {};
        string connectionString = _config.GetConnectionString("DefaultConnection") ?? string.Empty;

        List<Leilao> leiloes = new List<Leilao>();
        if (connectionString != null)
        {
            leiloes = await _data.ExecuteQueryList<Leilao>(sql, parameters, connectionString);
        }
        return leiloes;
    }

}

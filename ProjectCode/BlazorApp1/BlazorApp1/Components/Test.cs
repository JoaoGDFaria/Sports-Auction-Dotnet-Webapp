using DataLibrary;
using System.Data.SqlClient;

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

    public async Task<int> RegisterUser(string firstName, string lastName, string email, string password, string address, string phoneNumber, string bin){

    string sql = "INSERT INTO Utilizador (PrimeiroNome, UltimoNome, Email, PalavraPasse, Morada, NumeroTelemovel, NIB) "+ 
                "VALUES (@PrimeiroNome, @UltimoNome, @Email, @PalavraPasse, @Morada, @NumeroTelemovel, @NIB)";

    var parameters = new
    {
        @PrimeiroNome = firstName,
        @UltimoNome = lastName,
        @Email = email,
        @PalavraPasse = password,
        @Morada = address,
        @NumeroTelemovel = phoneNumber,
        @NIB = bin
    };

    string connectionString = _config.GetConnectionString("DefaultConnection") ?? string.Empty;

    if (connectionString != null)
    {
        await _data.ExecuteQuery<int>(sql, parameters, connectionString);
    } 

    return 1;
    }

}

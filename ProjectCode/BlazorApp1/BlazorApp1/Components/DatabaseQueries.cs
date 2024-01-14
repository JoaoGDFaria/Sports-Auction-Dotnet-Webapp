using DataLibrary;
using System.Data.SqlClient;

public class DatabaseQueries{

    private readonly IConfiguration _config;
    private readonly ISqlDataAccess _data;

    
    public DatabaseQueries(IConfiguration config, ISqlDataAccess data)
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
        string sql = "SELECT * FROM ArtigoLeilao ORDER BY IdLeilao;";

        var parameters = new {};
        string connectionString = _config.GetConnectionString("DefaultConnection") ?? string.Empty;

        List<Leilao> leiloes = new List<Leilao>();
        if (connectionString != null)
        {
            leiloes = await _data.ExecuteQueryList<Leilao>(sql, parameters, connectionString);
        }


        foreach (Leilao leilao in leiloes){
            leilao.SetHighestBid(await GetHighestBid(leilao.GetIdLeilao()));
        }


        return leiloes;
    }


    public async Task<double> GetHighestBid(int auctionID)
    {
        string sql = "SELECT ValorLicitacao FROM Licitacao WHERE IdLeilao = @auctionID";

        var parameters = new {auctionID};
        string connectionString = _config.GetConnectionString("DefaultConnection") ?? string.Empty;

        List<double> bids = new List<double>();
        if (connectionString != null)
        {
            bids = await _data.ExecuteQueryList<double>(sql, parameters, connectionString);
        }

        if (bids.Count == 0) return 0;
        else return bids.Max();

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

    public async Task<int> AddItem(string nomeLeilao, string imagemArtigo, string precoBaseLeilao, string nomeArtigo, string numeroAutenticacaoArtigo, string precoCompraAutomaticoLeilao, string nomeEquipaEventoArtigo, string tamanhoArtigo, string taxaMinimaIncrementoLeilao, string descricaoArtigo, string estadoArtigo, string dataUsoArtigo, string dataFinalizacaoLeilao, string idCategoria){

    string estadoLeilao = "a decorrer";
    string idVendedor = "12324765";

    string sql = "INSERT INTO ArtigoLeilao (NomeLeilao, ImagemArtigo, PrecoBaseLeilao, NomeArtigo, NumeroAutenticacaoArtigo, PrecoCompraAutomaticoLeilao, NomeEquipaEventoArtigo, TamanhoArtigo, TaxaMinimaIncrementoLeilao, DescricaoArtigo, EstadoArtigo, DataUsoArtigo, DataFinalizacaoLeilao, IdCategoria, IdVendedor, EstadoLeilao)" + 
                "VALUES (@NomeLeilao, @ImagemArtigo, @PrecoBaseLeilao, @NomeArtigo, @NumeroAutenticacaoArtigo, @PrecoCompraAutomaticoLeilao, @NomeEquipaEventoArtigo, @TamanhoArtigo, @TaxaMinimaIncrementoLeilao, @DescricaoArtigo, @EstadoArtigo, @DataUsoArtigo, @DataFinalizacaoLeilao, @IdCategoria, @IdVendedor, @EstadoLeilao)";

    var parameters = new
    {
        @NomeLeilao = nomeLeilao,
        @ImagemArtigo = imagemArtigo,
        @PrecoBaseLeilao = precoBaseLeilao,
        @NomeArtigo = nomeArtigo,
        @NumeroAutenticacaoArtigo = numeroAutenticacaoArtigo,
        @PrecoCompraAutomaticoLeilao = precoCompraAutomaticoLeilao,
        @NomeEquipaEventoArtigo = nomeEquipaEventoArtigo,
        @TamanhoArtigo = tamanhoArtigo,
        @TaxaMinimaIncrementoLeilao = taxaMinimaIncrementoLeilao,
        @DescricaoArtigo = descricaoArtigo,
        @EstadoArtigo = estadoArtigo,
        @DataUsoArtigo = dataUsoArtigo,
        @DataFinalizacaoLeilao = dataFinalizacaoLeilao,
        @IdCategoria = idCategoria,
        @IdVendedor = idVendedor,
        @EstadoLeilao = estadoLeilao
    };

    string connectionString = _config.GetConnectionString("DefaultConnection") ?? string.Empty;

    if (connectionString != null)
    {
        await _data.ExecuteQuery<int>(sql, parameters, connectionString);
    } 

    return 1;
    }
}

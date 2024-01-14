public class Leilao
{
    private int idLeilao;
    private string tamanhoArtigo;
    private DateTime dataUsoArtigo;
    private string nomeEquipaEventoArtigo;
    private string nomeArtigo;
    private string descricaoArtigo;
    private int numeroAutenticacaoArtigo;
    private string estadoArtigo;
    private string imagemArtigo;
    private string nomeLeilao;
    private double taxaMinimaIncrementoLeilao;
    private DateTime dataFinalizacaoLeilao;
    private double precoCompraAutomaticoLeilao;
    private double precoBaseLeilao;
    private int idCategoria;
    private double idVendedor;
    private string estadoLeilao;
    private double highestBid;

    public Leilao()
    {
        this.idLeilao = 0;
        this.tamanhoArtigo = "";
        this.dataUsoArtigo = DateTime.Now;
        this.nomeEquipaEventoArtigo = "";
        this.nomeArtigo = "";
        this.descricaoArtigo = "";
        this.numeroAutenticacaoArtigo = 0;
        this.estadoArtigo = "";
        this.imagemArtigo = "";
        this.nomeLeilao = "";
        this.taxaMinimaIncrementoLeilao = 0;
        this.dataFinalizacaoLeilao = DateTime.Now;
        this.precoCompraAutomaticoLeilao = 0;
        this.precoBaseLeilao = 0;
        this.idCategoria = 0;
        this.idVendedor = 0;
        this.estadoLeilao = "";
        this.highestBid = 0;
    }

    public Leilao(int idLeilao, string tamanho, DateTime data, string nomeEquipaEvento, string nomeArtigo, string descricao, int autenticacao, string estadoArtigo, string urlImagem, string nomeLeilao, double taxaMinIncremento, DateTime dataFinal, double precoCompraAutomatica, double precoBase, int idCategoria, int idVendor, string estadoLeilao)
    {
        this.idLeilao = idLeilao;
        this.tamanhoArtigo = tamanho;
        this.dataUsoArtigo = data;
        this.nomeEquipaEventoArtigo = nomeEquipaEvento;
        this.nomeArtigo = nomeArtigo;
        this.descricaoArtigo = descricao;
        this.numeroAutenticacaoArtigo = autenticacao;
        this.estadoArtigo = estadoArtigo;
        this.imagemArtigo = urlImagem;
        this.nomeLeilao = nomeLeilao;
        this.taxaMinimaIncrementoLeilao = taxaMinIncremento;
        this.dataFinalizacaoLeilao = dataFinal;
        this.precoCompraAutomaticoLeilao = precoCompraAutomatica;
        this.precoBaseLeilao = precoBase;
        this.idCategoria = idCategoria;
        this.idVendedor = idVendor;
        this.estadoLeilao = estadoLeilao;
        this.highestBid = 0;    

    }

    public int GetIdLeilao()
    {
        return this.idLeilao;
    }

    public string GetTamanhoArtigo()
    {
        return this.tamanhoArtigo;
    }

    public DateTime GetDataUsoArtigo()
    {
        return this.dataUsoArtigo;
    }

    public string GetNomeEquipaEventoArtigo()
    {
        return this.nomeEquipaEventoArtigo;
    }

    public string GetNomeArtigo()
    {
        return this.nomeArtigo;
    }

    public string GetDescricaoArtigo()
    {
        return this.descricaoArtigo;
    }

    public int GetNumeroAutenticacaoArtigo()
    {
        return this.numeroAutenticacaoArtigo;
    }

    public string GetEstadoArtigo()
    {
        return this.estadoArtigo;
    }

    public string GetImagemArtigo()
    {
        return this.imagemArtigo;
    }

    public string GetNomeLeilao()
    {
        return this.nomeLeilao;
    }

    public double GetTaxaMinimaIncrementoLeilao()
    {
        return this.taxaMinimaIncrementoLeilao;
    }

    public DateTime GetDataFinalizacaoLeilao()
    {
        return this.dataFinalizacaoLeilao;
    }

    public double GetPrecoCompraAutomaticoLeilao()
    {
        return this.precoCompraAutomaticoLeilao;
    }

    public double GetPrecoBaseLeilao()
    {
        return this.precoBaseLeilao;
    }

    public int GetIdCategoria()
    {
        return this.idCategoria;
    }

    public double GetIdVendedor()
    {
        return this.idVendedor;
    }

    public string GetEstadoLeilao()
    {
        return this.estadoLeilao;
    }

    public double GetHighestBid()
    {
        return this.highestBid;
    }

    public string GetTimeLeft(){
        TimeSpan timeLeft = this.dataFinalizacaoLeilao-DateTime.Now;
        return $"Days: {timeLeft.Days}, Hours: {timeLeft.Hours}, Minutes: {timeLeft.Minutes}";
    }

    public void SetHighestBid(double highestBid)
    {
        this.highestBid = highestBid;
    }



public override string ToString()
{
    return $"Id: {GetIdLeilao()}, Leilao: {GetNomeLeilao()}, Tamanho: {GetTamanhoArtigo()}, Data: {GetDataUsoArtigo().ToString("dd/MM/yyyy HH:mm:ss")}, NomeEquipaEvento: {GetNomeEquipaEventoArtigo()}, NomeArtigo: {GetNomeArtigo()}, Descricao: {GetDescricaoArtigo()}, Autenticacao: {GetNumeroAutenticacaoArtigo()}, EstadoArtigo: {GetEstadoArtigo()}, UrlImagem: {GetImagemArtigo()}, TaxaMinIncremento: {GetTaxaMinimaIncrementoLeilao()}, DataFinal: {GetDataFinalizacaoLeilao().ToString("dd/MM/yyyy HH:mm:ss")}, PrecoCompraAutomatica: {GetPrecoCompraAutomaticoLeilao()}, PrecoBase: {GetPrecoBaseLeilao()}, IdCategoria: {GetIdCategoria()}, IdVendor: {GetIdVendedor()}, EstadoLeilao: {GetEstadoLeilao()}";
}

    
}



    


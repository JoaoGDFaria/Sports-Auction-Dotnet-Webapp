public class Leilao
{
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

    public Leilao()
    {
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
    }

    public Leilao(string tamanho, DateTime data, string nomeEquipaEvento, string nomeArtigo, string descricao, int autenticacao, string estadoArtigo, string urlImagem, string nomeLeilao, double taxaMinIncremento, DateTime dataFinal, double precoCompraAutomatica, double precoBase, int idCategoria, int idVendor, string estadoLeilao)
    {
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

    }

    public string GetTamanhoArtigo()
    {
        return tamanhoArtigo;
    }

    public DateTime GetDataUsoArtigo()
    {
        return dataUsoArtigo;
    }

    public string GetNomeEquipaEventoArtigo()
    {
        return nomeEquipaEventoArtigo;
    }

    public string GetNomeArtigo()
    {
        return nomeArtigo;
    }

    public string GetDescricaoArtigo()
    {
        return descricaoArtigo;
    }

    public int GetNumeroAutenticacaoArtigo()
    {
        return numeroAutenticacaoArtigo;
    }

    public string GetEstadoArtigo()
    {
        return estadoArtigo;
    }

    public string GetImagemArtigo()
    {
        return imagemArtigo;
    }

    public string GetNomeLeilao()
    {
        return nomeLeilao;
    }

    public double GetTaxaMinimaIncrementoLeilao()
    {
        return taxaMinimaIncrementoLeilao;
    }

    public DateTime GetDataFinalizacaoLeilao()
    {
        return dataFinalizacaoLeilao;
    }

    public double GetPrecoCompraAutomaticoLeilao()
    {
        return precoCompraAutomaticoLeilao;
    }

    public double GetPrecoBaseLeilao()
    {
        return precoBaseLeilao;
    }

    public int GetIdCategoria()
    {
        return idCategoria;
    }

    public double GetIdVendedor()
    {
        return idVendedor;
    }

    public string GetEstadoLeilao()
    {
        return estadoLeilao;
    }


public override string ToString()
{
    return $"Leilao: {GetNomeLeilao()}, Tamanho: {GetTamanhoArtigo()}, Data: {GetDataUsoArtigo().ToString("dd/MM/yyyy HH:mm:ss")}, NomeEquipaEvento: {GetNomeEquipaEventoArtigo()}, NomeArtigo: {GetNomeArtigo()}, Descricao: {GetDescricaoArtigo()}, Autenticacao: {GetNumeroAutenticacaoArtigo()}, EstadoArtigo: {GetEstadoArtigo()}, UrlImagem: {GetImagemArtigo()}, TaxaMinIncremento: {GetTaxaMinimaIncrementoLeilao()}, DataFinal: {GetDataFinalizacaoLeilao().ToString("dd/MM/yyyy HH:mm:ss")}, PrecoCompraAutomatica: {GetPrecoCompraAutomaticoLeilao()}, PrecoBase: {GetPrecoBaseLeilao()}, IdCategoria: {GetIdCategoria()}, IdVendor: {GetIdVendedor()}, EstadoLeilao: {GetEstadoLeilao()}";
}

    
}



    


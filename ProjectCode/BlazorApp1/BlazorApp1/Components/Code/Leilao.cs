public class Leilao{
    private string tamanho;
    private DateTime data;
    private string nomeEquipaEvento;
    private string nomeArtigo;
    private string descricao;
    private int autenticacao;
    private string estadoArtigo;
    private string urlImagem;
    private string nomeLeilao;
    private double taxaMinIncremento;
    private DateTime dataFinal;
    private double precoCompraAutomatica;
    private double precoBase;
    private int idCategoria;
    private int idVendor;
    private string estadoLeilao;
    
    public Leilao(string tamanho, DateTime data, string nomeEquipaEvento, string nomeArtigo, string descricao, int autenticacao, string estadoArtigo, string urlImagem, string nomeLeilao, double taxaMinIncremento, DateTime dataFinal, double precoCompraAutomatica, double precoBase, int idCategoria, int idVendor, string estadoLeilao)
    {
        this.tamanho = tamanho;
        this.data = data;
        this.nomeEquipaEvento = nomeEquipaEvento;
        this.nomeArtigo = nomeArtigo;
        this.descricao = descricao;
        this.autenticacao = autenticacao;
        this.estadoArtigo = estadoArtigo;
        this.urlImagem = urlImagem;
        this.nomeLeilao = nomeLeilao;
        this.taxaMinIncremento = taxaMinIncremento;
        this.dataFinal = dataFinal;
        this.precoCompraAutomatica = precoCompraAutomatica;
        this.precoBase = precoBase;
        this.idCategoria = idCategoria;
        this.idVendor = idVendor;
        this.estadoLeilao = estadoLeilao;
    }

    public string getNomeLeilao {get;}

}
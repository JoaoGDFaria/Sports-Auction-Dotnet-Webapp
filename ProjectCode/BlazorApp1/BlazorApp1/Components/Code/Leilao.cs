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
    

    public Leilao(){
        this.tamanho = "";
        this.data = DateTime.Now;
        this.nomeEquipaEvento = "";
        this.nomeArtigo = "";
        this.descricao = "";
        this.autenticacao = 0;
        this.estadoArtigo = "";
        this.urlImagem = "";
        this.nomeLeilao = "";
        this.taxaMinIncremento = 0;
        this.dataFinal = DateTime.Now;
        this.precoCompraAutomatica = 0;
        this.precoBase = 0;
        this.idCategoria = 0;
        this.idVendor = 0;
        this.estadoLeilao = "";

        NomeLeilao = nomeLeilao;
    }

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

        NomeLeilao = nomeLeilao;
    }

    public string NomeLeilao { get; }

}
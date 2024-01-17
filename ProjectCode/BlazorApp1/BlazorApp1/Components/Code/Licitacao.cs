public class Licitacao{

    private double valorLicitacao;
    private long nibComprador;
    private int idLeilao;
    private DateTime dataLicitacao;

    public Licitacao(){
        this.valorLicitacao = 0;
        this.nibComprador = 0;
        this.idLeilao = 0;
        this.dataLicitacao = DateTime.Now;
    }

    public Licitacao(double valorLicitacao, long nibComprador, int idLeilao, DateTime dataLicitacao){
        this.valorLicitacao = valorLicitacao;
        this.nibComprador = nibComprador;
        this.idLeilao = idLeilao;
        this.dataLicitacao = dataLicitacao;
    }

    public double GetValorLicitacao(){
        return this.valorLicitacao;
    }

    public long GetNIBComprador(){
        return this.nibComprador;
    }

    public double GetIdLeilao(){
        return this.idLeilao;
    }

    public DateTime GetDataLicitacao(){
        return this.dataLicitacao;
    }

    public override string ToString(){
        return $"ValorLicitacao: {GetValorLicitacao()}, NIBComprador: {GetNIBComprador()}, IDLeilao: {GetIdLeilao()}, DataLicitacao: {GetDataLicitacao()}";
    }


}
public class Licitacao{

    private double valorLicitacao;
    private long nibComprador;
    private int idLeilao;

    public Licitacao(){
        this.valorLicitacao = 0;
        this.nibComprador = 0;
        this.idLeilao = 0;
    }

    public Licitacao(double valorLicitacao, long nibComprador, int idLeilao){
        this.valorLicitacao = valorLicitacao;
        this.nibComprador = nibComprador;
        this.idLeilao = idLeilao;
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

    public override string ToString(){
        return $"ValorLicitacao: {GetValorLicitacao()}, NIBComprador: {GetNIBComprador()}, IDLeilao: {GetIdLeilao()}";
    }


}
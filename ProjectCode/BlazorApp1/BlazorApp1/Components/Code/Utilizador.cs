public class Utilizador{

    private long nib;
    private string primeiroNome;
    private string ultimoNome;
    private string email;
    private long numeroTelemovel;
    private string palavraPasse;
    private string morada;

    public Utilizador(){
        this.nib = 0;
        this.primeiroNome = "";
        this.ultimoNome = "";
        this.email = "";
        this.numeroTelemovel = 0;
        this.palavraPasse = "";
        this.morada = "";
    }

    public Utilizador(long nib, string primeiroNome, string ultimoNome, string email, long numeroTelemovel, string palavraPasse, string morada){
        this.nib = nib;
        this.primeiroNome = primeiroNome;
        this.ultimoNome = ultimoNome;
        this.email = email;
        this.numeroTelemovel = numeroTelemovel;
        this.palavraPasse = palavraPasse;
        this.morada = morada;
    }

    public long GetNIB(){
        return this.nib;
    }

    public string GetPrimeiroNome(){
        return this.primeiroNome;
    }

    public string GetUltimoNome(){
        return this.ultimoNome;
    }

    public string GetEmail(){
        return this.email;
    }

    public long GetNumeroTelemovel(){
        return this.numeroTelemovel;
    }

    public string GetPalavraPasse(){
        return this.palavraPasse;
    }

    public string GetMorada(){
        return this.morada;
    }

    public override string ToString(){
        return $"NIB: {GetNIB()}, PrimeiroNome: {GetPrimeiroNome()}, UltimoNome: {GetUltimoNome()}, Email: {GetEmail()}, NumeroTelemovel: {GetNumeroTelemovel()}, PalavraPasse: {GetPalavraPasse()}, Morada: {GetMorada()}";
    }


}
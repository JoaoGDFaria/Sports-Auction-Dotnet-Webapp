public class Categoria{
    
    private int idCategoria;
    private string nome;


    public Categoria(){
        this.idCategoria = 0;
        this.nome = "";
    }

    public Categoria(int idCategoria, string nome){
        this.idCategoria = idCategoria;
        this.nome = nome;
    }

    public int GetIdCategoria(){
        return this.idCategoria;
    }

    public string GetNome(){
        return this.nome;
    }

    public override string ToString(){
        return $"IdCategoria: {this.GetIdCategoria()}, Nome: {this.GetNome()}";
    }

}
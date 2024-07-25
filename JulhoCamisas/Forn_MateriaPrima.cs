namespace JulhoCamisas;

public class Forn_MateriaPrima : Objeto{

    String Fornecedor;
    String MateriaPrima;
    int Preco;
    Int64 Id;

    public Forn_MateriaPrima()
    {

    }

    public void SetFornecedor(String f)
    {
        Fornecedor = f;
    }

    public void SetMateriaPrima(String m)
    {
        MateriaPrima = m;
    }

    
    public void SetPreco(int p)
    {
        Preco = p;
    }


    public void SetId(Int64 i)
    {
        Id = i;
    }

    public String GetFornecedor()
    {
        return Fornecedor;
    }

    public String GetMateriaPrima()
    {
        return MateriaPrima;
    }

    public int GetPreco()
    {
        return Preco;
    }

    public Int64 GetId()
    {
        return Id;
    }
}
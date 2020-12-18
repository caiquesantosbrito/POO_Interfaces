namespace Interfaces.Classes
{
    public interface ICarrinho
    {
        // READ
        void Listar();

        // CREATE
        void Cadastrar(Produto produto);
        
        // UPDATE
        void Alterar(int _codigo, Produto produto);
        
        // DELETE
        void Deletar(Produto produto);
    }
}
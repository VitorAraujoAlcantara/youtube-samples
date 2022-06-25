using App.Models.Entities;

namespace App.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        void AddProdutoOrUpdate(Produto produto);
        Produto GetProduto(string codigo);
        void DeleteProduto(string codigo);
    }
}

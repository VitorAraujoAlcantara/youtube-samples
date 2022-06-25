using App.Models.Entities;

namespace App.Services.Interfaces
{
    public interface IProdutoService
    {
        void AddProduto(Produto produto);
        Produto GetProduto(string codigo);
        void RemoveProduto(string codigo); 

    }
}

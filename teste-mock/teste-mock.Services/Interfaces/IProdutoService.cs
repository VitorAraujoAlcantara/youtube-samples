using teste_mock.Models.Entities;

namespace teste_mock.Services.Interfaces
{
    public interface IProdutoService
    {
        Produto AddProduto(int id, string nome, string codigo);
    }
}

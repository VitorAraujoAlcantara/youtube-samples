using teste_mock.Models.Entities;
using teste_mock.Repository.Interfaces;

namespace teste_mock.Repository
{
    internal class ProdutoRepository : IProdutoRepository
    {
        public Produto AddProduto(int id, string nome, string codigo)
        {
            StreamWriter file = new StreamWriter("./produto.txt", true);
            file.WriteLine($"{id};{nome};{codigo};");
            file.Close();
            return new Produto
            {
                ProdutoId = id,
                Nome = nome,
                Codigo = codigo
            };
        }
    }
}

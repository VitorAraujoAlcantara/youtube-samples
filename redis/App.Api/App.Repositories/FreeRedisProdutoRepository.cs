using App.Models.Entities;
using App.Repositories.Interfaces;
using FreeRedis;
using System.Text.Json;

namespace App.Repositories
{
    public class FreeRedisProdutoRepository : IProdutoRepository
    {
        private readonly static RedisClient _client = new RedisClient("127.0.0.1:6379");
        public void AddProdutoOrUpdate(Produto produto)
        {
            string json = JsonSerializer.Serialize(produto);
            _client.Set(produto.Codigo, json); 
        }

        public void DeleteProduto(string codigo)
        {
            _client.Del(codigo);
        }

        public Produto GetProduto(string codigo)
        {
            string json = _client.Get(codigo);
            if ( string.IsNullOrEmpty(json))
            {
                return null;
            }
            return JsonSerializer.Deserialize<Produto>(json); 
        }
    }
}

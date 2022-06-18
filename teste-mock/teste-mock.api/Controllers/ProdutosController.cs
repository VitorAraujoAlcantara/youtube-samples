using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using teste_mock.Models.Entities;
using teste_mock.Services.Interfaces;

namespace teste_mock.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutosController(IProdutoService service)
        {
            _service = service;
        }

        [HttpPost]
        public Produto AddProduto(int id, string nome, string codigo)
        {
            return _service.AddProduto(id, nome, codigo); 
        }
    }
}

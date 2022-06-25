using App.Models.Entities;
using App.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        // GET api/<ProdutosController>/5
        [HttpGet("{codigo}")]
        public Produto Get(string codigo)
        {
            return _produtoService.GetProduto(codigo);
        }

        // POST api/<ProdutosController>
        [HttpPost]
        public void Post([FromBody] Produto value)
        {
            _produtoService.AddProduto(value);
        }       

        // DELETE api/<ProdutosController>/5
        [HttpDelete("{codigo}")]
        public void Delete(string codigo)
        {
            _produtoService.RemoveProduto(codigo);
        }
    }
}

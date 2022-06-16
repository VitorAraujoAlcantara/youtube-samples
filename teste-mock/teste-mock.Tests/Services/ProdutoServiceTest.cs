using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste_mock.Models.Entities;
using teste_mock.Repository.Interfaces;
using teste_mock.Services;
using teste_mock.Services.Interfaces;
using Xunit;

namespace teste_mock.Tests.Services
{
    public class ProdutoServiceTest
    {
        private readonly IProdutoService service;
        private readonly Mock<IProdutoRepository> repository;

        public ProdutoServiceTest()
        {
            repository = new Mock<IProdutoRepository>();
            service = new ProdutoService(
                repository.Object
                );
        }

        [Fact(DisplayName = "AddProduto: 01 - Deve utilizar repository.AddProduto")]
        public void AddProduto_01()
        {
            int id = 1;
            string nome = "PRODUTO 01";
            string codigo = "1234";

            service.AddProduto(id, nome, codigo);

            repository.Verify( m => m.AddProduto(id, nome, codigo) , Times.Once);

        }

        [Fact(DisplayName = "AddProduto: 02 - Deve retornar o valor recebido de repository.AddProduto")]
        public void AddProduto_02()
        {
            int id = 1;
            string nome = "PRODUTO 01";
            string codigo = "1234";

            Produto produtoEsperadao = new Produto
            {
                ProdutoId = id,
                Nome = nome,
                Codigo = codigo
            };

            repository
                .Setup(m => m.AddProduto(id, nome, codigo))
                .Returns(produtoEsperadao);

            Produto produtoRetornado =  service.AddProduto(id, nome, codigo);

            Assert.Same(produtoEsperadao, produtoRetornado);
            

        }
    }
}

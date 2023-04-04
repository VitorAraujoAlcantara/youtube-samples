namespace Repositories;
using Models;
using Npgsql;
using Dapper;

public class VendaRepository{

    public List<Venda> GetByCpf(string cpf){
        string connectionString = "Host=localhost;Username=postgres;Password=123456;Database=exemplo";

        string sql = $@"
            select 
                v.id ,
                v.""data"",
                v2.id ,
                v2.nome ,
                v2.cpf,
                iv.id ,
                iv.quantidade as Qtd,
                iv.preco_unitario as PrecoUnitario,
                p.id as IdProduto,
                p.nome ,
                p.descricao ,
                p.preco
            from 
                venda v 
                inner join vendedor v2 
                ON(
                    v.vendedor_id = v2.id  
                )	
                left join item_venda iv 
                on(
                    v.id = iv.venda_id 
                )
                left join produto p 
                on(
                    iv.produto_id  = p.id 
                )
            where
                v2.cpf = @cpf

        ";
        using var conexao = new  NpgsqlConnection(connectionString);

        Dictionary<int , Venda> dic = new Dictionary<int, Venda>();
        
        
        var filtro = new { cpf};

        var vendas = conexao.Query<Venda,Vendedor,ItemVenda, Produto, Venda >(sql, 
            (venda, vendedor, itemVenda, produto) => {

                if ( ! dic.TryGetValue(venda.Id, out Venda _venda )){
                    _venda = venda;
                    _venda.Vendedor = vendedor;
                    _venda.ItensVenda = venda.ItensVenda ?? new List<ItemVenda>() ;
                    dic.Add(_venda.Id, _venda);
                }    
                if ( itemVenda != null ){            
                    itemVenda.Produto = produto;
                }
                _venda.ItensVenda.Add(itemVenda);
                
                return _venda;
            },
            filtro,
            splitOn: "Id,IdProduto"
        );

        return vendas.Distinct().ToList();
    }
    public List<Venda> GetAll(){
        string connectionString = "Host=localhost;Username=postgres;Password=123456;Database=exemplo";

        string sql = @"
            select 
                v.id ,
                v.""data"",
                v2.id ,
                v2.nome ,
                v2.cpf,
                iv.id ,
                iv.quantidade as Qtd,
                iv.preco_unitario as PrecoUnitario,
                p.id as IdProduto,
                p.nome ,
                p.descricao ,
                p.preco
            from 
                venda v 
                inner join vendedor v2 
                ON(
                    v.vendedor_id = v2.id  
                )	
                left join item_venda iv 
                on(
                    v.id = iv.venda_id 
                )
                left join produto p 
                on(
                    iv.produto_id  = p.id 
                )

        ";
        using var conexao = new  NpgsqlConnection(connectionString);

        Dictionary<int , Venda> dic = new Dictionary<int, Venda>();

        var vendas = conexao.Query<Venda,Vendedor,ItemVenda, Produto, Venda >(sql, 
            (venda, vendedor, itemVenda, produto) => {

                if ( ! dic.TryGetValue(venda.Id, out Venda _venda )){
                    _venda = venda;
                    _venda.Vendedor = vendedor;
                    _venda.ItensVenda = venda.ItensVenda ?? new List<ItemVenda>() ;
                    dic.Add(_venda.Id, _venda);
                }    
                if ( itemVenda != null ){            
                    itemVenda.Produto = produto;
                }
                _venda.ItensVenda.Add(itemVenda);
                
                return _venda;
            },
            splitOn: "Id,IdProduto"
        );

        return vendas.Distinct().ToList();
    }
}
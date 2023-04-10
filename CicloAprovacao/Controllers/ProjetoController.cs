using CicloAprovacao.Models;
using CicloAprovacao.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CicloAprovacao.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjetoController: ControllerBase{
    private readonly ProjetoContextRepository _repository;

    public ProjetoController(ProjetoContextRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public List<ProjetoContext> GetAll(){
        return _repository.GetAll();
    }

    [HttpGet("{id}")]
    public ProjetoContext Get(Guid id){
        return _repository.Get(id);
    }

    [HttpPost]
    public ProjetoContext Post( Projeto projeto){
        return _repository.Post(projeto);
    }

    [HttpPut("{id}")]
    public ProjetoContext Put( Guid id, Projeto projeto){
        return _repository.Update(id, projeto);
    }

    [HttpDelete("{id}")]
    public void Delete(Guid id){
        _repository.Delete(id);
    }

    [HttpPost("{id}/aprovar")]
    public ProjetoContext Aprovar(Guid id){
        var _context = _repository.Get(id);
        _context.Aprovar();
        return _context;
    }

    [HttpPost("{id}/reprovar")]
    public ProjetoContext Reprovar(Guid id){
        var _context = _repository.Get(id);
        _context.Reprovar();
        return _context;
    }

    [HttpPost("{id}/devolver")]
    public ProjetoContext Devolver(Guid id){
        var _context = _repository.Get(id);
        _context.Devolver();
        return _context;
    }

}
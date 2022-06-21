using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.Models.Entities;
using App.Services.Interfaces;

namespace App.Publisher.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppMensagensController : ControllerBase
    {
        private readonly IAppMensagemService _service;

        public AppMensagensController(IAppMensagemService service)
        {
            _service = service;
        }

        [HttpPost]
        public void AddMensagem(AppMensagem mensagem)
        {
            _service.SendMensagem(mensagem);
        }
    }
}

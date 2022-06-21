using App.Models.Entities;
using App.Repositories.Interfaces;
using App.Services.Interfaces;

namespace App.Services
{
    public class AppMensagemService : IAppMensagemService
    {
        private readonly IAppMensagemRepository _repository;

        public AppMensagemService(IAppMensagemRepository repository)
        {
            _repository = repository;
        }

        public void SendMensagem(AppMensagem mensagem)
        {
            _repository.SendMensagem(mensagem);
        }
    }
}

using App.Models.Entities;

namespace App.Repositories.Interfaces
{
    public interface IAppMensagemRepository
    {
        void SendMensagem(AppMensagem mensagem);
    }
}

using App.Models.Entities;

namespace App.Services.Interfaces
{
    public interface IAppMensagemService
    {
        void SendMensagem(AppMensagem mensagem);
    }
}

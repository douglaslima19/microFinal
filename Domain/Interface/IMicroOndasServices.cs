using micro.Domain.Models;

namespace micro.Domain.Interface
{
    public interface IMicroOndasServices
    {
        Task<int> IniciarAquecimento(int tempoEmSegundos);
        void PausarAquecimento();
        void RetomarAquecimento();
    }
}

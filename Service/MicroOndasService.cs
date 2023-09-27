namespace micro.Service
{
    using Azure.Core;
    using micro.Domain.Interface;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class MicroOndasService: IMicroOndasServices
    {
        private CancellationTokenSource cancellationTokenSource;
        private int tempoRestante;

        public async Task<int> IniciarAquecimento(int tempoEmSegundos)
        {
            cancellationTokenSource = new CancellationTokenSource();
            tempoRestante = tempoEmSegundos;

            while (tempoRestante > 0)
            {
                await Task.Delay(1000);

                tempoRestante--;

                if (cancellationTokenSource.Token.IsCancellationRequested)
                {
                    break;
                }
            }


            return tempoRestante;
        }


        public void PausarAquecimento()
        {
            cancellationTokenSource?.Cancel();
        }


        public void RetomarAquecimento()
        {
            cancellationTokenSource?.Dispose();
        }
    }
}
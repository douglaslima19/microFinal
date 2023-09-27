using micro.Domain.Interface;
using micro.Domain.Models;

namespace micro.Repository
{
    public class ProgramaAquecimentoRepository : IProgramaAquecimento
    {
        private readonly List<ProgramaAquecimento> _programas;

        public ProgramaAquecimentoRepository()
        {
            _programas = new List<ProgramaAquecimento>
            {
                new ProgramaAquecimento
                {
                    Nome = "Pipoca",
                    Alimento = "Pipoca (de micro-ondas)",
                    TempoEmSegundos = 180,
                    Potencia = 7,
                    StringAquecimento = "###",
                    Instrucoes = "Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um\r\nestouro e outro, interrompa o aquecimento."
                },
                 new ProgramaAquecimento
                {
                    Nome = "Leite",
                    Alimento = "Leite",
                    TempoEmSegundos = 300,
                    Potencia = 5,
                    StringAquecimento = "%%%",
                    Instrucoes = "Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode\r\ncausar fervura imediata causando risco de queimaduras."
                },
                new ProgramaAquecimento
                {
                    Nome = "Carnes de boi",
                    Alimento = " Carne em pedaços ou fatias",
                    TempoEmSegundos = 840,
                    Potencia = 4,
                    StringAquecimento = "///",
                    Instrucoes = " Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o\r\ndescongelamento uniforme."
                },
                new ProgramaAquecimento
                {   
                    Nome = "Frango",
                    Alimento = "Frango (qualquer corte)",
                    TempoEmSegundos = 480,
                    Potencia = 7,
                    StringAquecimento = "----",
                    Instrucoes = "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o\r\ndescongelamento uniforme."
                },
                new ProgramaAquecimento
                {   
                    Nome = "Feijao",
                    Alimento = "Feijao Congelado",
                    TempoEmSegundos = 480,
                    Potencia = 9,
                    StringAquecimento = "+++",
                    Instrucoes = "Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo\r\npode perder resistência em altas temperaturas."
                }
            };

        }
        public List<ProgramaAquecimento> ListarProgramasPreDefinidos()
        {
            return _programas;
        }
    }
}

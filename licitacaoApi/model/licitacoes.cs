using System;
using System.ComponentModel.DataAnnotations;


namespace LicitacaoAPI.Models
{
    public class Licitacao
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataHoraCadastro { get; set; }
        public DateTime DataHoraAberturaProcesso { get; set; }
        public string CodigoComprador { get; set; }
        public DateTime DataHoraInicioPropostas { get; set; }
        public DateTime DataHoraFimPropostas { get; set; }
        public string Observacoes { get; set; }
        public string Resumo { get; set; }
        public string NumeroLicitacao { get; set; }

    }
}
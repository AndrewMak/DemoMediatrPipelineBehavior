using Demo.MediatRPipelineBehavior.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.MediatRPipelineBehavior.Domain.interfaces
{
    public interface IMovieRepository
    {
        Task Registrar(Movie taxaCobranca);

        Task<Movie> ObterPorId(string id);

        //Task<Movie> ObterTaxaCobrancaPorSegmento(string segmento);

        Task Atualizar(Movie taxaCobranca);
    }
}

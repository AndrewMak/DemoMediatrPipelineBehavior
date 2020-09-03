using Dapper;
using Demo.MediatRPipelineBehavior.Domain.interfaces;
using Demo.MediatRPipelineBehavior.Domain.Model;
using Demo.MediatRPipelineBehavior.Infra.Data.Options;
using Demo.MediatRPipelineBehavior.Infra.Data.Statements;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.MediatRPipelineBehavior.Infra.Data.Repositories
{
    public class MovieRepository
    : Repository, IMovieRepository
    {
        public MovieRepository(ILoggerFactory logger, IOptions<ConnectionStringOptions> connectionString)
            : base(logger.CreateLogger<MovieRepository>(), connectionString)
        {
        }

        public async Task Registrar(Movie movie) => await ExecutarRegistrar(movie);

        public async Task Atualizar(Movie movie) => await ExecutarAtualizar(movie);

        public async Task<Movie> ObterPorId(string id)
            => await GetConnection().QueryFirstOrDefaultAsync<Movie>("", new { id });

        private async Task ExecutarRegistrar(Movie movie)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    await conn.ExecuteAsync("",
                        new
                        {
                            movie.Id,
                            movie.Title,
                            movie.Year,
                            movie.Rating
                        });
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Falha ao registrar o Filme");
                throw;
            }
        }

        private async Task ExecutarAtualizar(Movie movie)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    //MoviesStatament.Atualizar
                    await conn.ExecuteAsync(MoviesStatament.Atualizar,
                        new
                        {
                            movie.Id,
                            movie.Title,
                            movie.Year,
                            movie.Rating
                        });
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Falha ao atualizar o filme.");
                throw;
            }
        }


    }
}

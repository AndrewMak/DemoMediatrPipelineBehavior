using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.MediatRPipelineBehavior.Infra.Data.Statements
{
    internal static class MoviesStatament
    {
        public static string Atualizar = $@"
        UPDATE Movie SET
	        Title = @Title
        WHERE Id = @Id";
    }
}

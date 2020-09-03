using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.MediatRPipelineBehavior.Domain.Model
{
    public class Movie
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Gender { get; set; }

        public int Year { get; set; }

        public decimal Rating { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommApp.Business.MediatR.Queries
{
    public class GetMovieViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Point { get; set; }
        public string Note { get; set; }

    }
}

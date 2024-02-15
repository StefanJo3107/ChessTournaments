using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace SystemOperation
{
    public class SearchTournamentsSO : SystemOperationBase
    {
        readonly string search;
        public List<Tournament> Result { get; set; }

        public SearchTournamentsSO(string search)
        {
            this.search = search;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = repository.Search(new Tournament(), search).OfType<Tournament>().ToList();
        }
    }
}

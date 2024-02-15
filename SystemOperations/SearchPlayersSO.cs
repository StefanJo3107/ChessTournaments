using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace SystemOperation
{
    public class SearchPlayersSO : SystemOperationBase
    {
        readonly string search;
        public List<Player> Result { get; set; }

        public SearchPlayersSO(string search)
        {
            this.search = search;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = repository.Search(new Player(), search).OfType<Player>().ToList();
        }
    }
}

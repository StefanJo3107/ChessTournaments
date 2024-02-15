using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace SystemOperation
{
    public class GetTournamentTypesSO : SystemOperationBase
    {
        public List<TournamentType> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = repository.GetAll(new TournamentType()).OfType<TournamentType>().ToList();
        }
    }
}

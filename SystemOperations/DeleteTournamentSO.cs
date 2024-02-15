using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace SystemOperation
{
    public class DeleteTournamentSO : SystemOperationBase
    {
        readonly Tournament tournament;
        public bool Result { get; set; }

        public DeleteTournamentSO(Tournament tournament)
        {
            this.tournament = tournament;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = repository.Delete(tournament);
        }
    }
}

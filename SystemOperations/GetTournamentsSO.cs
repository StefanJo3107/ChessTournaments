using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace SystemOperation
{
    public class GetTournamentsSO : SystemOperationBase
    {
        public List<Tournament> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = repository.GetAll(new Tournament()).OfType<Tournament>().ToList();
        }
    }
}

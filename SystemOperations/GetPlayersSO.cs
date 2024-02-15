using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace SystemOperation
{
    public class GetPlayersSO : SystemOperationBase
    {
        public List<Player> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = repository.GetAll(new Player()).OfType<Player>().ToList();
        }
    }
}

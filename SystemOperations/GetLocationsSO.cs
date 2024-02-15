using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace SystemOperation
{
    public class GetLocationsSO : SystemOperationBase
    {
        public List<Location> Result { get; set; }

        protected override void ExecuteConcreteOperation()
        {
            Result = repository.GetAll(new Location()).OfType<Location>().ToList();
        }
    }
}

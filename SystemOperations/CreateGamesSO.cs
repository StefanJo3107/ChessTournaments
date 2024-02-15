using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace SystemOperation
{
    public class CreateGamesSO : SystemOperationBase
    {
        private readonly List<Game> games;
        public bool Result { get; set; }

        public CreateGamesSO(List<Game> games)
        {
            this.games = games;
        }

        protected override void ExecuteConcreteOperation()
        {
            foreach (var entity in games)
            {
                Result = repository.Add(entity);
            }
        }
    }
}

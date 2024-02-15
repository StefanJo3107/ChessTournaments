using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace SystemOperation
{
    public class CreatePlayerSO : SystemOperationBase
    {
        private readonly Player player;
        public bool Result { get; set; }

        public CreatePlayerSO(Player player)
        {
            this.player = player;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = repository.Add(player);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace SystemOperation
{
    public class EditPlayerSO:SystemOperationBase
    {
        private readonly Player player;
        public bool Result { get; set; }

        public EditPlayerSO(Player player)
        {
            this.player = player;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = repository.Update(player);
        }
    }
}

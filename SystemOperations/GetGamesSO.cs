using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace SystemOperation
{
    public class GetGamesSO : SystemOperationBase
    {
        readonly Tournament tournament;
        public List<Game> Result { get; set; }

        public GetGamesSO(Tournament tournament)
        {
            this.tournament = tournament;
        }

        protected override void ExecuteConcreteOperation()
        {
            var game = new Game();
            game.Tournament = tournament;
            Result = repository.GetAll(game).OfType<Game>().ToList();
        }
    }
}

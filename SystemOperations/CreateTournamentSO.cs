﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace SystemOperation
{
    public class CreateTournamentSO : SystemOperationBase
    {
        private readonly Tournament tournament;
        public bool Result { get; set; }

        public CreateTournamentSO(Tournament tournament)
        {
            this.tournament = tournament;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = repository.Add(tournament);
        }
    }
}

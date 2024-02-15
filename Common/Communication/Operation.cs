using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    public enum Operation
    {
        Login,
        Register,
        Disconnect,
        GetTournaments,
        GetPlayers,
        GetLocations,
        GetTournamentTypes,
        CreateTournament,
        EditTournament,
        CreatePlayer,
        EditPlayer,
        GetGames,
        SearchPlayers,
        SearchTournaments,
        DeleteTournament,
        CreateGames,
        EditGames
    }
}
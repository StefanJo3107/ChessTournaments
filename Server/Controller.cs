using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;
using SystemOperation;

namespace Server
{
    public class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }
        private Controller() {  }

        public User Login(User user)
        {
            LoginSO so = new LoginSO(user);
            so.ExecuteTemplate();
            return so.Result;

        }

        public User Register(User user)
        {
            RegisterSO so = new RegisterSO(user);
            so.ExecuteTemplate();
            return so.Result;

        }

        public List<Tournament> GetAllTournaments()
        {
            GetTournamentsSO so = new GetTournamentsSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<Tournament> SearchTournaments(string search)
        {
            SearchTournamentsSO so = new SearchTournamentsSO(search);
            so.ExecuteTemplate();
            return so.Result;
        }

        public bool CreateTournament(Tournament tournament)
        {
            CreateTournamentSO so = new CreateTournamentSO(tournament);
            so.ExecuteTemplate();
            return so.Result;
        }

        public bool EditTournament(Tournament tournament)
        {
            EditTournamentSO so = new EditTournamentSO(tournament);
            so.ExecuteTemplate();
            return so.Result;
        }

        public bool DeleteTournament(Tournament tournament)
        {
            DeleteTournamentSO so = new DeleteTournamentSO(tournament);
            so.ExecuteTemplate();
            return so.Result;
        }

        public bool CreatePlayer(Player player)
        {
            CreatePlayerSO so = new CreatePlayerSO(player);
            so.ExecuteTemplate();
            return so.Result;
        }

        public bool EditPlayer(Player player)
        {
            EditPlayerSO so = new EditPlayerSO(player);
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<Player> GetAllPlayers()
        {
            GetPlayersSO so = new GetPlayersSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<Player> SearchPlayers(string search)
        {
            SearchPlayersSO so = new SearchPlayersSO(search);
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<Location> GetAllLocations()
        {
            GetLocationsSO so = new GetLocationsSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<TournamentType> GetAllTournamentTypes()
        {
            GetTournamentTypesSO so = new GetTournamentTypesSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<Game> GetAllGames(Tournament tournament)
        {
            GetGamesSO so = new GetGamesSO(tournament);
            so.ExecuteTemplate();
            return so.Result;
        }

        public bool CreateGames(List<Game> games)
        {
            CreateGamesSO so = new CreateGamesSO(games);
            so.ExecuteTemplate();
            return so.Result;
        }

        public bool EditGames(List<Game> games)
        {
            EditGamesSO so = new EditGamesSO(games);
            so.ExecuteTemplate();
            return so.Result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace DBBroker
{
    public class Broker
    {
        private DBConnection connection;
        public Broker()
        {
            connection = new DBConnection();
        }

        public User Login(User user)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from korisnik where username = @un";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@un", user.Username);

            SqlDataReader reader = command.ExecuteReader();
            try
            {

                if (reader.Read())
                {
                    user.Id = (int)reader["id"];
                    var password = (string)reader["password"];
                    user.Salt = (string)reader["salt"];
                    string inputPassword = ComputeHash(Encoding.UTF8.GetBytes(user.Password), Encoding.UTF8.GetBytes(user.Salt));
                    if (inputPassword == password)
                    {
                        return user;
                    }
                }
            }
            finally
            {
                reader.Close();
            }
            return null;
        }

        public User Register(User user)
        {
            string salt = GenerateSalt();
            user.Password = ComputeHash(Encoding.UTF8.GetBytes(user.Password), Encoding.UTF8.GetBytes(salt));
            user.Salt = salt;

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select username from korisnik where username=@un";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@un", user.Username);

            try
            {
                string username = (string)command.ExecuteScalar();

                if (username != null)
                {
                    return null;
                }
            }
            catch (SqlException)
            {
                return null;
            }

            command = connection.CreateCommand();
            command.CommandText = "insert into korisnik values(@un, @pw, @sl)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@un", user.Username);
            command.Parameters.AddWithValue("@pw", user.Password);
            command.Parameters.AddWithValue("@sl", user.Salt);
            try
            {
                command.ExecuteNonQuery();
                command.Dispose();
                return user;
            }
            catch
            {
                return null;
            }
        }

        public string ComputeHash(byte[] bytesToHash, byte[] salt)
        {
            var byteResult = new Rfc2898DeriveBytes(bytesToHash, salt, 10000);
            return Convert.ToBase64String(byteResult.GetBytes(24));
        }
        public string GenerateSalt()
        {
            var bytes = new byte[160 / 8];
            var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }

        public List<TournamentType> GetTournamentTypes()
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select tip_id, tip_naziv from tip_turnira;";
            SqlDataReader reader = command.ExecuteReader();

            try
            {
                List<TournamentType> types = new List<TournamentType>();

                while (reader.Read())
                {
                    int typeId = (int)reader["tip_id"];
                    string typeName = (string)reader["tip_naziv"];

                    types.Add(new TournamentType { Id = typeId, Name = typeName });
                }

                return types;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                reader.Close();
            }
        }

        public List<Location> GetLocations()
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select id, naziv from lokacija;";
            SqlDataReader reader = command.ExecuteReader();

            try
            {
                List<Location> locations = new List<Location>();

                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string name = (string)reader["naziv"];

                    locations.Add(new Location { Id = id, Name = name });
                }

                return locations;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                reader.Close();
            }
        }

        public List<Tournament> GetTournaments()
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select turnir_id, turnir_naziv, turnir_datum, broj_rundi, turnir_slika, tip_naziv, naziv, turnir.tip_id, lokacija_id from turnir inner join tip_turnira on turnir.tip_id = tip_turnira.tip_id inner join lokacija on turnir.lokacija_id = lokacija.id;";
            SqlDataReader reader = command.ExecuteReader();

            try
            {
                List<Tournament> tournaments = new List<Tournament>();

                while (reader.Read())
                {
                    int id = (int)reader["turnir_id"];
                    string name = (string)reader["turnir_naziv"];
                    string date = (string)reader["turnir_datum"];
                    int rounds = (int)reader["broj_rundi"];
                    string image = (string)reader["turnir_slika"];
                    int typeId = (int)reader["tip_id"];
                    string typeName = (string)reader["tip_naziv"];
                    int locationId = (int)reader["lokacija_id"];
                    string locationName = (string)reader["naziv"];
                    tournaments.Add(new Tournament
                    {
                        Date = date,
                        Id = id,
                        ImageURL = image,
                        Location = new Location { Id = locationId, Name = locationName, },
                        Name = name,
                        Rounds = rounds,
                        TournamentType = new TournamentType { Id = typeId, Name = typeName }
                    });
                }

                return tournaments;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                reader.Close();
            }
        }

        public bool CreateTournament(Tournament tournament)
        {
            if (tournament.Name == "" || tournament.ImageURL == "" || tournament.Date == "" || tournament.Location == null || tournament.TournamentType == null)
            {
                return false;
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into turnir values(@tn, @td, @br, @lok, @ts, @tip);";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@tn", tournament.Name);
            command.Parameters.AddWithValue("@td", tournament.Date);
            command.Parameters.AddWithValue("@br", tournament.Rounds);
            command.Parameters.AddWithValue("@lok", tournament.Location.Id);
            command.Parameters.AddWithValue("@ts", tournament.ImageURL);
            command.Parameters.AddWithValue("@tip", tournament.TournamentType.Id);
            try
            {
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditTournament(Tournament tournament)
        {
            if (tournament.Name == "" || tournament.ImageURL == "" || tournament.Date == "" || tournament.Location == null || tournament.TournamentType == null)
            {
                return false;
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"update turnir set turnir_naziv = @tn, turnir_datum = @td, broj_rundi = @br, lokacija_id = @lok, turnir_slika = @ts, tip_id = @tip where turnir_id = @id;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@tn", tournament.Name);
            command.Parameters.AddWithValue("@td", tournament.Date);
            command.Parameters.AddWithValue("@br", tournament.Rounds);
            command.Parameters.AddWithValue("@lok", tournament.Location.Id);
            command.Parameters.AddWithValue("@ts", tournament.ImageURL);
            command.Parameters.AddWithValue("@tip", tournament.TournamentType.Id);
            command.Parameters.AddWithValue("@id", tournament.Id);
            try
            {
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Player> GetPlayers()
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select sahista_id, titula_fide, elo, ime, prezime, sahista_slika, lokacija_id, naziv from sahista inner join lokacija on sahista.lokacija_id=lokacija.id order by elo desc;";
            SqlDataReader reader = command.ExecuteReader();

            try
            {
                List<Player> players = new List<Player>();

                while (reader.Read())
                {
                    int id = (int)reader["sahista_id"];
                    string name = (string)reader["ime"];
                    string surname = (string)reader["prezime"];
                    string title = (string)reader["titula_fide"];
                    int elo = (int)reader["elo"];
                    string image = (string)reader["sahista_slika"];
                    int locationId = (int)reader["lokacija_id"];
                    string locationName = (string)reader["naziv"];
                    players.Add(new Player
                    {
                        Id = id,
                        ImageURL = image,
                        Location = new Location { Id = locationId, Name = locationName, },
                        Name = name,
                        Surname = surname,
                        Title = title,
                        ELO = elo,
                    });
                }

                return players;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                reader.Close();
            }
        }

        public bool CreatePlayer(Player player)
        {
            if (player.Name == "" || player.Surname == "" || player.ImageURL == "" || player.Title == "" || player.Location == null)
            {
                return false;
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into sahista values(@tf, @elo, @name, @srnm, @lok, @img);";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@tf", player.Title);
            command.Parameters.AddWithValue("@elo", player.ELO);
            command.Parameters.AddWithValue("@name", player.Name);
            command.Parameters.AddWithValue("@srnm", player.Surname);
            command.Parameters.AddWithValue("@lok", player.Location.Id);
            command.Parameters.AddWithValue("@img", player.ImageURL);

            try
            {
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditPlayer(Player player)
        {
            if (player.Name == "" || player.Surname == "" || player.ImageURL == "" || player.Title == "" || player.Location == null)
            {
                return false;
            }

            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"update sahista set titula_fide = @tf, elo = @elo, ime = @name, prezime = @srnm, lokacija_id = @lok, sahista_slika = @img where sahista_id = @id;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@tf", player.Title);
            command.Parameters.AddWithValue("@elo", player.ELO);
            command.Parameters.AddWithValue("@name", player.Name);
            command.Parameters.AddWithValue("@srnm", player.Surname);
            command.Parameters.AddWithValue("@lok", player.Location.Id);
            command.Parameters.AddWithValue("@img", player.ImageURL);
            command.Parameters.AddWithValue("@id", player.Id);

            try
            {
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Game> GetGames(Tournament tournament)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select partija_id, runda, pgn, rezultat, otvaranje, datum, turnir.turnir_id, turnir.turnir_naziv, beli.sahista_id as beli_id, beli.ime as beli_ime, beli.prezime as beli_prezime, beli.titula_fide as beli_titula, crni.sahista_id as crni_id, crni.ime as crni_ime, crni.prezime as crni_prezime, crni.titula_fide as crni_titula from partija inner join turnir on turnir.turnir_id = partija.turnir_id inner join sahista as beli on beli.sahista_id = partija.beli_id inner join sahista as crni on crni.sahista_id = partija.crni_id where turnir.turnir_id = @tid;";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@tid", tournament.Id);
            SqlDataReader reader = command.ExecuteReader();

            try
            {
                List<Game> games = new List<Game>();

                while (reader.Read())
                {
                    int id = (int)reader["partija_id"];
                    int round = (int)reader["runda"];
                    string pgn = (string)reader["pgn"];
                    string result = (string)reader["rezultat"];
                    string date = ((DateTime)reader["datum"]).ToString("yyyy-MM-dd");
                    string opening = (string)reader["otvaranje"];
                    int tournamentId = (int)reader["turnir_id"];
                    string tournamentName = (string)reader["turnir_naziv"];
                    int whiteId = (int)reader["beli_id"];
                    string whiteName = (string)reader["beli_ime"];
                    string whiteSurname = (string)reader["beli_prezime"];
                    string whiteTitle = (string)reader["beli_titula"];
                    int blackId = (int)reader["crni_id"];
                    string blackName = (string)reader["crni_ime"];
                    string blackSurname = (string)reader["crni_prezime"];
                    string blackTitle = (string)reader["crni_titula"];
                    games.Add(new Game
                    {
                        Id = id,
                        Date = date,
                        Pgn = pgn,
                        Result = result,
                        Round = round,
                        Opening = opening,
                        Black = new Player
                        {
                            Id = blackId,
                            Name = blackName,
                            Surname = blackSurname,
                            Title = blackTitle,
                        },
                        White = new Player
                        {
                            Id = whiteId,
                            Name = whiteName,
                            Surname = whiteSurname,
                            Title = whiteTitle,
                        },
                        Tournament = new Tournament
                        {
                            Id = tournamentId,
                            Name = tournamentName,
                        }
                    });
                }

                return games;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return null;
            }
            finally
            {
                reader.Close();
            }
        }

        public void Rollback()
        {
            connection.Rollback();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }


        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }

    }
}

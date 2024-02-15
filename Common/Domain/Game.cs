using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Game : IEntity
    {
        public int Id { get; set; }
        public int Round { get; set; }
        public Player White { get; set; }
        public Player Black { get; set; }
        public string Pgn { get; set; }
        public string Result { get; set; }
        public string Date { get; set; }
        public string Opening { get; set; }
        public Tournament Tournament { get; set; }
        public string Summary { get => White.FullName + " " + Result + " " + Black.FullName; }

        public string TableName => "partija";

        public string InsertValues => "@runda, @bid, @cid, @pgn, @rez, @otv, @dat, @tid";

        public string IdColumnName => "partija_id";

        public string SelectFields => "partija_id, runda, pgn, rezultat, otvaranje, datum, turnir.turnir_id, turnir.turnir_naziv, beli.sahista_id as beli_id, beli.ime as beli_ime, beli.prezime as beli_prezime, beli.titula_fide as beli_titula, crni.sahista_id as crni_id, crni.ime as crni_ime, crni.prezime as crni_prezime, crni.titula_fide as crni_titula";

        public string Join => "inner join turnir on turnir.turnir_id = partija.turnir_id inner join sahista as beli on beli.sahista_id = partija.beli_id inner join sahista as crni on crni.sahista_id = partija.crni_id";

        public string UpdateValues => "runda = @runda, beli_id = @bid, crni_id = @cid, pgn = @pgn, rezultat = @rez, otvaranje = @otv, datum = @dat, turnir_id = @tid where partija_id = @pid";

        public string Order => "";

        public string Where => "where turnir.turnir_id = @tid";

        public string WhereSearch => "where turnir.turnir_id = @tid";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> games = new List<IEntity>();

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

        public void SelectParameters(SqlCommand command)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@tid", Tournament.Id);
        }

        public void SetParameters(SqlCommand command)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@pid", Id);
            command.Parameters.AddWithValue("@runda", Round);
            command.Parameters.AddWithValue("@pgn", Pgn);
            command.Parameters.AddWithValue("@rez", Result);
            command.Parameters.AddWithValue("@otv", Opening);
            command.Parameters.AddWithValue("@dat", Date);
            command.Parameters.AddWithValue("@bid", White.Id);
            command.Parameters.AddWithValue("@cid", Black.Id);
            command.Parameters.AddWithValue("@tid", Tournament.Id);
        }

        public bool Validate()
        {
            return !(White == null || Black == null || Pgn == "" || Result == "" || Date == "" || Opening == "" || Tournament == null);
        }
    }
}

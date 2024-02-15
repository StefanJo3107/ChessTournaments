using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Tournament : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public int Rounds { get; set; }
        public string ImageURL { get; set; }
        public TournamentType TournamentType { get; set; }
        public Location Location { get; set; }

        public string TableName => "turnir";

        public string InsertValues => "@tn, @td, @br, @lok, @ts, @tip";

        public string IdColumnName => "turnir_id";

        public string SelectFields => "turnir_id, turnir_naziv, turnir_datum, broj_rundi, turnir_slika, tip_naziv, naziv, turnir.tip_id, lokacija_id";

        public string Join => "inner join tip_turnira on turnir.tip_id = tip_turnira.tip_id inner join lokacija on turnir.lokacija_id = lokacija.id";

        public string UpdateValues => "turnir_naziv = @tn, turnir_datum = @td, broj_rundi = @br, lokacija_id = @lok, turnir_slika = @ts, tip_id = @tip where turnir_id = @id";

        public string Order => "";

        public string Where => "";

        public string WhereSearch => "where lower(turnir_naziv) LIKE @search";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> tournaments = new List<IEntity>();

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

        public void SelectParameters(SqlCommand command)
        {

        }

        public void SetParameters(SqlCommand command)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@tn", Name);
            command.Parameters.AddWithValue("@td", Date);
            command.Parameters.AddWithValue("@br", Rounds);
            command.Parameters.AddWithValue("@lok", Location.Id);
            command.Parameters.AddWithValue("@ts", ImageURL);
            command.Parameters.AddWithValue("@tip", TournamentType.Id);
            command.Parameters.AddWithValue("@id", Id);
        }

        public bool Validate()
        {
            return !(Name == "" || ImageURL == "" || Date == "" || Location == null || TournamentType == null);
        }
    }
}

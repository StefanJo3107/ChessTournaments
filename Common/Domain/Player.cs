using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Player : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public int ELO { get; set; }
        public Location Location { get; set; }

        public string FullName { get => Name + " " + Surname; }
        public Player Self { get { return this; } }

        public string TableName => "sahista";

        public string InsertValues => "@tf, @elo, @name, @srnm, @lok, @img";

        public string IdColumnName => "sahista_id";

        public string SelectFields => "sahista_id, titula_fide, elo, ime, prezime, sahista_slika, lokacija_id, naziv";

        public string Join => "inner join lokacija on sahista.lokacija_id=lokacija.id";

        public string UpdateValues => "titula_fide = @tf, elo = @elo, ime = @name, prezime = @srnm, lokacija_id = @lok, sahista_slika = @img where sahista_id = @id";

        public string Order => "order by elo desc";

        public string Where => "";

        public string WhereSearch => "where lower(concat(ime, concat(' ', prezime))) LIKE @search";

        public override bool Equals(object obj)
        {
            return obj is Player player &&
                   Name == player.Name &&
                   Surname == player.Surname;
        }

        public override int GetHashCode()
        {
            int hashCode = 1047523809;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ImageURL);
            hashCode = hashCode * -1521134295 + ELO.GetHashCode();
            return hashCode;
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> players = new List<IEntity>();

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

        public void SelectParameters(SqlCommand command)
        {

        }

        public void SetParameters(SqlCommand command)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@tf", Title);
            command.Parameters.AddWithValue("@elo", ELO);
            command.Parameters.AddWithValue("@name", Name);
            command.Parameters.AddWithValue("@srnm", Surname);
            command.Parameters.AddWithValue("@lok", Location.Id);
            command.Parameters.AddWithValue("@img", ImageURL);
            command.Parameters.AddWithValue("@id", Id);
        }

        public bool Validate()
        {
            return !(Name == "" || Surname == "" || ImageURL == "" || Title == "" || Location == null);
        }
    }
}

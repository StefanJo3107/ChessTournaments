using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Location : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Location Self { get { return this; } }

        public string TableName => "lokacija";

        public string InsertValues => "";

        public string IdColumnName => "id";

        public string Join => "";

        public string UpdateValues => "";

        public string SelectFields => "id, naziv";

        public string Order => "";

        public string Where => "";

        public string WhereSearch => "";

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id &&
                   Name == location.Name;
        }

        public override int GetHashCode()
        {
            int hashCode = -356797299;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<Location>.Default.GetHashCode(Self);
            return hashCode;
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> locations = new List<IEntity>();

            while (reader.Read())
            {
                int id = (int)reader["id"];
                string name = (string)reader["naziv"];

                locations.Add(new Location { Id = id, Name = name });
            }

            return locations;
        }

        public void SelectParameters(SqlCommand command)
        {

        }

        public void SetParameters(SqlCommand command)
        {

        }

        public bool Validate()
        {
            return true;
        }
    }
}

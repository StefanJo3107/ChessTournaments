using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class TournamentType : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TournamentType Self { get { return this; } }

        public string TableName => "tip_turnira";

        public string InsertValues => "";

        public string IdColumnName => "tip_id";

        public string SelectFields => "tip_id, tip_naziv";

        public string Join => "";

        public string UpdateValues => "";

        public string Order => "";

        public string Where => "";

        public string WhereSearch => "";

        public override bool Equals(object obj)
        {
            return obj is TournamentType type &&
                   Id == type.Id &&
                   Name == type.Name;
        }

        public override int GetHashCode()
        {
            int hashCode = -356797299;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<TournamentType>.Default.GetHashCode(Self);
            return hashCode;
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> types = new List<IEntity>();

            while (reader.Read())
            {
                int typeId = (int)reader["tip_id"];
                string typeName = (string)reader["tip_naziv"];

                types.Add(new TournamentType { Id = typeId, Name = typeName });
            }

            return types;
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

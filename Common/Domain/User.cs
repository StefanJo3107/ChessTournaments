using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Common.Domain
{
    [Serializable]
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }

        public string TableName => "korisnik";

        public string InsertValues => "@un, @pw, @sl";

        public string IdColumnName => "id";

        public string SelectFields => "id, username, password, salt";

        public string Join => "";

        public string UpdateValues => "";

        public string Where => "where username = @un";

        public string WhereSearch => "";

        public string Order => "";

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Username == user.Username;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> users = new List<IEntity>();
            while (reader.Read())
            {
                Id = (int)reader["id"];
                Password = (string)reader["password"];
                Salt = (string)reader["salt"];
                User user = new User { Id = Id, Username = Username, Password = Password, Salt = Salt };
                users.Add(user);
            }

            return users;
        }

        public void SelectParameters(SqlCommand command)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@un", Username);
        }

        public void SetParameters(SqlCommand command)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@un", Username);
            command.Parameters.AddWithValue("@pw", Password);
            command.Parameters.AddWithValue("@sl", Salt);
        }

        public bool Validate()
        {
            return true;
        }
    }
}

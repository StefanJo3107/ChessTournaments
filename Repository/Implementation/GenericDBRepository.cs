using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace Repository
{
    public class GenericDBRepository : IDBRepository<IEntity>
    {
        public User Login(User user)
        {
            SqlCommand command = DBConnectionFactory.Instance.GetDBConnection().CreateCommand();
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

            SqlCommand command = DBConnectionFactory.Instance.GetDBConnection().CreateCommand();
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

            command = DBConnectionFactory.Instance.GetDBConnection().CreateCommand();
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

        public bool Add(IEntity entity)
        {
            if (!entity.Validate())
            {
                return false;
            }

            SqlCommand command = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"insert into {entity.TableName} values ({entity.InsertValues})");
            entity.SetParameters(command);

            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                command.Dispose();
            }
        }

        public void Close()
        {
            DBConnectionFactory.Instance.GetDBConnection().Close();
        }

        public void Commit()
        {
            DBConnectionFactory.Instance.GetDBConnection().Commit();
        }

        public bool Delete(IEntity entity)
        {
            SqlCommand command = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"delete from {entity.TableName} where {entity.IdColumnName} = {entity.Id}");
            entity.SetParameters(command);

            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                command.Dispose();
            }
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            SqlCommand command = DBConnectionFactory.Instance.GetDBConnection().CreateCommand();
            command.CommandText = $"select {entity.SelectFields} from {entity.TableName} {entity.Join} {entity.Where} {entity.Order}";
            entity.SelectParameters(command);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                List<IEntity> entities = entity.GetReaderList(reader);
                return entities;
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

        public void Rollback()
        {
            DBConnectionFactory.Instance.GetDBConnection().Rollback();
        }

        public List<IEntity> Search(IEntity entity, string criteria)
        {
            SqlCommand command = DBConnectionFactory.Instance.GetDBConnection().CreateCommand();
            command.CommandText = $"select {entity.SelectFields} from {entity.TableName} {entity.Join} {entity.WhereSearch} {entity.Order}";
            entity.SelectParameters(command);
            command.Parameters.AddWithValue("@search", "%" + criteria + "%");
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                List<IEntity> entities = entity.GetReaderList(reader);
                return entities;
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

        public bool Update(IEntity entity)
        {
            if (!entity.Validate())
            {
                return false;
            }

            SqlCommand command = DBConnectionFactory.Instance.GetDBConnection().CreateCommand($"update {entity.TableName} set {entity.UpdateValues}");
            entity.SetParameters(command);

            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                command.Dispose();
            }
        }
    }
}

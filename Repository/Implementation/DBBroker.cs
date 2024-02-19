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
    public class DBBroker : IDBRepository<IEntity>
    {
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

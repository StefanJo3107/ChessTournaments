using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public interface IEntity
    {
        int Id { get; set; }
        string TableName { get; }
        string InsertValues { get; }
        string IdColumnName { get; }
        string SelectFields { get; }
        string Join { get; }
        string UpdateValues { get; }
        string Where { get; }
        string WhereSearch { get; }
        string Order { get; }
        void SetParameters(SqlCommand command);
        void SelectParameters(SqlCommand command);
        List<IEntity> GetReaderList(SqlDataReader reader);
        bool Validate();
    }
}

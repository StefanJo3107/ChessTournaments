using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;
using Repository;

namespace SystemOperation
{
    public abstract class SystemOperationBase
    {
        protected IDBRepository<IEntity> repository;

        public SystemOperationBase()
        {
            repository = new DBBroker();
        }

        public void ExecuteTemplate()
        {
            try
            {
                ExecuteConcreteOperation();
                repository.Commit();
            }
            catch (Exception)
            {
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.Close();
            }
        }

        protected abstract void ExecuteConcreteOperation();
    }
}

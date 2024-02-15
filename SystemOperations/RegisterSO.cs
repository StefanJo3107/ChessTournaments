using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace SystemOperation
{
    public class RegisterSO : SystemOperationBase
    {
        private readonly User user;
        public User Result { get; set; }

        public RegisterSO(User user)
        {
            this.user = user;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = repository.Register(user);
        }
    }
}

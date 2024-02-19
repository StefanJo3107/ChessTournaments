using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;
using SystemOperations;

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
            var users = repository.GetAll(user);
            if(users.Count > 0)
            {
                Result = null;
                return;
            }

            string salt = HelperSO.GenerateSalt();
            user.Password = HelperSO.ComputeHash(Encoding.UTF8.GetBytes(user.Password), Encoding.UTF8.GetBytes(salt));
            user.Salt = salt;
            var res = repository.Add(user);
            if (res)
            {
                Result = user;
            }
            else
            {
                Result = null;
            }
        }
    }
}

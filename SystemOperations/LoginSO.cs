using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;
using SystemOperations;

namespace SystemOperation
{
    public class LoginSO : SystemOperationBase
    {
        private readonly User user;
        public User Result { get; set; }

        public LoginSO(User user)
        {
            this.user = user;
        }

        protected override void ExecuteConcreteOperation()
        {
            var password = user.Password;
            var users = repository.GetAll(user);
            if (users == null || users.Count != 1) {
                Result = null;
            }
            else
            {
                User found = (User)users[0];
                user.Salt = found.Salt;
                string inputPassword = HelperSO.ComputeHash(Encoding.UTF8.GetBytes(password), Encoding.UTF8.GetBytes(user.Salt));
                if (inputPassword == found.Password)
                {
                    Result = found;
                    return;
                }
            }

            Result = null;
        }
    }
}

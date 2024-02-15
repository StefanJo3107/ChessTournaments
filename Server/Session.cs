using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace Server
{
    public static class Session
    {
        public static List<User> activeUsers = new List<User>();
    }
}

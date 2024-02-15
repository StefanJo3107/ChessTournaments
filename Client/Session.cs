using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Domain;

namespace Client
{
    public static class Session
    {
        public static User activeUser = null;
        public static BindingList<Game> games = new BindingList<Game>();
    }
}

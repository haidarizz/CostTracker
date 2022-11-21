using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Npgsql;

namespace CostTracker
{
    class User
    {
        private string _id_user;
        private string _name;
        private string _email;
        private string _password;

        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }
        public string ID_user { get => _id_user; set => _id_user = value; }

        public User(string _id_user, string _name, string _email)
        {
            ID_user = _id_user;
            Name = _name;
            Email = _email;
        }
    }
}

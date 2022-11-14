﻿using System;
using System.Collections.Generic;
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
        public NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=costtracker;Password=junpro;Database=costtracker";
        public static NpgsqlCommand cmd;
        private string sql = null;

        private string _id_user;
        private string _name;
        private string _email;
        private string _password;

        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string ID_user { get { return _id_user; } set { _id_user = value; } }

        public void signUp(string Name, string Email, string Password)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = @"select * from ct_insert(:_name,:_email,:_password)";

                _name = Name;
                _email = Email;
                _password = Password;

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_name", _name);
                cmd.Parameters.AddWithValue("_email", _email);
                cmd.Parameters.AddWithValue("_password", _password);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Berhasil");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void login(string Email, string Password)
        {
           
        }
    }
}

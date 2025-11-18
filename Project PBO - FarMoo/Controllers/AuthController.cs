using Npgsql;
using Project_PBO___FarMoo.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PBO___FarMoo.Controllers
{
    internal class AuthController
    {
        private DbContext _db = new DbContext();

        public bool Login(string user, string pass)
        {
            _db.Open();

            string query = "SELECT * FROM users WHERE username=@u AND password=@p";

            using (var cmd = new NpgsqlCommand(query, _db.Connection))
            {
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        _db.Close();
                        return true;
                    }
                }
            }

            _db.Close();
            return false;
        }
    }
}

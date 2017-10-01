using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace pgsqlProject
{
    public class procedure
    {
        NpgsqlConnection conn;

        public procedure()
        {
            connect();
        }

        void connect()
        {
            conn = new NpgsqlConnection("Server="+config.ip+ "; Port=" + config.port + "; User Id=" + config.login + "; Password=" + config.password + "; Database=" + config.database + "");
        }

        public bool test()
        {
            bool boolfound = false;

            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM journal", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                boolfound = true;
                Console.WriteLine("connection established");
            }
            if (boolfound == false)
            {
                Console.WriteLine("Data does not exist");
            }
            dr.Close();

            conn.Close();
            return boolfound;
        }
    }
}

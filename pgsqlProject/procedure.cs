using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Security.Cryptography;
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
            conn = new NpgsqlConnection("Server="+config.server+ "; Port=" + config.port + "; User Id=" + config.login + "; Password=" + config.password + "; Database=" + config.database + "");
        }

        public DataTable login(string login, string password)
        {
            DataTable dtData = new DataTable();
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.user WHERE login = '" + login + "' and password = '" + sha256_hash(password + "@216") + "'", conn);
            dtData.Load(cmd.ExecuteReader());

            conn.Close();
            return dtData;
        }

        public DataTable getSDriver()
        {
            DataTable dtData = new DataTable();
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.auto_personnel ORDER BY first_name", conn);
            dtData.Load(cmd.ExecuteReader());

            conn.Close();
            return dtData;
        }

        public void setSDriver(int id, string firstName, string lastName, string partherName)
        {
            string query = "";
            conn.Open();

            if (id == -1)
                query = "INSERT INTO public.auto_personnel (first_name, last_name, parther_name) VALUES ('" + firstName + "','" + lastName + "','" + partherName + "')";
            else
                query = "UPDATE public.auto_personnel SET first_name = '" + firstName + "', last_name = '" + lastName + "', parther_name = '" + partherName + "' where id = " + id + "";

            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public bool test()
        {
            bool boolfound = false;
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.user", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                boolfound = true;

                Console.WriteLine("Подключение успешно");
            }
            if (boolfound == false)
            {
                Console.WriteLine("Данные не полученны");
            }
            dr.Close();

            conn.Close();

            Console.WriteLine(sha256_hash("sormat7511@216"));

            return boolfound;
        }

        private String sha256_hash(string value)
        {
            StringBuilder Sb = new StringBuilder();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}

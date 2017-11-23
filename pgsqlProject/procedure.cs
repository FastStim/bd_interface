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

        private void connect()
        {
            conn = new NpgsqlConnection("Server="+config.server+ "; Port=" + config.port + "; User Id=" + config.login + "; Password=" + config.password + "; Database=" + config.database + "");
        }

        private bool openConnect()
        {
            bool error = true;

            try
            {
                conn.Open();
            }
            catch
            {
                error = false;
            }

            return error;
        }

        private bool closeConnect()
        {
            bool error = true;

            try
            {
                conn.Close();
            }
            catch
            {
                error = false;
            }

            return error;
        }

        public DataTable login(string login, string password)
        {
            DataTable dtData = new DataTable();
            if (openConnect())
            { 
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.user WHERE login = '" + login + "' and password = '" + sha256_hash(password + "@216") + "'", conn);
                dtData.Load(cmd.ExecuteReader());
                closeConnect();
            }
            
            return dtData;
        }

        public DataTable getSDriver()
        {
            DataTable dtData = new DataTable();
            if (openConnect())
            {
                string query;
                query =  "SELECT a.*, CASE WHEN b.id is null THEN 0 ELSE 1 END e_car FROM public.auto_personnel a";
                query += " LEFT JOIN public.auto b on b.personnel_id = a.id";
                query += " ORDER BY first_name";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                dtData.Load(cmd.ExecuteReader());

                closeConnect();
            }

            return dtData;
        }

        public void setSDriver(int id, string firstName, string lastName, string partherName)
        {
            if (openConnect())
            {
                string query = "";

                if (id == -1)
                    query = "INSERT INTO public.auto_personnel (first_name, last_name, parther_name) VALUES ('" + firstName + "','" + lastName + "','" + partherName + "')";
                else
                    query = "UPDATE public.auto_personnel SET first_name = '" + firstName + "', last_name = '" + lastName + "', parther_name = '" + partherName + "' where id = " + id + "";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                closeConnect();
            }
        }

        public void delSDriver(int id)
        {
            if (openConnect())
            {
                string query = "";

                query = "DELETE FROM public.auto_personnel WHERE id =" + id;

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                closeConnect();
            }
        }

        public DataTable getSAuto()
        {
            DataTable dtData = new DataTable();
            if (openConnect())
            {
                string query;
                query = "SELECT a.*, CASE WHEN b.id is null THEN 0 ELSE 1 END e_car FROM public.auto a";
                query += " LEFT JOIN public.journal b on b.auto_id = a.id";
                query += " ORDER BY num";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                dtData.Load(cmd.ExecuteReader());

                closeConnect();
            }

            return dtData;
        }

        public void setSAuto(int id, string num, string color, string mark)
        {
            if (openConnect())
            {
                string query = "";

                //if (id == -1)
                //    query = "INSERT INTO public.auto (first_name, last_name, parther_name) VALUES ('" + firstName + "','" + lastName + "','" + partherName + "')";
                //else
                //    query = "UPDATE public.auto_personnel SET first_name = '" + firstName + "', last_name = '" + lastName + "', parther_name = '" + partherName + "' where id = " + id + "";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                closeConnect();
            }
        }

        public DataTable getSRoutes()
        {
            DataTable dtData = new DataTable();
            if (openConnect())
            {
                string query;
                query = "SELECT a.*, CASE WHEN b.id is null THEN 0 ELSE 1 END e_routes FROM public.routes a";
                query += " LEFT JOIN public.journal b on b.routes_id = a.id";
                query += " ORDER BY name";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                dtData.Load(cmd.ExecuteReader());

                closeConnect();
            }

            return dtData;
        }

        public bool test()
        {
            bool boolfound = false;
            if (openConnect())
            {

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

                closeConnect();
            }

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

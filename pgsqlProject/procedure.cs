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
                query += " LEFT JOIN (select max(id) id, personnel_id from public.auto group by personnel_id) b on b.personnel_id = a.id";
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

        public void setSAuto(int id, string num, string color, string mark, int personnel_id)
        {
            if (openConnect())
            {
                string query = "";

                if (id == -1)
                    query = "INSERT INTO public.auto (num, color, mark, personnel_id) VALUES ('" + num + "','" + color + "','" + mark + "'," + personnel_id + ")";
                else
                    query = "UPDATE public.auto SET color = '" + color + "', mark = '" + mark + "', personnel_id = " + personnel_id + " where id = " + id + "";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                closeConnect();
            }
        }
        
        public void setSRoutes(int id, string name)
        {
            if (openConnect())
            {
                string query = "";

                if (id == -1)
                    query = "INSERT INTO public.routes (name) VALUES ('" + name + "')";
                else
                    query = "UPDATE public.routes SET name = '" + name + "' where id = " + id + "";

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

                query = "DELETE FROM public.auto_personnel WHERE id = " + id;

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                closeConnect();
            }
        }

        public void delSAuto(int id)
        {
            if (openConnect())
            {
                string query = "";

                query = "DELETE FROM public.auto WHERE id = " + id;

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                closeConnect();
            }
        }

        public void delSRoutes(int id)
        {
            if (openConnect())
            {
                string query = "";

                query = "DELETE FROM public.routes WHERE id = " + id;

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
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
                query += " LEFT JOIN (select max(id) id, auto_id from public.journal group by auto_id) b on b.auto_id = a.id";
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
                query += " LEFT JOIN (select max(id) id, routes_id from public.journal group by routes_id) b on b.routes_id = a.id";
                query += " ORDER BY name";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                dtData.Load(cmd.ExecuteReader());

                closeConnect();
            }

            return dtData;
        }

        public DataTable getJournal()
        {
            DataTable dtData = new DataTable();
            if (openConnect())
            {
                string query;
                query = "SELECT a.id, a.time_in, a.time_out, b.num, b.color, b.mark, c.first_name, c.last_name, c.parther_name, d.name FROM public.journal a";
                query += " LEFT JOIN public.auto b on b.id = a.auto_id";
                query += " LEFT JOIN public.auto_personnel c on c.id = b.personnel_id";
                query += " LEFT JOIN public.routes d on d.id = a.routes_id";
                query += " ORDER BY a.time_out";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                dtData.Load(cmd.ExecuteReader());

                closeConnect();
            }

            return dtData;
        }

        public DataTable getListDriver()
        {
            DataTable dtData = new DataTable();
            if (openConnect())
            {
                string query;
                query = "SELECT a.id, (first_name || ' ' || last_name || ' ' || parther_name) as name FROM public.auto_personnel a";
                query += " INNER JOIN (select max(id) id, personnel_id from public.auto group by personnel_id) b on a.id = b.personnel_id";
                query += " ORDER BY first_name, last_name, parther_name";
               
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                dtData.Load(cmd.ExecuteReader());

                closeConnect();
            }

            return dtData;
        }

        public DataTable getListAllDriver()
        {
            DataTable dtData = new DataTable();
            if (openConnect())
            {
                string query;
                query = "SELECT id, (first_name || ' ' || last_name || ' ' || parther_name) as name FROM public.auto_personnel";
                query += " ORDER BY first_name, last_name, parther_name";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                dtData.Load(cmd.ExecuteReader());

                closeConnect();
            }

            return dtData;
        }

        public DataTable getListAuto(int id)
        {
            DataTable dtData = new DataTable();
            if (openConnect())
            {
                string query;
                query = "SELECT id, (mark || ' ' || num || ' ' || color) as name FROM public.auto WHERE personnel_id = " + id;
                query += " ORDER BY mark, num, color";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                dtData.Load(cmd.ExecuteReader());

                closeConnect();
            }

            return dtData;
        }

        public int getCountJournal()
        {
            int count = 0;

            if (openConnect())
            {
                string query;
                query = "SELECT count(id) as count FROM public.journal";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                DataTable dtData = new DataTable();
                dtData.Load(cmd.ExecuteReader());
                count = int.Parse(dtData.Rows[0]["count"].ToString());
                closeConnect();
            }

            return count;
        }

        public void setNewJournal(int idRoutes, int idAuto)
        {
            if (openConnect())
            {
                string query = "";
                query = "INSERT INTO public.journal (time_in, auto_id, routes_id) VALUES ('" + DateTime.Now + "','" + idAuto + "','" + idRoutes + "')";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                closeConnect();
            }
        }

        public void setNewJournal(int id)
        {
            if (openConnect())
            {
                string query = "";
                query = "UPDATE public.journal SET time_out = '" + DateTime.Now + "' where id = " + id + "";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                closeConnect();
            }
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

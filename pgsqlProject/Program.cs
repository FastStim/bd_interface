using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pgsqlProject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Стандартные настройки программы при запуске
            config.ip = Properties.Resources.ip;
            config.login = Properties.Resources.login;
            config.password = Properties.Resources.password;
            config.database = Properties.Resources.database;
            config.port = Properties.Resources.port;

            //Проверка работоспособности
            procedure sql = new procedure();
            sql.test();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main());
        }
    }
}

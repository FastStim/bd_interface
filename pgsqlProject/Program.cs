using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

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
            //ini file
            try
            {
                var parser = new FileIniDataParser();
                IniData f = parser.ReadFile("config.ini");
                config.server = f["config"]["server"];
                config.login = f["config"]["login"];
                config.password = f["config"]["password"];
                config.database = f["config"]["database"];
                config.port = f["config"]["port"];
                config.mode = "С";
                config.path = Application.StartupPath;
            }
            catch
            {
                MessageBox.Show("Ошибка подключения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            //Проверка работоспособности
            procedure sql = new procedure();
            if (sql.test())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new main());
            }
            else
            {
                MessageBox.Show("Ошибка подключения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}

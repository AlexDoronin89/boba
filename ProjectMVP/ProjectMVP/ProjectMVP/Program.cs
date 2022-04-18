using ProjectMVP.Model;
using ProjectMVP.Presenter;
using ProjectMVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMVP
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Warehouse warehouse = new Warehouse(new List<Rack>());
            FormMain formMain = new FormMain();
            MainPresenter mainPresenter = new MainPresenter(warehouse, formMain);
            Application.Run(formMain);
        }
    }
}

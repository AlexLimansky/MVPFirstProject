using System;
using System.Windows.Forms;
using Services.Models;
using Services.Presenters;

namespace Forms
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
            var bf = new BookForm();
            var pr = new BookPresenter(new BookServices(), bf);
            Application.Run(bf);
        }
    }
}

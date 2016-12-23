using Services;
using Services.Models;
using Services.Presenters;

namespace MVPtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var cw = new ConsoleView();
            var pr = new BookPresenter(new BookServices(), cw);
            cw.Start();
        }
    }
}

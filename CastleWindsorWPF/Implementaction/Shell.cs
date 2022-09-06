using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleWindsorWPF.Implementaction
{
    public class Shell : IShell
    {
        public Shell(MainWindow window)
        {
            window.Title = "";
        }

        public virtual MainWindow window { get; set; }
        public void Run()
        {
            window.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCafe_Console
{
    public class KCafeConsole
    {
        static void Main(string[] args)
        {
            ShowContents ui = new ShowContents();
            ui.Run();
        }
    }
}

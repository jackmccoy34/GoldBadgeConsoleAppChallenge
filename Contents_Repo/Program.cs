using Contents_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_UI
{
    class Program
    {
        private readonly Dictionary<int, List<string>> internalDictionary;
        static void Main(string[] args)
        {
            MainUI ui = new MainUI();
            ui.Run();
        }
    }
}

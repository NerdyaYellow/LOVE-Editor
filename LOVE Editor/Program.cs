using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOVE_Editor
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        public static Editor editor = new();
        public static CreateBlock createblock = new();
        public static Output output = new();
        public static Exception exception = new();

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(editor);
        }
    }
}

using ImageMagick;
using System;
using System.IO;
using System.Windows.Forms;

namespace Converter
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var ghostscriptPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "vendor", "Ghostscript", "bin"
            );

            MagickNET.SetGhostscriptDirectory(ghostscriptPath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}

using PL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PL
{
    static class ProgramMain
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Podcasts());
        }
    }
}

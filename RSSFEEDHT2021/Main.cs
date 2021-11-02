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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitIdentityManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            if(args.Length > 0 && args[0] == "check")
            {
                var name = GitIdentityManager.Git("config --local user.name");
                var email = GitIdentityManager.Git("config --local user.email");
                return string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ? 1 : 0;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GitIdentityManager());
            return 1;
        }
    }
}

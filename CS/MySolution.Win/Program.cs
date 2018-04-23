using System;
using System.Configuration;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;

namespace MySolution.Win {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MySolutionWindowsFormsApplication winApplication = new MySolutionWindowsFormsApplication();
            winApplication.ConnectionString = 
                "Integrated Security=SSPI;Pooling=false;Data Source=(local);Initial Catalog=ModelFirstEntityFrameworkExample";
            try {
                winApplication.Setup();
                winApplication.Start();
            }
            catch (Exception e) {
                winApplication.HandleException(e);
            }
        }
    }
}

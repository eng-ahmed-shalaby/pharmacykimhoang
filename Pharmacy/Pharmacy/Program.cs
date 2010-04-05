using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Pharmacy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TRIAL.TrialMaker.SoftwareLocker.TrialMaker t = new TRIAL.TrialMaker.SoftwareLocker.TrialMaker("Pharmacy", Application.StartupPath + "\\RegFile.reg",
                Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\Sys.dbf",
                "Tel: 0907 834 516\nEmail: kimhoangad@yahoo.com\nWebSite:http:\\kimhoangad.com.vn",
                5, 10, "745");
            byte[] MyOwnKey = { 97, 250, 1, 5, 84, 21, 7, 63,
            4, 54, 87, 56, 123, 10, 3, 62,
            7, 9, 20, 36, 37, 21, 101, 57};
            t.TripleDESKey = MyOwnKey;

            TRIAL.TrialMaker.SoftwareLocker.TrialMaker.RunTypes RT = t.ShowDialog();
            bool is_trial = false;
            if (RT != TRIAL.TrialMaker.SoftwareLocker.TrialMaker.RunTypes.Expired)
            {
                if (RT == TRIAL.TrialMaker.SoftwareLocker.TrialMaker.RunTypes.Full)
                    is_trial = false;
                else
                    is_trial = true;

               // frmLogin fLogin = new frmLogin();
               // fLogin.IsTrial = is_trial;
                Application.Run(new frmLogin());
            }
        }
    }
}

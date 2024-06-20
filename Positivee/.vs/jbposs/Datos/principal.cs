
using jbposs.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jbposs.Datos
{
    internal static class principal
    {
        private static frmMain main;
        private static screenSale screen;

        public static void screenSaleShow(frmMain pMain, screenSale pScreen)
        {
            screen = pScreen;
            main = pMain;
            main.Hide();
            screen.Show();
        }
        public static void mainShow()
        {
           // screen.Dispose();
            main.Show();

        }

        public static void closeAll()
        {//descomentar al final
            screen.Dispose();
            main.log.Dispose();
            main.Dispose();

        }
        public static void setMainForm(frmMain _main)
        {
            main = _main;
        }
       public static frmMain getMainForm()
        {
            return main;
        }
        public static  void closeSession(frmMain pMain)
        {
            main = pMain;
            main.Dispose();
            screen.Dispose();
            LoginForm log = new LoginForm();
            log.Show();

        }
    }
}

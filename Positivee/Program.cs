﻿using Positive.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Positive
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Usuario us = new Usuario();

            Login aa = new Login();
            us.nombre_usuario = "ss";
            Menu_principal p = new Menu_principal();
            us.id_rol =3;
           Application.Run(new Pantalla_de_venta(p, us));
           //Application.Run(new Menu_principal());
        }
    }
}

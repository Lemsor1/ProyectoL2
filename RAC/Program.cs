using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAC
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu());

            //Application.Run(new FrmReporte());
        }

        public static byte[] imageToByteArray(Image imageIn)
        { 
            MemoryStream ms = new MemoryStream();

            imageIn.Save(ms, imageIn.RawFormat);

            return ms.ToArray();


        }

    }
}

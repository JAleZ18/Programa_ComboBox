using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    internal class AccionesComunes
    {
        public static void Mensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

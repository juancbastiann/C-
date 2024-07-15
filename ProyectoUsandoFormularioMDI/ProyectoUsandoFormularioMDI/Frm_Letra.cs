using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUsandoFormularioMDI
{
    public partial class Frm_Letra : Form
    {
        private static Frm_Letra instWindow = null;
        public Frm_Letra()
        {
            InitializeComponent();
        }

        public static Frm_Letra UnaWindow()
        {
            if (instWindow == null)
            {
                instWindow = new Frm_Letra();
                return instWindow;
            }
            return instWindow;
        }

        private void frm_Letra_Load(object sender, EventArgs e)
        {
        }
    }
}

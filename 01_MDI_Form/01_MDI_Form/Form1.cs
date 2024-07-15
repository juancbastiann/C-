using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_MDI_Form
{
  public partial class MDIForm : Form
  {
    public MDIForm()
    {
      InitializeComponent();
    }

    private void MDIForm_Load(object sender, EventArgs e)
    {

    }



    private void tipoDeLetraToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      Frm_TipoLetra frm_TLetra = Frm_TipoLetra.UnaVentana();
      frm_TLetra.MdiParent = this;
      frm_TLetra.Show();
    }
    private void letraToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Frm_Letra frm_letra = Frm_Letra.UnaWindow();
      frm_letra.MdiParent = this;
      frm_letra.Show();
    }
  }
}

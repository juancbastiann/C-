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
  public partial class Frm_Letra : Form
  {
    private static Frm_Letra instVentana = null;

    public Frm_Letra()
    {
      InitializeComponent();
    }

    public static Frm_Letra UnaWindow()
    {
      if (instVentana == null)
      {
        instVentana = new Frm_Letra();
        return instVentana;
      }
      return instVentana;
    }

    private void frm_Letra_Load(object sender, EventArgs e)
    {
    }
  }
}

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
  public partial class Frm_TipoLetra : Form
  {
    //defino variable de la clase para validar la instancia
    private static Frm_TipoLetra instVentana = null;

    public Frm_TipoLetra()
    {
      InitializeComponent();
    }

    //valida la creación de más de 1 instancia cuando creo el formulario
    public static Frm_TipoLetra UnaVentana()
    {
      if (instVentana == null)
      {
        instVentana = new Frm_TipoLetra();
        return instVentana;
      }
      return instVentana;
    }

    private void Frm_TipoLetra_Load(object sender, EventArgs e)
    {
    }
  }
}

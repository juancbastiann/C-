using System;
using System.Windows.Forms;

namespace WinFormApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      this.Text = "Nombres de los integrantes del equipo";
      this.Icon = new System.Drawing.Icon(@"Resources\usuario.ico");

      // Agregar el manejador de eventos Resize
      this.Resize += new EventHandler(Form1_Resize);
      CenterPictureBox();
    }

    private void Form1_Resize(object? sender, EventArgs e)
    {
      CenterPictureBox();
    }

    private void CenterPictureBox()
    {
      if (pictureBox != null)
      {
        pictureBox.Location = new System.Drawing.Point(
            (this.ClientSize.Width - pictureBox.Width) / 2,
            (this.ClientSize.Height - pictureBox.Height) / 2 - 30
        );
        label.Location = new System.Drawing.Point(
            (this.ClientSize.Width - label.Width) / 2,
            pictureBox.Bottom + 10
        );
      }
    }

    private void LetraMenu_Click(object sender, EventArgs e)
    {
      FormLetra formLetra = new FormLetra();
      formLetra.Show();
    }
  }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormApp
{
  public partial class FormTipoDeLetra : Form
  {
    private Label label = new Label();
    private ComboBox comboBoxFonts = new ComboBox();
    private Button buttonApply = new Button();

    public FormTipoDeLetra()
    {
      InitializeComponent();
    }

    private void InitializeComponent()
    {
      // 
      // label
      // 
      this.label.AutoSize = true;
      this.label.Location = new Point(20, 20);
      this.label.Name = "label";
      this.label.Size = new Size(200, 20);
      this.label.Text = "Seleccione el tipo de letra:";

      // 
      // comboBoxFonts
      // 
      this.comboBoxFonts.FormattingEnabled = true;
      this.comboBoxFonts.Location = new Point(20, 50);
      this.comboBoxFonts.Name = "comboBoxFonts";
      this.comboBoxFonts.Size = new Size(200, 21);
      this.comboBoxFonts.Items.AddRange(FontFamily.Families.Select(f => f.Name).ToArray());

      // 
      // buttonApply
      // 
      this.buttonApply.Location = new Point(20, 80);
      this.buttonApply.Name = "buttonApply";
      this.buttonApply.Size = new Size(75, 23);
      this.buttonApply.Text = "Aplicar";
      this.buttonApply.UseVisualStyleBackColor = true;
      this.buttonApply.Click += new EventHandler(this.ButtonApply_Click);

      // 
      // FormTipoDeLetra
      // 
      this.ClientSize = new Size(300, 150);
      this.Controls.Add(this.label);
      this.Controls.Add(this.comboBoxFonts);
      this.Controls.Add(this.buttonApply);
      this.Name = "FormTipoDeLetra";
      this.Text = "Ventana Tipo de Letra";
    }

    private void ButtonApply_Click(object sender, EventArgs e)
    {
      if (comboBoxFonts.SelectedItem != null)
      {
        string selectedFont = comboBoxFonts.SelectedItem.ToString() ?? "Arial"; // Manejo de valor predeterminado en caso de nulo
        this.Font = new Font(selectedFont, this.Font.Size);
        MessageBox.Show("El tipo de letra se ha aplicado: " + selectedFont, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        MessageBox.Show("Por favor, seleccione un tipo de letra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
  }
}

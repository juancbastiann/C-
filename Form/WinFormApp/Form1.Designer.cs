namespace WinFormApp
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private MenuStrip menuStrip;
    private ToolStripMenuItem mantenimientoMenu;
    private ToolStripMenuItem tipoDeLetraMenu;
    private ToolStripMenuItem letraMenu;
    private PictureBox pictureBox;
    private Label label;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.mantenimientoMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.tipoDeLetraMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.letraMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.pictureBox = new System.Windows.Forms.PictureBox();
      this.label = new System.Windows.Forms.Label();
      this.menuStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      this.SuspendLayout();

      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoMenu});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(800, 24);
      this.menuStrip.TabIndex = 0;
      this.menuStrip.Text = "menuStrip";

      // 
      // mantenimientoMenu
      // 
      this.mantenimientoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeLetraMenu,
            this.letraMenu});
      this.mantenimientoMenu.Name = "mantenimientoMenu";
      this.mantenimientoMenu.Size = new System.Drawing.Size(101, 20);
      this.mantenimientoMenu.Text = "Mantenimiento";

      // 
      // tipoDeLetraMenu
      // 
      this.tipoDeLetraMenu.Name = "tipoDeLetraMenu";
      this.tipoDeLetraMenu.Size = new System.Drawing.Size(141, 22);
      this.tipoDeLetraMenu.Text = "Tipo de Letra";
      this.tipoDeLetraMenu.Click += new System.EventHandler(this.TipoDeLetraMenu_Click);

      // 
      // letraMenu
      // 
      this.letraMenu.Name = "letraMenu";
      this.letraMenu.Size = new System.Drawing.Size(141, 22);
      this.letraMenu.Text = "Letra";
      // this.letraMenu.Click += new System.EventHandler(this.LetraMenu_Click);

      // 
      // pictureBox
      // 
      this.pictureBox.Image = System.Drawing.Image.FromFile(@"Resources\grupo.png");
      this.pictureBox.Location = new System.Drawing.Point((this.ClientSize.Width - 200) / 2, (this.ClientSize.Height - 200) / 2);
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.Size = new System.Drawing.Size(200, 200);
      this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox.TabIndex = 1;
      this.pictureBox.TabStop = false;

      // 
      // label
      // 
      this.label.AutoSize = true;
      this.label.BackColor = System.Drawing.Color.Transparent;
      this.label.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label.ForeColor = System.Drawing.Color.DarkBlue;
      this.label.Location = new System.Drawing.Point((this.ClientSize.Width - 300) / 2, this.pictureBox.Bottom + 10);
      this.label.Name = "label";
      this.label.Size = new System.Drawing.Size(241, 26);
      this.label.TabIndex = 2;
      this.label.Text = "Taller de Windows Forms";

      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label);
      this.Controls.Add(this.pictureBox);
      this.Controls.Add(this.menuStrip);
      this.MainMenuStrip = this.menuStrip;
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void TipoDeLetraMenu_Click(object sender, EventArgs e)
    {
      FormTipoDeLetra formTipoDeLetra = new FormTipoDeLetra();
      formTipoDeLetra.Show();
    }

    // private void LetraMenu_Click(object sender, EventArgs e)
    // {
    //     FormLetra formLetra = new FormLetra();
    //     formLetra.Show();
    // }

    public class ChildForm : Form
    {
      public ChildForm(string title)
      {
        this.Text = title;
        this.Size = new System.Drawing.Size(400, 300);
      }
    }
  }
}

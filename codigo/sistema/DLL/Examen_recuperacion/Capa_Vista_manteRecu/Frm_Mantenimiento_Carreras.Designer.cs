
namespace Capa_Vista_manteRecu
{
    partial class Frm_Mantenimiento_Carreras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navegador1 = new Capa_Vista_Navegador.Navegador();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.IPkId_Aplicacion = 0;
            this.navegador1.IPkId_Modulo = 0;
            this.navegador1.Location = new System.Drawing.Point(0, 3);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.SAlias = null;
            this.navegador1.SEtiquetas = null;
            this.navegador1.Size = new System.Drawing.Size(1573, 601);
            this.navegador1.SNombreTabla = null;
            this.navegador1.TabIndex = 0;
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.Image = global::Capa_Vista_manteRecu.Properties.Resources.help_question_16768;
            this.Btn_Ayuda.Location = new System.Drawing.Point(1290, 3);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(97, 111);
            this.Btn_Ayuda.TabIndex = 1;
            this.Btn_Ayuda.Text = "Ayuda";
            this.Btn_Ayuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Frm_Mantenimiento_Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 593);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.navegador1);
            this.Name = "Frm_Mantenimiento_Carreras";
            this.Text = "Frm_Mantenimiento_Carreras";
            this.ResumeLayout(false);

        }

        #endregion

        private Capa_Vista_Navegador.Navegador navegador1;
        private System.Windows.Forms.Button Btn_Ayuda;
    }
}
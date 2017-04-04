namespace SiCandi.Vistas
{
    partial class frmReportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRePorConvocatoria = new System.Windows.Forms.Button();
            this.btnRePorMunicipio = new System.Windows.Forms.Button();
            this.btnRePuntuacionMunicipio = new System.Windows.Forms.Button();
            this.btnReGanadorasMunicipio = new System.Windows.Forms.Button();
            this.btnCanPorCapturista = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reportes";
            // 
            // btnRePorConvocatoria
            // 
            this.btnRePorConvocatoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRePorConvocatoria.Location = new System.Drawing.Point(25, 94);
            this.btnRePorConvocatoria.Name = "btnRePorConvocatoria";
            this.btnRePorConvocatoria.Size = new System.Drawing.Size(543, 29);
            this.btnRePorConvocatoria.TabIndex = 4;
            this.btnRePorConvocatoria.Text = "Registro de candidatas por Convocatoria (año) ";
            this.btnRePorConvocatoria.UseVisualStyleBackColor = true;
            this.btnRePorConvocatoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRePorMunicipio
            // 
            this.btnRePorMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRePorMunicipio.Location = new System.Drawing.Point(25, 153);
            this.btnRePorMunicipio.Name = "btnRePorMunicipio";
            this.btnRePorMunicipio.Size = new System.Drawing.Size(543, 29);
            this.btnRePorMunicipio.TabIndex = 5;
            this.btnRePorMunicipio.Text = "Registro de candidatas por Municipio (año) ";
            this.btnRePorMunicipio.UseVisualStyleBackColor = true;
            // 
            // btnRePuntuacionMunicipio
            // 
            this.btnRePuntuacionMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRePuntuacionMunicipio.Location = new System.Drawing.Point(25, 213);
            this.btnRePuntuacionMunicipio.Name = "btnRePuntuacionMunicipio";
            this.btnRePuntuacionMunicipio.Size = new System.Drawing.Size(543, 29);
            this.btnRePuntuacionMunicipio.TabIndex = 6;
            this.btnRePuntuacionMunicipio.Text = "Candidatas (3) con las más alta puntuación de cada uno de los municipios. ";
            this.btnRePuntuacionMunicipio.UseVisualStyleBackColor = true;
            this.btnRePuntuacionMunicipio.Click += new System.EventHandler(this.btnRePuntuacionMunicipio_Click);
            // 
            // btnReGanadorasMunicipio
            // 
            this.btnReGanadorasMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReGanadorasMunicipio.Location = new System.Drawing.Point(25, 275);
            this.btnReGanadorasMunicipio.Name = "btnReGanadorasMunicipio";
            this.btnReGanadorasMunicipio.Size = new System.Drawing.Size(543, 28);
            this.btnReGanadorasMunicipio.TabIndex = 7;
            this.btnReGanadorasMunicipio.Text = "Candidatas ganadoras por municipio.";
            this.btnReGanadorasMunicipio.UseVisualStyleBackColor = true;
            this.btnReGanadorasMunicipio.Click += new System.EventHandler(this.btnReGanadorasMunicipio_Click);
            // 
            // btnCanPorCapturista
            // 
            this.btnCanPorCapturista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanPorCapturista.Location = new System.Drawing.Point(25, 335);
            this.btnCanPorCapturista.Name = "btnCanPorCapturista";
            this.btnCanPorCapturista.Size = new System.Drawing.Size(543, 28);
            this.btnCanPorCapturista.TabIndex = 8;
            this.btnCanPorCapturista.Text = "Candidatas capturadas por Capturista.";
            this.btnCanPorCapturista.UseVisualStyleBackColor = true;
            this.btnCanPorCapturista.Click += new System.EventHandler(this.btnCanPorCapturista_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SiCandi.Properties.Resources.bARRA_GRIS;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 388);
            this.Controls.Add(this.btnCanPorCapturista);
            this.Controls.Add(this.btnReGanadorasMunicipio);
            this.Controls.Add(this.btnRePuntuacionMunicipio);
            this.Controls.Add(this.btnRePorMunicipio);
            this.Controls.Add(this.btnRePorConvocatoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRePorConvocatoria;
        private System.Windows.Forms.Button btnRePorMunicipio;
        private System.Windows.Forms.Button btnRePuntuacionMunicipio;
        private System.Windows.Forms.Button btnReGanadorasMunicipio;
        private System.Windows.Forms.Button btnCanPorCapturista;
    }
}
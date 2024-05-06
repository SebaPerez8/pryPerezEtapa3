namespace pryPerezEtapa3
{
    partial class frmEtapa3
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picImagen = new PictureBox();
            btnAuto = new Button();
            txtNombre = new TextBox();
            txtTipo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAvion = new Button();
            btnBarco = new Button();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // picImagen
            // 
            picImagen.Location = new Point(29, 33);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(302, 250);
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(357, 253);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(79, 30);
            btnAuto.TabIndex = 1;
            btnAuto.Text = "auto";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Location = new Point(428, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(125, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtTipo
            // 
            txtTipo.BackColor = Color.White;
            txtTipo.Location = new Point(428, 134);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(125, 23);
            txtTipo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(471, 116);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 4;
            label1.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(471, 57);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // btnAvion
            // 
            btnAvion.Location = new Point(443, 253);
            btnAvion.Name = "btnAvion";
            btnAvion.Size = new Size(79, 30);
            btnAvion.TabIndex = 6;
            btnAvion.Text = "avion";
            btnAvion.UseVisualStyleBackColor = true;
            btnAvion.Click += btnAvion_Click;
            // 
            // btnBarco
            // 
            btnBarco.Location = new Point(533, 253);
            btnBarco.Name = "btnBarco";
            btnBarco.Size = new Size(79, 30);
            btnBarco.TabIndex = 7;
            btnBarco.Text = "barco";
            btnBarco.UseVisualStyleBackColor = true;
            btnBarco.Click += btnBarco_Click;
            // 
            // frmEtapa3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 318);
            Controls.Add(btnBarco);
            Controls.Add(btnAvion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTipo);
            Controls.Add(txtNombre);
            Controls.Add(btnAuto);
            Controls.Add(picImagen);
            Name = "frmEtapa3";
            Text = "Etapa 3 - CREAR OBJETOS POR CÓDIGO";
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picImagen;
        private Button btnAuto;
        private TextBox txtNombre;
        private TextBox txtTipo;
        private Label label1;
        private Label label2;
        private Button btnAvion;
        private Button btnBarco;
    }
}

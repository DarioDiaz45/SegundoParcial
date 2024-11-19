namespace SegundoParcialRombo.Windows
{
    partial class frmRombosAE
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
            components = new System.ComponentModel.Container();
            lblDiagonalMayor = new Label();
            lblDiagonalMenor = new Label();
            groupBox1 = new GroupBox();
            rbtRayado = new RadioButton();
            rbtDoble = new RadioButton();
            rbtPunteado = new RadioButton();
            rbtSolido = new RadioButton();
            lblColor = new Label();
            txtDMayor = new TextBox();
            txtDMenor = new TextBox();
            cboColores = new ComboBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblDiagonalMayor
            // 
            lblDiagonalMayor.AutoSize = true;
            lblDiagonalMayor.Location = new Point(16, 19);
            lblDiagonalMayor.Name = "lblDiagonalMayor";
            lblDiagonalMayor.Size = new Size(91, 15);
            lblDiagonalMayor.TabIndex = 0;
            lblDiagonalMayor.Text = "Diagonal Mayor";
            // 
            // lblDiagonalMenor
            // 
            lblDiagonalMenor.AutoSize = true;
            lblDiagonalMenor.Location = new Point(16, 45);
            lblDiagonalMenor.Name = "lblDiagonalMenor";
            lblDiagonalMenor.Size = new Size(92, 15);
            lblDiagonalMenor.TabIndex = 0;
            lblDiagonalMenor.Text = "Diagonal Menor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtRayado);
            groupBox1.Controls.Add(rbtDoble);
            groupBox1.Controls.Add(rbtPunteado);
            groupBox1.Controls.Add(rbtSolido);
            groupBox1.Location = new Point(16, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 140);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contornos";
            // 
            // rbtRayado
            // 
            rbtRayado.AutoSize = true;
            rbtRayado.Location = new Point(13, 103);
            rbtRayado.Name = "rbtRayado";
            rbtRayado.Size = new Size(64, 19);
            rbtRayado.TabIndex = 0;
            rbtRayado.TabStop = true;
            rbtRayado.Text = "Rayado";
            rbtRayado.UseVisualStyleBackColor = true;
            // 
            // rbtDoble
            // 
            rbtDoble.AutoSize = true;
            rbtDoble.Location = new Point(13, 78);
            rbtDoble.Name = "rbtDoble";
            rbtDoble.Size = new Size(56, 19);
            rbtDoble.TabIndex = 0;
            rbtDoble.TabStop = true;
            rbtDoble.Text = "Doble";
            rbtDoble.UseVisualStyleBackColor = true;
            // 
            // rbtPunteado
            // 
            rbtPunteado.AutoSize = true;
            rbtPunteado.Location = new Point(13, 53);
            rbtPunteado.Name = "rbtPunteado";
            rbtPunteado.Size = new Size(76, 19);
            rbtPunteado.TabIndex = 0;
            rbtPunteado.TabStop = true;
            rbtPunteado.Text = "Punteado";
            rbtPunteado.UseVisualStyleBackColor = true;
            // 
            // rbtSolido
            // 
            rbtSolido.AutoSize = true;
            rbtSolido.Location = new Point(13, 28);
            rbtSolido.Name = "rbtSolido";
            rbtSolido.Size = new Size(58, 19);
            rbtSolido.TabIndex = 0;
            rbtSolido.TabStop = true;
            rbtSolido.Text = "Solido";
            rbtSolido.UseVisualStyleBackColor = true;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(16, 258);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(36, 15);
            lblColor.TabIndex = 2;
            lblColor.Text = "Color";
            // 
            // txtDMayor
            // 
            txtDMayor.Location = new Point(113, 16);
            txtDMayor.Name = "txtDMayor";
            txtDMayor.Size = new Size(100, 23);
            txtDMayor.TabIndex = 3;
            // 
            // txtDMenor
            // 
            txtDMenor.Location = new Point(113, 42);
            txtDMenor.Name = "txtDMenor";
            txtDMenor.Size = new Size(100, 23);
            txtDMenor.TabIndex = 3;
            // 
            // cboColores
            // 
            cboColores.FormattingEnabled = true;
            cboColores.Location = new Point(58, 255);
            cboColores.Name = "cboColores";
            cboColores.Size = new Size(121, 23);
            cboColores.TabIndex = 4;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(40, 316);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 78);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(184, 316);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 78);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRombosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 406);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(cboColores);
            Controls.Add(txtDMenor);
            Controls.Add(txtDMayor);
            Controls.Add(lblColor);
            Controls.Add(groupBox1);
            Controls.Add(lblDiagonalMenor);
            Controls.Add(lblDiagonalMayor);
            Name = "frmRombosAE";
            Text = "frmRombosAE";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDiagonalMayor;
        private Label lblDiagonalMenor;
        private GroupBox groupBox1;
        private Label lblColor;
        private RadioButton rbtRayado;
        private RadioButton rbtDoble;
        private RadioButton rbtPunteado;
        private RadioButton rbtSolido;
        private TextBox txtDMayor;
        private TextBox txtDMenor;
        private ComboBox cboColores;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}
namespace LocalizaCEP
{
    partial class frmAvaliacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvaliacao));
            label1 = new Label();
            txtNota = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtBoxComentario = new TextBox();
            btnEnviar = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(101, 19);
            label1.Name = "label1";
            label1.Size = new Size(197, 31);
            label1.TabIndex = 3;
            label1.Text = "Informe sua nota:";
            // 
            // txtNota
            // 
            txtNota.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNota.Location = new Point(111, 84);
            txtNota.MaxLength = 1;
            txtNota.Name = "txtNota";
            txtNota.PlaceholderText = "Nota";
            txtNota.Size = new Size(137, 34);
            txtNota.TabIndex = 4;
            txtNota.KeyPress += txtNota_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(68, 50);
            label2.Name = "label2";
            label2.Size = new Size(263, 31);
            label2.TabIndex = 5;
            label2.Text = "0 - Ruim, 5 - Muito Bom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(80, 131);
            label3.Name = "label3";
            label3.Size = new Size(239, 31);
            label3.TabIndex = 6;
            label3.Text = "Deixe seu comentário";
            // 
            // txtBoxComentario
            // 
            txtBoxComentario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxComentario.Location = new Point(83, 176);
            txtBoxComentario.Multiline = true;
            txtBoxComentario.Name = "txtBoxComentario";
            txtBoxComentario.PlaceholderText = "Descrição...";
            txtBoxComentario.Size = new Size(233, 145);
            txtBoxComentario.TabIndex = 7;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.FromArgb(39, 174, 96);
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviar.Location = new Point(132, 327);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(124, 42);
            btnEnviar.TabIndex = 8;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Red;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.Location = new Point(132, 375);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(124, 42);
            btnVoltar.TabIndex = 9;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmAvaliacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(400, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnEnviar);
            Controls.Add(txtBoxComentario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNota);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAvaliacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LocalizaCEP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNota;
        private Label label2;
        private Label label3;
        private TextBox txtBoxComentario;
        private Button btnEnviar;
        private Button btnVoltar;
    }
}
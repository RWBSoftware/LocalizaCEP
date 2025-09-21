namespace LocalizaCEP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnBusccar = new Button();
            label1 = new Label();
            txtCEP = new MaskedTextBox();
            label2 = new Label();
            lblCEP = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            lblLogradouro = new Label();
            lblComplemento = new Label();
            lblUnidade = new Label();
            lblBairro = new Label();
            lblLocalidade = new Label();
            lblUF = new Label();
            lblEstado = new Label();
            lblRegiao = new Label();
            lblIBGE = new Label();
            lblGIA = new Label();
            lblDDD = new Label();
            lblSiafi = new Label();
            btnLimpar = new Button();
            btnCopiar = new Button();
            link = new LinkLabel();
            SuspendLayout();
            // 
            // btnBusccar
            // 
            btnBusccar.BackColor = Color.FromArgb(39, 174, 96);
            btnBusccar.FlatAppearance.BorderSize = 0;
            btnBusccar.FlatStyle = FlatStyle.Flat;
            btnBusccar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBusccar.Location = new Point(178, 47);
            btnBusccar.Name = "btnBusccar";
            btnBusccar.Size = new Size(124, 34);
            btnBusccar.TabIndex = 1;
            btnBusccar.Text = "Buscar";
            btnBusccar.UseVisualStyleBackColor = false;
            btnBusccar.Click += btnBusccar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 31);
            label1.TabIndex = 2;
            label1.Text = "Digite o CEP";
            // 
            // txtCEP
            // 
            txtCEP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCEP.Location = new Point(30, 47);
            txtCEP.Mask = "00000-000";
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(142, 34);
            txtCEP.TabIndex = 3;
            txtCEP.KeyPress += txtCEP_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 104);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 4;
            label2.Text = "CEP:";
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCEP.ForeColor = Color.FromArgb(127, 140, 141);
            lblCEP.Location = new Point(87, 104);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(46, 28);
            lblCEP.TabIndex = 5;
            lblCEP.Text = "CEP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 132);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 6;
            label4.Text = "Logradouro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 160);
            label5.Name = "label5";
            label5.Size = new Size(147, 28);
            label5.TabIndex = 7;
            label5.Text = "Complemento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 188);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 8;
            label6.Text = "Unidade:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(30, 216);
            label7.Name = "label7";
            label7.Size = new Size(70, 28);
            label7.TabIndex = 9;
            label7.Text = "Bairro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(30, 244);
            label8.Name = "label8";
            label8.Size = new Size(113, 28);
            label8.TabIndex = 10;
            label8.Text = "Localidade:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(30, 272);
            label9.Name = "label9";
            label9.Size = new Size(41, 28);
            label9.TabIndex = 11;
            label9.Text = "UF:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(30, 300);
            label10.Name = "label10";
            label10.Size = new Size(77, 28);
            label10.TabIndex = 12;
            label10.Text = "Estado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(30, 328);
            label11.Name = "label11";
            label11.Size = new Size(78, 28);
            label11.TabIndex = 13;
            label11.Text = "Região:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(30, 356);
            label12.Name = "label12";
            label12.Size = new Size(59, 28);
            label12.TabIndex = 14;
            label12.Text = "IBGE:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(30, 384);
            label13.Name = "label13";
            label13.Size = new Size(50, 28);
            label13.TabIndex = 15;
            label13.Text = "GIA:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(30, 412);
            label14.Name = "label14";
            label14.Size = new Size(59, 28);
            label14.TabIndex = 16;
            label14.Text = "DDD:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(30, 440);
            label15.Name = "label15";
            label15.Size = new Size(63, 28);
            label15.TabIndex = 17;
            label15.Text = "SIAFI:";
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogradouro.ForeColor = Color.FromArgb(127, 140, 141);
            lblLogradouro.Location = new Point(159, 132);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(118, 28);
            lblLogradouro.TabIndex = 18;
            lblLogradouro.Text = "Logradouro";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplemento.ForeColor = Color.FromArgb(127, 140, 141);
            lblComplemento.Location = new Point(183, 160);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(142, 28);
            lblComplemento.TabIndex = 19;
            lblComplemento.Text = "Complemento";
            // 
            // lblUnidade
            // 
            lblUnidade.AutoSize = true;
            lblUnidade.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnidade.ForeColor = Color.FromArgb(127, 140, 141);
            lblUnidade.Location = new Point(129, 188);
            lblUnidade.Name = "lblUnidade";
            lblUnidade.Size = new Size(88, 28);
            lblUnidade.TabIndex = 20;
            lblUnidade.Text = "Unidade";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBairro.ForeColor = Color.FromArgb(127, 140, 141);
            lblBairro.Location = new Point(106, 216);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(65, 28);
            lblBairro.TabIndex = 21;
            lblBairro.Text = "Bairro";
            // 
            // lblLocalidade
            // 
            lblLocalidade.AutoSize = true;
            lblLocalidade.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalidade.ForeColor = Color.FromArgb(127, 140, 141);
            lblLocalidade.Location = new Point(149, 244);
            lblLocalidade.Name = "lblLocalidade";
            lblLocalidade.Size = new Size(108, 28);
            lblLocalidade.TabIndex = 22;
            lblLocalidade.Text = "Localidade";
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUF.ForeColor = Color.FromArgb(127, 140, 141);
            lblUF.Location = new Point(77, 272);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(36, 28);
            lblUF.TabIndex = 23;
            lblUF.Text = "UF";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = Color.FromArgb(127, 140, 141);
            lblEstado.Location = new Point(113, 300);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(72, 28);
            lblEstado.TabIndex = 24;
            lblEstado.Text = "Estado";
            // 
            // lblRegiao
            // 
            lblRegiao.AutoSize = true;
            lblRegiao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegiao.ForeColor = Color.FromArgb(127, 140, 141);
            lblRegiao.Location = new Point(114, 328);
            lblRegiao.Name = "lblRegiao";
            lblRegiao.Size = new Size(73, 28);
            lblRegiao.TabIndex = 25;
            lblRegiao.Text = "Região";
            // 
            // lblIBGE
            // 
            lblIBGE.AutoSize = true;
            lblIBGE.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIBGE.ForeColor = Color.FromArgb(127, 140, 141);
            lblIBGE.Location = new Point(95, 356);
            lblIBGE.Name = "lblIBGE";
            lblIBGE.Size = new Size(54, 28);
            lblIBGE.TabIndex = 26;
            lblIBGE.Text = "IBGE";
            // 
            // lblGIA
            // 
            lblGIA.AutoSize = true;
            lblGIA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGIA.ForeColor = Color.FromArgb(127, 140, 141);
            lblGIA.Location = new Point(86, 384);
            lblGIA.Name = "lblGIA";
            lblGIA.Size = new Size(45, 28);
            lblGIA.TabIndex = 27;
            lblGIA.Text = "GIA";
            // 
            // lblDDD
            // 
            lblDDD.AutoSize = true;
            lblDDD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDDD.ForeColor = Color.FromArgb(127, 140, 141);
            lblDDD.Location = new Point(95, 412);
            lblDDD.Name = "lblDDD";
            lblDDD.Size = new Size(54, 28);
            lblDDD.TabIndex = 28;
            lblDDD.Text = "DDD";
            // 
            // lblSiafi
            // 
            lblSiafi.AutoSize = true;
            lblSiafi.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSiafi.ForeColor = Color.FromArgb(127, 140, 141);
            lblSiafi.Location = new Point(99, 440);
            lblSiafi.Name = "lblSiafi";
            lblSiafi.Size = new Size(50, 28);
            lblSiafi.TabIndex = 29;
            lblSiafi.Text = "Siafi";
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(149, 165, 166);
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(30, 481);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(118, 38);
            btnLimpar.TabIndex = 30;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.BackColor = Color.FromArgb(52, 152, 219);
            btnCopiar.FlatAppearance.BorderSize = 0;
            btnCopiar.FlatStyle = FlatStyle.Flat;
            btnCopiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCopiar.Location = new Point(154, 481);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(118, 38);
            btnCopiar.TabIndex = 31;
            btnCopiar.Text = "Copiar";
            btnCopiar.UseVisualStyleBackColor = false;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // link
            // 
            link.ActiveLinkColor = SystemColors.ControlText;
            link.AutoSize = true;
            link.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            link.LinkColor = SystemColors.ControlText;
            link.Location = new Point(64, 534);
            link.Name = "link";
            link.Size = new Size(371, 28);
            link.TabIndex = 32;
            link.TabStop = true;
            link.Text = "Deixe seu feedback, Sua opinião conta!";
            link.LinkClicked += link_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 62, 80);
            ClientSize = new Size(500, 586);
            Controls.Add(link);
            Controls.Add(btnCopiar);
            Controls.Add(btnLimpar);
            Controls.Add(lblSiafi);
            Controls.Add(lblDDD);
            Controls.Add(lblGIA);
            Controls.Add(lblIBGE);
            Controls.Add(lblRegiao);
            Controls.Add(lblEstado);
            Controls.Add(lblUF);
            Controls.Add(lblLocalidade);
            Controls.Add(lblBairro);
            Controls.Add(lblUnidade);
            Controls.Add(lblComplemento);
            Controls.Add(lblLogradouro);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblCEP);
            Controls.Add(label2);
            Controls.Add(txtCEP);
            Controls.Add(label1);
            Controls.Add(btnBusccar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LocalizaCEP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBusccar;
        private Label label1;
        private MaskedTextBox txtCEP;
        private Label label2;
        private Label lblCEP;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label lblLogradouro;
        private Label lblComplemento;
        private Label lblUnidade;
        private Label lblBairro;
        private Label lblLocalidade;
        private Label lblUF;
        private Label lblEstado;
        private Label lblRegiao;
        private Label lblIBGE;
        private Label lblGIA;
        private Label lblDDD;
        private Label lblSiafi;
        private Button btnLimpar;
        private Button btnCopiar;
        private LinkLabel link;
    }
}

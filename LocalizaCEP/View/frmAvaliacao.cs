using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalizaCEP
{
    public partial class frmAvaliacao : Form
    {
        #region Eventos
        public frmAvaliacao()
        {
            InitializeComponent();
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Verificacao();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            AbrirForm();
        }
        #endregion

        #region Metodos
        public void AbrirForm()
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void ExibirMessagem(string mensagem, string erro, MessageBoxIcon icon)
        {
            MessageBox.Show(mensagem, erro, MessageBoxButtons.OK, icon);
        }

        public void Verificacao()
        {
            if (int.TryParse(txtNota.Text, out int nota))
            {
                if (nota >= 0 && nota <= 5)
                {
                    ExibirMessagem("Obrigado pela sua avaliação!", "Avaliação", MessageBoxIcon.Information);
                    AbrirForm();
                }
                else
                    ExibirMessagem("Insira uma nota válida de 0 a 5.", "Aviso", MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}

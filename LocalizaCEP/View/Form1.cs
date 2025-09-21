namespace LocalizaCEP
{
    public partial class Form1 : Form
    {
        #region Eventos
        public Form1()
        {
            InitializeComponent();
            Limpar();
        }

        public void ProcurarCEP(string cep)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                var response = httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var cepInfo = System.Text.Json.JsonSerializer.Deserialize<CEP>(content);
                    if (cepInfo != null)
                        PopularLabels(cepInfo);
                    else
                        ExibirMessagemErro("CEP não encontrado.");
                }
                else
                    ExibirMessagemErro("CEP não encontrado.");
            }
            catch (Exception ex) { ExibirMessagemErro($"Ocorreu um erro: {ex.Message}"); }
        }

        private void btnBusccar_Click(object sender, EventArgs e)
        {
            EfetuarBusca();
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCEP.Clear();
            Limpar();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            CopiarTexto();
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAvaliacao frmAvaliacao = new frmAvaliacao();
            frmAvaliacao.Show();
            this.Hide();
        }

        #endregion

        #region Metodos
        public void Limpar()
        {
            lblCEP.Text = string.Empty;
            lblLogradouro.Text = string.Empty;
            lblComplemento.Text = string.Empty;
            lblBairro.Text = string.Empty;
            lblLocalidade.Text = string.Empty;
            lblUF.Text = string.Empty;
            lblIBGE.Text = string.Empty;
            lblGIA.Text = string.Empty;
            lblDDD.Text = string.Empty;
            lblSiafi.Text = string.Empty;
            lblRegiao.Text = string.Empty;
            lblEstado.Text = string.Empty;
            lblUnidade.Text = string.Empty;
        }

        private void PopularLabels(CEP cepInfo)
        {
            lblCEP.Text = cepInfo.Cep;
            lblLogradouro.Text = cepInfo.Logradouro;
            lblComplemento.Text = cepInfo.Complemento;
            lblBairro.Text = cepInfo.Bairro;
            lblLocalidade.Text = cepInfo.Localidade;
            lblUF.Text = cepInfo.UF;
            lblIBGE.Text = cepInfo.IBGE;
            lblGIA.Text = cepInfo.GIA;
            lblDDD.Text = cepInfo.DDD;
            lblSiafi.Text = cepInfo.SIAFI;
            lblRegiao.Text = cepInfo.Regiao;
            lblEstado.Text = cepInfo.Estado;
            lblUnidade.Text = cepInfo.Unidade;
            lblCEP.Visible = true;
        }
        
        private void EfetuarBusca()
        {
            var cep = txtCEP.Text.Trim();
            if (string.IsNullOrEmpty(cep))
            { ExibirMessagemErro("Por favor, informe um CEP válido."); return; }
            else
                ProcurarCEP(cep);
        }

        private void CopiarTexto()
        {
            if (lblCEP.Visible && !string.IsNullOrEmpty(lblCEP.Text))
            {
                string enderecoFormatado = $"{lblLogradouro.Text} - {lblLocalidade.Text}/{lblUF.Text}, CEP: {lblCEP.Text}";
                Clipboard.SetText(enderecoFormatado);
                MessageBox.Show("Endereço copiado para a área de transferência!", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExibirMessagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}

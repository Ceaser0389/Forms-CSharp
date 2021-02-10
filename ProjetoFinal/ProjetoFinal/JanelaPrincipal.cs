using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class JanelaPrincipal : Form
    {
        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        private void JanelaPrincipal_Load(object sender, EventArgs e)
        {
            cb_Status.SelectedItem = null;

        }

        private void TeclaPressionada_ID(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BotaoAdicionar(object sender, EventArgs e)
        {
            if (ChecarDados())
            {
                AddRelatorio();
                LimparDados();
            }
            else
            {
                MessageBox.Show("Voçê não completou todos os dados corretamente!", "Erro:");
            }
           
            


        }

        private bool ChecarDados()
        {
            if (!string.IsNullOrEmpty(tb_ID.Text) &&
               !string.IsNullOrEmpty(tb_Nome.Text) &&
               !string.IsNullOrEmpty(tb_Sobrenome.Text) &&
               !string.IsNullOrEmpty(mtb_Valor.Text) &&
               !string.IsNullOrEmpty(tb_Sobrenome.Text) &&
               cb_Status.SelectedItem != null)
                return true;
            else
            {
                return false;
            }
        }

        private void AddRelatorio()
        {
            ListViewItem relatorio = new ListViewItem(tb_ID.Text);
            relatorio.SubItems.Add(tb_Nome.Text);
            relatorio.SubItems.Add(tb_Sobrenome.Text);
            relatorio.SubItems.Add(mtb_Telefone.Text) ;
            relatorio.SubItems.Add(mtb_Cep.Text);
            relatorio.SubItems.Add(cb_Status.Text);
            
            relatorio.SubItems.Add(gb_NovoCliente.Controls.OfType<RadioButton>().FirstOrDefault(rb =>rb.Checked).Text);// radio button novo cliente
            
            relatorio.SubItems.Add(mtb_Valor.Text);
            relatorio.SubItems.Add(dtp_Date.Text);

            string anotacoes = string.Empty;
            if (cb_HComercial.Checked)
                anotacoes += cb_HComercial.Text + "  ";
            if (cb_Condominio.Checked)
                anotacoes += cb_Condominio.Text + "  ";
            if (cb_AvisoPrevio.Checked)
                anotacoes += cb_AvisoPrevio.Text;

            relatorio.SubItems.Add(anotacoes); // check box Anotações

            lv_Relatorio.Items.Add(relatorio);

        }


        private void LimparDados()
        {
            tb_ID.Text = null;
            tb_Nome.Text = null;
            tb_Sobrenome.Text = null;
            mtb_Telefone.Text = null;
            mtb_Cep.Text = null;
            cb_Status.Text = null;
            rb_Sim.Checked = true;
            rb_Nao.Checked = true;
            mtb_Valor.Text = null;
            dtp_Date.Text = null;

            cb_HComercial.Checked = false;
            cb_Condominio.Checked = false;
            cb_AvisoPrevio.Checked = false;
        }





    }
}

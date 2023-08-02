using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaCarmel
{
    public partial class frmCalcula : Form
    {
        public frmCalcula()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textNum1.Text = "";
            texNum2.Clear();
            lblResposta.Text = "";
            rdbSoma.Checked = false;
            rdbSubtracao.Checked = false;
            rdbMultiplicacao.Checked = false;
            rdbDivisao.Checked = false;

            textNum1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;

            try
            {
                num1 = Convert.ToDouble(textNum1.Text);
                num2 = Convert.ToDouble(texNum2.Text);

                if(rdbSoma.Checked || rdbMultiplicacao.Checked || rdbDivisao.Checked || rdbSubtracao.Checked)
                {
                    MessageBox.Show("é isso");
                }

                if (rdbSoma.Checked)
                {
                    resp = num1 + num2;
                }

                if (rdbSubtracao.Checked)
                {
                    resp = num1 - num2;
                }

                if (rdbMultiplicacao.Checked)
                {
                    resp = num1 * num2;
                }

                if (rdbDivisao.Checked)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Impossivel dividir esse numero");
                        textNum1.Text = "";
                        texNum2.Text = "";
                        lblResposta.Text = "";
                        rdbDivisao.Checked = false;
                        textNum1.Focus();
                    }
                    else
                    {
                        resp = num1 / num2;
                    }
                }

                lblResposta.Text = resp.ToString();
              
            }
            catch (Exception)
            {
                MessageBox.Show("Somente números!!");
                textNum1.Clear();
                texNum2.Text = "";
                textNum1.Focus();
            }
        }
    }
}

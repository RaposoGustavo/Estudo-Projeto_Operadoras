using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Operadoras
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Txt_vlrecarga.Text = Btn_valor5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Txt_vlrecarga.Text = Btn_valor6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Txt_vlrecarga.Text = Btn_valor7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Txt_vlrecarga.Text = Btn_valor8.Text;
        }

        private void Rb_TIM_CheckedChanged(object sender, EventArgs e)
        {
            Pic_imagem.Image = Properties.Resources.gif_tim;

            BackColor = Color.Blue;
            ForeColor = Color.White;

            Btn_valor1.ForeColor = Color.RoyalBlue;
            Btn_valor2.ForeColor = Color.RoyalBlue;
            Btn_valor3.ForeColor = Color.RoyalBlue;
            Btn_valor4.ForeColor = Color.RoyalBlue;
            Btn_valor5.ForeColor = Color.RoyalBlue;
            Btn_valor6.ForeColor = Color.RoyalBlue;
            Btn_valor7.ForeColor = Color.RoyalBlue;
            Btn_valor8.ForeColor = Color.RoyalBlue;

            Txt_nome.Enabled = true;
            Txt_ddd.Enabled = true;
            Txt_numero.Enabled = true;

            Btn_valor1.Enabled = true;
            Btn_valor2.Enabled = true;
            Btn_valor3.Enabled = true;
            Btn_valor4.Enabled = true;
            Btn_valor5.Enabled = true;
            Btn_valor6.Enabled = true;
            Btn_valor7.Enabled = true;
            Btn_valor8.Enabled = true;
            Btn_recarregar.Enabled = true;

            Txt_vlrecarga.Text = "";
            Txt_operadora.Text = "TIM";

            Btn_valor1.Text = "R$10,00";
            Lb_validade1.Text = "30 Dias";

            Btn_valor2.Text = "R$15,00";
            Lb_validade2.Text = "30 Dias";

            Btn_valor3.Text = "R$20,00";
            Lb_validade3.Text = "30 Dias";

            Btn_valor4.Text = "R$30,00";
            Lb_validade4.Text = "90 Dias";

            Btn_valor5.Text = "R$40,00";
            Lb_validade5.Text = "90 Dias";

            Btn_valor6.Text = "R$50,00";
            Lb_validade6.Text = "180 Dias";

            Btn_valor7.Text = "R$60,00";
            Lb_validade7.Text = "180 Dias";

            Btn_valor8.Text = "R$100,00";
            Lb_validade8.Text = "180 Dias";

            Lbl_recarcagaRalaizada.Text = "";
        }

        private void Rb_vivo_CheckedChanged(object sender, EventArgs e)
        {
            Pic_imagem.Image = Properties.Resources.gif_vivo;

            BackColor = Color.DarkViolet;
            ForeColor = Color.White;

            Btn_valor1.ForeColor = Color.Violet;
            Btn_valor2.ForeColor = Color.Violet;
            Btn_valor3.ForeColor = Color.Violet;
            Btn_valor4.ForeColor = Color.Violet;
            Btn_valor5.ForeColor = Color.Violet;
            Btn_valor6.ForeColor = Color.Violet;
            Btn_valor7.ForeColor = Color.Violet;
            Btn_valor8.ForeColor = Color.Violet;

            Txt_nome.Enabled = true;
            Txt_ddd.Enabled = true;
            Txt_numero.Enabled = true;

            Btn_valor1.Enabled = true;
            Btn_valor2.Enabled = true;
            Btn_valor3.Enabled = true;
            Btn_valor4.Enabled = true;
            Btn_valor5.Enabled = true;
            Btn_valor6.Enabled = true;
            Btn_valor7.Enabled = true;
            Btn_valor8.Enabled = true;
            Btn_recarregar.Enabled = true;

            Txt_vlrecarga.Text = "";
            Txt_operadora.Text = "VIVO";

            Btn_valor1.Text = "R$12,00";
            Lb_validade1.Text = "30 Dias";

            Btn_valor2.Text = "R$15,00";
            Lb_validade2.Text = "30 Dias";

            Btn_valor3.Text = "R$20,00";
            Lb_validade3.Text = "30 Dias";

            Btn_valor4.Text = "R$30,00";
            Lb_validade4.Text = "30 Dias";

            Btn_valor5.Text = "R$35,00";
            Lb_validade5.Text = "90 Dias";

            Btn_valor6.Text = "R$40,00";
            Lb_validade6.Text = "90 Dias";

            Btn_valor7.Text = "R$100,00";
            Lb_validade7.Text = "180 Dias";

            Btn_valor8.Text = "R$200,00";
            Lb_validade8.Text = "365 Dias";

            Lbl_recarcagaRalaizada.Text = "";
        }

        private void Rb_claro_CheckedChanged(object sender, EventArgs e)
        {
            Pic_imagem.Image = Properties.Resources.gif_claro;
            BackColor = Color.Red;
            ForeColor = Color.White;

            Btn_valor1.ForeColor = Color.Black;
            Btn_valor2.ForeColor = Color.Black;
            Btn_valor3.ForeColor = Color.Black;
            Btn_valor4.ForeColor = Color.Black;
            Btn_valor5.ForeColor = Color.Black;
            Btn_valor6.ForeColor = Color.Black;
            Btn_valor7.ForeColor = Color.Black;
            Btn_valor8.ForeColor = Color.Black;

            Txt_nome.Enabled = true;
            Txt_numero.Enabled = true;
            Txt_ddd.Enabled = true;

            Btn_valor1.Enabled = true;
            Btn_valor2.Enabled = true;
            Btn_valor3.Enabled = true;
            Btn_valor4.Enabled = true;
            Btn_valor5.Enabled = true;
            Btn_valor6.Enabled = true;
            Btn_valor7.Enabled = true;
            Btn_valor8.Enabled = true;
            Btn_recarregar.Enabled = true;

            Txt_vlrecarga.Text = "";
            Txt_operadora.Text = "CLARO";

            Btn_valor1.Text = "R$12,00";
            Lb_validade1.Text = "30 Dias";

            Btn_valor2.Text = "R$15,00";
            Lb_validade2.Text = "30 Dias";

            Btn_valor3.Text = "R$20,00";
            Lb_validade3.Text = "60 Dias";

            Btn_valor4.Text = "R$25,00";
            Lb_validade4.Text = "60 Dias";

            Btn_valor5.Text = "R$30,00";
            Lb_validade5.Text = "90 Dias";

            Btn_valor6.Text = "R$35,00";
            Lb_validade6.Text = "90 Dias";

            Btn_valor7.Text = "R$50,00";
            Lb_validade7.Text = "120 Dias";

            Btn_valor8.Text = "R$100,00";
            Lb_validade8.Text = "180 Dias";

            Lbl_recarcagaRalaizada.Text = "";
        }

        private void Rb_oi_CheckedChanged(object sender, EventArgs e)
        {
            Pic_imagem.Image = Properties.Resources.gif_oi;

            BackColor = Color.Orange;
            ForeColor = Color.White;

            Btn_valor1.ForeColor = Color.Gold;
            Btn_valor2.ForeColor = Color.Gold;
            Btn_valor3.ForeColor = Color.Gold;
            Btn_valor4.ForeColor = Color.Gold;
            Btn_valor5.ForeColor = Color.Gold;
            Btn_valor6.ForeColor = Color.Gold;
            Btn_valor7.ForeColor = Color.Gold;
            Btn_valor8.ForeColor = Color.Gold;

            Txt_nome.Enabled = true;
            Txt_ddd.Enabled = true;
            Txt_numero.Enabled = true;

            Btn_valor1.Enabled = true;
            Btn_valor2.Enabled = true;
            Btn_valor3.Enabled = true;
            Btn_valor4.Enabled = true;
            Btn_valor5.Enabled = true;
            Btn_valor6.Enabled = true;
            Btn_valor7.Enabled = true;
            Btn_valor8.Enabled = true;
            Btn_recarregar.Enabled = true;

            Txt_vlrecarga.Text = "";
            Txt_operadora.Text = "OI";

            Btn_valor1.Text = "R$10,00";
            Lb_validade1.Text = "30 Dias";

            Btn_valor2.Text = "R$15,00";
            Lb_validade2.Text = "30 Dias";

            Btn_valor3.Text = "R$20,00";
            Lb_validade3.Text = "45 Dias";

            Btn_valor4.Text = "R$25,00";
            Lb_validade4.Text = "45 Dias";

            Btn_valor5.Text = "R$30,00";
            Lb_validade5.Text = "90 Dias";

            Btn_valor6.Text = "R$35,00";
            Lb_validade6.Text = "90 Dias";

            Btn_valor7.Text = "R$40,00";
            Lb_validade7.Text = "90 Dias";

            Btn_valor8.Text = "R$50,00";
            Lb_validade8.Text = "90 Dias";

            Lbl_recarcagaRalaizada.Text = "";
        }

        private void Btn_valor1_Click(object sender, EventArgs e)
        {
            Txt_vlrecarga.Text = Btn_valor1.Text;
        }

        private void Btn_valor2_Click(object sender, EventArgs e)
        {
            Txt_vlrecarga.Text = Btn_valor2.Text;
        }

        private void Btn_valor3_Click(object sender, EventArgs e)
        {
            Txt_vlrecarga.Text = Btn_valor3.Text;
        }

        private void Btn_valor4_Click(object sender, EventArgs e)
        {
            Txt_vlrecarga.Text = Btn_valor4.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_recarregar_Click(object sender, EventArgs e)
        {
            Txt_nome.Enabled = false;
            Txt_operadora.Enabled = false;
            Txt_ddd.Enabled = false;
            Txt_numero.Enabled = false;
            Txt_vlrecarga.Enabled = false;

            Lbl_recarcagaRalaizada.Text = "Recarga realizada com sucesso!";

            //String TodosDados;
            /*TodosDados =*/
            Lbl_dados.Text = "Dados da recarga:" + "\r\n" + Txt_nome.Text + "\r\n" + Txt_ddd.Text + " " + Txt_numero.Text + "\r\n" + Txt_operadora.Text + "\r\n" + Txt_vlrecarga.Text;
            //Lbl_dados.Text = TodosDados;

            Pic_imagem.Image = Properties.Resources.gif_mlkdancando;       
        }

        private void Btn_novaRecarga_Click(object sender, EventArgs e)
        {
            Rb_vivo.Checked = false;
            Rb_claro.Checked = false;
            Rb_TIM.Checked = false;
            Rb_oi.Checked = false;

            Txt_nome.Text = "";
            Txt_operadora.Text = "";
            Txt_ddd.Text = "";
            Txt_numero.Text = "";
            Txt_vlrecarga.Text = "";
            Lbl_dados.Text = "";

            Pic_imagem.Image = Properties.Resources.img_recargas;

        }
    }
}
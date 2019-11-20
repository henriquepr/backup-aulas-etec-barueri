using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        string operador;
        int a = 0;
        int b;
        bool validar = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_valor.Text = "";
            label1.Text = "";
            a = 0;
            validar = false;
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a += int.Parse(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "+";
                txt_valor.Text = "";
                operador = "+";
            }

            else
            {
                label1.Text = txt_valor.Text + btn_soma.Text;
                a = int.Parse(txt_valor.Text);
                txt_valor.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a - int.Parse(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "-";
                txt_valor.Text = "";
                operador = "-";
            }
            else
            {
                label1.Text = txt_valor.Text + btn_subtracao.Text;
                a = int.Parse(txt_valor.Text);
                txt_valor.Text = "";
                operador = "-";
                validar = true;
            }
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * int.Parse(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "*";
                txt_valor.Text = "";
                operador = "*";
            }
            else
            {
                label1.Text = txt_valor.Text + btn_multiplicacao.Text;
                a = int.Parse(txt_valor.Text);
                txt_valor.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / int.Parse(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "/";
                txt_valor.Text = "";
                operador = "/";
            }
            else
            {
                label1.Text = txt_valor.Text + btn_divisao.Text;
                a = int.Parse(txt_valor.Text);
                txt_valor.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            switch (operador)
            {
                case "+":
                    label1.Text = label1.Text + txt_valor.Text + "=";
                    txt_valor.Text = Convert.ToString(a + int.Parse(txt_valor.Text));
                    break;

                case "-":
                    label1.Text = label1.Text + txt_valor.Text + "=";
                    txt_valor.Text = Convert.ToString(a - int.Parse(txt_valor.Text));
                    break;

                case "*":
                    label1.Text = label1.Text + txt_valor.Text + "=";
                    txt_valor.Text = Convert.ToString(a * int.Parse(txt_valor.Text));
                    break;

                case "/":
                    label1.Text = label1.Text + txt_valor.Text + "=";
                    txt_valor.Text = Convert.ToString(a / int.Parse(txt_valor.Text));
                    break;
            }
        }
    }
}

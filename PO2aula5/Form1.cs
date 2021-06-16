using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PO2aula5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool erros = false;

        private void button1_Click(object sender, EventArgs e)
        {
            Circulo c1 = new Circulo();
            try
            {
                c1.Raio = Convert.ToDouble(textBox1.Text.Trim());
            }
            catch
            {
                erros = true;
                errorProvider1.SetError(textBox1, "Erro no valor informado!");
            }
            MessageBox.Show("A Área do Circulo é : " + c1.CalculaArea(c1.Raio).ToString());
            
        }

        private void btnCalculaComprimento_Click(object sender, EventArgs e)
        {
            Circulo c1 = new Circulo();
            try
            {

                c1.Raio = Convert.ToDouble(textBox1.Text.Trim());
            }
            catch
            {
                erros = true;
                errorProvider1.SetError(textBox1, "Erro no valor informado!");
            }
            MessageBox.Show("O Comprimento do Circulo é : " + c1.CalculaComprimento(c1.Raio).ToString());
            
        }
    }
}

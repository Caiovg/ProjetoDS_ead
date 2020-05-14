using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_ProjetoDS_EAD;

namespace ProjetoDS_EAD
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomedousuario, email, senha;
                nomedousuario = textBox1.Text;
                email = textBox1.Text;
                senha = textBox2.Text;
                if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Digite seu nome de Úsuario")
                {
                    throw new Exception("Preencha o campo Nome do Úsuario");
                }
                if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Digite seu email")
                {
                    throw new Exception("Preencha o campo email");
                }
                if (string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text == "Digite sua senha")
                {
                    throw new Exception("Preencha o campo senha");
                }
                MessageBox.Show("Login efetuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Clear();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult escolha;
            escolha = MessageBox.Show("Deseja voltar?", "Retornar a Home", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (escolha.ToString().ToLower() == "yes")
            {
                this.Hide();
                Form1 home = new Form1();
                home.ShowDialog();
                this.Close();
            }
        }
    }
}

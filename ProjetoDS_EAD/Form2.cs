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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, nomedousuario, cpf, email, senha, confirmesenha;
                nome = textBox1.Text;
                nomedousuario = textBox2.Text;
                cpf = maskedTextBox1.Text;
                email = textBox5.Text;
                senha = textBox3.Text;
                confirmesenha = textBox4.Text;
                if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text == "Digite o seu nome")
                {
                    throw new Exception("Preencha o campo Nome ");
                }
                if (string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text == "Digite o Nome de Úsuario") 
                {
                    throw new Exception("Preencha o campo Nome do Úsuario");
                }
                if (string.IsNullOrWhiteSpace(maskedTextBox1.Text) || maskedTextBox1.Text == "Digite seu CPF") 
                {
                    throw new Exception("Preencha o campo CPF");
                }
                try
                {
                    Convert.ToInt64(cpf);
                }
                catch
                {
                    throw new Exception("Cpf deve ser numeros");
                }
                if (cpf.Length != 11)
                {
                    throw new Exception("Cpf deve ter 13 digitos");
                }
                if (string.IsNullOrWhiteSpace(textBox5.Text) || textBox5.Text == "Digite seu email")
                {
                    throw new Exception("Preencha o campo email");
                }
                if (string.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text == "Digite sua senha")
                {
                    throw new Exception("Preencha o campo senha");
                }
                if (string.IsNullOrWhiteSpace(textBox4.Text) || textBox4.Text == "Confirme sua senha")
                {
                    throw new Exception("Preencha o campo confirme sua senha");
                }
                if (senha == confirmesenha) 
                {

                }
                else
                {
                    throw new Exception("senha diferente");

                }
                MessageBox.Show("Cadastro efetuado com sucesso", "Sucesso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                maskedTextBox1.Clear();
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

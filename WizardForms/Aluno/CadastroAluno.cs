using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WizardForms.Professor;

namespace WizardForms.Aluno
{
    public partial class CadastroAluno : Form
    {

        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            this.Close();
            telaPrincipal.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Verificando o se já é aluno ou nao
            string experiencia; 
            if (radioButton1.Checked)
            {
                experiencia = "Já sou aluno";
            }
            else
            {
                experiencia = "Não sou aluno";
            }


            Aluno aluno = new Aluno();
            AlunoDAO alunoDAO= new AlunoDAO();

            aluno.setId(int.Parse(textBox12.Text));
            aluno.setNome((textBox1.Text));
            aluno.setSobreNome(textBox2.Text);
            aluno.setEmail((textBox3.Text));
            aluno.setRepEmail((textBox4.Text));
            aluno.setSenha((textBox5.Text));
            aluno.setRepSenha((textBox6.Text)); 
            aluno.setCelular((textBox7.Text));
            aluno.setLiguagem((textBox8.Text));
            aluno.setEstado(textBox9.Text);
            aluno.setCidade((textBox10.Text));
            aluno.setExperiencia(experiencia);

            if (alunoDAO.cadastar(aluno))
            {
                MessageBox.Show("Cadastrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nao Cadastrado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizardForms.Aluno
{
    public partial class AtualizarAluno : Form
    {
        public AtualizarAluno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            AlunoDAO alunoDAO = new AlunoDAO();

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
            aluno.setId(int.Parse(textBox12.Text));

            if (alunoDAO.alterar(aluno))
            {
                MessageBox.Show("Dados atualizados com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nao atualizado!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
